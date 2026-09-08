## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Numbers()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       call      qword ptr [7FFDF2A4FE88]; JitFoldProof.Subjects.ClearNumbers(System.Collections.Generic.List`1<Int32>)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; JitFoldProof.Subjects.ClearNumbers(System.Collections.Generic.List`1<Int32>)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF28C7C38]; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].Clear()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 33
```
```assembly
; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].Clear()
       inc       dword ptr [rcx+14]
       xor       eax,eax
       mov       [rcx+10],eax
       ret
; Total bytes of code 9
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Words()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       call      qword ptr [7FFDF2A6FE70]; JitFoldProof.Subjects.ClearWords(System.Collections.Generic.List`1<System.String>)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; JitFoldProof.Subjects.ClearWords(System.Collections.Generic.List`1<System.String>)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF27A17E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Clear()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 33
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Clear()
       inc       dword ptr [rcx+14]
       mov       r8d,[rcx+10]
       xor       eax,eax
       mov       [rcx+10],eax
       test      r8d,r8d
       jle       short M02_L00
       mov       rcx,[rcx+8]
       lea       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       xor       edx,edx
       jmp       qword ptr [rax]
M02_L00:
       ret
; Total bytes of code 34
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Points()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+18]
       call      qword ptr [7FFDF2A6FE88]; JitFoldProof.Subjects.ClearPoints(System.Collections.Generic.List`1<JitFoldProof.Types.PointValue>)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; JitFoldProof.Subjects.ClearPoints(System.Collections.Generic.List`1<JitFoldProof.Types.PointValue>)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF294D828]; System.Collections.Generic.List`1[[JitFoldProof.Types.PointValue, JitFoldProof]].Clear()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 33
```
```assembly
; System.Collections.Generic.List`1[[JitFoldProof.Types.PointValue, JitFoldProof]].Clear()
       push      rbp
       sub       rsp,10
       lea       rbp,[rsp+10]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       inc       dword ptr [rax+14]
       mov       rax,[rbp+10]
       xor       ecx,ecx
       mov       [rax+10],ecx
       add       rsp,10
       pop       rbp
       ret
; Total bytes of code 36
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Pairs()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+20]
       call      qword ptr [7FFDF2A5FE88]; JitFoldProof.Subjects.ClearPairs(System.Collections.Generic.List`1<JitFoldProof.Types.PairValue>)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; JitFoldProof.Subjects.ClearPairs(System.Collections.Generic.List`1<JitFoldProof.Types.PairValue>)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF293EA78]; System.Collections.Generic.List`1[[JitFoldProof.Types.PairValue, JitFoldProof]].Clear()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 33
```
```assembly
; System.Collections.Generic.List`1[[JitFoldProof.Types.PairValue, JitFoldProof]].Clear()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       inc       dword ptr [rax+14]
       mov       rax,[rbp+10]
       mov       eax,[rax+10]
       mov       [rbp-4],eax
       mov       rax,[rbp+10]
       xor       ecx,ecx
       mov       [rax+10],ecx
       cmp       dword ptr [rbp-4],0
       jle       short M02_L00
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       mov       r8d,[rbp-4]
       xor       edx,edx
       call      qword ptr [7FFDF2A54C78]; System.Array.Clear(System.Array, Int32, Int32)
       nop
       add       rsp,30
       pop       rbp
       ret
M02_L00:
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 79
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Numbers()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       call      qword ptr [7FFDC8E95C98]; JitFoldProof.Subjects.ClearNumbers(System.Collections.Generic.List`1<Int32>)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; JitFoldProof.Subjects.ClearNumbers(System.Collections.Generic.List`1<Int32>)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDC8C80AA8]; Precode of System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].Clear()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 33
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Words()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       call      qword ptr [7FFDC8E959F8]; JitFoldProof.Subjects.ClearWords(System.Collections.Generic.List`1<System.String>)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; JitFoldProof.Subjects.ClearWords(System.Collections.Generic.List`1<System.String>)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDC8B272C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Clear()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 33
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Clear()
       inc       dword ptr [rcx+14]
       mov       r8d,[rcx+10]
       xor       eax,eax
       mov       [rcx+10],eax
       test      r8d,r8d
       jle       short M02_L00
       mov       rcx,[rcx+8]
       lea       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       xor       edx,edx
       jmp       qword ptr [rax]
