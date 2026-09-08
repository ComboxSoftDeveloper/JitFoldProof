## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.TierBench.Guarded()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFAD7DCF9F0]; JitFoldProof.Subjects.SumGuarded(Int32[])
; Total bytes of code 10
```
```assembly
; JitFoldProof.Subjects.SumGuarded(Int32[])
       push      rsi
       push      rbx
       sub       rsp,38
       vmovaps   [rsp+20],xmm6
       xor       eax,eax
       xor       ebx,ebx
       mov       esi,[rcx+8]
       cmp       esi,8
       jl        short M01_L02
       vxorps    ymm6,ymm6,ymm6
       lea       eax,[rsi-8]
       test      eax,eax
       jl        short M01_L01
M01_L00:
       test      ebx,ebx
       jl        short M01_L03
       mov       edx,esi
       sub       edx,ebx
       cmp       edx,8
       jl        short M01_L03
       mov       edx,ebx
       vpaddd    ymm6,ymm6,[rcx+rdx*4+10]
       add       ebx,8
       cmp       eax,ebx
       jge       short M01_L00
M01_L01:
       vpmulld   ymm0,ymm6,[7FFAD7AC9A40]
       vphaddd   ymm0,ymm0,ymm0
       vphaddd   ymm0,ymm0,ymm0
       vperm2i128 ymm1,ymm0,ymm0,1
       vpaddd    ymm0,ymm1,ymm0
       vmovd     eax,xmm0
M01_L02:
       cmp       esi,ebx
       jg        short M01_L04
       vzeroupper
       vmovaps   xmm6,[rsp+20]
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M01_L03:
       call      qword ptr [7FFAD7DCFA98]
       int       3
M01_L04:
       mov       edx,ebx
       add       eax,[rcx+rdx*4+10]
       inc       ebx
       jmp       short M01_L02
; Total bytes of code 133
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.TierBench.Scalar()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFAD7DAFAE0]; JitFoldProof.Subjects.SumScalar(Int32[])
; Total bytes of code 10
```
```assembly
; JitFoldProof.Subjects.SumScalar(Int32[])
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M01_L01
       add       rcx,10
M01_L00:
       add       eax,[rcx]
       add       rcx,4
       dec       edx
       jne       short M01_L00
M01_L01:
       ret
; Total bytes of code 24
```

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.TierBench.Guarded()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFAC3F5CFC0]; JitFoldProof.Subjects.SumGuarded(Int32[])
; Total bytes of code 10
```
```assembly
; JitFoldProof.Subjects.SumGuarded(Int32[])
       sub       rsp,28
       vzeroupper
       xor       eax,eax
       xor       edx,edx
       mov       r8d,[rcx+8]
       cmp       r8d,8
       jl        short M01_L03
       vxorps    ymm0,ymm0,ymm0
       lea       eax,[r8-8]
       test      eax,eax
       jl        short M01_L01
M01_L00:
       test      edx,edx
       jl        short M01_L04
       mov       r10d,r8d
       sub       r10d,edx
       cmp       r10d,8
       jl        short M01_L04
       mov       r10d,edx
       vpaddd    ymm0,ymm0,[rcx+r10*4+10]
       add       edx,8
       cmp       eax,edx
       jge       short M01_L00
M01_L01:
       vpmulld   ymm0,ymm0,[7FFAC3B68300]
       vphaddd   ymm0,ymm0,ymm0
       vphaddd   ymm0,ymm0,ymm0
       vperm2i128 ymm1,ymm0,ymm0,1
       vpaddd    ymm0,ymm0,ymm1
       vmovd     eax,xmm0
       cmp       r8d,edx
       jg        short M01_L05
M01_L02:
       vzeroupper
       add       rsp,28
       ret
M01_L03:
       cmp       r8d,edx
       jg        short M01_L05
       jmp       short M01_L02
M01_L04:
       call      qword ptr [7FFAC3CDEA78]
       int       3
M01_L05:
       cmp       edx,r8d
       jae       short M01_L06
       mov       r10d,edx
       add       eax,[rcx+r10*4+10]
       inc       edx
       jmp       short M01_L03
M01_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 149
```

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.TierBench.Scalar()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFAC80CCFD8]; JitFoldProof.Subjects.SumScalar(Int32[])
; Total bytes of code 10
```
```assembly
; JitFoldProof.Subjects.SumScalar(Int32[])
       xor       eax,eax
       xor       edx,edx
       mov       r8d,[rcx+8]
       test      r8d,r8d
       jle       short M01_L01
