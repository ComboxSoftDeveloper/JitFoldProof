## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Numbers()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       call      qword ptr [7FFEAFD44048]; JitFoldProof.Subjects.ClearNumbers(System.Collections.Generic.List`1<Int32>)
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
       call      qword ptr [7FFEAFB07C38]; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].Clear()
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
       call      qword ptr [7FFEAFD24048]; JitFoldProof.Subjects.ClearWords(System.Collections.Generic.List`1<System.String>)
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
       call      qword ptr [7FFEAF9A17E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Clear()
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
       call      qword ptr [7FFEAFD34048]; JitFoldProof.Subjects.ClearPoints(System.Collections.Generic.List`1<JitFoldProof.Types.PointValue>)
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
       call      qword ptr [7FFEAFB5D828]; System.Collections.Generic.List`1[[JitFoldProof.Types.PointValue, JitFoldProof]].Clear()
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
       call      qword ptr [7FFEAFD44048]; JitFoldProof.Subjects.ClearPairs(System.Collections.Generic.List`1<JitFoldProof.Types.PairValue>)
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
       call      qword ptr [7FFEAFB6EA78]; System.Collections.Generic.List`1[[JitFoldProof.Types.PairValue, JitFoldProof]].Clear()
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
       call      qword ptr [7FFEAFC94E40]; System.Array.Clear(System.Array, Int32, Int32)
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

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Numbers()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       call      qword ptr [7FFE6DE65C98]; JitFoldProof.Subjects.ClearNumbers(System.Collections.Generic.List`1<Int32>)
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
       call      qword ptr [7FFE6DC50AA8]; Precode of System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].Clear()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 33
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Words()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       call      qword ptr [7FFE6DE85CB0]; JitFoldProof.Subjects.ClearWords(System.Collections.Generic.List`1<System.String>)
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
       call      qword ptr [7FFE6DB172C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Clear()
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

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Points()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+18]
       call      qword ptr [7FFE6DE85CC8]; JitFoldProof.Subjects.ClearPoints(System.Collections.Generic.List`1<JitFoldProof.Types.PointValue>)
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
       call      qword ptr [7FFE6DC71988]; System.Collections.Generic.List`1[[JitFoldProof.Types.PointValue, JitFoldProof]].Clear()
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
       call      qword ptr [7FFE6DDBDF50]; System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[JitFoldProof.Types.PointValue, JitFoldProof]]()
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
       call      qword ptr [7FFE6D9974C8]
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

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Pairs()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+20]
       call      qword ptr [7FFE6DE75CE0]; JitFoldProof.Subjects.ClearPairs(System.Collections.Generic.List`1<JitFoldProof.Types.PairValue>)
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
       call      qword ptr [7FFE6DC62880]; System.Collections.Generic.List`1[[JitFoldProof.Types.PairValue, JitFoldProof]].Clear()
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
       call      qword ptr [7FFE6DDADF80]; System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[JitFoldProof.Types.PairValue, JitFoldProof]]()
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
       call      qword ptr [7FFE6D9874C8]; System.Array.Clear(System.Array, Int32, Int32)
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

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Numbers()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       call      qword ptr [7FFE9741EF70]; JitFoldProof.Subjects.ClearNumbers(System.Collections.Generic.List`1<Int32>)
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
       call      qword ptr [7FFE972A6760]; Precode of System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].Clear()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 33
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Words()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       call      qword ptr [7FFE973FEF70]; JitFoldProof.Subjects.ClearWords(System.Collections.Generic.List`1<System.String>)
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
       call      qword ptr [7FFE9714DB90]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Clear()
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

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Points()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+18]
       call      qword ptr [7FFE973FEF70]; JitFoldProof.Subjects.ClearPoints(System.Collections.Generic.List`1<JitFoldProof.Types.PointValue>)
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
       call      qword ptr [7FFE972E5D00]; System.Collections.Generic.List`1[[JitFoldProof.Types.PointValue, JitFoldProof]].Clear()
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

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Pairs()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+20]
       call      qword ptr [7FFE9740EF70]; JitFoldProof.Subjects.ClearPairs(System.Collections.Generic.List`1<JitFoldProof.Types.PairValue>)
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
       call      qword ptr [7FFE972F6F50]; System.Collections.Generic.List`1[[JitFoldProof.Types.PairValue, JitFoldProof]].Clear()
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
       call      qword ptr [7FFE9737FD20]; System.Array.Clear(System.Array, Int32, Int32)
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
       call      qword ptr [7FFEAFC9FF60]; JitFoldProof.Subjects.ClearNumbers(System.Collections.Generic.List`1<Int32>)
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
       call      qword ptr [7FFEAFB07C38]; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].Clear()
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
       call      qword ptr [7FFEAFC9FF60]; JitFoldProof.Subjects.ClearWords(System.Collections.Generic.List`1<System.String>)
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
       call      qword ptr [7FFEAF9C17E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Clear()
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
       call      qword ptr [7FFEAFC8FF60]; JitFoldProof.Subjects.ClearPoints(System.Collections.Generic.List`1<JitFoldProof.Types.PointValue>)
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
       call      qword ptr [7FFEAFB5D828]; System.Collections.Generic.List`1[[JitFoldProof.Types.PointValue, JitFoldProof]].Clear()
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
       call      qword ptr [7FFEAFD54030]; JitFoldProof.Subjects.ClearPairs(System.Collections.Generic.List`1<JitFoldProof.Types.PairValue>)
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
       call      qword ptr [7FFEAFB7EA78]; System.Collections.Generic.List`1[[JitFoldProof.Types.PairValue, JitFoldProof]].Clear()
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
       call      qword ptr [7FFEAFCA4E40]; System.Array.Clear(System.Array, Int32, Int32)
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

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Numbers()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       call      qword ptr [7FFE6DE55C98]; JitFoldProof.Subjects.ClearNumbers(System.Collections.Generic.List`1<Int32>)
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
       call      qword ptr [7FFE6DC40AA8]; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].Clear()
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

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Words()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       call      qword ptr [7FFE6DE859F8]; JitFoldProof.Subjects.ClearWords(System.Collections.Generic.List`1<System.String>)
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
       call      qword ptr [7FFE6DB172C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Clear()
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

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Points()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+18]
       call      qword ptr [7FFE6DE55A10]; JitFoldProof.Subjects.ClearPoints(System.Collections.Generic.List`1<JitFoldProof.Types.PointValue>)
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
       call      qword ptr [7FFE6DC41988]; System.Collections.Generic.List`1[[JitFoldProof.Types.PointValue, JitFoldProof]].Clear()
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
       call      qword ptr [7FFE6DD8DF50]; System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[JitFoldProof.Types.PointValue, JitFoldProof]]()
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
       call      qword ptr [7FFE6D9674C8]
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

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Pairs()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+20]
       call      qword ptr [7FFE6DE75A28]; JitFoldProof.Subjects.ClearPairs(System.Collections.Generic.List`1<JitFoldProof.Types.PairValue>)
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
       call      qword ptr [7FFE6DC62880]; System.Collections.Generic.List`1[[JitFoldProof.Types.PairValue, JitFoldProof]].Clear()
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
       call      qword ptr [7FFE6DDADF80]; System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[JitFoldProof.Types.PairValue, JitFoldProof]]()
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
       call      qword ptr [7FFE6D9874C8]; System.Array.Clear(System.Array, Int32, Int32)
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

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Numbers()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       call      qword ptr [7FFE9741F030]; JitFoldProof.Subjects.ClearNumbers(System.Collections.Generic.List`1<Int32>)
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
       call      qword ptr [7FFE972A6760]; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].Clear()
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

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Words()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       call      qword ptr [7FFE9740EF70]; JitFoldProof.Subjects.ClearWords(System.Collections.Generic.List`1<System.String>)
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
       call      qword ptr [7FFE9715DB90]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Clear()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 33
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Points()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+18]
       call      qword ptr [7FFE973FEF70]; JitFoldProof.Subjects.ClearPoints(System.Collections.Generic.List`1<JitFoldProof.Types.PointValue>)
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
       call      qword ptr [7FFE972E5D00]; System.Collections.Generic.List`1[[JitFoldProof.Types.PointValue, JitFoldProof]].Clear()
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

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Pairs()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+20]
       call      qword ptr [7FFE9740F048]; JitFoldProof.Subjects.ClearPairs(System.Collections.Generic.List`1<JitFoldProof.Types.PairValue>)
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
       call      qword ptr [7FFE972F6F50]; System.Collections.Generic.List`1[[JitFoldProof.Types.PairValue, JitFoldProof]].Clear()
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
       call      qword ptr [7FFE9737FD20]; System.Array.Clear(System.Array, Int32, Int32)
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
       call      qword ptr [7FFEAFD35320]; JitFoldProof.Subjects.ClearNumbers(System.Collections.Generic.List`1<Int32>)
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
       call      qword ptr [7FFEAFB07C38]; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].Clear()
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
       call      qword ptr [7FFEAFD353F8]; JitFoldProof.Subjects.ClearWords(System.Collections.Generic.List`1<System.String>)
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
       call      qword ptr [7FFEAF9B17E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Clear()
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
       call      qword ptr [7FFEAFD353F8]; JitFoldProof.Subjects.ClearPoints(System.Collections.Generic.List`1<JitFoldProof.Types.PointValue>)
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
       call      qword ptr [7FFEAFB5D828]; System.Collections.Generic.List`1[[JitFoldProof.Types.PointValue, JitFoldProof]].Clear()
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
       call      qword ptr [7FFEAFD25320]; JitFoldProof.Subjects.ClearPairs(System.Collections.Generic.List`1<JitFoldProof.Types.PairValue>)
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
       call      qword ptr [7FFEAFB5EA78]; Precode of System.Collections.Generic.List`1[[JitFoldProof.Types.PairValue, JitFoldProof]].Clear()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 33
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Numbers()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       call      qword ptr [7FFE740C59E0]; JitFoldProof.Subjects.ClearNumbers(System.Collections.Generic.List`1<Int32>)
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
       call      qword ptr [7FFE73E90AA8]; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].Clear()
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

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Words()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       call      qword ptr [7FFE740D5CB0]; JitFoldProof.Subjects.ClearWords(System.Collections.Generic.List`1<System.String>)
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
       call      qword ptr [7FFE73D472C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Clear()
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

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Points()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+18]
       call      qword ptr [7FFE740B5CC8]; JitFoldProof.Subjects.ClearPoints(System.Collections.Generic.List`1<JitFoldProof.Types.PointValue>)
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
       call      qword ptr [7FFE73E81988]; System.Collections.Generic.List`1[[JitFoldProof.Types.PointValue, JitFoldProof]].Clear()
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
       call      qword ptr [7FFE73FCDF50]; System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[JitFoldProof.Types.PointValue, JitFoldProof]]()
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
       call      qword ptr [7FFE73BA74C8]
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

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Pairs()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+20]
       call      qword ptr [7FFE740C5A28]; JitFoldProof.Subjects.ClearPairs(System.Collections.Generic.List`1<JitFoldProof.Types.PairValue>)
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
       call      qword ptr [7FFE73E92880]; System.Collections.Generic.List`1[[JitFoldProof.Types.PairValue, JitFoldProof]].Clear()
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
       call      qword ptr [7FFE73FDDF80]; System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[JitFoldProof.Types.PairValue, JitFoldProof]]()
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
       call      qword ptr [7FFE73BB74C8]; System.Array.Clear(System.Array, Int32, Int32)
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

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Numbers()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       call      qword ptr [7FFE740344F8]; JitFoldProof.Subjects.ClearNumbers(System.Collections.Generic.List`1<Int32>)
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
       call      qword ptr [7FFE73DF6760]; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].Clear()
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

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Words()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       call      qword ptr [7FFE74024438]; JitFoldProof.Subjects.ClearWords(System.Collections.Generic.List`1<System.String>)
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
       call      qword ptr [7FFE73CBDB90]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Clear()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 33
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Clear()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       inc       dword ptr [rbx+14]
       mov       esi,[rbx+10]
       xor       ecx,ecx
       mov       [rbx+10],ecx
       test      esi,esi
       jle       short M02_L00
       mov       rcx,7FFE74129240
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+8]
       mov       r8d,esi
       xor       edx,edx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE73EDFD20]; System.Array.Clear(System.Array, Int32, Int32)
M02_L00:
       mov       rcx,7FFE74129244
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 83
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Points()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+18]
       call      qword ptr [7FFE740348D0]; JitFoldProof.Subjects.ClearPoints(System.Collections.Generic.List`1<JitFoldProof.Types.PointValue>)
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
       call      qword ptr [7FFE73E55D00]; System.Collections.Generic.List`1[[JitFoldProof.Types.PointValue, JitFoldProof]].Clear()
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

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Pairs()
       mov       rcx,[rcx+20]
       jmp       qword ptr [7FFE74034510]; JitFoldProof.Subjects.ClearPairs(System.Collections.Generic.List`1<JitFoldProof.Types.PairValue>)
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
       call      qword ptr [7FFE73EDFD20]; System.Array.Clear(System.Array, Int32, Int32)
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
       jmp       qword ptr [7FFE73ED5158]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
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
       call      qword ptr [7FFE73BA5788]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L03:
       call      qword ptr [7FFE7403D7A0]
       int       3
M02_L04:
       mov       ecx,2
       call      qword ptr [7FFE73BAFB28]
       int       3
; Total bytes of code 159
```

