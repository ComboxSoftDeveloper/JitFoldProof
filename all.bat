@echo off
chcp 866 >nul
setlocal enabledelayedexpansion

rem Весь прогон одной командой. Складывает всё в Results\<имя машины>.

rem BenchmarkDotNet собирает вспомогательный проект и передаёт путь в MSBuild
rem без кавычек. Запятая и точка с запятой в пути разбираются как разделители
rem списка свойств, сборка падает с MSB1006, и замеры не выполняются вовсе.
rem Отчёты при этом снимаются нормально, поэтому сбой легко не заметить.
set "PATHCHK=%CD%"
if not "%PATHCHK%"=="%PATHCHK:,=%" goto badpath
if not "%PATHCHK%"=="%PATHCHK:;=%" goto badpath

set NAME=%COMPUTERNAME%
set OUT=Results\%NAME%
if not exist "Results" mkdir "Results"
if not exist "%OUT%" mkdir "%OUT%"
if not exist "%OUT%" (
    echo Не удалось создать папку %OUT%
    goto fail
)

rem Журнал прошлого прогона удаляется, чтобы не разбирать чужой сбой.
if exist "Bdn\*.log" del /Q "Bdn\*.log"

echo Всё ляжет в %OUT%
echo.

echo === Сборка ===
dotnet build -c Release -warnaserror
if errorlevel 1 goto fail

echo.
echo === Сверка на трёх рантаймах ===
for %%T in (net8.0 net9.0 net10.0) do (
    echo   %%T
    dotnet run -c Release -f %%T --no-build -- checks > "%OUT%\checks_%%T.txt"
    if errorlevel 1 (
        echo Сверка не прошла на %%T, смотри "%OUT%\checks_%%T.txt"
        goto fail
    )
)

echo.
echo === Отчёты, обычный режим ===
for %%T in (net8.0 net9.0 net10.0) do (
    for %%R in (counters ilsize alloc warmup timing) do (
        echo   %%T %%R
        dotnet run -c Release -f %%T --no-build -- %%R > "%OUT%\%%R_%%T.txt"
    )
)

echo.
rem Ярусная компиляция гасится вместе с профилем: иначе часть вызовов
rem выполняется кодом первого яруса, и режим ничего не показывает.
echo === Без динамического профиля ===
set DOTNET_TieredPGO=0
set DOTNET_TieredCompilation=0
for %%T in (net8.0 net9.0 net10.0) do (
    echo   %%T
    dotnet run -c Release -f %%T --no-build -- alloc  > "%OUT%\alloc_%%T_nopgo.txt"
    dotnet run -c Release -f %%T --no-build -- warmup > "%OUT%\warmup_%%T_nopgo.txt"
    dotnet run -c Release -f %%T --no-build -- timing > "%OUT%\timing_%%T_nopgo.txt"
)
set DOTNET_TieredPGO=
set DOTNET_TieredCompilation=

echo.
echo === Без ярусной компиляции ===
set DOTNET_TieredCompilation=0
for %%T in (net8.0 net9.0 net10.0) do (
    echo   %%T
    dotnet run -c Release -f %%T --no-build -- alloc  > "%OUT%\alloc_%%T_notiered.txt"
    dotnet run -c Release -f %%T --no-build -- warmup > "%OUT%\warmup_%%T_notiered.txt"
    dotnet run -c Release -f %%T --no-build -- timing > "%OUT%\timing_%%T_notiered.txt"
)
set DOTNET_TieredCompilation=

echo.
echo === Без готового машинного кода ===
set DOTNET_ReadyToRun=0
for %%T in (net8.0 net9.0 net10.0) do (
    echo   %%T
    dotnet run -c Release -f %%T --no-build -- warmup > "%OUT%\warmup_%%T_nor2r.txt"
    dotnet run -c Release -f %%T --no-build -- timing > "%OUT%\timing_%%T_nor2r.txt"
)
set DOTNET_ReadyToRun=

