## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Numbers()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       call      qword ptr [7FFAD7DAFEA0]; JitFoldProof.Subjects.ClearNumbers(System.Collections.Generic.List`1<Int32>)
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
       call      qword ptr [7FFAD7C43C78]; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].Clear()
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Words()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       call      qword ptr [7FFAD7D8FEA0]; JitFoldProof.Subjects.ClearWords(System.Collections.Generic.List`1<System.String>)
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
       call      qword ptr [7FFAD7B035A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Clear()
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Points()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+18]
       call      qword ptr [7FFAD7D9FEA0]; JitFoldProof.Subjects.ClearPoints(System.Collections.Generic.List`1<JitFoldProof.Types.PointValue>)
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
       call      qword ptr [7FFAD7C89E30]; System.Collections.Generic.List`1[[JitFoldProof.Types.PointValue, JitFoldProof]].Clear()
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Pairs()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+20]
       call      qword ptr [7FFAD7DAFF90]; JitFoldProof.Subjects.ClearPairs(System.Collections.Generic.List`1<JitFoldProof.Types.PairValue>)
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
       call      qword ptr [7FFAD7C9B080]; System.Collections.Generic.List`1[[JitFoldProof.Types.PairValue, JitFoldProof]].Clear()
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
       call      qword ptr [7FFAD7DA4D20]; System.Array.Clear(System.Array, Int32, Int32)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Numbers()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       call      qword ptr [7FFAB7AFF1C8]; JitFoldProof.Subjects.ClearNumbers(System.Collections.Generic.List`1<Int32>)
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
       call      qword ptr [7FFAB7900AA8]; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].Clear()
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Words()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       call      qword ptr [7FFAB7B2F5E8]; JitFoldProof.Subjects.ClearWords(System.Collections.Generic.List`1<System.String>)
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
       call      qword ptr [7FFAB77D72C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Clear()
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Points()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+18]
       call      qword ptr [7FFAB7B0F600]; JitFoldProof.Subjects.ClearPoints(System.Collections.Generic.List`1<JitFoldProof.Types.PointValue>)
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
       call      qword ptr [7FFAB7911988]; System.Collections.Generic.List`1[[JitFoldProof.Types.PointValue, JitFoldProof]].Clear()
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
       call      qword ptr [7FFAB7A57B28]; System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[JitFoldProof.Types.PointValue, JitFoldProof]]()
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
       call      qword ptr [7FFAB76374C8]
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Pairs()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+20]
       call      qword ptr [7FFAB7AEF618]; JitFoldProof.Subjects.ClearPairs(System.Collections.Generic.List`1<JitFoldProof.Types.PairValue>)
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
       call      qword ptr [7FFAB78F2880]; System.Collections.Generic.List`1[[JitFoldProof.Types.PairValue, JitFoldProof]].Clear()
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
       call      qword ptr [7FFAB7A37B58]; System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[JitFoldProof.Types.PairValue, JitFoldProof]]()
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
       call      qword ptr [7FFAB76174C8]; System.Array.Clear(System.Array, Int32, Int32)
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Numbers()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       call      qword ptr [7FFAC0C9EFA0]; JitFoldProof.Subjects.ClearNumbers(System.Collections.Generic.List`1<Int32>)
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
       call      qword ptr [7FFAC0B26778]; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].Clear()
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Words()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       call      qword ptr [7FFAC0CCF078]; JitFoldProof.Subjects.ClearWords(System.Collections.Generic.List`1<System.String>)
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
       call      qword ptr [7FFAC0A1DBD0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Clear()
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Points()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+18]
       call      qword ptr [7FFAC0CCF060]; JitFoldProof.Subjects.ClearPoints(System.Collections.Generic.List`1<JitFoldProof.Types.PointValue>)
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
       call      qword ptr [7FFAC0BB5D00]; System.Collections.Generic.List`1[[JitFoldProof.Types.PointValue, JitFoldProof]].Clear()
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Pairs()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+20]
       call      qword ptr [7FFAC0CCF078]; JitFoldProof.Subjects.ClearPairs(System.Collections.Generic.List`1<JitFoldProof.Types.PairValue>)
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
       call      qword ptr [7FFAC0BB6F50]; System.Collections.Generic.List`1[[JitFoldProof.Types.PairValue, JitFoldProof]].Clear()
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
       call      qword ptr [7FFAC0C3FD50]; System.Array.Clear(System.Array, Int32, Int32)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Numbers()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       call      qword ptr [7FFAD7D9FEA0]; JitFoldProof.Subjects.ClearNumbers(System.Collections.Generic.List`1<Int32>)
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
       call      qword ptr [7FFAD7C33C78]; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].Clear()
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Words()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       call      qword ptr [7FFAD7D9FF90]; JitFoldProof.Subjects.ClearWords(System.Collections.Generic.List`1<System.String>)
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
       call      qword ptr [7FFAD7B135A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Clear()
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Points()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+18]
       call      qword ptr [7FFAD7D8FEA0]; JitFoldProof.Subjects.ClearPoints(System.Collections.Generic.List`1<JitFoldProof.Types.PointValue>)
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
       call      qword ptr [7FFAD7C79E30]; System.Collections.Generic.List`1[[JitFoldProof.Types.PointValue, JitFoldProof]].Clear()
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Pairs()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+20]
       call      qword ptr [7FFAD7DAFF90]; JitFoldProof.Subjects.ClearPairs(System.Collections.Generic.List`1<JitFoldProof.Types.PairValue>)
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
       call      qword ptr [7FFAD7C9B080]; System.Collections.Generic.List`1[[JitFoldProof.Types.PairValue, JitFoldProof]].Clear()
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
       call      qword ptr [7FFAD7DA4D20]; System.Array.Clear(System.Array, Int32, Int32)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Numbers()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       call      qword ptr [7FFAB75CF5D0]; JitFoldProof.Subjects.ClearNumbers(System.Collections.Generic.List`1<Int32>)
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
       call      qword ptr [7FFAB73D0AA8]; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].Clear()
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Words()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       call      qword ptr [7FFAB75CF1E0]; JitFoldProof.Subjects.ClearWords(System.Collections.Generic.List`1<System.String>)
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
       call      qword ptr [7FFAB72772C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Clear()
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Points()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+18]
       call      qword ptr [7FFAB75CF1F8]; JitFoldProof.Subjects.ClearPoints(System.Collections.Generic.List`1<JitFoldProof.Types.PointValue>)
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
       call      qword ptr [7FFAB73D1988]; System.Collections.Generic.List`1[[JitFoldProof.Types.PointValue, JitFoldProof]].Clear()
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
       call      qword ptr [7FFAB7517B28]; System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[JitFoldProof.Types.PointValue, JitFoldProof]]()
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
       call      qword ptr [7FFAB70F74C8]
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Pairs()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+20]
       call      qword ptr [7FFAB75BF618]; JitFoldProof.Subjects.ClearPairs(System.Collections.Generic.List`1<JitFoldProof.Types.PairValue>)
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
       call      qword ptr [7FFAB73C2880]; System.Collections.Generic.List`1[[JitFoldProof.Types.PairValue, JitFoldProof]].Clear()
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
       call      qword ptr [7FFAB7507B58]; System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[JitFoldProof.Types.PairValue, JitFoldProof]]()
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
       call      qword ptr [7FFAB70E74C8]; System.Array.Clear(System.Array, Int32, Int32)
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Numbers()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       call      qword ptr [7FFAB74CF078]; JitFoldProof.Subjects.ClearNumbers(System.Collections.Generic.List`1<Int32>)
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
       call      qword ptr [7FFAB7356778]; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].Clear()
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Words()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       call      qword ptr [7FFAB74BF060]; JitFoldProof.Subjects.ClearWords(System.Collections.Generic.List`1<System.String>)
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
       call      qword ptr [7FFAB720DBD0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Clear()
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Points()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+18]
       call      qword ptr [7FFAB74BF078]; JitFoldProof.Subjects.ClearPoints(System.Collections.Generic.List`1<JitFoldProof.Types.PointValue>)
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
       call      qword ptr [7FFAB73A5D00]; System.Collections.Generic.List`1[[JitFoldProof.Types.PointValue, JitFoldProof]].Clear()
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Pairs()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+20]
       call      qword ptr [7FFAB74CF078]; JitFoldProof.Subjects.ClearPairs(System.Collections.Generic.List`1<JitFoldProof.Types.PairValue>)
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
       call      qword ptr [7FFAB73B6F50]; System.Collections.Generic.List`1[[JitFoldProof.Types.PairValue, JitFoldProof]].Clear()
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
       call      qword ptr [7FFAB743FD50]; System.Array.Clear(System.Array, Int32, Int32)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Numbers()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       call      qword ptr [7FFAD7E25350]; JitFoldProof.Subjects.ClearNumbers(System.Collections.Generic.List`1<Int32>)
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
       call      qword ptr [7FFAD7C53C78]; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].Clear()
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Words()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       call      qword ptr [7FFAD7E05350]; JitFoldProof.Subjects.ClearWords(System.Collections.Generic.List`1<System.String>)
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
       call      qword ptr [7FFAD7B135A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Clear()
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Points()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+18]
       call      qword ptr [7FFAD7E25338]; JitFoldProof.Subjects.ClearPoints(System.Collections.Generic.List`1<JitFoldProof.Types.PointValue>)
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
       call      qword ptr [7FFAD7CA9E30]; System.Collections.Generic.List`1[[JitFoldProof.Types.PointValue, JitFoldProof]].Clear()
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Pairs()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+20]
       call      qword ptr [7FFAD7E25350]; JitFoldProof.Subjects.ClearPairs(System.Collections.Generic.List`1<JitFoldProof.Types.PairValue>)
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
       call      qword ptr [7FFAD7CAB080]; Precode of System.Collections.Generic.List`1[[JitFoldProof.Types.PairValue, JitFoldProof]].Clear()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 33
```

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Numbers()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       call      qword ptr [7FFAB75EF828]; JitFoldProof.Subjects.ClearNumbers(System.Collections.Generic.List`1<Int32>)
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
       call      qword ptr [7FFAB73D0AA8]; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].Clear()
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Words()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       call      qword ptr [7FFAB75DF840]; JitFoldProof.Subjects.ClearWords(System.Collections.Generic.List`1<System.String>)
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
       call      qword ptr [7FFAB72672C0]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Clear()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 33