M02_L00:
       ret
; Total bytes of code 34
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Points()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+18]
       call      qword ptr [7FFDC8E75A10]; JitFoldProof.Subjects.ClearPoints(System.Collections.Generic.List`1<JitFoldProof.Types.PointValue>)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; JitFoldProof.Subjects.ClearPoints(System.Collections.Generic.List`1<JitFoldProof.Types.PointValue>)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDC8C61988]; Precode of System.Collections.Generic.List`1[[JitFoldProof.Types.PointValue, JitFoldProof]].Clear()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 33
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Pairs()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+20]
       call      qword ptr [7FFDC8EB5CE0]; JitFoldProof.Subjects.ClearPairs(System.Collections.Generic.List`1<JitFoldProof.Types.PairValue>)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; JitFoldProof.Subjects.ClearPairs(System.Collections.Generic.List`1<JitFoldProof.Types.PairValue>)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDC8CA2880]; System.Collections.Generic.List`1[[JitFoldProof.Types.PairValue, JitFoldProof]].Clear()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 33
```
```assembly
; System.Collections.Generic.List`1[[JitFoldProof.Types.PairValue, JitFoldProof]].Clear()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       inc       dword ptr [rax+14]
       call      qword ptr [7FFDC8DEDF80]; System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[JitFoldProof.Types.PairValue, JitFoldProof]]()
       test      eax,eax
       je        short M02_L00
       mov       rcx,[rbp+10]
       mov       ecx,[rcx+10]
       mov       [rbp-4],ecx
       mov       rcx,[rbp+10]
       xor       r8d,r8d
       mov       [rcx+10],r8d
       cmp       dword ptr [rbp-4],0
       jle       short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       r8d,[rbp-4]
       xor       edx,edx
       call      qword ptr [7FFDC89C74C8]; System.Array.Clear(System.Array, Int32, Int32)
       nop
       add       rsp,30
       pop       rbp
       ret
M02_L00:
       mov       rax,[rbp+10]
       xor       ecx,ecx
       mov       [rax+10],ecx
M02_L01:
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 100
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Numbers()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       call      qword ptr [7FFD9259F018]; JitFoldProof.Subjects.ClearNumbers(System.Collections.Generic.List`1<Int32>)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; JitFoldProof.Subjects.ClearNumbers(System.Collections.Generic.List`1<Int32>)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFD924281D8]; Precode of System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].Clear()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 33
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Words()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       call      qword ptr [7FFD925CF0C0]; JitFoldProof.Subjects.ClearWords(System.Collections.Generic.List`1<System.String>)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; JitFoldProof.Subjects.ClearWords(System.Collections.Generic.List`1<System.String>)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFD92322E78]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Clear()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 33
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Clear()
       inc       dword ptr [rcx+14]
       mov       r8d,[rcx+10]
       xor       eax,eax
       mov       [rcx+10],eax
       test      r8d,r8d
       jle       short M02_L00
       mov       rcx,[rcx+8]
       lea       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       xor       edx,edx
       jmp       qword ptr [rax]
M02_L00:
       ret
; Total bytes of code 34
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Points()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+18]
       call      qword ptr [7FFD925BF018]; JitFoldProof.Subjects.ClearPoints(System.Collections.Generic.List`1<JitFoldProof.Types.PointValue>)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; JitFoldProof.Subjects.ClearPoints(System.Collections.Generic.List`1<JitFoldProof.Types.PointValue>)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFD924A74A8]; Precode of System.Collections.Generic.List`1[[JitFoldProof.Types.PointValue, JitFoldProof]].Clear()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 33
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Pairs()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+20]
       call      qword ptr [7FFD925AF018]; JitFoldProof.Subjects.ClearPairs(System.Collections.Generic.List`1<JitFoldProof.Types.PairValue>)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; JitFoldProof.Subjects.ClearPairs(System.Collections.Generic.List`1<JitFoldProof.Types.PairValue>)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFD924986F8]; System.Collections.Generic.List`1[[JitFoldProof.Types.PairValue, JitFoldProof]].Clear()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 33
```
```assembly
; System.Collections.Generic.List`1[[JitFoldProof.Types.PairValue, JitFoldProof]].Clear()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       inc       dword ptr [rax+14]
       mov       rax,[rbp+10]
       mov       eax,[rax+10]
       mov       [rbp-4],eax
       mov       rax,[rbp+10]
       xor       ecx,ecx
       mov       [rax+10],ecx
       cmp       dword ptr [rbp-4],0
       jle       short M02_L00
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       mov       r8d,[rbp-4]
       xor       edx,edx
       call      qword ptr [7FFD9251FDC8]; System.Array.Clear(System.Array, Int32, Int32)
       nop
       add       rsp,30
       pop       rbp
       ret
