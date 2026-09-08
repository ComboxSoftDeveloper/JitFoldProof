## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.EscapeBench.BoxStays()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFDF2A8F8A0]; JitFoldProof.Subjects.BoxStays(Int32)
; Total bytes of code 9
```
```assembly
; JitFoldProof.Subjects.BoxStays(Int32)
       lea       eax,[rcx+1]
       ret
; Total bytes of code 4
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.EscapeBench.BoxEscapes()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFDF2A7F978]; JitFoldProof.Subjects.BoxEscapes(Int32)
; Total bytes of code 9
```
```assembly
; JitFoldProof.Subjects.BoxEscapes(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       mov       rcx,offset MT_System.Runtime.CompilerServices.StrongBox<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],ebx
       mov       ebx,[rax+8]
       inc       ebx
       mov       [rax+8],ebx
       mov       rcx,25B0B801300
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,ebx
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 59
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.EscapeBench.ArrayStays()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFDF2A8F978]; JitFoldProof.Subjects.ArrayStays(Int32)
; Total bytes of code 9
```
```assembly
; JitFoldProof.Subjects.ArrayStays(Int32)
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+10],xmm4
       mov       [rsp+20],rax
       mov       rax,offset MT_System.Int32[]
       mov       [rsp+8],rax
       lea       rax,[rsp+8]
       mov       dword ptr [rax+8],4
       lea       rax,[rsp+8]
       mov       [rax+10],ecx
       lea       edx,[rcx+1]
       mov       [rax+14],edx
       lea       r8d,[rcx+2]
       mov       [rax+18],r8d
       add       ecx,3
       mov       [rax+1C],ecx
       add       edx,[rax+10]
       lea       eax,[rdx+r8]
       add       eax,ecx
       add       rsp,28
       ret
; Total bytes of code 95
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.EscapeBench.ArrayEscapes()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFDF2A7F978]; JitFoldProof.Subjects.ArrayEscapes(Int32)
; Total bytes of code 9
```
```assembly
; JitFoldProof.Subjects.ArrayEscapes(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32[]
       mov       edx,4
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       mov       [rsi+10],ebx
       lea       edi,[rbx+1]
       mov       [rsi+14],edi
       lea       ebp,[rbx+2]
       mov       [rsi+18],ebp
       add       ebx,3
       mov       [rsi+1C],ebx
       mov       rcx,1F471401308
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       add       edi,[rsi+10]
       lea       eax,[rdi+rbp]
       add       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 89
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.EscapeBench.ArrayOnStack()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFDF2A6F978]; JitFoldProof.Subjects.ArrayOnStack(Int32)
; Total bytes of code 9
```
```assembly
; JitFoldProof.Subjects.ArrayOnStack(Int32)
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rax,0A34F887DCDBE
       mov       [rsp+30],rax
       lea       rax,[rsp+20]
       mov       [rax],ecx
       lea       edx,[rcx+1]
       mov       [rax+4],edx
       lea       edx,[rcx+2]
       mov       [rax+8],edx
       add       ecx,3
       mov       [rax+0C],ecx
       mov       ecx,[rax]
       add       ecx,[rax+4]
       add       ecx,[rax+8]
       add       ecx,[rax+0C]
       mov       eax,ecx
       mov       r8,0A34F887DCDBE
       cmp       [rsp+30],r8
       je        short M01_L00
       call      CORINFO_HELP_FAIL_FAST
M01_L00:
       nop
       add       rsp,38
       ret