echo.
rem Здесь ярусная компиляция гасится по той же причине: размещение на стеке
rem бывает только на втором ярусе, и без этого сравнивать не с чем.
echo === Без размещения объектов на стеке ===
set DOTNET_JitObjectStackAllocation=0
set DOTNET_TieredCompilation=0
for %%T in (net8.0 net9.0 net10.0) do (
    echo   %%T
    dotnet run -c Release -f %%T --no-build -- alloc  > "%OUT%\alloc_%%T_noobjstack.txt"
    dotnet run -c Release -f %%T --no-build -- timing > "%OUT%\timing_%%T_noobjstack.txt"
)
set DOTNET_JitObjectStackAllocation=
set DOTNET_TieredCompilation=

echo.
echo === На серверном сборщике ===
set DOTNET_gcServer=1
for %%T in (net8.0 net9.0 net10.0) do (
    echo   %%T
    dotnet run -c Release -f %%T --no-build -- alloc  > "%OUT%\alloc_%%T_servergc.txt"
    dotnet run -c Release -f %%T --no-build -- timing > "%OUT%\timing_%%T_servergc.txt"
)
set DOTNET_gcServer=

rem Два коротких прогона на одном классе. Нужны, чтобы отделить сбой самого
rem замера от сбоя снятия машинного кода: если без дизассемблера проходит,
rem а с ним нет, чинить надо дизассемблер.

echo.
echo === Проба: один класс без дизассемблера ===
dotnet run -c Release -f net10.0 --no-build -- --filter *EscapeBench* noasm > "%OUT%\probe_noasm.txt" 2>&1
set PROBE1=%ERRORLEVEL%
if exist "Bdn\JitFoldProof.log" copy /Y "Bdn\JitFoldProof.log" "%OUT%\probe_noasm.log" >nul
if exist "Bdn\*.log" del /Q "Bdn\*.log"
if not "%PROBE1%"=="0" echo   завершилось с ошибкой, смотри "%OUT%\probe_noasm.txt"

echo.
echo === Проба: один класс с дизассемблером ===
dotnet run -c Release -f net10.0 --no-build -- --filter *EscapeBench* > "%OUT%\probe_asm.txt" 2>&1
set PROBE2=%ERRORLEVEL%
if exist "Bdn\JitFoldProof.log" copy /Y "Bdn\JitFoldProof.log" "%OUT%\probe_asm.log" >nul
if exist "Bdn\*.log" del /Q "Bdn\*.log"
if not "%PROBE2%"=="0" echo   завершилось с ошибкой, смотри "%OUT%\probe_asm.txt"

echo.
echo === Замеры на трёх рантаймах одним прогоном ===
dotnet run -c Release -f net10.0 --no-build -- --filter *
set MAIN=%ERRORLEVEL%

rem Журнал забирается всегда, а не только при удаче: причина сбоя только в нём.
if exist "Bdn\JitFoldProof.log" copy /Y "Bdn\JitFoldProof.log" "%OUT%\bench.log" >nul

if exist "Bdn\results" (
    if not exist "%OUT%\bench" mkdir "%OUT%\bench"
    xcopy /Y /E /I "Bdn\results" "%OUT%\bench" >nul
)

echo.
if not "%MAIN%"=="0" (
    echo Замеры завершились с ошибкой. Причина в "%OUT%\bench.log".
    goto fail
)

echo Готово. Всё лежит в %OUT%
echo   пробы:  probe_noasm.txt, probe_asm.txt и журналы к ним
echo   журнал: bench.log
goto end

:badpath
echo.
echo В пути к проекту есть запятая или точка с запятой:
echo %CD%
echo.
echo BenchmarkDotNet не соберёт вспомогательный проект в таком пути.
echo Перенести проект туда, где этих знаков нет, и запустить снова.
endlocal
exit /b 1

:fail
echo.
echo Прогон остановлен.
endlocal
exit /b 1

:end
endlocal