M01_L00:
       mov       r10d,edx
       add       eax,[rcx+r10*4+10]
       inc       edx
       cmp       r8d,edx
       jg        short M01_L00
M01_L01:
       ret
; Total bytes of code 29
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.TierBench.Guarded()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFAC7FEEAF0]; JitFoldProof.Subjects.SumGuarded(Int32[])
; Total bytes of code 10
```
```assembly
; JitFoldProof.Subjects.SumGuarded(Int32[])
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       xor       ebx,ebx
       xor       edx,edx
       mov       esi,[rcx+8]
       cmp       esi,8
       jl        short M01_L04
       vxorps    ymm0,ymm0,ymm0
       lea       eax,[rsi-8]
       test      eax,eax
       jl        short M01_L01
       nop
M01_L00:
       test      edx,edx
       jl        short M01_L03
       mov       r8d,esi
       sub       r8d,edx
       cmp       r8d,8
       jl        short M01_L03
       vpaddd    ymm0,ymm0,[rcx+rdx*4+10]
       add       edx,8
       cmp       eax,edx
       jge       short M01_L00
       mov       ebx,edx
M01_L01:
       vpmulld   ymm0,ymm0,[7FFAC7CD9660]
       vphaddd   ymm0,ymm0,ymm0
       vphaddd   ymm0,ymm0,ymm0
       vperm2i128 ymm1,ymm0,ymm0,1
       vpaddd    ymm0,ymm1,ymm0
       vmovd     eax,xmm0
       cmp       esi,ebx
       jg        short M01_L05
M01_L02:
       vzeroupper
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L03:
       call      qword ptr [7FFAC7FEEB80]
       int       3
M01_L04:
       cmp       esi,ebx
       jle       short M01_L02
M01_L05:
       cmp       ebx,esi
       jae       short M01_L06
       mov       edx,ebx
       add       eax,[rcx+rdx*4+10]
       inc       ebx
       jmp       short M01_L04
M01_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 141
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.TierBench.Scalar()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFAC7FBEBB0]; JitFoldProof.Subjects.SumScalar(Int32[])
; Total bytes of code 10
```
```assembly
; JitFoldProof.Subjects.SumScalar(Int32[])
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M01_L01
       add       rcx,10
M01_L00:
       add       eax,[rcx]
       add       rcx,4
       dec       edx
       jne       short M01_L00
M01_L01:
       ret
; Total bytes of code 24
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.TierBench.Guarded()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFAD7DBFAC8]; JitFoldProof.Subjects.SumGuarded(Int32[])
; Total bytes of code 10
```
```assembly
; JitFoldProof.Subjects.SumGuarded(Int32[])
       push      rsi
       push      rbx
       sub       rsp,38
       vmovaps   [rsp+20],xmm6
       xor       eax,eax
       xor       ebx,ebx
       mov       esi,[rcx+8]
       cmp       esi,8
       jl        short M01_L02
       vxorps    ymm6,ymm6,ymm6
       lea       eax,[rsi-8]
       test      eax,eax
       jl        short M01_L01
M01_L00:
       test      ebx,ebx
       jl        short M01_L03
       mov       edx,esi
       sub       edx,ebx
       cmp       edx,8
       jl        short M01_L03
       mov       edx,ebx
       vpaddd    ymm6,ymm6,[rcx+rdx*4+10]
       add       ebx,8
       cmp       eax,ebx
       jge       short M01_L00
M01_L01:
       vpmulld   ymm0,ymm6,[7FFAD7AB9A40]
       vphaddd   ymm0,ymm0,ymm0
       vphaddd   ymm0,ymm0,ymm0
       vperm2i128 ymm1,ymm0,ymm0,1
       vpaddd    ymm0,ymm1,ymm0
       vmovd     eax,xmm0
M01_L02:
       cmp       esi,ebx
       jg        short M01_L04
       vzeroupper
       vmovaps   xmm6,[rsp+20]
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M01_L03:
       call      qword ptr [7FFAD7DBFB70]
       int       3