M02_L00:
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 79
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Numbers()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       call      qword ptr [7FFDF2A6FDB0]; JitFoldProof.Subjects.ClearNumbers(System.Collections.Generic.List`1<Int32>)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; JitFoldProof.Subjects.ClearNumbers(System.Collections.Generic.List`1<Int32>)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF28E7C38]; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].Clear()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 33
```
```assembly
; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].Clear()
       inc       dword ptr [rcx+14]
       xor       eax,eax
       mov       [rcx+10],eax
       ret
; Total bytes of code 9
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Words()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       call      qword ptr [7FFDF2A4FDB0]; JitFoldProof.Subjects.ClearWords(System.Collections.Generic.List`1<System.String>)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; JitFoldProof.Subjects.ClearWords(System.Collections.Generic.List`1<System.String>)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF27817E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Clear()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 33
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Clear()
       inc       dword ptr [rcx+14]
       mov       r8d,[rcx+10]
       xor       eax,eax
       mov       [rcx+10],eax
       test      r8d,r8d
       jle       short M02_L00
       mov       rcx,[rcx+8]
       lea       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       xor       edx,edx
       jmp       qword ptr [rax]
M02_L00:
       ret
; Total bytes of code 34
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Points()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+18]
       call      qword ptr [7FFDF2A6FDB0]; JitFoldProof.Subjects.ClearPoints(System.Collections.Generic.List`1<JitFoldProof.Types.PointValue>)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; JitFoldProof.Subjects.ClearPoints(System.Collections.Generic.List`1<JitFoldProof.Types.PointValue>)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF294D828]; System.Collections.Generic.List`1[[JitFoldProof.Types.PointValue, JitFoldProof]].Clear()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 33
```
```assembly
; System.Collections.Generic.List`1[[JitFoldProof.Types.PointValue, JitFoldProof]].Clear()
       push      rbp
       sub       rsp,10
       lea       rbp,[rsp+10]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       inc       dword ptr [rax+14]
       mov       rax,[rbp+10]
       xor       ecx,ecx
       mov       [rax+10],ecx
       add       rsp,10
       pop       rbp
       ret
; Total bytes of code 36
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Pairs()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+20]
       call      qword ptr [7FFDF2A6FE88]; JitFoldProof.Subjects.ClearPairs(System.Collections.Generic.List`1<JitFoldProof.Types.PairValue>)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; JitFoldProof.Subjects.ClearPairs(System.Collections.Generic.List`1<JitFoldProof.Types.PairValue>)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF294EA78]; System.Collections.Generic.List`1[[JitFoldProof.Types.PairValue, JitFoldProof]].Clear()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 33
```
```assembly
; System.Collections.Generic.List`1[[JitFoldProof.Types.PairValue, JitFoldProof]].Clear()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       inc       dword ptr [rax+14]
       mov       rax,[rbp+10]
       mov       eax,[rax+10]
       mov       [rbp-4],eax
       mov       rax,[rbp+10]
       xor       ecx,ecx
       mov       [rax+10],ecx
       cmp       dword ptr [rbp-4],0
       jle       short M02_L00
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       mov       r8d,[rbp-4]
       xor       edx,edx
       call      qword ptr [7FFDF2A64C78]; System.Array.Clear(System.Array, Int32, Int32)
       nop
       add       rsp,30
       pop       rbp
       ret