; Total bytes of code 97
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.EscapeBench.BoxStays()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFDC8E5EA78]; JitFoldProof.Subjects.BoxStays(Int32)
; Total bytes of code 9
```
```assembly
; JitFoldProof.Subjects.BoxStays(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       mov       rcx,offset MT_System.Runtime.CompilerServices.StrongBox<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],ebx
       mov       ecx,[rax+8]
       inc       ecx
       mov       [rax+8],ecx
       mov       eax,ecx
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 41
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.EscapeBench.BoxEscapes()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFDC8E9EA90]; JitFoldProof.Subjects.BoxEscapes(Int32)
; Total bytes of code 9
```
```assembly
; JitFoldProof.Subjects.BoxEscapes(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       mov       rcx,offset MT_System.Runtime.CompilerServices.StrongBox<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],ebx
       mov       ebx,[rax+8]
       inc       ebx
       mov       [rax+8],ebx
       mov       rcx,2A7718050F8
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,ebx
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 59
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.EscapeBench.ArrayStays()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFDC8E7EAA8]; JitFoldProof.Subjects.ArrayStays(Int32)
; Total bytes of code 9
```
```assembly
; JitFoldProof.Subjects.ArrayStays(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32[]
       mov       edx,4
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rax+10],ebx
       lea       ecx,[rbx+1]
       mov       [rax+14],ecx
       lea       edx,[rbx+2]
       mov       [rax+18],edx
       add       ebx,3
       mov       [rax+1C],ebx
       add       ecx,[rax+10]
       lea       eax,[rcx+rdx]
       add       eax,ebx
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 62
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.EscapeBench.ArrayEscapes()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFDC8E7EAC0]; JitFoldProof.Subjects.ArrayEscapes(Int32)
; Total bytes of code 9
```
```assembly
; JitFoldProof.Subjects.ArrayEscapes(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32[]
       mov       edx,4
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       mov       [rsi+10],ebx
       lea       edi,[rbx+1]
       mov       [rsi+14],edi
       lea       ebp,[rbx+2]
       mov       [rsi+18],ebp
       add       ebx,3
       mov       [rsi+1C],ebx
       mov       rcx,25265405100
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       add       edi,[rsi+10]
       lea       eax,[rdi+rbp]
       add       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 89
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.EscapeBench.ArrayOnStack()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFDC8E7EAD8]; JitFoldProof.Subjects.ArrayOnStack(Int32)
; Total bytes of code 9
```
```assembly
; JitFoldProof.Subjects.ArrayOnStack(Int32)
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rax,0D834E45AC5D4
       mov       [rsp+30],rax
       lea       rax,[rsp+20]
       mov       [rax],ecx
       lea       edx,[rcx+1]
       mov       [rax+4],edx
       lea       edx,[rcx+2]
       mov       [rax+8],edx
       add       ecx,3
       mov       [rax+0C],ecx
       mov       ecx,[rax]
       add       ecx,[rax+4]
       add       ecx,[rax+8]
       add       ecx,[rax+0C]
       mov       eax,ecx
       mov       rcx,0D834E45AC5D4
       cmp       [rsp+30],rcx
       je        short M01_L00
       call      CORINFO_HELP_FAIL_FAST
M01_L00:
       nop
       add       rsp,38
       ret
; Total bytes of code 97
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.EscapeBench.BoxStays()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFDAC74EBC8]; JitFoldProof.Subjects.BoxStays(Int32)
; Total bytes of code 9
```
```assembly
; JitFoldProof.Subjects.BoxStays(Int32)
       lea       eax,[rcx+1]
       ret
; Total bytes of code 4
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.EscapeBench.BoxEscapes()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFDAC74EAF0]; JitFoldProof.Subjects.BoxEscapes(Int32)
; Total bytes of code 9
```
```assembly
; JitFoldProof.Subjects.BoxEscapes(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       mov       rcx,offset MT_System.Runtime.CompilerServices.StrongBox<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],ebx
       mov       ebx,[rax+8]
       inc       ebx
       mov       [rax+8],ebx
       mov       rcx,14371C01310
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,ebx
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 59
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.EscapeBench.ArrayStays()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFDAC73EBC8]; JitFoldProof.Subjects.ArrayStays(Int32)
; Total bytes of code 9
```
```assembly
; JitFoldProof.Subjects.ArrayStays(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32[]
       mov       edx,4
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rax+10],ebx
       lea       ecx,[rbx+1]
       mov       [rax+14],ecx
       lea       edx,[rbx+2]
       mov       [rax+18],edx
       add       ebx,3
       mov       [rax+1C],ebx
       add       ecx,[rax+10]
       lea       eax,[rcx+rdx]
       add       eax,ebx
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 62
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.EscapeBench.ArrayEscapes()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFDAC74EAF0]; JitFoldProof.Subjects.ArrayEscapes(Int32)
; Total bytes of code 9
```
```assembly
; JitFoldProof.Subjects.ArrayEscapes(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32[]
       mov       edx,4
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       mov       [rsi+10],ebx
       lea       edi,[rbx+1]
       mov       [rsi+14],edi
       lea       ebp,[rbx+2]
       mov       [rsi+18],ebp
       add       ebx,3
       mov       [rsi+1C],ebx
       mov       rcx,21500001318
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       add       edi,[rsi+10]
       lea       eax,[rdi+rbp]
       add       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 89
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.EscapeBench.ArrayOnStack()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFDAC74EBC8]; JitFoldProof.Subjects.ArrayOnStack(Int32)
; Total bytes of code 9
```
```assembly
; JitFoldProof.Subjects.ArrayOnStack(Int32)
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rax,0D1DC78F0C86E
       mov       [rsp+30],rax
       lea       rax,[rsp+20]
       mov       [rax],ecx
       lea       edx,[rcx+1]
       mov       [rax+4],edx
       lea       edx,[rcx+2]
       mov       [rax+8],edx
       add       ecx,3
       mov       [rax+0C],ecx
       mov       ecx,[rax]
       add       ecx,[rax+4]
       add       ecx,[rax+8]
       add       ecx,[rax+0C]
       mov       eax,ecx
       mov       rcx,0D1DC78F0C86E
       cmp       [rsp+30],rcx
       je        short M01_L00
       call      CORINFO_HELP_FAIL_FAST
M01_L00:
       nop
       add       rsp,38
       ret
; Total bytes of code 97
```