M01_L04:
       mov       edx,ebx
       add       eax,[rcx+rdx*4+10]
       inc       ebx
       jmp       short M01_L02
; Total bytes of code 133
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.TierBench.Scalar()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFAD7DAFAE0]; JitFoldProof.Subjects.SumScalar(Int32[])
; Total bytes of code 10
```
```assembly
; JitFoldProof.Subjects.SumScalar(Int32[])
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M01_L01
       add       rcx,10
M01_L00:
       add       eax,[rcx]
       add       rcx,4
       dec       edx
       jne       short M01_L00
M01_L01:
       ret
; Total bytes of code 24
```

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.TierBench.Guarded()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFAC80BCD50]; JitFoldProof.Subjects.SumGuarded(Int32[])
; Total bytes of code 10
```
```assembly
; JitFoldProof.Subjects.SumGuarded(Int32[])
       sub       rsp,28
       vzeroupper
       xor       eax,eax
       xor       edx,edx
       mov       r8d,[rcx+8]
       cmp       r8d,8
       jl        short M01_L03
       vxorps    ymm0,ymm0,ymm0
       lea       eax,[r8-8]
       test      eax,eax
       jl        short M01_L01
M01_L00:
       test      edx,edx
       jl        short M01_L04
       mov       r10d,r8d
       sub       r10d,edx
       cmp       r10d,8
       jl        short M01_L04
       mov       r10d,edx
       vpaddd    ymm0,ymm0,[rcx+r10*4+10]
       add       edx,8
       cmp       eax,edx
       jge       short M01_L00
M01_L01:
       vpmulld   ymm0,ymm0,[7FFAC7CC8300]
       vphaddd   ymm0,ymm0,ymm0
       vphaddd   ymm0,ymm0,ymm0
       vperm2i128 ymm1,ymm0,ymm0,1
       vpaddd    ymm0,ymm0,ymm1
       vmovd     eax,xmm0
       cmp       r8d,edx
       jg        short M01_L05
M01_L02:
       vzeroupper
       add       rsp,28
       ret
M01_L03:
       cmp       r8d,edx
       jg        short M01_L05
       jmp       short M01_L02
M01_L04:
       call      qword ptr [7FFAC7E3EA78]
       int       3
M01_L05:
       cmp       edx,r8d
       jae       short M01_L06
       mov       r10d,edx
       add       eax,[rcx+r10*4+10]
       inc       edx
       jmp       short M01_L03
M01_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 149
```

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.TierBench.Scalar()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFAC80DCD68]; JitFoldProof.Subjects.SumScalar(Int32[])
; Total bytes of code 10
```
```assembly
; JitFoldProof.Subjects.SumScalar(Int32[])
       xor       eax,eax
       xor       edx,edx
       mov       r8d,[rcx+8]
       test      r8d,r8d
       jle       short M01_L01
M01_L00:
       mov       r10d,edx
       add       eax,[rcx+r10*4+10]
       inc       edx
       cmp       r8d,edx
       jg        short M01_L00
M01_L01:
       ret
; Total bytes of code 29
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.TierBench.Guarded()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFAC7FDEBC8]; JitFoldProof.Subjects.SumGuarded(Int32[])
; Total bytes of code 10
```
```assembly
; JitFoldProof.Subjects.SumGuarded(Int32[])
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       xor       ebx,ebx
       xor       edx,edx
       mov       esi,[rcx+8]
       cmp       esi,8
       jl        short M01_L02
       vxorps    ymm0,ymm0,ymm0
       lea       eax,[rsi-8]
       test      eax,eax
       jl        short M01_L01
       nop
M01_L00:
       test      edx,edx
       jl        short M01_L04
       mov       r8d,esi
       sub       r8d,edx
       cmp       r8d,8
       jl        short M01_L04
       vpaddd    ymm0,ymm0,[rcx+rdx*4+10]
       add       edx,8
       cmp       eax,edx
       jge       short M01_L00
       mov       ebx,edx
M01_L01:
       vpmulld   ymm0,ymm0,[7FFAC7CC9660]
       vphaddd   ymm0,ymm0,ymm0
       vphaddd   ymm0,ymm0,ymm0
       vperm2i128 ymm1,ymm0,ymm0,1
       vpaddd    ymm0,ymm1,ymm0
       vmovd     eax,xmm0
       cmp       esi,ebx
       jle       short M01_L03
       jmp       short M01_L05