M02_L00:
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 79
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Numbers()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       call      qword ptr [7FFDC8E859E0]; JitFoldProof.Subjects.ClearNumbers(System.Collections.Generic.List`1<Int32>)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; JitFoldProof.Subjects.ClearNumbers(System.Collections.Generic.List`1<Int32>)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDC8C70AA8]; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].Clear()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 33
```
```assembly
; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].Clear()
       inc       dword ptr [rcx+14]
       xor       eax,eax
       mov       [rcx+10],eax
       ret
; Total bytes of code 9
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Words()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       call      qword ptr [7FFDC8EA5CB0]; JitFoldProof.Subjects.ClearWords(System.Collections.Generic.List`1<System.String>)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; JitFoldProof.Subjects.ClearWords(System.Collections.Generic.List`1<System.String>)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDC8B372C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Clear()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 33
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Clear()
       inc       dword ptr [rcx+14]
       mov       r8d,[rcx+10]
       xor       eax,eax
       mov       [rcx+10],eax
       test      r8d,r8d
       jle       short M02_L00
       mov       rcx,[rcx+8]
       lea       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       xor       edx,edx
       jmp       qword ptr [rax]
M02_L00:
       ret
; Total bytes of code 34
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Points()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+18]
       call      qword ptr [7FFDC8E95A10]; JitFoldProof.Subjects.ClearPoints(System.Collections.Generic.List`1<JitFoldProof.Types.PointValue>)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; JitFoldProof.Subjects.ClearPoints(System.Collections.Generic.List`1<JitFoldProof.Types.PointValue>)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDC8C81988]; System.Collections.Generic.List`1[[JitFoldProof.Types.PointValue, JitFoldProof]].Clear()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 33
```
```assembly
; System.Collections.Generic.List`1[[JitFoldProof.Types.PointValue, JitFoldProof]].Clear()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       inc       dword ptr [rax+14]
       call      qword ptr [7FFDC8DCDF50]; System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[JitFoldProof.Types.PointValue, JitFoldProof]]()
       test      eax,eax
       je        short M02_L00
       mov       rcx,[rbp+10]
       mov       ecx,[rcx+10]
       mov       [rbp-4],ecx
       mov       rcx,[rbp+10]
       xor       r8d,r8d
       mov       [rcx+10],r8d
       cmp       dword ptr [rbp-4],0
       jle       short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       r8d,[rbp-4]
       xor       edx,edx
       call      qword ptr [7FFDC89A74C8]
       nop
       add       rsp,30
       pop       rbp
       ret
M02_L00:
       mov       rax,[rbp+10]
       xor       ecx,ecx
       mov       [rax+10],ecx
M02_L01:
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 100
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Pairs()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+20]
       call      qword ptr [7FFDC8E75A28]; JitFoldProof.Subjects.ClearPairs(System.Collections.Generic.List`1<JitFoldProof.Types.PairValue>)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; JitFoldProof.Subjects.ClearPairs(System.Collections.Generic.List`1<JitFoldProof.Types.PairValue>)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDC8C62880]; System.Collections.Generic.List`1[[JitFoldProof.Types.PairValue, JitFoldProof]].Clear()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 33
```
```assembly
; System.Collections.Generic.List`1[[JitFoldProof.Types.PairValue, JitFoldProof]].Clear()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       inc       dword ptr [rax+14]
       call      qword ptr [7FFDC8DADF80]; System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[JitFoldProof.Types.PairValue, JitFoldProof]]()
       test      eax,eax
       je        short M02_L00
       mov       rcx,[rbp+10]
       mov       ecx,[rcx+10]
       mov       [rbp-4],ecx
       mov       rcx,[rbp+10]
       xor       r8d,r8d
       mov       [rcx+10],r8d
       cmp       dword ptr [rbp-4],0
       jle       short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       r8d,[rbp-4]
       xor       edx,edx
       call      qword ptr [7FFDC89874C8]; System.Array.Clear(System.Array, Int32, Int32)
       nop
       add       rsp,30
       pop       rbp
       ret