```

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Points()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+18]
       call      qword ptr [7FFAB75DFB88]; JitFoldProof.Subjects.ClearPoints(System.Collections.Generic.List`1<JitFoldProof.Types.PointValue>)
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
       call      qword ptr [7FFAB73C1988]; System.Collections.Generic.List`1[[JitFoldProof.Types.PointValue, JitFoldProof]].Clear()
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
       call      qword ptr [7FFAB7507B28]; System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[JitFoldProof.Types.PointValue, JitFoldProof]]()
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
       call      qword ptr [7FFAB70E74C8]
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Pairs()
       mov       rcx,[rcx+20]
       jmp       qword ptr [7FFAC0DEFBA0]; JitFoldProof.Subjects.ClearPairs(System.Collections.Generic.List`1<JitFoldProof.Types.PairValue>)
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
       call      qword ptr [7FFAC08F74C8]; System.Array.Clear(System.Array, Int32, Int32)
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
       jmp       qword ptr [7FFAC0A55290]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M02_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFAC0A55278]
M02_L02:
       mov       ecx,2
       call      qword ptr [7FFAC0B4ED00]
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
       call      qword ptr [7FFAC0B4E9B8]
       int       3
; Total bytes of code 162
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Numbers()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       call      qword ptr [7FFAC0D54540]; JitFoldProof.Subjects.ClearNumbers(System.Collections.Generic.List`1<Int32>)
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
       call      qword ptr [7FFAC0B26778]; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].Clear()
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Words()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       call      qword ptr [7FFAC0D74528]; JitFoldProof.Subjects.ClearWords(System.Collections.Generic.List`1<System.String>)
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
       call      qword ptr [7FFAC0A0DBD0]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Clear()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 33
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Points()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+18]
       call      qword ptr [7FFAC0D64468]; JitFoldProof.Subjects.ClearPoints(System.Collections.Generic.List`1<JitFoldProof.Types.PointValue>)
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
       call      qword ptr [7FFAC0B95D00]; System.Collections.Generic.List`1[[JitFoldProof.Types.PointValue, JitFoldProof]].Clear()
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Pairs()
       mov       rcx,[rcx+20]
       jmp       qword ptr [7FFAC0D54468]; JitFoldProof.Subjects.ClearPairs(System.Collections.Generic.List`1<JitFoldProof.Types.PairValue>)
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
       call      qword ptr [7FFAC0C0FD50]; System.Array.Clear(System.Array, Int32, Int32)
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
       jmp       qword ptr [7FFAC0D54480]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
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
       call      qword ptr [7FFAC08D5788]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L03:
       call      qword ptr [7FFAC0D5D290]
       int       3
M02_L04:
       mov       ecx,2
       call      qword ptr [7FFAC08DFB28]
       int       3
; Total bytes of code 159
```