M01_L02:
       cmp       esi,ebx
       jg        short M01_L05
M01_L03:
       vzeroupper
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L04:
       call      qword ptr [7FFAC7FDEC58]
       int       3
M01_L05:
       cmp       ebx,esi
       jae       short M01_L06
       mov       edx,ebx
       add       eax,[rcx+rdx*4+10]
       inc       ebx
       jmp       short M01_L02
M01_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 143
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.TierBench.Scalar()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFAC7FCEBC8]; JitFoldProof.Subjects.SumScalar(Int32[])
; Total bytes of code 10
```
```assembly
; JitFoldProof.Subjects.SumScalar(Int32[])
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M01_L01
       add       rcx,10
M01_L00:
       add       eax,[rcx]
       add       rcx,4
       dec       edx
       jne       short M01_L00
M01_L01:
       ret
; Total bytes of code 24
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.TierBench.Guarded()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFAD7DBF9F0]; JitFoldProof.Subjects.SumGuarded(Int32[])
; Total bytes of code 10
```
```assembly
; JitFoldProof.Subjects.SumGuarded(Int32[])
       push      rsi
       push      rbx
       sub       rsp,38
       vmovaps   [rsp+20],xmm6
       xor       eax,eax
       xor       ebx,ebx
       mov       esi,[rcx+8]
       cmp       esi,8
       jl        short M01_L02
       vxorps    ymm6,ymm6,ymm6
       lea       eax,[rsi-8]
       test      eax,eax
       jl        short M01_L01
M01_L00:
       test      ebx,ebx
       jl        short M01_L04
       mov       edx,esi
       sub       edx,ebx
       cmp       edx,8
       jl        short M01_L04
       mov       edx,ebx
       vpaddd    ymm6,ymm6,[rcx+rdx*4+10]
       add       ebx,8
       cmp       eax,ebx
       jge       short M01_L00
M01_L01:
       vpmulld   ymm0,ymm6,[7FFAD7AB9CA0]
       vphaddd   ymm0,ymm0,ymm0
       vphaddd   ymm0,ymm0,ymm0
       vperm2i128 ymm1,ymm0,ymm0,1
       vpaddd    ymm0,ymm1,ymm0
       vmovd     eax,xmm0
M01_L02:
       cmp       esi,ebx
       jg        short M01_L05
M01_L03:
       vzeroupper
       vmovaps   xmm6,[rsp+20]
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M01_L04:
       call      qword ptr [7FFAD7DBFA98]
       int       3
M01_L05:
       test      ebx,ebx
       jl        short M01_L07
M01_L06:
       mov       edx,ebx
       add       eax,[rcx+rdx*4+10]
       inc       ebx
       cmp       esi,ebx
       jg        short M01_L06
       jmp       short M01_L03
M01_L07:
       mov       edx,ebx
       add       eax,[rcx+rdx*4+10]
       inc       ebx
       cmp       esi,ebx
       jg        short M01_L07
       jmp       short M01_L03
; Total bytes of code 155
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.TierBench.Scalar()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFAD7DBFAC8]; JitFoldProof.Subjects.SumScalar(Int32[])
; Total bytes of code 10
```
```assembly
; JitFoldProof.Subjects.SumScalar(Int32[])
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M01_L01
       add       rcx,10
M01_L00:
       add       eax,[rcx]
       add       rcx,4
       dec       edx
       jne       short M01_L00
M01_L01:
       ret