M02_L00:
       mov       rax,[rbp+10]
       xor       ecx,ecx
       mov       [rax+10],ecx
M02_L01:
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 100
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Numbers()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       call      qword ptr [7FFD9259F018]; JitFoldProof.Subjects.ClearNumbers(System.Collections.Generic.List`1<Int32>)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; JitFoldProof.Subjects.ClearNumbers(System.Collections.Generic.List`1<Int32>)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFD92427A08]; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].Clear()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 33
```
```assembly
; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].Clear()
       inc       dword ptr [rcx+14]
       xor       eax,eax
       mov       [rcx+10],eax
       ret
; Total bytes of code 9
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Words()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       call      qword ptr [7FFD925CF018]; JitFoldProof.Subjects.ClearWords(System.Collections.Generic.List`1<System.String>)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; JitFoldProof.Subjects.ClearWords(System.Collections.Generic.List`1<System.String>)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFD923227B8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Clear()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 33
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Clear()
       inc       dword ptr [rcx+14]
       mov       r8d,[rcx+10]
       xor       eax,eax
       mov       [rcx+10],eax
       test      r8d,r8d
       jle       short M02_L00
       mov       rcx,[rcx+8]
       lea       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       xor       edx,edx
       jmp       qword ptr [rax]
M02_L00:
       ret
; Total bytes of code 34
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Points()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+18]
       call      qword ptr [7FFD925AF0F0]; JitFoldProof.Subjects.ClearPoints(System.Collections.Generic.List`1<JitFoldProof.Types.PointValue>)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; JitFoldProof.Subjects.ClearPoints(System.Collections.Generic.List`1<JitFoldProof.Types.PointValue>)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFD924974A8]; System.Collections.Generic.List`1[[JitFoldProof.Types.PointValue, JitFoldProof]].Clear()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 33
```
```assembly
; System.Collections.Generic.List`1[[JitFoldProof.Types.PointValue, JitFoldProof]].Clear()
       push      rbp
       sub       rsp,10
       lea       rbp,[rsp+10]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       inc       dword ptr [rax+14]
       mov       rax,[rbp+10]
       xor       ecx,ecx
       mov       [rax+10],ecx
       add       rsp,10
       pop       rbp
       ret
; Total bytes of code 36
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Pairs()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+20]
       call      qword ptr [7FFD925AF0F0]; JitFoldProof.Subjects.ClearPairs(System.Collections.Generic.List`1<JitFoldProof.Types.PairValue>)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; JitFoldProof.Subjects.ClearPairs(System.Collections.Generic.List`1<JitFoldProof.Types.PairValue>)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFD924986F8]; System.Collections.Generic.List`1[[JitFoldProof.Types.PairValue, JitFoldProof]].Clear()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 33
```
```assembly
; System.Collections.Generic.List`1[[JitFoldProof.Types.PairValue, JitFoldProof]].Clear()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       inc       dword ptr [rax+14]
       mov       rax,[rbp+10]
       mov       eax,[rax+10]
       mov       [rbp-4],eax
       mov       rax,[rbp+10]
       xor       ecx,ecx
       mov       [rax+10],ecx
       cmp       dword ptr [rbp-4],0
       jle       short M02_L00
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       mov       r8d,[rbp-4]
       xor       edx,edx
       call      qword ptr [7FFD9251FDC8]; System.Array.Clear(System.Array, Int32, Int32)
       nop
       add       rsp,30
       pop       rbp
       ret
