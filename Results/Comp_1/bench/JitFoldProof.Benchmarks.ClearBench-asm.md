## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Numbers()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       call      qword ptr [7FFE1255FF90]; JitFoldProof.Subjects.ClearNumbers(System.Collections.Generic.List`1<Int32>)
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
       call      qword ptr [7FFE123F3C78]; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].Clear()
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Words()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       call      qword ptr [7FFE1255FEA0]; JitFoldProof.Subjects.ClearWords(System.Collections.Generic.List`1<System.String>)
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
       call      qword ptr [7FFE122D35A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Clear()
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Points()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+18]
       call      qword ptr [7FFE1258FF90]; JitFoldProof.Subjects.ClearPoints(System.Collections.Generic.List`1<JitFoldProof.Types.PointValue>)
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
       call      qword ptr [7FFE12479E30]; System.Collections.Generic.List`1[[JitFoldProof.Types.PointValue, JitFoldProof]].Clear()
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Pairs()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+20]
       call      qword ptr [7FFE1254FEA0]; JitFoldProof.Subjects.ClearPairs(System.Collections.Generic.List`1<JitFoldProof.Types.PairValue>)
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
       call      qword ptr [7FFE1243B080]; System.Collections.Generic.List`1[[JitFoldProof.Types.PairValue, JitFoldProof]].Clear()
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
       call      qword ptr [7FFE12544D20]; System.Array.Clear(System.Array, Int32, Int32)
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Numbers()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       call      qword ptr [7FFE0D7EF5D0]; JitFoldProof.Subjects.ClearNumbers(System.Collections.Generic.List`1<Int32>)
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
       call      qword ptr [7FFE0D5F0AA8]; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].Clear()
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Words()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       call      qword ptr [7FFE0D7EF1E0]; JitFoldProof.Subjects.ClearWords(System.Collections.Generic.List`1<System.String>)
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
       call      qword ptr [7FFE0D4972C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Clear()
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Points()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+18]
       call      qword ptr [7FFE0D7DF600]; JitFoldProof.Subjects.ClearPoints(System.Collections.Generic.List`1<JitFoldProof.Types.PointValue>)
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
       call      qword ptr [7FFE0D5E1988]; System.Collections.Generic.List`1[[JitFoldProof.Types.PointValue, JitFoldProof]].Clear()
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
       call      qword ptr [7FFE0D727B28]; System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[JitFoldProof.Types.PointValue, JitFoldProof]]()
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
       call      qword ptr [7FFE0D3074C8]
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Pairs()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+20]
       call      qword ptr [7FFE0D7DF618]; JitFoldProof.Subjects.ClearPairs(System.Collections.Generic.List`1<JitFoldProof.Types.PairValue>)
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
       call      qword ptr [7FFE0D5E2880]; System.Collections.Generic.List`1[[JitFoldProof.Types.PairValue, JitFoldProof]].Clear()
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
       call      qword ptr [7FFE0D727B58]; System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[JitFoldProof.Types.PairValue, JitFoldProof]]()
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
       call      qword ptr [7FFE0D3074C8]; System.Array.Clear(System.Array, Int32, Int32)
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Numbers()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       call      qword ptr [7FFE0FDFEFA0]; JitFoldProof.Subjects.ClearNumbers(System.Collections.Generic.List`1<Int32>)
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
       call      qword ptr [7FFE0FC86778]; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].Clear()
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Words()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       call      qword ptr [7FFE0FDFEFA0]; JitFoldProof.Subjects.ClearWords(System.Collections.Generic.List`1<System.String>)
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
       call      qword ptr [7FFE0FB4DBD0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Clear()
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Points()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+18]
       call      qword ptr [7FFE0FDFF078]; JitFoldProof.Subjects.ClearPoints(System.Collections.Generic.List`1<JitFoldProof.Types.PointValue>)
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
       call      qword ptr [7FFE0FCE5D00]; System.Collections.Generic.List`1[[JitFoldProof.Types.PointValue, JitFoldProof]].Clear()
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Pairs()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+20]
       call      qword ptr [7FFE0FDCF078]; JitFoldProof.Subjects.ClearPairs(System.Collections.Generic.List`1<JitFoldProof.Types.PairValue>)
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
       call      qword ptr [7FFE0FCB6F50]; System.Collections.Generic.List`1[[JitFoldProof.Types.PairValue, JitFoldProof]].Clear()
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
       call      qword ptr [7FFE0FD3FD50]; System.Array.Clear(System.Array, Int32, Int32)
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Numbers()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       call      qword ptr [7FFE1257FEA0]; JitFoldProof.Subjects.ClearNumbers(System.Collections.Generic.List`1<Int32>)
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
       call      qword ptr [7FFE12413C78]; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].Clear()
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Words()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       call      qword ptr [7FFE1256FF90]; JitFoldProof.Subjects.ClearWords(System.Collections.Generic.List`1<System.String>)
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
       call      qword ptr [7FFE122E35A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Clear()
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Points()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+18]
       call      qword ptr [7FFE1255FEA0]; JitFoldProof.Subjects.ClearPoints(System.Collections.Generic.List`1<JitFoldProof.Types.PointValue>)
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
       call      qword ptr [7FFE12449E30]; System.Collections.Generic.List`1[[JitFoldProof.Types.PointValue, JitFoldProof]].Clear()
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Pairs()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+20]
       call      qword ptr [7FFE1256FF90]; JitFoldProof.Subjects.ClearPairs(System.Collections.Generic.List`1<JitFoldProof.Types.PairValue>)
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
       call      qword ptr [7FFE1245B080]; System.Collections.Generic.List`1[[JitFoldProof.Types.PairValue, JitFoldProof]].Clear()
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
       call      qword ptr [7FFE12564D20]; System.Array.Clear(System.Array, Int32, Int32)
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Numbers()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       call      qword ptr [7FFE0D7CF1C8]; JitFoldProof.Subjects.ClearNumbers(System.Collections.Generic.List`1<Int32>)
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
       call      qword ptr [7FFE0D5D0AA8]; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].Clear()
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Words()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       call      qword ptr [7FFE0D7DF5E8]; JitFoldProof.Subjects.ClearWords(System.Collections.Generic.List`1<System.String>)
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
       call      qword ptr [7FFE0D4872C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Clear()
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Points()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+18]
       call      qword ptr [7FFE0D7DF600]; JitFoldProof.Subjects.ClearPoints(System.Collections.Generic.List`1<JitFoldProof.Types.PointValue>)
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
       call      qword ptr [7FFE0D5E1988]; System.Collections.Generic.List`1[[JitFoldProof.Types.PointValue, JitFoldProof]].Clear()
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
       call      qword ptr [7FFE0D727B28]; System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[JitFoldProof.Types.PointValue, JitFoldProof]]()
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
       call      qword ptr [7FFE0D3074C8]
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Pairs()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+20]
       call      qword ptr [7FFE0D7EF618]; JitFoldProof.Subjects.ClearPairs(System.Collections.Generic.List`1<JitFoldProof.Types.PairValue>)
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
       call      qword ptr [7FFE0D5F2880]; System.Collections.Generic.List`1[[JitFoldProof.Types.PairValue, JitFoldProof]].Clear()
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
       call      qword ptr [7FFE0D737B58]; System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[JitFoldProof.Types.PairValue, JitFoldProof]]()
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
       call      qword ptr [7FFE0D3174C8]; System.Array.Clear(System.Array, Int32, Int32)
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Numbers()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       call      qword ptr [7FFE0FDDF078]; JitFoldProof.Subjects.ClearNumbers(System.Collections.Generic.List`1<Int32>)
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
       call      qword ptr [7FFE0FC66778]; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].Clear()
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Words()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       call      qword ptr [7FFE0FDCF078]; JitFoldProof.Subjects.ClearWords(System.Collections.Generic.List`1<System.String>)
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
       call      qword ptr [7FFE0FB1DBD0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Clear()
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Points()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+18]
       call      qword ptr [7FFE0FDEF078]; JitFoldProof.Subjects.ClearPoints(System.Collections.Generic.List`1<JitFoldProof.Types.PointValue>)
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
       call      qword ptr [7FFE0FCD5D00]; System.Collections.Generic.List`1[[JitFoldProof.Types.PointValue, JitFoldProof]].Clear()
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Pairs()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+20]
       call      qword ptr [7FFE0FDDF078]; JitFoldProof.Subjects.ClearPairs(System.Collections.Generic.List`1<JitFoldProof.Types.PairValue>)
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
       call      qword ptr [7FFE0FCC6F50]; System.Collections.Generic.List`1[[JitFoldProof.Types.PairValue, JitFoldProof]].Clear()
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
       call      qword ptr [7FFE0FD4FD50]; System.Array.Clear(System.Array, Int32, Int32)
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Numbers()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       call      qword ptr [7FFE125B5350]; JitFoldProof.Subjects.ClearNumbers(System.Collections.Generic.List`1<Int32>)
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
       call      qword ptr [7FFE123E3C78]; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].Clear()
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Words()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       call      qword ptr [7FFE125E5350]; JitFoldProof.Subjects.ClearWords(System.Collections.Generic.List`1<System.String>)
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
       call      qword ptr [7FFE122F35A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Clear()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 33
```

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Points()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+18]
       call      qword ptr [7FFE125E5350]; JitFoldProof.Subjects.ClearPoints(System.Collections.Generic.List`1<JitFoldProof.Types.PointValue>)
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
       call      qword ptr [7FFE12469E30]; System.Collections.Generic.List`1[[JitFoldProof.Types.PointValue, JitFoldProof]].Clear()
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Pairs()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+20]
       call      qword ptr [7FFE125D5260]; JitFoldProof.Subjects.ClearPairs(System.Collections.Generic.List`1<JitFoldProof.Types.PairValue>)
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
       call      qword ptr [7FFE1245B080]; System.Collections.Generic.List`1[[JitFoldProof.Types.PairValue, JitFoldProof]].Clear()
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
       mov       rcx,7FFE1269A178
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       mov       r8d,[rbp-4]
       xor       edx,edx
       call      qword ptr [7FFE12564D20]; System.Array.Clear(System.Array, Int32, Int32)
       nop
       add       rsp,30
       pop       rbp
       ret
M02_L00:
       mov       rcx,7FFE1269A17C
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 110
```

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Numbers()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       call      qword ptr [7FFE0D8147E0]; JitFoldProof.Subjects.ClearNumbers(System.Collections.Generic.List`1<Int32>)
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
       call      qword ptr [7FFE0D5F0AA8]; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].Clear()
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Words()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       call      qword ptr [7FFE0D804D38]; JitFoldProof.Subjects.ClearWords(System.Collections.Generic.List`1<System.String>)
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
       call      qword ptr [7FFE0D4872C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Clear()
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
       mov       rcx,7FFE0D9132E8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+8]
       mov       r8d,esi
       xor       edx,edx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE0D3074C8]; System.Array.Clear(System.Array, Int32, Int32)
M02_L00:
       mov       rcx,7FFE0D9132F0
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 83
```

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Points()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+18]
       call      qword ptr [7FFE0D7F4810]; JitFoldProof.Subjects.ClearPoints(System.Collections.Generic.List`1<JitFoldProof.Types.PointValue>)
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
       call      qword ptr [7FFE0D5D1988]; System.Collections.Generic.List`1[[JitFoldProof.Types.PointValue, JitFoldProof]].Clear()
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
       call      qword ptr [7FFE0D717B28]; System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[JitFoldProof.Types.PointValue, JitFoldProof]]()
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
       call      qword ptr [7FFE0D2F74C8]
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Pairs()
       mov       rcx,[rcx+20]
       jmp       qword ptr [7FFE0D814828]; JitFoldProof.Subjects.ClearPairs(System.Collections.Generic.List`1<JitFoldProof.Types.PairValue>)
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
       call      qword ptr [7FFE0D3174C8]; System.Array.Clear(System.Array, Int32, Int32)
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
       jmp       qword ptr [7FFE0D475290]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M02_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE0D475278]
M02_L02:
       mov       ecx,2
       call      qword ptr [7FFE0D56ED00]
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
       call      qword ptr [7FFE0D56E9B8]
       int       3
; Total bytes of code 162
```

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Numbers()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       call      qword ptr [7FFE0FE84540]; JitFoldProof.Subjects.ClearNumbers(System.Collections.Generic.List`1<Int32>)
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
       call      qword ptr [7FFE0FC56778]; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].Clear()
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Words()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       call      qword ptr [7FFE0FE84468]; JitFoldProof.Subjects.ClearWords(System.Collections.Generic.List`1<System.String>)
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
       call      qword ptr [7FFE0FB1DBD0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Clear()
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
       mov       rcx,7FFE0FF68540
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+8]
       mov       r8d,esi
       xor       edx,edx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE0FD3FD50]; System.Array.Clear(System.Array, Int32, Int32)
M02_L00:
       mov       rcx,7FFE0FF68544
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 83
```

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Points()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+18]
       call      qword ptr [7FFE0FEA4540]; JitFoldProof.Subjects.ClearPoints(System.Collections.Generic.List`1<JitFoldProof.Types.PointValue>)
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
       call      qword ptr [7FFE0FCD5D00]; System.Collections.Generic.List`1[[JitFoldProof.Types.PointValue, JitFoldProof]].Clear()
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9, InvocationCount=1, UnrollFactor=1))

```assembly
; JitFoldProof.Benchmarks.ClearBench.Pairs()
       mov       rcx,[rcx+20]
       jmp       qword ptr [7FFE0FEB4468]; JitFoldProof.Subjects.ClearPairs(System.Collections.Generic.List`1<JitFoldProof.Types.PairValue>)
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
       call      qword ptr [7FFE0FD6FD50]; System.Array.Clear(System.Array, Int32, Int32)
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
       jmp       qword ptr [7FFE0FEB4480]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
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
       call      qword ptr [7FFE0FA35788]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L03:
       call      qword ptr [7FFE0FEBD470]
       int       3
M02_L04:
       mov       ecx,2
       call      qword ptr [7FFE0FA3FB28]
       int       3
; Total bytes of code 159
```