; Total bytes of code 24
```

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.TierBench.Guarded()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFAC80ACD50]; JitFoldProof.Subjects.SumGuarded(Int32[])
; Total bytes of code 10
```
```assembly
; JitFoldProof.Subjects.SumGuarded(Int32[])
       sub       rsp,28
       vzeroupper
       xor       eax,eax
       xor       edx,edx
       mov       r8d,[rcx+8]
       cmp       r8d,8
       jl        short M01_L03
       vxorps    ymm0,ymm0,ymm0
       lea       eax,[r8-8]
       test      eax,eax
       jl        short M01_L01
M01_L00:
       test      edx,edx
       jl        short M01_L04
       mov       r10d,r8d
       sub       r10d,edx
       cmp       r10d,8
       jl        short M01_L04
       mov       r10d,edx
       vpaddd    ymm0,ymm0,[rcx+r10*4+10]
       add       edx,8
       cmp       eax,edx
       jge       short M01_L00
M01_L01:
       vpmulld   ymm0,ymm0,[7FFAC7CB8580]
       vphaddd   ymm0,ymm0,ymm0
       vphaddd   ymm0,ymm0,ymm0
       vperm2i128 ymm1,ymm0,ymm0,1
       vpaddd    ymm0,ymm0,ymm1
       vmovd     eax,xmm0
       cmp       r8d,edx
       jg        short M01_L05
M01_L02:
       vzeroupper
       add       rsp,28
       ret
M01_L03:
       cmp       r8d,edx
       jg        short M01_L05
       jmp       short M01_L02
M01_L04:
       call      qword ptr [7FFAC7E2EA78]
       int       3
M01_L05:
       cmp       edx,r8d
       jae       short M01_L06
       mov       r10d,edx
       add       eax,[rcx+r10*4+10]
       inc       edx
       jmp       short M01_L03
M01_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 149
```

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.TierBench.Scalar()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFAC80BCFD8]; JitFoldProof.Subjects.SumScalar(Int32[])
; Total bytes of code 10
```
```assembly
; JitFoldProof.Subjects.SumScalar(Int32[])
       xor       eax,eax
       xor       edx,edx
       mov       r8d,[rcx+8]
       test      r8d,r8d
       jle       short M01_L01
M01_L00:
       mov       r10d,edx
       add       eax,[rcx+r10*4+10]
       inc       edx
       cmp       r8d,edx
       jg        short M01_L00
M01_L01:
       ret
; Total bytes of code 29
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.TierBench.Guarded()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFAC7FDEBC8]; JitFoldProof.Subjects.SumGuarded(Int32[])
; Total bytes of code 10
```
```assembly
; JitFoldProof.Subjects.SumGuarded(Int32[])
       sub       rsp,28
       xor       eax,eax
       xor       edx,edx
       mov       r8d,[rcx+8]
       cmp       r8d,8
       jl        short M01_L02
       vxorps    ymm0,ymm0,ymm0
       lea       eax,[r8-8]
       test      eax,eax
       jl        short M01_L01
M01_L00:
       test      edx,edx
       jl        short M01_L07
       mov       r10d,r8d
       sub       r10d,edx
       cmp       r10d,8
       jl        short M01_L07
       mov       r10d,edx
       vpaddd    ymm0,ymm0,[rcx+r10*4+10]
       add       edx,8
       cmp       eax,edx
       jge       short M01_L00
M01_L01:
       vpmulld   ymm0,ymm0,[7FFAC7CC98E0]
       vphaddd   ymm0,ymm0,ymm0
       vphaddd   ymm0,ymm0,ymm0
       vperm2i128 ymm1,ymm0,ymm0,1
       vpaddd    ymm0,ymm1,ymm0
       vmovd     eax,xmm0
M01_L02:
       cmp       r8d,edx
       jg        short M01_L04
M01_L03:
       vzeroupper
       add       rsp,28
       ret
M01_L04:
       test      edx,edx
       jl        short M01_L06
M01_L05:
       mov       r10d,edx
       add       eax,[rcx+r10*4+10]
       inc       edx
       cmp       r8d,edx
       jg        short M01_L05
       jmp       short M01_L03
M01_L06:
       cmp       edx,r8d
       jae       short M01_L08
       mov       r10d,edx
       add       eax,[rcx+r10*4+10]
       inc       edx
       cmp       r8d,edx
       jg        short M01_L06
       jmp       short M01_L03
M01_L07:
       call      qword ptr [7FFAC7FDEC58]
       int       3
M01_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 165
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.TierBench.Scalar()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFAC7FBEBC8]; JitFoldProof.Subjects.SumScalar(Int32[])
; Total bytes of code 10
```
```assembly
; JitFoldProof.Subjects.SumScalar(Int32[])
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M01_L01
       add       rcx,10
M01_L00:
       add       eax,[rcx]
       add       rcx,4
       dec       edx
       jne       short M01_L00
M01_L01:
       ret
; Total bytes of code 24
```