M02_L00:
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 79
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Numbers()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       call      qword ptr [7FFDF2B05248]; JitFoldProof.Subjects.ClearNumbers(System.Collections.Generic.List`1<Int32>)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; JitFoldProof.Subjects.ClearNumbers(System.Collections.Generic.List`1<Int32>)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF28D7C38]; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].Clear()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 33
```
```assembly
; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].Clear()
       inc       dword ptr [rcx+14]
       xor       eax,eax
       mov       [rcx+10],eax
       ret
; Total bytes of code 9
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Words()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       call      qword ptr [7FFDF2B15248]; JitFoldProof.Subjects.ClearWords(System.Collections.Generic.List`1<System.String>)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; JitFoldProof.Subjects.ClearWords(System.Collections.Generic.List`1<System.String>)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF27A17E0]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Clear()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 33
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Points()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+18]
       call      qword ptr [7FFDF2B15248]; JitFoldProof.Subjects.ClearPoints(System.Collections.Generic.List`1<JitFoldProof.Types.PointValue>)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; JitFoldProof.Subjects.ClearPoints(System.Collections.Generic.List`1<JitFoldProof.Types.PointValue>)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF294D828]; System.Collections.Generic.List`1[[JitFoldProof.Types.PointValue, JitFoldProof]].Clear()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 33
```
```assembly
; System.Collections.Generic.List`1[[JitFoldProof.Types.PointValue, JitFoldProof]].Clear()
       push      rbp
       sub       rsp,10
       lea       rbp,[rsp+10]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       inc       dword ptr [rax+14]
       mov       rax,[rbp+10]
       xor       ecx,ecx
       mov       [rax+10],ecx
       add       rsp,10
       pop       rbp
       ret
; Total bytes of code 36
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Pairs()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+20]
       call      qword ptr [7FFDF2AF5248]; JitFoldProof.Subjects.ClearPairs(System.Collections.Generic.List`1<JitFoldProof.Types.PairValue>)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; JitFoldProof.Subjects.ClearPairs(System.Collections.Generic.List`1<JitFoldProof.Types.PairValue>)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF292EA78]; Precode of System.Collections.Generic.List`1[[JitFoldProof.Types.PairValue, JitFoldProof]].Clear()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 33
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Numbers()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       call      qword ptr [7FFDC8EB5C98]; JitFoldProof.Subjects.ClearNumbers(System.Collections.Generic.List`1<Int32>)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; JitFoldProof.Subjects.ClearNumbers(System.Collections.Generic.List`1<Int32>)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDC8C80AA8]; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].Clear()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 33
```
```assembly
; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].Clear()
       inc       dword ptr [rcx+14]
       xor       eax,eax
       mov       [rcx+10],eax
       ret
; Total bytes of code 9
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Words()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       call      qword ptr [7FFDC8ED59F8]; JitFoldProof.Subjects.ClearWords(System.Collections.Generic.List`1<System.String>)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; JitFoldProof.Subjects.ClearWords(System.Collections.Generic.List`1<System.String>)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDC8B472C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Clear()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 33
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Clear()
       inc       dword ptr [rcx+14]
       mov       r8d,[rcx+10]
       xor       eax,eax
       mov       [rcx+10],eax
       test      r8d,r8d
       jle       short M02_L00
       mov       rcx,[rcx+8]
       lea       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       xor       edx,edx
       jmp       qword ptr [rax]
M02_L00:
       ret
; Total bytes of code 34
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Points()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+18]
       call      qword ptr [7FFDC8EA5CC8]; JitFoldProof.Subjects.ClearPoints(System.Collections.Generic.List`1<JitFoldProof.Types.PointValue>)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; JitFoldProof.Subjects.ClearPoints(System.Collections.Generic.List`1<JitFoldProof.Types.PointValue>)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDC8C71988]; System.Collections.Generic.List`1[[JitFoldProof.Types.PointValue, JitFoldProof]].Clear()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 33
```
```assembly
; System.Collections.Generic.List`1[[JitFoldProof.Types.PointValue, JitFoldProof]].Clear()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       inc       dword ptr [rax+14]
       call      qword ptr [7FFDC8DBDF50]; System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[JitFoldProof.Types.PointValue, JitFoldProof]]()
       test      eax,eax
       je        short M02_L00
       mov       rcx,[rbp+10]
       mov       ecx,[rcx+10]
       mov       [rbp-4],ecx
       mov       rcx,[rbp+10]
       xor       r8d,r8d
       mov       [rcx+10],r8d
       cmp       dword ptr [rbp-4],0
       jle       short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       r8d,[rbp-4]
       xor       edx,edx
       call      qword ptr [7FFDC89974C8]
       nop
       add       rsp,30
       pop       rbp
       ret
M02_L00:
       mov       rax,[rbp+10]
       xor       ecx,ecx
       mov       [rax+10],ecx
M02_L01:
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 100
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Pairs()
       mov       rcx,[rcx+20]
       jmp       qword ptr [7FFDC8EC5CE0]; JitFoldProof.Subjects.ClearPairs(System.Collections.Generic.List`1<JitFoldProof.Types.PairValue>)
; Total bytes of code 10
```
```assembly
; JitFoldProof.Subjects.ClearPairs(System.Collections.Generic.List`1<JitFoldProof.Types.PairValue>)
       sub       rsp,28
       inc       dword ptr [rcx+14]
       mov       r8d,[rcx+10]
       xor       edx,edx
       mov       [rcx+10],edx
       test      r8d,r8d
       jle       short M01_L00
       mov       rcx,[rcx+8]
       xor       edx,edx
       call      qword ptr [7FFDC89B74C8]; System.Array.Clear(System.Array, Int32, Int32)
M01_L00:
       nop
       add       rsp,28
       ret
; Total bytes of code 39
```
```assembly
; System.Array.Clear(System.Array, Int32, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       test      rcx,rcx
       je        short M02_L02
       lea       rbx,[rcx+10]
       xor       esi,esi
       mov       rdi,[rcx]
       cmp       dword ptr [rdi+4],18
       ja        short M02_L03
       mov       ebp,edx
       sub       ebp,esi
       cmp       edx,esi
       jl        short M02_L04
M02_L00:
       mov       edx,ebp
       or        edx,r8d
       jl        short M02_L04
       lea       edx,[r8+rbp]
       cmp       edx,[rcx+8]
       ja        short M02_L04
       movzx     edx,word ptr [rdi]
       mov       ecx,ebp
       imul      rcx,rdx
       add       rcx,rbx
       mov       eax,r8d
       imul      rdx,rax
       test      dword ptr [rdi],1000000
       je        short M02_L01
       shr       rdx,3
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFDC8B15290]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M02_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFDC8B15278]
M02_L02:
       mov       ecx,2
       call      qword ptr [7FFDC8C0ED00]
       int       3
M02_L03:
       mov       eax,[rdi+4]
       add       eax,0FFFFFFE8
       shr       eax,3
       movsxd    r10,eax
       mov       esi,[rbx+r10*4]
       shl       eax,3
       cdqe
       add       rbx,rax
       mov       ebp,edx
       sub       ebp,esi
       cmp       edx,esi
       jge       short M02_L00
M02_L04:
       call      qword ptr [7FFDC8C0E9B8]
       int       3
; Total bytes of code 162
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Numbers()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       call      qword ptr [7FFD926644E0]; JitFoldProof.Subjects.ClearNumbers(System.Collections.Generic.List`1<Int32>)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; JitFoldProof.Subjects.ClearNumbers(System.Collections.Generic.List`1<Int32>)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFD92437A08]; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].Clear()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 33
```
```assembly
; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].Clear()
       inc       dword ptr [rcx+14]
       xor       eax,eax
       mov       [rcx+10],eax
       ret
; Total bytes of code 9
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Words()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       call      qword ptr [7FFD926645B8]; JitFoldProof.Subjects.ClearWords(System.Collections.Generic.List`1<System.String>)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; JitFoldProof.Subjects.ClearWords(System.Collections.Generic.List`1<System.String>)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFD922F27B8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Clear()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 33
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Clear()
       inc       dword ptr [rcx+14]
       mov       r8d,[rcx+10]
       xor       eax,eax
       mov       [rcx+10],eax
       test      r8d,r8d
       jle       short M02_L00
       mov       rcx,[rcx+8]
       lea       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       xor       edx,edx
       jmp       qword ptr [rax]
M02_L00:
       ret
; Total bytes of code 34
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Points()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+18]
       call      qword ptr [7FFD926744E0]; JitFoldProof.Subjects.ClearPoints(System.Collections.Generic.List`1<JitFoldProof.Types.PointValue>)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; JitFoldProof.Subjects.ClearPoints(System.Collections.Generic.List`1<JitFoldProof.Types.PointValue>)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFD924A74A8]; System.Collections.Generic.List`1[[JitFoldProof.Types.PointValue, JitFoldProof]].Clear()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 33
```
```assembly
; System.Collections.Generic.List`1[[JitFoldProof.Types.PointValue, JitFoldProof]].Clear()
       push      rbp
       sub       rsp,10
       lea       rbp,[rsp+10]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       inc       dword ptr [rax+14]
       mov       rax,[rbp+10]
       xor       ecx,ecx
       mov       [rax+10],ecx
       add       rsp,10
       pop       rbp
       ret
; Total bytes of code 36
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Pairs()
       mov       rcx,[rcx+20]
       jmp       qword ptr [7FFD926644E0]; JitFoldProof.Subjects.ClearPairs(System.Collections.Generic.List`1<JitFoldProof.Types.PairValue>)
; Total bytes of code 10
```
```assembly
; JitFoldProof.Subjects.ClearPairs(System.Collections.Generic.List`1<JitFoldProof.Types.PairValue>)
       sub       rsp,28
       inc       dword ptr [rcx+14]
       mov       r8d,[rcx+10]
       xor       edx,edx
       mov       [rcx+10],edx
       test      r8d,r8d
       jle       short M01_L00
       mov       rcx,[rcx+8]
       xor       edx,edx
       call      qword ptr [7FFD9251FDC8]; System.Array.Clear(System.Array, Int32, Int32)
M01_L00:
       nop
       add       rsp,28
       ret
; Total bytes of code 39
```
```assembly
; System.Array.Clear(System.Array, Int32, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       test      rcx,rcx
       je        near ptr M02_L04
       lea       rbx,[rcx+10]
       xor       esi,esi
       mov       rdi,[rcx]
       cmp       dword ptr [rdi+4],18
       ja        short M02_L01
M02_L00:
       mov       eax,edx
       sub       eax,esi
       cmp       edx,esi
       jl        short M02_L03
       mov       edx,eax
       or        edx,r8d
       jl        short M02_L03
       lea       edx,[rax+r8]
       cmp       edx,[rcx+8]
       ja        short M02_L03
       movzx     edx,word ptr [rdi]
       mov       ecx,eax
       imul      rcx,rdx
       add       rcx,rbx
       mov       eax,r8d
       imul      rdx,rax
       test      dword ptr [rdi],1000000
       je        short M02_L02
       shr       rdx,3
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFD92515200]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M02_L01:
       mov       eax,[rdi+4]
       add       eax,0FFFFFFE8
       shr       eax,3
       movsxd    r10,eax
       mov       esi,[rbx+r10*4]
       shl       eax,3
       cdqe
       add       rbx,rax
       jmp       short M02_L00
M02_L02:
       call      qword ptr [7FFD921E5788]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L03:
       call      qword ptr [7FFD9266D4E8]
       int       3
M02_L04:
       mov       ecx,2
       call      qword ptr [7FFD921EFC18]
       int       3
; Total bytes of code 159
```

