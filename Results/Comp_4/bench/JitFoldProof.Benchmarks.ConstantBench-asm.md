## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC6FC60]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EqualsLiteral(System.String)
       cmp       rcx,2D36400
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0E
       je        short M01_L01
M01_L00:
       xor       eax,eax
       jmp       short M01_L03
M01_L01:
       vmovups   xmm0,[rcx+0C]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFEAF928B30]
       vpternlogq xmm0,xmm1,[7FFEAF928B40],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L03
M01_L02:
       mov       eax,1
M01_L03:
       ret
; Total bytes of code 72
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFEAFC8FB88]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L03
       test      rcx,rcx
       je        short M01_L02
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M01_L02
       lea       rax,[rcx+0C]
       add       rdx,0C
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       je        short M01_L00
       mov       rcx,rax
       call      qword ptr [7FFEAF8AC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
M01_L00:
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       r8,[rdx]
       xor       rcx,r8
       xor       rax,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L01:
       jmp       short M01_L04
M01_L02:
       xor       eax,eax
       jmp       short M01_L04
M01_L03:
       mov       eax,1
M01_L04:
       add       rsp,28
       ret
; Total bytes of code 104
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L02
       cmp       rcx,rdx
       je        near ptr M02_L15
       cmp       r8,40
       jae       near ptr M02_L07
       cmp       r8,20
       jae       near ptr M02_L10
       cmp       r8,10
       jb        near ptr M02_L16
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        near ptr M02_L14
M02_L00:
       vmovups   xmm0,[rcx+rax]
       vpcmpnequb k1,xmm0,[rdx+rax]
       kortestw  k1,k1
       je        near ptr M02_L13
M02_L01:
       xor       eax,eax
       vzeroupper
       ret
M02_L02:
       cmp       r8,4
       jae       short M02_L05
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L03
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L03:
       test      r8b,1
       je        short M02_L04
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M02_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L06
M02_L05:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M02_L06:
       vzeroupper
       ret
M02_L07:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFC0
       je        short M02_L09
M02_L08:
       vmovups   zmm0,[rcx+rax]
       vpcmpnequb k1,zmm0,[rdx+rax]
       kortestq  k1,k1
       jne       short M02_L01
       add       rax,40
       cmp       r8,rax
       ja        short M02_L08
M02_L09:
       vmovups   zmm0,[rcx+r8]
       vpcmpeqb  k1,zmm0,[rdx+r8]
       kortestq  k1,k1
       jae       near ptr M02_L01
       jmp       short M02_L15
M02_L10:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L12
M02_L11:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       jne       near ptr M02_L01
       add       rax,20
       cmp       r8,rax
       ja        short M02_L11
M02_L12:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       jae       near ptr M02_L01
       jmp       short M02_L15
M02_L13:
       add       rax,10
       cmp       r8,rax
       ja        near ptr M02_L00
M02_L14:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jae       near ptr M02_L01
M02_L15:
       mov       eax,1
       vzeroupper
       ret
M02_L16:
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L06
; Total bytes of code 384
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC7FB88]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       cmp       rcx,2C60008
       je        short M01_L01
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       jmp       short M01_L02
M01_L00:
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
       jmp       short M01_L02
M01_L01:
       mov       eax,1
M01_L02:
       ret
; Total bytes of code 36
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+18]
       call      qword ptr [7FFEAFC7FC60]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L00
       test      rdx,rdx
       je        short M01_L00
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       je        short M01_L03
M01_L00:
       xor       eax,eax
M01_L01:
       add       rsp,28
       ret
M01_L02:
       mov       eax,1
       jmp       short M01_L01
M01_L03:
       lea       rax,[rcx+0C]
       add       rdx,0C
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       jne       short M01_L04
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       r8,[rdx]
       xor       rcx,r8
       xor       rax,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       short M01_L05
M01_L04:
       mov       rcx,rax
       call      qword ptr [7FFEAF89C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M01_L05:
       jmp       short M01_L01
; Total bytes of code 104
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L06
       cmp       rcx,rdx
       je        short M02_L04
       cmp       r8,10
       jae       short M02_L01
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L00:
       ret
M02_L01:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L03
       movups    xmm0,[rcx]
       movups    xmm1,[rdx]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
M02_L02:
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L03:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  eax,xmm0
       cmp       eax,0FFFF
       jne       short M02_L05
M02_L04:
       mov       eax,1
       ret
M02_L05:
       xor       eax,eax
       ret
M02_L06:
       cmp       r8,4
       jb        short M02_L07
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L00
M02_L07:
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L08
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L08:
       test      r8b,1
       je        short M02_L09
       movzx     ecx,byte ptr [rcx+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        eax,ecx
M02_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L00
M02_L10:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
       jmp       near ptr M02_L02
; Total bytes of code 237
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLength()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC6FB88]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLength(System.String)
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 11
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithChar()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC7FC60]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.StartsWithChar(System.String)
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 12
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithText()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC7FB88]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.StartsWithText(System.String)
       cmp       dword ptr [rcx+8],0
       jg        short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
M01_L01:
       ret
; Total bytes of code 22
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE7434E0D0]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.EqualsLiteral(System.String)
       vzeroupper
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0E
       jne       short M01_L00
       vmovups   xmm0,[rcx+0C]
       vpxor     xmm0,xmm0,[7FFE73F57600]
       vmovups   xmm1,[rcx+18]
       vpternlogq xmm0,xmm1,[7FFE73F57610],0F6
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 59
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       edx,edi
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE7432E8F8]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 85
```
```assembly
; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L01
       test      rcx,rcx
       je        short M01_L02
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M01_L02
       add       rcx,0C
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFE73FB5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       xor       eax,eax
       jmp       short M01_L00
; Total bytes of code 63
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       cmp       r8,8
       jae       short M02_L03
       cmp       r8,4
       jae       short M02_L02
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L00
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L00:
       test      r8b,1
       je        short M02_L01
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        r8d,eax
       mov       eax,r8d
M02_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L02:
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L03:
       cmp       rcx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L04:
       vzeroupper
       ret
M02_L05:
       mov       eax,1
       vzeroupper
       ret
M02_L06:
       cmp       r8,40
       jb        short M02_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFC0
       je        short M02_L08
M02_L07:
       vmovups   zmm0,[rcx+rax]
       vpcmpnequb k1,zmm0,[rdx+rax]
       kortestq  k1,k1
       nop       dword ptr [rax]
       jne       near ptr M02_L16
       add       rax,40
       cmp       r8,rax
       ja        short M02_L07
M02_L08:
       vmovups   zmm0,[rcx+r8]
       vpcmpeqb  k1,zmm0,[rdx+r8]
       kortestq  k1,k1
       nop       dword ptr [rax]
       jae       near ptr M02_L16
       jmp       short M02_L05
M02_L09:
       cmp       r8,20
       jb        short M02_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L11
M02_L10:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       nop       dword ptr [rax]
       jne       near ptr M02_L16
       add       rax,20
       cmp       r8,rax
       ja        short M02_L10
M02_L11:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       nop       dword ptr [rax]
       jae       short M02_L16
       jmp       near ptr M02_L05
       nop       dword ptr [rax+rax]
       nop       dword ptr [rax+rax]
M02_L12:
       cmp       r8,10
       jb        short M02_L15
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L14
M02_L13:
       vmovups   xmm0,[rcx+rax]
       vpcmpnequb k1,xmm0,[rdx+rax]
       kortestw  k1,k1
       jne       short M02_L16
       add       rax,10
       cmp       r8,rax
       ja        short M02_L13
M02_L14:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jae       short M02_L16
       jmp       near ptr M02_L05
M02_L15:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
M02_L16:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 394
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE7434E100]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      rcx,rcx
       je        short M01_L00
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 19
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       edx,edi
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,[rbx+18]
       call      qword ptr [7FFE7435E118]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 85
```
```assembly
; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L00
       test      rdx,rdx
       je        short M01_L00
       mov       eax,[rcx+8]
       cmp       eax,[rdx+8]
       je        short M01_L03
M01_L00:
       xor       eax,eax
M01_L01:
       add       rsp,28
       ret
M01_L02:
       mov       eax,1
       jmp       short M01_L01
M01_L03:
       lea       rax,[rcx+0C]
       mov       r8d,[rcx+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,rax
       call      qword ptr [7FFE73FE5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
; Total bytes of code 67
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jae       short M02_L03
       cmp       r8,4
       jae       short M02_L02
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L00
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L00:
       test      r8b,1
       je        short M02_L01
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        r8d,eax
       mov       eax,r8d
M02_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L02:
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L03:
       cmp       rcx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L04:
       ret
M02_L05:
       mov       eax,1
       ret
M02_L06:
       cmp       r8,10
       jb        short M02_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L08
M02_L07:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L10
       add       rax,10
       cmp       r8,rax
       ja        short M02_L07
M02_L08:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M02_L10
       jmp       short M02_L05
M02_L09:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L10:
       xor       eax,eax
       ret
; Total bytes of code 217
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLength()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE7434E130]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.EmptyByLength(System.String)
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       ret
; Total bytes of code 10
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithChar()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE7432E958]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.StartsWithChar(System.String)
       xor       eax,eax
       cmp       word ptr [rcx+0C],63
       sete      al
       ret
; Total bytes of code 11
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithText()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE7434E970]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.StartsWithText(System.String)
       cmp       dword ptr [rcx+8],0
       jle       short M01_L00
       xor       eax,eax
       cmp       word ptr [rcx+0C],63
       sete      al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 21
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE7422EB50]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0E
       je        short M01_L02
M01_L00:
       xor       eax,eax
M01_L01:
       ret
M01_L02:
       vmovups   xmm0,[rcx+0C]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE73F18BC0]
       vpternlogq xmm0,xmm1,[7FFE73F18BD0],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 56
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE7425EC28]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L03
       test      rcx,rcx
       je        short M01_L02
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M01_L02
       add       rcx,0C
       add       rdx,0C
       add       r8d,r8d
       cmp       r8,0A
       je        short M01_L00
       call      qword ptr [7FFE73E9C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
M01_L00:
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[rdx]
       xor       rax,r8
       xor       rcx,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L01:
       add       rsp,28
       ret
M01_L02:
       xor       eax,eax
       jmp       short M01_L01
M01_L03:
       mov       eax,1
       jmp       short M01_L01
; Total bytes of code 96
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        near ptr M02_L12
       cmp       rcx,rdx
       je        near ptr M02_L11
       cmp       r8,40
       jae       near ptr M02_L08
       cmp       r8,20
       jae       short M02_L05
       cmp       r8,10
       jb        short M02_L04
       xor       r10d,r10d
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L03
M02_L00:
       vmovups   xmm0,[rcx+r10]
       vpcmpnequb k1,xmm0,[rdx+r10]
       kortestw  k1,k1
       je        short M02_L02
M02_L01:
       xor       eax,eax
       vzeroupper
       ret
M02_L02:
       add       r10,10
       cmp       r8,r10
       ja        short M02_L00
M02_L03:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jae       short M02_L01
       jmp       near ptr M02_L11
M02_L04:
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L16
M02_L05:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L07
M02_L06:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       jne       short M02_L01
       add       rax,20
       cmp       r8,rax
       ja        short M02_L06
M02_L07:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       jae       short M02_L01
       jmp       short M02_L11
M02_L08:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFC0
       je        short M02_L10
M02_L09:
       vmovups   zmm0,[rcx+rax]
       vpcmpnequb k1,zmm0,[rdx+rax]
       kortestq  k1,k1
       jne       near ptr M02_L01
       add       rax,40
       cmp       r8,rax
       ja        short M02_L09
M02_L10:
       vmovups   zmm0,[rcx+r8]
       vpcmpeqb  k1,zmm0,[rdx+r8]
       kortestq  k1,k1
       jae       near ptr M02_L01
M02_L11:
       mov       eax,1
       vzeroupper
       ret
M02_L12:
       cmp       r8,4
       jae       short M02_L15
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L13
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L13:
       test      r8b,1
       je        short M02_L14
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M02_L14:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L16
M02_L15:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M02_L16:
       vzeroupper
       ret
; Total bytes of code 365
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE7424EB50]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
M01_L01:
       ret
; Total bytes of code 20
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+18]
       call      qword ptr [7FFE7425EC28]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L05
       test      rcx,rcx
       je        short M01_L00
       test      rdx,rdx
       je        short M01_L00
       mov       eax,[rcx+8]
       cmp       eax,[rdx+8]
       je        short M01_L02
M01_L00:
       xor       eax,eax
M01_L01:
       add       rsp,28
       ret
M01_L02:
       lea       rax,[rcx+0C]
       add       rdx,0C
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       je        short M01_L03
       mov       rcx,rax
       call      qword ptr [7FFE73E9C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       r8,[rdx]
       xor       rcx,r8
       xor       rax,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L04:
       jmp       short M01_L01
M01_L05:
       mov       eax,1
       jmp       short M01_L01
; Total bytes of code 102
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L06
       cmp       rcx,rdx
       je        short M02_L04
       cmp       r8,10
       jae       short M02_L01
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L00:
       ret
M02_L01:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L03
M02_L02:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
       add       rax,10
       cmp       r8,rax
       ja        short M02_L02
M02_L03:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  eax,xmm0
       cmp       eax,0FFFF
       jne       short M02_L05
M02_L04:
       mov       eax,1
       ret
M02_L05:
       xor       eax,eax
       ret
M02_L06:
       cmp       r8,4
       jb        short M02_L07
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L00
M02_L07:
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L08
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L08:
       test      r8b,1
       jne       short M02_L10
M02_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L00
M02_L10:
       movzx     ecx,byte ptr [rcx+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        eax,ecx
       jmp       short M02_L09
; Total bytes of code 210
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLength()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE7424EC28]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLength(System.String)
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 11
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithChar()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE7425EC28]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.StartsWithChar(System.String)
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 12
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithText()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE7424EB50]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.StartsWithText(System.String)
       cmp       dword ptr [rcx+8],0
       jg        short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
M01_L01:
       ret
; Total bytes of code 22
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L02
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L02:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC6FC48]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
       jmp       short M00_L01
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EqualsLiteral(System.String)
       cmp       rcx,2C86400
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0E
       je        short M01_L01
M01_L00:
       xor       eax,eax
       jmp       short M01_L03
M01_L01:
       vmovups   xmm0,[rcx+0C]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFEAF928C70]
       vpternlogq xmm0,xmm1,[7FFEAF928C80],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L03
M01_L02:
       mov       eax,1
M01_L03:
       ret
; Total bytes of code 72
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L02
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L02:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFEAFC8FC60]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
       jmp       short M00_L01
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L03
       test      rdx,rdx
       je        short M01_L03
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M01_L03
       add       rcx,0C
       add       rdx,0C
       add       r8d,r8d
       cmp       r8,0A
       je        short M01_L00
       call      qword ptr [7FFEAF8AC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
M01_L00:
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[rdx]
       xor       rax,r8
       xor       rcx,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L01:
       add       rsp,28
       ret
M01_L02:
       mov       eax,1
       jmp       short M01_L01
M01_L03:
       xor       eax,eax
       jmp       short M01_L01
; Total bytes of code 96
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L02
       cmp       rcx,rdx
       je        near ptr M02_L15
       cmp       r8,40
       jae       near ptr M02_L07
       cmp       r8,20
       jae       near ptr M02_L10
       cmp       r8,10
       jb        near ptr M02_L16
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        near ptr M02_L14
M02_L00:
       vmovups   xmm0,[rcx+rax]
       vpcmpnequb k1,xmm0,[rdx+rax]
       kortestw  k1,k1
       je        near ptr M02_L13
M02_L01:
       xor       eax,eax
       vzeroupper
       ret
M02_L02:
       cmp       r8,4
       jae       short M02_L05
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L03
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L03:
       test      r8b,1
       je        short M02_L04
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M02_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L06
M02_L05:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M02_L06:
       vzeroupper
       ret
M02_L07:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFC0
       je        short M02_L09
M02_L08:
       vmovups   zmm0,[rcx+rax]
       vpcmpnequb k1,zmm0,[rdx+rax]
       kortestq  k1,k1
       jne       short M02_L01
       add       rax,40
       cmp       r8,rax
       ja        short M02_L08
M02_L09:
       vmovups   zmm0,[rcx+r8]
       vpcmpeqb  k1,zmm0,[rdx+r8]
       kortestq  k1,k1
       jae       near ptr M02_L01
       jmp       short M02_L15
M02_L10:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L12
M02_L11:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       jne       near ptr M02_L01
       add       rax,20
       cmp       r8,rax
       ja        short M02_L11
M02_L12:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       jae       near ptr M02_L01
       jmp       short M02_L15
M02_L13:
       add       rax,10
       cmp       r8,rax
       ja        near ptr M02_L00
M02_L14:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jae       near ptr M02_L01
M02_L15:
       mov       eax,1
       vzeroupper
       ret
M02_L16:
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L06
; Total bytes of code 384
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L02
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L02:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC8FB88]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
       jmp       short M00_L01
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       cmp       rcx,2C00008
       je        short M01_L01
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       jmp       short M01_L02
M01_L00:
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
       jmp       short M01_L02
M01_L01:
       mov       eax,1
M01_L02:
       ret
; Total bytes of code 36
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L02
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L02:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+18]
       call      qword ptr [7FFEAFC8FC48]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
       jmp       short M00_L01
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L00
       test      rdx,rdx
       je        short M01_L00
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       je        short M01_L03
M01_L00:
       xor       eax,eax
M01_L01:
       add       rsp,28
       ret
M01_L02:
       mov       eax,1
       jmp       short M01_L01
M01_L03:
       lea       rax,[rcx+0C]
       add       rdx,0C
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       jne       short M01_L04
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       r8,[rdx]
       xor       rcx,r8
       xor       rax,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       short M01_L05
M01_L04:
       mov       rcx,rax
       call      qword ptr [7FFEAF8AC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M01_L05:
       jmp       short M01_L01
; Total bytes of code 104
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L06
       cmp       rcx,rdx
       je        short M02_L04
       cmp       r8,10
       jae       short M02_L01
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L00:
       ret
M02_L01:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L03
       movups    xmm0,[rcx]
       movups    xmm1,[rdx]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
M02_L02:
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L03:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  eax,xmm0
       cmp       eax,0FFFF
       jne       short M02_L05
M02_L04:
       mov       eax,1
       ret
M02_L05:
       xor       eax,eax
       ret
M02_L06:
       cmp       r8,4
       jb        short M02_L07
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L00
M02_L07:
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L08
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L08:
       test      r8b,1
       je        short M02_L09
       movzx     ecx,byte ptr [rcx+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        eax,ecx
M02_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L00
M02_L10:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
       jmp       near ptr M02_L02
; Total bytes of code 237
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLength()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L02
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L02:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC9FC60]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
       jmp       short M00_L01
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLength(System.String)
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 11
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithChar()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L02
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L02:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC9FB88]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
       jmp       short M00_L01
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.StartsWithChar(System.String)
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 12
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithText()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L02
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L02:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC6FB88]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
       jmp       short M00_L01
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.StartsWithText(System.String)
       cmp       dword ptr [rcx+8],0
       jg        short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
M01_L01:
       ret
; Total bytes of code 22
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE7433E0D0]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.EqualsLiteral(System.String)
       vzeroupper
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0E
       jne       short M01_L00
       vmovups   xmm0,[rcx+0C]
       vpxor     xmm0,xmm0,[7FFE73F47740]
       vmovups   xmm1,[rcx+18]
       vpternlogq xmm0,xmm1,[7FFE73F47750],0F6
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 59
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       edx,edi
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE7433E8F8]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 85
```
```assembly
; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L01
       test      rcx,rcx
       je        short M01_L02
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M01_L02
       add       rcx,0C
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFE73FC5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       xor       eax,eax
       jmp       short M01_L00
; Total bytes of code 63
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       cmp       r8,8
       jae       short M02_L03
       cmp       r8,4
       jae       short M02_L02
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L00
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L00:
       test      r8b,1
       je        short M02_L01
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        r8d,eax
       mov       eax,r8d
M02_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L02:
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L03:
       cmp       rcx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L04:
       vzeroupper
       ret
M02_L05:
       mov       eax,1
       vzeroupper
       ret
M02_L06:
       cmp       r8,40
       jb        short M02_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFC0
       je        short M02_L08
M02_L07:
       vmovups   zmm0,[rcx+rax]
       vpcmpnequb k1,zmm0,[rdx+rax]
       kortestq  k1,k1
       nop       dword ptr [rax]
       jne       near ptr M02_L16
       add       rax,40
       cmp       r8,rax
       ja        short M02_L07
M02_L08:
       vmovups   zmm0,[rcx+r8]
       vpcmpeqb  k1,zmm0,[rdx+r8]
       kortestq  k1,k1
       nop       dword ptr [rax]
       jae       near ptr M02_L16
       jmp       short M02_L05
M02_L09:
       cmp       r8,20
       jb        short M02_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L11
M02_L10:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       nop       dword ptr [rax]
       jne       near ptr M02_L16
       add       rax,20
       cmp       r8,rax
       ja        short M02_L10
M02_L11:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       nop       dword ptr [rax]
       jae       short M02_L16
       jmp       near ptr M02_L05
       nop       dword ptr [rax+rax]
       nop       dword ptr [rax+rax]
M02_L12:
       cmp       r8,10
       jb        short M02_L15
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L14
M02_L13:
       vmovups   xmm0,[rcx+rax]
       vpcmpnequb k1,xmm0,[rdx+rax]
       kortestw  k1,k1
       jne       short M02_L16
       add       rax,10
       cmp       r8,rax
       ja        short M02_L13
M02_L14:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jae       short M02_L16
       jmp       near ptr M02_L05
M02_L15:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
M02_L16:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 394
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE7433E910]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      rcx,rcx
       je        short M01_L00
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 19
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       edx,edi
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,[rbx+18]
       call      qword ptr [7FFE7434E448]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 85
```
```assembly
; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L00
       test      rdx,rdx
       je        short M01_L00
       mov       eax,[rcx+8]
       cmp       eax,[rdx+8]
       je        short M01_L03
M01_L00:
       xor       eax,eax
M01_L01:
       add       rsp,28
       ret
M01_L02:
       mov       eax,1
       jmp       short M01_L01
M01_L03:
       lea       rax,[rcx+0C]
       mov       r8d,[rcx+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,rax
       call      qword ptr [7FFE73FD5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
; Total bytes of code 67
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jae       short M02_L03
       cmp       r8,4
       jae       short M02_L02
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L00
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L00:
       test      r8b,1
       je        short M02_L01
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        r8d,eax
       mov       eax,r8d
M02_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L02:
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L03:
       cmp       rcx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L04:
       ret
M02_L05:
       mov       eax,1
       ret
M02_L06:
       cmp       r8,10
       jb        short M02_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L08
M02_L07:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L10
       add       rax,10
       cmp       r8,rax
       ja        short M02_L07
M02_L08:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M02_L10
       jmp       short M02_L05
M02_L09:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L10:
       xor       eax,eax
       ret
; Total bytes of code 217
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLength()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE7435E940]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.EmptyByLength(System.String)
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       ret
; Total bytes of code 10
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithChar()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE7434E148]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.StartsWithChar(System.String)
       xor       eax,eax
       cmp       word ptr [rcx+0C],63
       sete      al
       ret
; Total bytes of code 11
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithText()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE7435E160]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.StartsWithText(System.String)
       cmp       dword ptr [rcx+8],0
       jle       short M01_L00
       xor       eax,eax
       cmp       word ptr [rcx+0C],63
       sete      al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 21
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE7424EC10]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0E
       je        short M01_L02
M01_L00:
       xor       eax,eax
M01_L01:
       ret
M01_L02:
       vmovups   xmm0,[rcx+0C]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE73F38D00]
       vpternlogq xmm0,xmm1,[7FFE73F38D10],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 56
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE7424EC28]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L03
       test      rcx,rcx
       je        short M01_L02
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M01_L02
       add       rcx,0C
       add       rdx,0C
       add       r8d,r8d
       cmp       r8,0A
       je        short M01_L00
       call      qword ptr [7FFE73E8C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
M01_L00:
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[rdx]
       xor       rax,r8
       xor       rcx,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L01:
       add       rsp,28
       ret
M01_L02:
       xor       eax,eax
       jmp       short M01_L01
M01_L03:
       mov       eax,1
       jmp       short M01_L01
; Total bytes of code 96
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        near ptr M02_L12
       cmp       rcx,rdx
       je        near ptr M02_L11
       cmp       r8,40
       jae       near ptr M02_L08
       cmp       r8,20
       jae       short M02_L05
       cmp       r8,10
       jb        short M02_L04
       xor       r10d,r10d
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L03
M02_L00:
       vmovups   xmm0,[rcx+r10]
       vpcmpnequb k1,xmm0,[rdx+r10]
       kortestw  k1,k1
       je        short M02_L02
M02_L01:
       xor       eax,eax
       vzeroupper
       ret
M02_L02:
       add       r10,10
       cmp       r8,r10
       ja        short M02_L00
M02_L03:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jae       short M02_L01
       jmp       near ptr M02_L11
M02_L04:
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L16
M02_L05:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L07
M02_L06:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       jne       short M02_L01
       add       rax,20
       cmp       r8,rax
       ja        short M02_L06
M02_L07:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       jae       short M02_L01
       jmp       short M02_L11
M02_L08:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFC0
       je        short M02_L10
M02_L09:
       vmovups   zmm0,[rcx+rax]
       vpcmpnequb k1,zmm0,[rdx+rax]
       kortestq  k1,k1
       jne       near ptr M02_L01
       add       rax,40
       cmp       r8,rax
       ja        short M02_L09
M02_L10:
       vmovups   zmm0,[rcx+r8]
       vpcmpeqb  k1,zmm0,[rdx+r8]
       kortestq  k1,k1
       jae       near ptr M02_L01
M02_L11:
       mov       eax,1
       vzeroupper
       ret
M02_L12:
       cmp       r8,4
       jae       short M02_L15
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L13
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L13:
       test      r8b,1
       je        short M02_L14
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M02_L14:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L16
M02_L15:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M02_L16:
       vzeroupper
       ret
; Total bytes of code 365
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE7423EC28]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
M01_L01:
       ret
; Total bytes of code 20
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+18]
       call      qword ptr [7FFE7422EC28]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L05
       test      rcx,rcx
       je        short M01_L00
       test      rdx,rdx
       je        short M01_L00
       mov       eax,[rcx+8]
       cmp       eax,[rdx+8]
       je        short M01_L02
M01_L00:
       xor       eax,eax
M01_L01:
       add       rsp,28
       ret
M01_L02:
       lea       rax,[rcx+0C]
       add       rdx,0C
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       je        short M01_L03
       mov       rcx,rax
       call      qword ptr [7FFE73E6C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       r8,[rdx]
       xor       rcx,r8
       xor       rax,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L04:
       jmp       short M01_L01
M01_L05:
       mov       eax,1
       jmp       short M01_L01
; Total bytes of code 102
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L06
       cmp       rcx,rdx
       je        short M02_L04
       cmp       r8,10
       jae       short M02_L01
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L00:
       ret
M02_L01:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L03
M02_L02:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
       add       rax,10
       cmp       r8,rax
       ja        short M02_L02
M02_L03:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  eax,xmm0
       cmp       eax,0FFFF
       jne       short M02_L05
M02_L04:
       mov       eax,1
       ret
M02_L05:
       xor       eax,eax
       ret
M02_L06:
       cmp       r8,4
       jb        short M02_L07
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L00
M02_L07:
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L08
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L08:
       test      r8b,1
       jne       short M02_L10
M02_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L00
M02_L10:
       movzx     ecx,byte ptr [rcx+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        eax,ecx
       jmp       short M02_L09
; Total bytes of code 210
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLength()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE7422EC28]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLength(System.String)
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 11
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithChar()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE7425EB50]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.StartsWithChar(System.String)
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 12
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithText()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE7422EC28]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.StartsWithText(System.String)
       cmp       dword ptr [rcx+8],0
       jg        short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
M01_L01:
       ret
; Total bytes of code 22
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L02
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L02:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC8FC78]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
       jmp       short M00_L01
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EqualsLiteral(System.String)
       cmp       rcx,2D56400
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0E
       je        short M01_L01
M01_L00:
       xor       eax,eax
       jmp       short M01_L03
M01_L01:
       vmovups   xmm0,[rcx+0C]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFEAF948BF0]
       vpternlogq xmm0,xmm1,[7FFEAF948C00],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L03
M01_L02:
       mov       eax,1
M01_L03:
       ret
; Total bytes of code 72
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L02
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L02:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFEAFC9FC78]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
       jmp       short M00_L01
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L03
       test      rdx,rdx
       je        short M01_L03
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M01_L03
       add       rcx,0C
       add       rdx,0C
       add       r8d,r8d
       cmp       r8,0A
       je        short M01_L00
       call      qword ptr [7FFEAF8BC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
M01_L00:
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[rdx]
       xor       rax,r8
       xor       rcx,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L01:
       add       rsp,28
       ret
M01_L02:
       mov       eax,1
       jmp       short M01_L01
M01_L03:
       xor       eax,eax
       jmp       short M01_L01
; Total bytes of code 96
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L02
       cmp       rcx,rdx
       je        near ptr M02_L15
       cmp       r8,40
       jae       near ptr M02_L07
       cmp       r8,20
       jae       near ptr M02_L10
       cmp       r8,10
       jb        near ptr M02_L16
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        near ptr M02_L14
M02_L00:
       vmovups   xmm0,[rcx+rax]
       vpcmpnequb k1,xmm0,[rdx+rax]
       kortestw  k1,k1
       je        near ptr M02_L13
M02_L01:
       xor       eax,eax
       vzeroupper
       ret
M02_L02:
       cmp       r8,4
       jae       short M02_L05
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L03
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L03:
       test      r8b,1
       je        short M02_L04
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M02_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L06
M02_L05:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M02_L06:
       vzeroupper
       ret
M02_L07:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFC0
       je        short M02_L09
M02_L08:
       vmovups   zmm0,[rcx+rax]
       vpcmpnequb k1,zmm0,[rdx+rax]
       kortestq  k1,k1
       jne       short M02_L01
       add       rax,40
       cmp       r8,rax
       ja        short M02_L08
M02_L09:
       vmovups   zmm0,[rcx+r8]
       vpcmpeqb  k1,zmm0,[rdx+r8]
       kortestq  k1,k1
       jae       near ptr M02_L01
       jmp       short M02_L15
M02_L10:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L12
M02_L11:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       jne       near ptr M02_L01
       add       rax,20
       cmp       r8,rax
       ja        short M02_L11
M02_L12:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       jae       near ptr M02_L01
       jmp       short M02_L15
M02_L13:
       add       rax,10
       cmp       r8,rax
       ja        near ptr M02_L00
M02_L14:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jae       near ptr M02_L01
M02_L15:
       mov       eax,1
       vzeroupper
       ret
M02_L16:
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L06
; Total bytes of code 384
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L02
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L02:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC8FC60]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
       jmp       short M00_L01
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       cmp       rcx,2DA0008
       je        short M01_L01
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       jmp       short M01_L02
M01_L00:
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
       jmp       short M01_L02
M01_L01:
       mov       eax,1
M01_L02:
       ret
; Total bytes of code 36
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L02
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L02:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+18]
       call      qword ptr [7FFEAFC6FBA0]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
       jmp       short M00_L01
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L00
       test      rdx,rdx
       je        short M01_L00
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       je        short M01_L03
M01_L00:
       xor       eax,eax
M01_L01:
       add       rsp,28
       ret
M01_L02:
       mov       eax,1
       jmp       short M01_L01
M01_L03:
       lea       rax,[rcx+0C]
       add       rdx,0C
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       jne       short M01_L04
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       r8,[rdx]
       xor       rcx,r8
       xor       rax,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       short M01_L05
M01_L04:
       mov       rcx,rax
       call      qword ptr [7FFEAF88C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M01_L05:
       jmp       short M01_L01
; Total bytes of code 104
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L06
       cmp       rcx,rdx
       je        short M02_L04
       cmp       r8,10
       jae       short M02_L01
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L00:
       ret
M02_L01:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L03
       movups    xmm0,[rcx]
       movups    xmm1,[rdx]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
M02_L02:
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L03:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  eax,xmm0
       cmp       eax,0FFFF
       jne       short M02_L05
M02_L04:
       mov       eax,1
       ret
M02_L05:
       xor       eax,eax
       ret
M02_L06:
       cmp       r8,4
       jb        short M02_L07
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L00
M02_L07:
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L08
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L08:
       test      r8b,1
       je        short M02_L09
       movzx     ecx,byte ptr [rcx+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        eax,ecx
M02_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L00
M02_L10:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
       jmp       near ptr M02_L02
; Total bytes of code 237
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLength()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L02
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L02:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC8FBA0]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
       jmp       short M00_L01
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLength(System.String)
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 11
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithChar()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L02
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L02:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC9FC78]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
       jmp       short M00_L01
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.StartsWithChar(System.String)
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 12
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithText()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L02
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L02:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC9FC78]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
       jmp       short M00_L01
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.StartsWithText(System.String)
       cmp       dword ptr [rcx+8],0
       jg        short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
M01_L01:
       ret
; Total bytes of code 22
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE73EAED90]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.EqualsLiteral(System.String)
       vzeroupper
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0E
       jne       short M01_L00
       vmovups   xmm0,[rcx+0C]
       vpxor     xmm0,xmm0,[7FFE73AB7720]
       vmovups   xmm1,[rcx+18]
       vpternlogq xmm0,xmm1,[7FFE73AB7730],0F6
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 59
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       edx,edi
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE73EBEDA8]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 85
```
```assembly
; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L01
       test      rcx,rcx
       je        short M01_L02
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M01_L02
       add       rcx,0C
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFE73B45068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       xor       eax,eax
       jmp       short M01_L00
; Total bytes of code 63
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       cmp       r8,8
       jae       short M02_L03
       cmp       r8,4
       jae       short M02_L02
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L00
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L00:
       test      r8b,1
       je        short M02_L01
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        r8d,eax
       mov       eax,r8d
M02_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L02:
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L03:
       cmp       rcx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L04:
       vzeroupper
       ret
M02_L05:
       mov       eax,1
       vzeroupper
       ret
M02_L06:
       cmp       r8,40
       jb        short M02_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFC0
       je        short M02_L08
M02_L07:
       vmovups   zmm0,[rcx+rax]
       vpcmpnequb k1,zmm0,[rdx+rax]
       kortestq  k1,k1
       nop       dword ptr [rax]
       jne       near ptr M02_L16
       add       rax,40
       cmp       r8,rax
       ja        short M02_L07
M02_L08:
       vmovups   zmm0,[rcx+r8]
       vpcmpeqb  k1,zmm0,[rdx+r8]
       kortestq  k1,k1
       nop       dword ptr [rax]
       jae       near ptr M02_L16
       jmp       short M02_L05
M02_L09:
       cmp       r8,20
       jb        short M02_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L11
M02_L10:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       nop       dword ptr [rax]
       jne       near ptr M02_L16
       add       rax,20
       cmp       r8,rax
       ja        short M02_L10
M02_L11:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       nop       dword ptr [rax]
       jae       short M02_L16
       jmp       near ptr M02_L05
       nop       dword ptr [rax+rax]
       nop       dword ptr [rax+rax]
M02_L12:
       cmp       r8,10
       jb        short M02_L15
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L14
M02_L13:
       vmovups   xmm0,[rcx+rax]
       vpcmpnequb k1,xmm0,[rdx+rax]
       kortestw  k1,k1
       jne       short M02_L16
       add       rax,10
       cmp       r8,rax
       ja        short M02_L13
M02_L14:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jae       short M02_L16
       jmp       near ptr M02_L05
M02_L15:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
M02_L16:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 394
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE73E9EDC0]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      rcx,rcx
       je        short M01_L00
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 19
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       edx,edi
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,[rbx+18]
       call      qword ptr [7FFE73EAEDD8]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 85
```
```assembly
; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L00
       test      rdx,rdx
       je        short M01_L00
       mov       eax,[rcx+8]
       cmp       eax,[rdx+8]
       je        short M01_L03
M01_L00:
       xor       eax,eax
M01_L01:
       add       rsp,28
       ret
M01_L02:
       mov       eax,1
       jmp       short M01_L01
M01_L03:
       lea       rax,[rcx+0C]
       mov       r8d,[rcx+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,rax
       call      qword ptr [7FFE73B35068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
; Total bytes of code 67
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jae       short M02_L03
       cmp       r8,4
       jae       short M02_L02
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L00
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L00:
       test      r8b,1
       je        short M02_L01
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        r8d,eax
       mov       eax,r8d
M02_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L02:
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L03:
       cmp       rcx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L04:
       ret
M02_L05:
       mov       eax,1
       ret
M02_L06:
       cmp       r8,10
       jb        short M02_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L08
M02_L07:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L10
       add       rax,10
       cmp       r8,rax
       ja        short M02_L07
M02_L08:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M02_L10
       jmp       short M02_L05
M02_L09:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L10:
       xor       eax,eax
       ret
; Total bytes of code 217
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLength()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE73EAEDF0]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.EmptyByLength(System.String)
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       ret
; Total bytes of code 10
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithChar()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE73EAEE08]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.StartsWithChar(System.String)
       xor       eax,eax
       cmp       word ptr [rcx+0C],63
       sete      al
       ret
; Total bytes of code 11
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithText()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE73ECEE20]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.StartsWithText(System.String)
       cmp       dword ptr [rcx+8],0
       jle       short M01_L00
       xor       eax,eax
       cmp       word ptr [rcx+0C],63
       sete      al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 21
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE73DBEC10]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0E
       je        short M01_L02
M01_L00:
       xor       eax,eax
M01_L01:
       ret
M01_L02:
       vmovups   xmm0,[rcx+0C]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE73AA8C80]
       vpternlogq xmm0,xmm1,[7FFE73AA8C90],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 56
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE73DAEC40]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L03
       test      rcx,rcx
       je        short M01_L02
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M01_L02
       add       rcx,0C
       add       rdx,0C
       add       r8d,r8d
       cmp       r8,0A
       je        short M01_L00
       call      qword ptr [7FFE739EC090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
M01_L00:
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[rdx]
       xor       rax,r8
       xor       rcx,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L01:
       add       rsp,28
       ret
M01_L02:
       xor       eax,eax
       jmp       short M01_L01
M01_L03:
       mov       eax,1
       jmp       short M01_L01
; Total bytes of code 96
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        near ptr M02_L12
       cmp       rcx,rdx
       je        near ptr M02_L11
       cmp       r8,40
       jae       near ptr M02_L08
       cmp       r8,20
       jae       short M02_L05
       cmp       r8,10
       jb        short M02_L04
       xor       r10d,r10d
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L03
M02_L00:
       vmovups   xmm0,[rcx+r10]
       vpcmpnequb k1,xmm0,[rdx+r10]
       kortestw  k1,k1
       je        short M02_L02
M02_L01:
       xor       eax,eax
       vzeroupper
       ret
M02_L02:
       add       r10,10
       cmp       r8,r10
       ja        short M02_L00
M02_L03:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jae       short M02_L01
       jmp       near ptr M02_L11
M02_L04:
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L16
M02_L05:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L07
M02_L06:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       jne       short M02_L01
       add       rax,20
       cmp       r8,rax
       ja        short M02_L06
M02_L07:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       jae       short M02_L01
       jmp       short M02_L11
M02_L08:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFC0
       je        short M02_L10
M02_L09:
       vmovups   zmm0,[rcx+rax]
       vpcmpnequb k1,zmm0,[rdx+rax]
       kortestq  k1,k1
       jne       near ptr M02_L01
       add       rax,40
       cmp       r8,rax
       ja        short M02_L09
M02_L10:
       vmovups   zmm0,[rcx+r8]
       vpcmpeqb  k1,zmm0,[rdx+r8]
       kortestq  k1,k1
       jae       near ptr M02_L01
M02_L11:
       mov       eax,1
       vzeroupper
       ret
M02_L12:
       cmp       r8,4
       jae       short M02_L15
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L13
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L13:
       test      r8b,1
       je        short M02_L14
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M02_L14:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L16
M02_L15:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M02_L16:
       vzeroupper
       ret
; Total bytes of code 365
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE73D9EC28]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
M01_L01:
       ret
; Total bytes of code 20
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+18]
       call      qword ptr [7FFE73DAEB68]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L05
       test      rcx,rcx
       je        short M01_L00
       test      rdx,rdx
       je        short M01_L00
       mov       eax,[rcx+8]
       cmp       eax,[rdx+8]
       je        short M01_L02
M01_L00:
       xor       eax,eax
M01_L01:
       add       rsp,28
       ret
M01_L02:
       lea       rax,[rcx+0C]
       add       rdx,0C
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       je        short M01_L03
       mov       rcx,rax
       call      qword ptr [7FFE739EC090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       r8,[rdx]
       xor       rcx,r8
       xor       rax,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L04:
       jmp       short M01_L01
M01_L05:
       mov       eax,1
       jmp       short M01_L01
; Total bytes of code 102
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L06
       cmp       rcx,rdx
       je        short M02_L04
       cmp       r8,10
       jae       short M02_L01
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L00:
       ret
M02_L01:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L03
M02_L02:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
       add       rax,10
       cmp       r8,rax
       ja        short M02_L02
M02_L03:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  eax,xmm0
       cmp       eax,0FFFF
       jne       short M02_L05
M02_L04:
       mov       eax,1
       ret
M02_L05:
       xor       eax,eax
       ret
M02_L06:
       cmp       r8,4
       jb        short M02_L07
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L00
M02_L07:
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L08
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L08:
       test      r8b,1
       jne       short M02_L10
M02_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L00
M02_L10:
       movzx     ecx,byte ptr [rcx+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        eax,ecx
       jmp       short M02_L09
; Total bytes of code 210
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLength()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE73DCEC40]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLength(System.String)
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 11
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithChar()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE73DCEC40]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.StartsWithChar(System.String)
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 12
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithText()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE73DAEC40]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.StartsWithText(System.String)
       cmp       dword ptr [rcx+8],0
       jg        short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
M01_L01:
       ret
; Total bytes of code 22
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC9FB88]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EqualsLiteral(System.String)
       cmp       rcx,2C563F8
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0E
       je        short M01_L01
M01_L00:
       xor       eax,eax
       jmp       short M01_L03
M01_L01:
       vmovups   xmm0,[rcx+0C]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFEAF9585F0]
       vpternlogq xmm0,xmm1,[7FFEAF958600],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L03
M01_L02:
       mov       eax,1
M01_L03:
       ret
; Total bytes of code 72
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFEAFC9FC60]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L00
       test      rdx,rdx
       je        short M01_L00
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       je        short M01_L03
M01_L00:
       xor       eax,eax
M01_L01:
       add       rsp,28
       ret
M01_L02:
       mov       eax,1
       jmp       short M01_L01
M01_L03:
       lea       rax,[rcx+0C]
       add       rdx,0C
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       jne       short M01_L04
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       r8,[rdx]
       xor       rcx,r8
       xor       rax,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       short M01_L05
M01_L04:
       mov       rcx,rax
       call      qword ptr [7FFEAF8BC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M01_L05:
       jmp       short M01_L01
; Total bytes of code 104
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L06
       cmp       rcx,rdx
       je        short M02_L04
       cmp       r8,10
       jae       short M02_L01
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L00:
       ret
M02_L01:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L03
       movups    xmm0,[rcx]
       movups    xmm1,[rdx]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
M02_L02:
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L03:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  eax,xmm0
       cmp       eax,0FFFF
       jne       short M02_L05
M02_L04:
       mov       eax,1
       ret
M02_L05:
       xor       eax,eax
       ret
M02_L06:
       cmp       r8,4
       jb        short M02_L07
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L00
M02_L07:
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L08
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L08:
       test      r8b,1
       je        short M02_L09
       movzx     ecx,byte ptr [rcx+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        eax,ecx
M02_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L00
M02_L10:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
       jmp       near ptr M02_L02
; Total bytes of code 237
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC9FC60]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 77
```
```assembly
; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       cmp       rcx,2D60008
       je        short M01_L01
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       jmp       short M01_L02
M01_L00:
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
       jmp       short M01_L02
M01_L01:
       mov       eax,1
M01_L02:
       ret
; Total bytes of code 36
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+18]
       call      qword ptr [7FFEAFC6FC60]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       jne       short M01_L01
       mov       eax,1
M01_L00:
       add       rsp,28
       ret
M01_L01:
       test      rcx,rcx
       je        short M01_L02
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       je        short M01_L03
M01_L02:
       xor       eax,eax
       jmp       short M01_L00
M01_L03:
       lea       rax,[rcx+0C]
       add       rdx,0C
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       jne       short M01_L04
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       r8,[rdx]
       xor       rcx,r8
       xor       rax,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       short M01_L05
M01_L04:
       mov       rcx,rax
       call      qword ptr [7FFEAF88C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M01_L05:
       jmp       short M01_L00
; Total bytes of code 104
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L06
       cmp       rcx,rdx
       je        short M02_L04
       cmp       r8,10
       jae       short M02_L01
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L00:
       ret
M02_L01:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L03
       movups    xmm0,[rcx]
       movups    xmm1,[rdx]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
M02_L02:
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L03:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  eax,xmm0
       cmp       eax,0FFFF
       jne       short M02_L05
M02_L04:
       mov       eax,1
       ret
M02_L05:
       xor       eax,eax
       ret
M02_L06:
       cmp       r8,4
       jb        short M02_L07
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L00
M02_L07:
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L08
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L08:
       test      r8b,1
       je        short M02_L09
       movzx     ecx,byte ptr [rcx+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        eax,ecx
M02_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L00
M02_L10:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
       jmp       near ptr M02_L02
; Total bytes of code 237
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLength()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC8FC60]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 77
```
```assembly
; JitFoldProof.Subjects.EmptyByLength(System.String)
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 11
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithChar()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC7FC60]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.StartsWithChar(System.String)
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 12
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithText()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC9FC48]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.StartsWithText(System.String)
       cmp       dword ptr [rcx+8],0
       jg        short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
M01_L01:
       ret
; Total bytes of code 22
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE672CE0D0]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.EqualsLiteral(System.String)
       vzeroupper
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0E
       jne       short M01_L00
       vmovups   xmm0,[rcx+0C]
       vpxor     xmm0,xmm0,[7FFE66ED72B0]
       vmovups   xmm1,[rcx+18]
       vpternlogq xmm0,xmm1,[7FFE66ED72C0],0F6
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 59
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       edx,edi
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE672DE8F8]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 85
```
```assembly
; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L00
       test      rdx,rdx
       je        short M01_L00
       mov       eax,[rcx+8]
       cmp       eax,[rdx+8]
       je        short M01_L03
M01_L00:
       xor       eax,eax
M01_L01:
       add       rsp,28
       ret
M01_L02:
       mov       eax,1
       jmp       short M01_L01
M01_L03:
       lea       rax,[rcx+0C]
       mov       r8d,[rcx+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,rax
       call      qword ptr [7FFE66F65068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
; Total bytes of code 67
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jae       short M02_L03
       cmp       r8,4
       jae       short M02_L02
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L00
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L00:
       test      r8b,1
       je        short M02_L01
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        r8d,eax
       mov       eax,r8d
M02_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L02:
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L03:
       cmp       rcx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L04:
       ret
M02_L05:
       mov       eax,1
       ret
M02_L06:
       cmp       r8,10
       jb        short M02_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L08
M02_L07:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L10
       add       rax,10
       cmp       r8,rax
       ja        short M02_L07
M02_L08:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M02_L10
       jmp       short M02_L05
M02_L09:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L10:
       xor       eax,eax
       ret
; Total bytes of code 217
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE6D65E910]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      rcx,rcx
       je        short M01_L00
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 19
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       edx,edi
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,[rbx+18]
       call      qword ptr [7FFE6D64E928]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       jne       short M01_L01
       mov       eax,1
M01_L00:
       add       rsp,28
       ret
M01_L01:
       test      rcx,rcx
       je        short M01_L02
       test      rdx,rdx
       je        short M01_L02
       mov       eax,[rcx+8]
       cmp       eax,[rdx+8]
       je        short M01_L03
M01_L02:
       xor       eax,eax
       jmp       short M01_L00
M01_L03:
       lea       rax,[rcx+0C]
       mov       r8d,[rcx+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,rax
       call      qword ptr [7FFE6D2D5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L00
; Total bytes of code 67
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jae       short M02_L03
       cmp       r8,4
       jae       short M02_L02
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L00
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L00:
       test      r8b,1
       je        short M02_L01
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        r8d,eax
       mov       eax,r8d
M02_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L02:
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L03:
       cmp       rcx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L04:
       ret
M02_L05:
       mov       eax,1
       ret
M02_L06:
       cmp       r8,10
       jb        short M02_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L08
M02_L07:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L10
       add       rax,10
       cmp       r8,rax
       ja        short M02_L07
M02_L08:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M02_L10
       jmp       short M02_L05
M02_L09:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L10:
       xor       eax,eax
       ret
; Total bytes of code 217
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLength()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE6D62E940]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLength(System.String)
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       ret
; Total bytes of code 10
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithChar()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE7431E148]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.StartsWithChar(System.String)
       xor       eax,eax
       cmp       word ptr [rcx+0C],63
       sete      al
       ret
; Total bytes of code 11
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithText()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE7435E970]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.StartsWithText(System.String)
       cmp       dword ptr [rcx+8],0
       jle       short M01_L00
       xor       eax,eax
       cmp       word ptr [rcx+0C],63
       sete      al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 21
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE7424EB50]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0E
       je        short M01_L02
M01_L00:
       xor       eax,eax
M01_L01:
       ret
M01_L02:
       vmovups   xmm0,[rcx+0C]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE73F386D0]
       vpternlogq xmm0,xmm1,[7FFE73F386E0],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 56
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE7422EC28]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L05
       test      rcx,rcx
       je        short M01_L00
       test      rdx,rdx
       je        short M01_L00
       mov       eax,[rcx+8]
       cmp       eax,[rdx+8]
       je        short M01_L02
M01_L00:
       xor       eax,eax
M01_L01:
       add       rsp,28
       ret
M01_L02:
       lea       rax,[rcx+0C]
       add       rdx,0C
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       je        short M01_L03
       mov       rcx,rax
       call      qword ptr [7FFE73E6C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       r8,[rdx]
       xor       rcx,r8
       xor       rax,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L04:
       jmp       short M01_L01
M01_L05:
       mov       eax,1
       jmp       short M01_L01
; Total bytes of code 102
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L06
       cmp       rcx,rdx
       je        short M02_L04
       cmp       r8,10
       jae       short M02_L01
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L00:
       ret
M02_L01:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L03
M02_L02:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
       add       rax,10
       cmp       r8,rax
       ja        short M02_L02
M02_L03:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  eax,xmm0
       cmp       eax,0FFFF
       jne       short M02_L05
M02_L04:
       mov       eax,1
       ret
M02_L05:
       xor       eax,eax
       ret
M02_L06:
       cmp       r8,4
       jb        short M02_L07
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L00
M02_L07:
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L08
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L08:
       test      r8b,1
       jne       short M02_L10
M02_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L00
M02_L10:
       movzx     ecx,byte ptr [rcx+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        eax,ecx
       jmp       short M02_L09
; Total bytes of code 210
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE7423EC28]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 77
```
```assembly
; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
M01_L01:
       ret
; Total bytes of code 20
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+18]
       call      qword ptr [7FFE7425EC10]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       jne       short M01_L01
       mov       eax,1
M01_L00:
       add       rsp,28
       ret
M01_L01:
       test      rcx,rcx
       je        short M01_L04
       test      rdx,rdx
       je        short M01_L04
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M01_L04
       lea       rax,[rcx+0C]
       add       rdx,0C
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       je        short M01_L02
       mov       rcx,rax
       call      qword ptr [7FFE73E9C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       r8,[rdx]
       xor       rcx,r8
       xor       rax,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L03:
       jmp       short M01_L00
M01_L04:
       xor       eax,eax
       jmp       short M01_L00
; Total bytes of code 104
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L06
       cmp       rcx,rdx
       je        short M02_L04
       cmp       r8,10
       jae       short M02_L01
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L00:
       ret
M02_L01:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L03
M02_L02:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
       add       rax,10
       cmp       r8,rax
       ja        short M02_L02
M02_L03:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  eax,xmm0
       cmp       eax,0FFFF
       jne       short M02_L05
M02_L04:
       mov       eax,1
       ret
M02_L05:
       xor       eax,eax
       ret
M02_L06:
       cmp       r8,4
       jb        short M02_L07
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L00
M02_L07:
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L08
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L08:
       test      r8b,1
       jne       short M02_L10
M02_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L00
M02_L10:
       movzx     ecx,byte ptr [rcx+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        eax,ecx
       jmp       short M02_L09
; Total bytes of code 210
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLength()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE7425EC28]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 77
```
```assembly
; JitFoldProof.Subjects.EmptyByLength(System.String)
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 11
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithChar()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE9740EB50]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.StartsWithChar(System.String)
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 12
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithText()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE973FEBF8]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.StartsWithText(System.String)
       cmp       dword ptr [rcx+8],0
       jg        short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
M01_L01:
       ret
; Total bytes of code 22
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L02
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L02:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC6FC60]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
       jmp       short M00_L01
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EqualsLiteral(System.String)
       cmp       rcx,2CD63F8
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0E
       je        short M01_L01
M01_L00:
       xor       eax,eax
       jmp       short M01_L03
M01_L01:
       vmovups   xmm0,[rcx+0C]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFEAF928730]
       vpternlogq xmm0,xmm1,[7FFEAF928740],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L03
M01_L02:
       mov       eax,1
M01_L03:
       ret
; Total bytes of code 72
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L02
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L02:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFEAFC7FC60]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
       jmp       short M00_L01
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L00
       test      rdx,rdx
       je        short M01_L00
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       je        short M01_L03
M01_L00:
       xor       eax,eax
M01_L01:
       add       rsp,28
       ret
M01_L02:
       mov       eax,1
       jmp       short M01_L01
M01_L03:
       lea       rax,[rcx+0C]
       add       rdx,0C
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       jne       short M01_L04
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       r8,[rdx]
       xor       rcx,r8
       xor       rax,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       short M01_L05
M01_L04:
       mov       rcx,rax
       call      qword ptr [7FFEAF89C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M01_L05:
       jmp       short M01_L01
; Total bytes of code 104
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L06
       cmp       rcx,rdx
       je        short M02_L04
       cmp       r8,10
       jae       short M02_L01
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L00:
       ret
M02_L01:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L03
       movups    xmm0,[rcx]
       movups    xmm1,[rdx]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
M02_L02:
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L03:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  eax,xmm0
       cmp       eax,0FFFF
       jne       short M02_L05
M02_L04:
       mov       eax,1
       ret
M02_L05:
       xor       eax,eax
       ret
M02_L06:
       cmp       r8,4
       jb        short M02_L07
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L00
M02_L07:
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L08
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L08:
       test      r8b,1
       je        short M02_L09
       movzx     ecx,byte ptr [rcx+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        eax,ecx
M02_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L00
M02_L10:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
       jmp       near ptr M02_L02
; Total bytes of code 237
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L03
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       esi
M00_L02:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L03:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC9FC60]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       je        short M00_L02
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       cmp       rcx,2C40008
       je        short M01_L01
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       jmp       short M01_L02
M01_L00:
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
       jmp       short M01_L02
M01_L01:
       mov       eax,1
M01_L02:
       ret
; Total bytes of code 36
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L03
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       esi
M00_L02:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L03:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+18]
       call      qword ptr [7FFEAFC9FC60]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       je        short M00_L02
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       jne       short M01_L01
       mov       eax,1
M01_L00:
       add       rsp,28
       ret
M01_L01:
       test      rcx,rcx
       je        short M01_L02
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       je        short M01_L03
M01_L02:
       xor       eax,eax
       jmp       short M01_L00
M01_L03:
       lea       rax,[rcx+0C]
       add       rdx,0C
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       jne       short M01_L04
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       r8,[rdx]
       xor       rcx,r8
       xor       rax,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       short M01_L05
M01_L04:
       mov       rcx,rax
       call      qword ptr [7FFEAF8BC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M01_L05:
       jmp       short M01_L00
; Total bytes of code 104
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L06
       cmp       rcx,rdx
       je        short M02_L04
       cmp       r8,10
       jae       short M02_L01
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L00:
       ret
M02_L01:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L03
       movups    xmm0,[rcx]
       movups    xmm1,[rdx]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
M02_L02:
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L03:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  eax,xmm0
       cmp       eax,0FFFF
       jne       short M02_L05
M02_L04:
       mov       eax,1
       ret
M02_L05:
       xor       eax,eax
       ret
M02_L06:
       cmp       r8,4
       jb        short M02_L07
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L00
M02_L07:
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L08
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L08:
       test      r8b,1
       je        short M02_L09
       movzx     ecx,byte ptr [rcx+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        eax,ecx
M02_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L00
M02_L10:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
       jmp       near ptr M02_L02
; Total bytes of code 237
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLength()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L03
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       esi
M00_L02:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L03:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC7FC60]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       je        short M00_L02
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLength(System.String)
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 11
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithChar()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L02
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L02:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC7FC48]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
       jmp       short M00_L01
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.StartsWithChar(System.String)
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 12
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithText()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L02
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L02:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFCAFC60]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
       jmp       short M00_L01
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.StartsWithText(System.String)
       cmp       dword ptr [rcx+8],0
       jg        short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
M01_L01:
       ret
; Total bytes of code 22
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE69F4E8E0]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.EqualsLiteral(System.String)
       vzeroupper
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0E
       jne       short M01_L00
       vmovups   xmm0,[rcx+0C]
       vpxor     xmm0,xmm0,[7FFE69B57400]
       vmovups   xmm1,[rcx+18]
       vpternlogq xmm0,xmm1,[7FFE69B57410],0F6
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 59
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       edx,edi
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE69F1E0E8]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 85
```
```assembly
; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L00
       test      rdx,rdx
       je        short M01_L00
       mov       eax,[rcx+8]
       cmp       eax,[rdx+8]
       je        short M01_L03
M01_L00:
       xor       eax,eax
M01_L01:
       add       rsp,28
       ret
M01_L02:
       mov       eax,1
       jmp       short M01_L01
M01_L03:
       lea       rax,[rcx+0C]
       mov       r8d,[rcx+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,rax
       call      qword ptr [7FFE69BA5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
; Total bytes of code 67
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jae       short M02_L03
       cmp       r8,4
       jae       short M02_L02
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L00
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L00:
       test      r8b,1
       je        short M02_L01
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        r8d,eax
       mov       eax,r8d
M02_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L02:
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L03:
       cmp       rcx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L04:
       ret
M02_L05:
       mov       eax,1
       ret
M02_L06:
       cmp       r8,10
       jb        short M02_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L08
M02_L07:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L10
       add       rax,10
       cmp       r8,rax
       ja        short M02_L07
M02_L08:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M02_L10
       jmp       short M02_L05
M02_L09:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L10:
       xor       eax,eax
       ret
; Total bytes of code 217
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE9750E100]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      rcx,rcx
       je        short M01_L00
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 19
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       edx,edi
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,[rbx+18]
       call      qword ptr [7FFE9750E928]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       jne       short M01_L01
       mov       eax,1
M01_L00:
       add       rsp,28
       ret
M01_L01:
       test      rcx,rcx
       je        short M01_L02
       test      rdx,rdx
       je        short M01_L02
       mov       eax,[rcx+8]
       cmp       eax,[rdx+8]
       je        short M01_L03
M01_L02:
       xor       eax,eax
       jmp       short M01_L00
M01_L03:
       lea       rax,[rcx+0C]
       mov       r8d,[rcx+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,rax
       call      qword ptr [7FFE97195068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L00
; Total bytes of code 67
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jae       short M02_L03
       cmp       r8,4
       jae       short M02_L02
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L00
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L00:
       test      r8b,1
       je        short M02_L01
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        r8d,eax
       mov       eax,r8d
M02_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L02:
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L03:
       cmp       rcx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L04:
       ret
M02_L05:
       mov       eax,1
       ret
M02_L06:
       cmp       r8,10
       jb        short M02_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L08
M02_L07:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L10
       add       rax,10
       cmp       r8,rax
       ja        short M02_L07
M02_L08:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M02_L10
       jmp       short M02_L05
M02_L09:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L10:
       xor       eax,eax
       ret
; Total bytes of code 217
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLength()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE9750E130]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLength(System.String)
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       ret
; Total bytes of code 10
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithChar()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE9750E958]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.StartsWithChar(System.String)
       xor       eax,eax
       cmp       word ptr [rcx+0C],63
       sete      al
       ret
; Total bytes of code 11
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithText()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE9750E970]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.StartsWithText(System.String)
       cmp       dword ptr [rcx+8],0
       jle       short M01_L00
       xor       eax,eax
       cmp       word ptr [rcx+0C],63
       sete      al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 21
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE973EEC28]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0E
       je        short M01_L02
M01_L00:
       xor       eax,eax
M01_L01:
       ret
M01_L02:
       vmovups   xmm0,[rcx+0C]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE970D8820]
       vpternlogq xmm0,xmm1,[7FFE970D8830],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 56
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE973FEB50]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L05
       test      rcx,rcx
       je        short M01_L00
       test      rdx,rdx
       je        short M01_L00
       mov       eax,[rcx+8]
       cmp       eax,[rdx+8]
       je        short M01_L02
M01_L00:
       xor       eax,eax
M01_L01:
       add       rsp,28
       ret
M01_L02:
       lea       rax,[rcx+0C]
       add       rdx,0C
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       je        short M01_L03
       mov       rcx,rax
       call      qword ptr [7FFE9703C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       r8,[rdx]
       xor       rcx,r8
       xor       rax,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L04:
       jmp       short M01_L01
M01_L05:
       mov       eax,1
       jmp       short M01_L01
; Total bytes of code 102
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L06
       cmp       rcx,rdx
       je        short M02_L04
       cmp       r8,10
       jae       short M02_L01
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L00:
       ret
M02_L01:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L03
M02_L02:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
       add       rax,10
       cmp       r8,rax
       ja        short M02_L02
M02_L03:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  eax,xmm0
       cmp       eax,0FFFF
       jne       short M02_L05
M02_L04:
       mov       eax,1
       ret
M02_L05:
       xor       eax,eax
       ret
M02_L06:
       cmp       r8,4
       jb        short M02_L07
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L00
M02_L07:
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L08
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L08:
       test      r8b,1
       jne       short M02_L10
M02_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L00
M02_L10:
       movzx     ecx,byte ptr [rcx+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        eax,ecx
       jmp       short M02_L09
; Total bytes of code 210
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE9740EC28]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 77
```
```assembly
; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
M01_L01:
       ret
; Total bytes of code 20
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+18]
       call      qword ptr [7FFE973FEC28]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       jne       short M01_L01
       mov       eax,1
M01_L00:
       add       rsp,28
       ret
M01_L01:
       test      rcx,rcx
       je        short M01_L04
       test      rdx,rdx
       je        short M01_L04
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M01_L04
       lea       rax,[rcx+0C]
       add       rdx,0C
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       je        short M01_L02
       mov       rcx,rax
       call      qword ptr [7FFE9703C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       r8,[rdx]
       xor       rcx,r8
       xor       rax,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L03:
       jmp       short M01_L00
M01_L04:
       xor       eax,eax
       jmp       short M01_L00
; Total bytes of code 104
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L06
       cmp       rcx,rdx
       je        short M02_L04
       cmp       r8,10
       jae       short M02_L01
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L00:
       ret
M02_L01:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L03
M02_L02:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
       add       rax,10
       cmp       r8,rax
       ja        short M02_L02
M02_L03:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  eax,xmm0
       cmp       eax,0FFFF
       jne       short M02_L05
M02_L04:
       mov       eax,1
       ret
M02_L05:
       xor       eax,eax
       ret
M02_L06:
       cmp       r8,4
       jb        short M02_L07
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L00
M02_L07:
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L08
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L08:
       test      r8b,1
       jne       short M02_L10
M02_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L00
M02_L10:
       movzx     ecx,byte ptr [rcx+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        eax,ecx
       jmp       short M02_L09
; Total bytes of code 210
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLength()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE9740EC28]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 77
```
```assembly
; JitFoldProof.Subjects.EmptyByLength(System.String)
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 11
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithChar()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE9741EB50]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.StartsWithChar(System.String)
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 12
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithText()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE9741EC10]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.StartsWithText(System.String)
       cmp       dword ptr [rcx+8],0
       jg        short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
M01_L01:
       ret
; Total bytes of code 22
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L02
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L02:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC7FBA0]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
       jmp       short M00_L01
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EqualsLiteral(System.String)
       cmp       rcx,2C163F8
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0E
       je        short M01_L01
M01_L00:
       xor       eax,eax
       jmp       short M01_L03
M01_L01:
       vmovups   xmm0,[rcx+0C]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFEAF938640]
       vpternlogq xmm0,xmm1,[7FFEAF938650],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L03
M01_L02:
       mov       eax,1
M01_L03:
       ret
; Total bytes of code 72
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L02
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L02:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFEAFC7FC60]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
       jmp       short M00_L01
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L00
       test      rdx,rdx
       je        short M01_L00
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       je        short M01_L03
M01_L00:
       xor       eax,eax
M01_L01:
       add       rsp,28
       ret
M01_L02:
       mov       eax,1
       jmp       short M01_L01
M01_L03:
       lea       rax,[rcx+0C]
       add       rdx,0C
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       jne       short M01_L04
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       r8,[rdx]
       xor       rcx,r8
       xor       rax,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       short M01_L05
M01_L04:
       mov       rcx,rax
       call      qword ptr [7FFEAF89C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M01_L05:
       jmp       short M01_L01
; Total bytes of code 104
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L06
       cmp       rcx,rdx
       je        short M02_L04
       cmp       r8,10
       jae       short M02_L01
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L00:
       ret
M02_L01:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L03
       movups    xmm0,[rcx]
       movups    xmm1,[rdx]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
M02_L02:
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L03:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  eax,xmm0
       cmp       eax,0FFFF
       jne       short M02_L05
M02_L04:
       mov       eax,1
       ret
M02_L05:
       xor       eax,eax
       ret
M02_L06:
       cmp       r8,4
       jb        short M02_L07
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L00
M02_L07:
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L08
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L08:
       test      r8b,1
       je        short M02_L09
       movzx     ecx,byte ptr [rcx+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        eax,ecx
M02_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L00
M02_L10:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
       jmp       near ptr M02_L02
; Total bytes of code 237
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L02
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L02:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC6FC78]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
       jmp       short M00_L01
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       cmp       rcx,2C60008
       je        short M01_L01
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       jmp       short M01_L02
M01_L00:
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
       jmp       short M01_L02
M01_L01:
       mov       eax,1
M01_L02:
       ret
; Total bytes of code 36
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L02
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L02:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+18]
       call      qword ptr [7FFEAFC7FC60]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
       jmp       short M00_L01
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       jne       short M01_L01
       mov       eax,1
M01_L00:
       add       rsp,28
       ret
M01_L01:
       test      rcx,rcx
       je        short M01_L02
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       je        short M01_L03
M01_L02:
       xor       eax,eax
       jmp       short M01_L00
M01_L03:
       lea       rax,[rcx+0C]
       add       rdx,0C
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       jne       short M01_L04
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       r8,[rdx]
       xor       rcx,r8
       xor       rax,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       short M01_L05
M01_L04:
       mov       rcx,rax
       call      qword ptr [7FFEAF89C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M01_L05:
       jmp       short M01_L00
; Total bytes of code 104
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L06
       cmp       rcx,rdx
       je        short M02_L04
       cmp       r8,10
       jae       short M02_L01
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L00:
       ret
M02_L01:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L03
       movups    xmm0,[rcx]
       movups    xmm1,[rdx]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
M02_L02:
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L03:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  eax,xmm0
       cmp       eax,0FFFF
       jne       short M02_L05
M02_L04:
       mov       eax,1
       ret
M02_L05:
       xor       eax,eax
       ret
M02_L06:
       cmp       r8,4
       jb        short M02_L07
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L00
M02_L07:
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L08
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L08:
       test      r8b,1
       je        short M02_L09
       movzx     ecx,byte ptr [rcx+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        eax,ecx
M02_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L00
M02_L10:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
       jmp       near ptr M02_L02
; Total bytes of code 237
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLength()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L03
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       esi
M00_L02:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L03:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC9FC60]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       je        short M00_L02
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLength(System.String)
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 11
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithChar()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L02
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L02:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC6FBA0]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
       jmp       short M00_L01
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.StartsWithChar(System.String)
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 12
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithText()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L02
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L02:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC8FC60]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
       jmp       short M00_L01
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.StartsWithText(System.String)
       cmp       dword ptr [rcx+8],0
       jg        short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
M01_L01:
       ret
; Total bytes of code 22
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE6781EC10]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.EqualsLiteral(System.String)
       vzeroupper
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0E
       jne       short M01_L00
       vmovups   xmm0,[rcx+0C]
       vpxor     xmm0,xmm0,[7FFE67427340]
       vmovups   xmm1,[rcx+18]
       vpternlogq xmm0,xmm1,[7FFE67427350],0F6
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 59
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       edx,edi
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE6782E8F8]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 85
```
```assembly
; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L00
       test      rdx,rdx
       je        short M01_L00
       mov       eax,[rcx+8]
       cmp       eax,[rdx+8]
       je        short M01_L03
M01_L00:
       xor       eax,eax
M01_L01:
       add       rsp,28
       ret
M01_L02:
       mov       eax,1
       jmp       short M01_L01
M01_L03:
       lea       rax,[rcx+0C]
       mov       r8d,[rcx+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,rax
       call      qword ptr [7FFE674B5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
; Total bytes of code 67
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jae       short M02_L03
       cmp       r8,4
       jae       short M02_L02
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L00
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L00:
       test      r8b,1
       je        short M02_L01
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        r8d,eax
       mov       eax,r8d
M02_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L02:
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L03:
       cmp       rcx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L04:
       ret
M02_L05:
       mov       eax,1
       ret
M02_L06:
       cmp       r8,10
       jb        short M02_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L08
M02_L07:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L10
       add       rax,10
       cmp       r8,rax
       ja        short M02_L07
M02_L08:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M02_L10
       jmp       short M02_L05
M02_L09:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L10:
       xor       eax,eax
       ret
; Total bytes of code 217
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE6781EDC0]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      rcx,rcx
       je        short M01_L00
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 19
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       edx,edi
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,[rbx+18]
       call      qword ptr [7FFE6782E928]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       jne       short M01_L01
       mov       eax,1
M01_L00:
       add       rsp,28
       ret
M01_L01:
       test      rcx,rcx
       je        short M01_L02
       test      rdx,rdx
       je        short M01_L02
       mov       eax,[rcx+8]
       cmp       eax,[rdx+8]
       je        short M01_L03
M01_L02:
       xor       eax,eax
       jmp       short M01_L00
M01_L03:
       lea       rax,[rcx+0C]
       mov       r8d,[rcx+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,rax
       call      qword ptr [7FFE674B5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L00
; Total bytes of code 67
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jae       short M02_L03
       cmp       r8,4
       jae       short M02_L02
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L00
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L00:
       test      r8b,1
       je        short M02_L01
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        r8d,eax
       mov       eax,r8d
M02_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L02:
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L03:
       cmp       rcx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L04:
       ret
M02_L05:
       mov       eax,1
       ret
M02_L06:
       cmp       r8,10
       jb        short M02_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L08
M02_L07:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L10
       add       rax,10
       cmp       r8,rax
       ja        short M02_L07
M02_L08:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M02_L10
       jmp       short M02_L05
M02_L09:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L10:
       xor       eax,eax
       ret
; Total bytes of code 217
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLength()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE6783E940]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLength(System.String)
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       ret
; Total bytes of code 10
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithChar()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE974FE958]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.StartsWithChar(System.String)
       xor       eax,eax
       cmp       word ptr [rcx+0C],63
       sete      al
       ret
; Total bytes of code 11
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithText()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE9750EE20]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.StartsWithText(System.String)
       cmp       dword ptr [rcx+8],0
       jle       short M01_L00
       xor       eax,eax
       cmp       word ptr [rcx+0C],63
       sete      al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 21
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE9740EC28]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0E
       je        short M01_L02
M01_L00:
       xor       eax,eax
M01_L01:
       ret
M01_L02:
       vmovups   xmm0,[rcx+0C]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE970F8720]
       vpternlogq xmm0,xmm1,[7FFE970F8730],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 56
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE973FEB68]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L05
       test      rcx,rcx
       je        short M01_L00
       test      rdx,rdx
       je        short M01_L00
       mov       eax,[rcx+8]
       cmp       eax,[rdx+8]
       je        short M01_L02
M01_L00:
       xor       eax,eax
M01_L01:
       add       rsp,28
       ret
M01_L02:
       lea       rax,[rcx+0C]
       add       rdx,0C
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       je        short M01_L03
       mov       rcx,rax
       call      qword ptr [7FFE9703C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       r8,[rdx]
       xor       rcx,r8
       xor       rax,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L04:
       jmp       short M01_L01
M01_L05:
       mov       eax,1
       jmp       short M01_L01
; Total bytes of code 102
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L06
       cmp       rcx,rdx
       je        short M02_L04
       cmp       r8,10
       jae       short M02_L01
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L00:
       ret
M02_L01:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L03
M02_L02:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
       add       rax,10
       cmp       r8,rax
       ja        short M02_L02
M02_L03:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  eax,xmm0
       cmp       eax,0FFFF
       jne       short M02_L05
M02_L04:
       mov       eax,1
       ret
M02_L05:
       xor       eax,eax
       ret
M02_L06:
       cmp       r8,4
       jb        short M02_L07
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L00
M02_L07:
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L08
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L08:
       test      r8b,1
       jne       short M02_L10
M02_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L00
M02_L10:
       movzx     ecx,byte ptr [rcx+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        eax,ecx
       jmp       short M02_L09
; Total bytes of code 210
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE9740EC40]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 77
```
```assembly
; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
M01_L01:
       ret
; Total bytes of code 20
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+18]
       call      qword ptr [7FFE9741EB68]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       jne       short M01_L01
       mov       eax,1
M01_L00:
       add       rsp,28
       ret
M01_L01:
       test      rcx,rcx
       je        short M01_L04
       test      rdx,rdx
       je        short M01_L04
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M01_L04
       lea       rax,[rcx+0C]
       add       rdx,0C
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       je        short M01_L02
       mov       rcx,rax
       call      qword ptr [7FFE9705C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       r8,[rdx]
       xor       rcx,r8
       xor       rax,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L03:
       jmp       short M01_L00
M01_L04:
       xor       eax,eax
       jmp       short M01_L00
; Total bytes of code 104
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L06
       cmp       rcx,rdx
       je        short M02_L04
       cmp       r8,10
       jae       short M02_L01
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L00:
       ret
M02_L01:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L03
M02_L02:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
       add       rax,10
       cmp       r8,rax
       ja        short M02_L02
M02_L03:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  eax,xmm0
       cmp       eax,0FFFF
       jne       short M02_L05
M02_L04:
       mov       eax,1
       ret
M02_L05:
       xor       eax,eax
       ret
M02_L06:
       cmp       r8,4
       jb        short M02_L07
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L00
M02_L07:
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L08
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L08:
       test      r8b,1
       jne       short M02_L10
M02_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L00
M02_L10:
       movzx     ecx,byte ptr [rcx+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        eax,ecx
       jmp       short M02_L09
; Total bytes of code 210
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLength()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE973FEC40]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 77
```
```assembly
; JitFoldProof.Subjects.EmptyByLength(System.String)
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 11
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithChar()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE973EEC40]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.StartsWithChar(System.String)
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 12
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithText()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE973FEC28]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.StartsWithText(System.String)
       cmp       dword ptr [rcx+8],0
       jg        short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
M01_L01:
       ret
; Total bytes of code 22
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC7FC60]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 77
```
```assembly
; JitFoldProof.Subjects.EqualsLiteral(System.String)
       cmp       rcx,2D363D8
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0E
       je        short M01_L01
M01_L00:
       xor       eax,eax
       jmp       short M01_L03
M01_L01:
       vmovups   xmm0,[rcx+0C]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFEAF938B50]
       vpternlogq xmm0,xmm1,[7FFEAF938B60],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L03
M01_L02:
       mov       eax,1
M01_L03:
       ret
; Total bytes of code 72
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFEAFC9FC60]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L03
       test      rdx,rdx
       je        short M01_L03
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M01_L03
       add       rcx,0C
       add       rdx,0C
       add       r8d,r8d
       cmp       r8,0A
       je        short M01_L00
       call      qword ptr [7FFEAF8BC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
M01_L00:
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[rdx]
       xor       rax,r8
       xor       rcx,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L01:
       add       rsp,28
       ret
M01_L02:
       mov       eax,1
       jmp       short M01_L01
M01_L03:
       xor       eax,eax
       jmp       short M01_L01
; Total bytes of code 96
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L03
       cmp       rcx,rdx
       je        short M02_L02
       cmp       r8,40
       jae       near ptr M02_L08
       cmp       r8,20
       jae       near ptr M02_L11
       cmp       r8,10
       jb        near ptr M02_L15
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L01
       vmovups   xmm0,[rcx]
       vpcmpnequb k1,xmm0,[rdx]
       kortestw  k1,k1
       jne       near ptr M02_L16
M02_L00:
       add       rax,10
       cmp       r8,rax
       ja        near ptr M02_L14
M02_L01:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jae       near ptr M02_L16
M02_L02:
       mov       eax,1
       vzeroupper
       ret
M02_L03:
       cmp       r8,4
       jae       short M02_L06
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L04
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L04:
       test      r8b,1
       je        short M02_L05
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M02_L05:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L07
M02_L06:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M02_L07:
       vzeroupper
       ret
M02_L08:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFC0
       je        short M02_L10
M02_L09:
       vmovups   zmm0,[rcx+rax]
       vpcmpnequb k1,zmm0,[rdx+rax]
       kortestq  k1,k1
       jne       near ptr M02_L16
       add       rax,40
       cmp       r8,rax
       ja        short M02_L09
M02_L10:
       vmovups   zmm0,[rcx+r8]
       vpcmpeqb  k1,zmm0,[rdx+r8]
       kortestq  k1,k1
       jae       near ptr M02_L16
       jmp       near ptr M02_L02
M02_L11:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L13
M02_L12:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       jne       short M02_L16
       add       rax,20
       cmp       r8,rax
       ja        short M02_L12
M02_L13:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       jae       short M02_L16
       jmp       near ptr M02_L02
M02_L14:
       vmovups   xmm0,[rcx+rax]
       vpcmpnequb k1,xmm0,[rdx+rax]
       kortestw  k1,k1
       jne       short M02_L16
       jmp       near ptr M02_L00
M02_L15:
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L07
M02_L16:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 400
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC9FC48]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       cmp       rcx,2D10008
       je        short M01_L01
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       jmp       short M01_L02
M01_L00:
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
       jmp       short M01_L02
M01_L01:
       mov       eax,1
M01_L02:
       ret
; Total bytes of code 36
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+18]
       call      qword ptr [7FFEAFC9FB88]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L00
       test      rdx,rdx
       je        short M01_L00
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       je        short M01_L03
M01_L00:
       xor       eax,eax
M01_L01:
       add       rsp,28
       ret
M01_L02:
       mov       eax,1
       jmp       short M01_L01
M01_L03:
       lea       rax,[rcx+0C]
       add       rdx,0C
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       jne       short M01_L04
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       r8,[rdx]
       xor       rcx,r8
       xor       rax,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       short M01_L05
M01_L04:
       mov       rcx,rax
       call      qword ptr [7FFEAF8BC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M01_L05:
       jmp       short M01_L01
; Total bytes of code 104
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L06
       cmp       rcx,rdx
       je        short M02_L04
       cmp       r8,10
       jae       short M02_L01
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L00:
       ret
M02_L01:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L03
       movups    xmm0,[rcx]
       movups    xmm1,[rdx]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
M02_L02:
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L03:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  eax,xmm0
       cmp       eax,0FFFF
       jne       short M02_L05
M02_L04:
       mov       eax,1
       ret
M02_L05:
       xor       eax,eax
       ret
M02_L06:
       cmp       r8,4
       jb        short M02_L07
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L00
M02_L07:
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L08
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L08:
       test      r8b,1
       je        short M02_L09
       movzx     ecx,byte ptr [rcx+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        eax,ecx
M02_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L00
M02_L10:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
       jmp       near ptr M02_L02
; Total bytes of code 237
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLength()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC7FC48]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLength(System.String)
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 11
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithChar()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC7FC48]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 77
```
```assembly
; JitFoldProof.Subjects.StartsWithChar(System.String)
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 12
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithText()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC9FC48]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 77
```
```assembly
; JitFoldProof.Subjects.StartsWithText(System.String)
       cmp       dword ptr [rcx+8],0
       jg        short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
M01_L01:
       ret
; Total bytes of code 22
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE9751E0D0]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EqualsLiteral(System.String)
       vzeroupper
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0E
       jne       short M01_L00
       vmovups   xmm0,[rcx+0C]
       vpxor     xmm0,xmm0,[7FFE97127600]
       vmovups   xmm1,[rcx+18]
       vpternlogq xmm0,xmm1,[7FFE97127610],0F6
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 59
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       edx,edi
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE9751E8F8]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L01
       test      rcx,rcx
       je        short M01_L02
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M01_L02
       add       rcx,0C
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFE971A5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       xor       eax,eax
       jmp       short M01_L00
; Total bytes of code 63
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       cmp       r8,8
       jae       short M02_L03
       cmp       r8,4
       jae       short M02_L02
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L00
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L00:
       test      r8b,1
       je        short M02_L01
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        r8d,eax
       mov       eax,r8d
M02_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L02:
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L03:
       cmp       rcx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L04:
       vzeroupper
       ret
M02_L05:
       mov       eax,1
       vzeroupper
       ret
M02_L06:
       cmp       r8,40
       jb        short M02_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFC0
       je        short M02_L08
M02_L07:
       vmovups   zmm0,[rcx+rax]
       vpcmpnequb k1,zmm0,[rdx+rax]
       kortestq  k1,k1
       nop       dword ptr [rax]
       jne       near ptr M02_L16
       add       rax,40
       cmp       r8,rax
       ja        short M02_L07
M02_L08:
       vmovups   zmm0,[rcx+r8]
       vpcmpeqb  k1,zmm0,[rdx+r8]
       kortestq  k1,k1
       nop       dword ptr [rax]
       jae       near ptr M02_L16
       jmp       short M02_L05
M02_L09:
       cmp       r8,20
       jb        short M02_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L11
M02_L10:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       nop       dword ptr [rax]
       jne       near ptr M02_L16
       add       rax,20
       cmp       r8,rax
       ja        short M02_L10
M02_L11:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       nop       dword ptr [rax]
       jae       short M02_L16
       jmp       near ptr M02_L05
       nop       dword ptr [rax+rax]
       nop       dword ptr [rax+rax]
M02_L12:
       cmp       r8,10
       jb        short M02_L15
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L14
M02_L13:
       vmovups   xmm0,[rcx+rax]
       vpcmpnequb k1,xmm0,[rdx+rax]
       kortestw  k1,k1
       jne       short M02_L16
       add       rax,10
       cmp       r8,rax
       ja        short M02_L13
M02_L14:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jae       short M02_L16
       jmp       near ptr M02_L05
M02_L15:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
M02_L16:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 394
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE974EE100]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      rcx,rcx
       je        short M01_L00
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 19
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       edx,edi
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,[rbx+18]
       call      qword ptr [7FFE974FE118]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 85
```
```assembly
; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L00
       test      rdx,rdx
       je        short M01_L00
       mov       eax,[rcx+8]
       cmp       eax,[rdx+8]
       je        short M01_L03
M01_L00:
       xor       eax,eax
M01_L01:
       add       rsp,28
       ret
M01_L02:
       mov       eax,1
       jmp       short M01_L01
M01_L03:
       lea       rax,[rcx+0C]
       mov       r8d,[rcx+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,rax
       call      qword ptr [7FFE97185068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
; Total bytes of code 67
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jae       short M02_L03
       cmp       r8,4
       jae       short M02_L02
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L00
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L00:
       test      r8b,1
       je        short M02_L01
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        r8d,eax
       mov       eax,r8d
M02_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L02:
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L03:
       cmp       rcx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L04:
       ret
M02_L05:
       mov       eax,1
       ret
M02_L06:
       cmp       r8,10
       jb        short M02_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L08
M02_L07:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L10
       add       rax,10
       cmp       r8,rax
       ja        short M02_L07
M02_L08:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M02_L10
       jmp       short M02_L05
M02_L09:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L10:
       xor       eax,eax
       ret
; Total bytes of code 217
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLength()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE974FE940]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.EmptyByLength(System.String)
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       ret
; Total bytes of code 10
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithChar()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE974EE148]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.StartsWithChar(System.String)
       xor       eax,eax
       cmp       word ptr [rcx+0C],63
       sete      al
       ret
; Total bytes of code 11
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithText()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE9750E970]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.StartsWithText(System.String)
       cmp       dword ptr [rcx+8],0
       jle       short M01_L00
       xor       eax,eax
       cmp       word ptr [rcx+0C],63
       sete      al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 21
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE9740EC10]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 77
```
```assembly
; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0E
       je        short M01_L02
M01_L00:
       xor       eax,eax
M01_L01:
       ret
M01_L02:
       vmovups   xmm0,[rcx+0C]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE970F8BD0]
       vpternlogq xmm0,xmm1,[7FFE970F8BE0],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 56
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE9741EC28]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L03
       test      rcx,rcx
       je        short M01_L02
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M01_L02
       add       rcx,0C
       add       rdx,0C
       add       r8d,r8d
       cmp       r8,0A
       je        short M01_L00
       call      qword ptr [7FFE9705C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
M01_L00:
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[rdx]
       xor       rax,r8
       xor       rcx,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L01:
       add       rsp,28
       ret
M01_L02:
       xor       eax,eax
       jmp       short M01_L01
M01_L03:
       mov       eax,1
       jmp       short M01_L01
; Total bytes of code 96
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        near ptr M02_L11
       cmp       rcx,rdx
       je        short M02_L02
       cmp       r8,40
       jae       near ptr M02_L07
       cmp       r8,20
       jae       short M02_L04
       cmp       r8,10
       jb        short M02_L03
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L01
M02_L00:
       vmovups   xmm0,[rcx+rax]
       vpcmpnequb k1,xmm0,[rdx+rax]
       kortestw  k1,k1
       jne       near ptr M02_L10
       add       rax,10
       cmp       r8,rax
       ja        short M02_L00
M02_L01:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jae       near ptr M02_L10
M02_L02:
       mov       eax,1
       vzeroupper
       ret
M02_L03:
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L15
M02_L04:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L06
M02_L05:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       jne       short M02_L10
       add       rax,20
       cmp       r8,rax
       ja        short M02_L05
M02_L06:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       jae       short M02_L10
       jmp       short M02_L02
M02_L07:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFC0
       je        short M02_L09
M02_L08:
       vmovups   zmm0,[rcx+rax]
       vpcmpnequb k1,zmm0,[rdx+rax]
       kortestq  k1,k1
       jne       short M02_L10
       add       rax,40
       cmp       r8,rax
       ja        short M02_L08
M02_L09:
       vmovups   zmm0,[rcx+r8]
       vpcmpeqb  k1,zmm0,[rdx+r8]
       kortestq  k1,k1
       jb        near ptr M02_L02
M02_L10:
       xor       eax,eax
       vzeroupper
       ret
M02_L11:
       cmp       r8,4
       jae       short M02_L14
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L12
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L12:
       test      r8b,1
       je        short M02_L13
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M02_L13:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L15
M02_L14:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M02_L15:
       vzeroupper
       ret
; Total bytes of code 358
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE973EEC28]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
M01_L01:
       ret
; Total bytes of code 20
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+18]
       call      qword ptr [7FFE973FEC28]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L05
       test      rcx,rcx
       je        short M01_L00
       test      rdx,rdx
       je        short M01_L00
       mov       eax,[rcx+8]
       cmp       eax,[rdx+8]
       je        short M01_L02
M01_L00:
       xor       eax,eax
M01_L01:
       add       rsp,28
       ret
M01_L02:
       lea       rax,[rcx+0C]
       add       rdx,0C
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       je        short M01_L03
       mov       rcx,rax
       call      qword ptr [7FFE9703C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       r8,[rdx]
       xor       rcx,r8
       xor       rax,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L04:
       jmp       short M01_L01
M01_L05:
       mov       eax,1
       jmp       short M01_L01
; Total bytes of code 102
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L06
       cmp       rcx,rdx
       je        short M02_L04
       cmp       r8,10
       jae       short M02_L01
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L00:
       ret
M02_L01:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L03
M02_L02:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
       add       rax,10
       cmp       r8,rax
       ja        short M02_L02
M02_L03:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  eax,xmm0
       cmp       eax,0FFFF
       jne       short M02_L05
M02_L04:
       mov       eax,1
       ret
M02_L05:
       xor       eax,eax
       ret
M02_L06:
       cmp       r8,4
       jb        short M02_L07
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L00
M02_L07:
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L08
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L08:
       test      r8b,1
       jne       short M02_L10
M02_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L00
M02_L10:
       movzx     ecx,byte ptr [rcx+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        eax,ecx
       jmp       short M02_L09
; Total bytes of code 210
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLength()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE9741EC28]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLength(System.String)
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 11
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithChar()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE973FEB50]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 77
```
```assembly
; JitFoldProof.Subjects.StartsWithChar(System.String)
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 12
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithText()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE9740EC28]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 77
```
```assembly
; JitFoldProof.Subjects.StartsWithText(System.String)
       cmp       dword ptr [rcx+8],0
       jg        short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
M01_L01:
       ret
; Total bytes of code 22
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L03
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       esi
M00_L02:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L03:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC8FC60]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       je        short M00_L02
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EqualsLiteral(System.String)
       cmp       rcx,2C363D8
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0E
       je        short M01_L01
M01_L00:
       xor       eax,eax
       jmp       short M01_L03
M01_L01:
       vmovups   xmm0,[rcx+0C]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFEAF948C90]
       vpternlogq xmm0,xmm1,[7FFEAF948CA0],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L03
M01_L02:
       mov       eax,1
M01_L03:
       ret
; Total bytes of code 72
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L03
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       esi
M00_L02:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L03:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFEAFC9FC60]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       je        short M00_L02
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L03
       test      rdx,rdx
       je        short M01_L03
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M01_L03
       add       rcx,0C
       add       rdx,0C
       add       r8d,r8d
       cmp       r8,0A
       je        short M01_L00
       call      qword ptr [7FFEAF8BC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
M01_L00:
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[rdx]
       xor       rax,r8
       xor       rcx,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L01:
       add       rsp,28
       ret
M01_L02:
       mov       eax,1
       jmp       short M01_L01
M01_L03:
       xor       eax,eax
       jmp       short M01_L01
; Total bytes of code 96
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L03
       cmp       rcx,rdx
       je        short M02_L02
       cmp       r8,40
       jae       near ptr M02_L08
       cmp       r8,20
       jae       near ptr M02_L11
       cmp       r8,10
       jb        near ptr M02_L15
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L01
       vmovups   xmm0,[rcx]
       vpcmpnequb k1,xmm0,[rdx]
       kortestw  k1,k1
       jne       near ptr M02_L16
M02_L00:
       add       rax,10
       cmp       r8,rax
       ja        near ptr M02_L14
M02_L01:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jae       near ptr M02_L16
M02_L02:
       mov       eax,1
       vzeroupper
       ret
M02_L03:
       cmp       r8,4
       jae       short M02_L06
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L04
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L04:
       test      r8b,1
       je        short M02_L05
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M02_L05:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L07
M02_L06:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M02_L07:
       vzeroupper
       ret
M02_L08:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFC0
       je        short M02_L10
M02_L09:
       vmovups   zmm0,[rcx+rax]
       vpcmpnequb k1,zmm0,[rdx+rax]
       kortestq  k1,k1
       jne       near ptr M02_L16
       add       rax,40
       cmp       r8,rax
       ja        short M02_L09
M02_L10:
       vmovups   zmm0,[rcx+r8]
       vpcmpeqb  k1,zmm0,[rdx+r8]
       kortestq  k1,k1
       jae       near ptr M02_L16
       jmp       near ptr M02_L02
M02_L11:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L13
M02_L12:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       jne       short M02_L16
       add       rax,20
       cmp       r8,rax
       ja        short M02_L12
M02_L13:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       jae       short M02_L16
       jmp       near ptr M02_L02
M02_L14:
       vmovups   xmm0,[rcx+rax]
       vpcmpnequb k1,xmm0,[rdx+rax]
       kortestw  k1,k1
       jne       short M02_L16
       jmp       near ptr M02_L00
M02_L15:
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L07
M02_L16:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 400
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L02
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L02:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC7FC60]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
       jmp       short M00_L01
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       cmp       rcx,2C60008
       je        short M01_L01
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       jmp       short M01_L02
M01_L00:
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
       jmp       short M01_L02
M01_L01:
       mov       eax,1
M01_L02:
       ret
; Total bytes of code 36
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L02
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L02:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+18]
       call      qword ptr [7FFEAFC7FC48]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
       jmp       short M00_L01
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L00
       test      rdx,rdx
       je        short M01_L00
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       je        short M01_L03
M01_L00:
       xor       eax,eax
M01_L01:
       add       rsp,28
       ret
M01_L02:
       mov       eax,1
       jmp       short M01_L01
M01_L03:
       lea       rax,[rcx+0C]
       add       rdx,0C
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       jne       short M01_L04
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       r8,[rdx]
       xor       rcx,r8
       xor       rax,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       short M01_L05
M01_L04:
       mov       rcx,rax
       call      qword ptr [7FFEAF89C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M01_L05:
       jmp       short M01_L01
; Total bytes of code 104
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L06
       cmp       rcx,rdx
       je        short M02_L04
       cmp       r8,10
       jae       short M02_L01
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L00:
       ret
M02_L01:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L03
       movups    xmm0,[rcx]
       movups    xmm1,[rdx]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
M02_L02:
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L03:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  eax,xmm0
       cmp       eax,0FFFF
       jne       short M02_L05
M02_L04:
       mov       eax,1
       ret
M02_L05:
       xor       eax,eax
       ret
M02_L06:
       cmp       r8,4
       jb        short M02_L07
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L00
M02_L07:
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L08
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L08:
       test      r8b,1
       je        short M02_L09
       movzx     ecx,byte ptr [rcx+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        eax,ecx
M02_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L00
M02_L10:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
       jmp       near ptr M02_L02
; Total bytes of code 237
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLength()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L02
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L02:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC6FC60]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
       jmp       short M00_L01
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLength(System.String)
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 11
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithChar()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L03
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       esi
M00_L02:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L03:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC6FC60]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       je        short M00_L02
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.StartsWithChar(System.String)
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 12
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithText()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L03
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       esi
M00_L02:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L03:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC7FC60]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       je        short M00_L02
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.StartsWithText(System.String)
       cmp       dword ptr [rcx+8],0
       jg        short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
M01_L01:
       ret
; Total bytes of code 22
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE9750E8E0]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EqualsLiteral(System.String)
       vzeroupper
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0E
       jne       short M01_L00
       vmovups   xmm0,[rcx+0C]
       vpxor     xmm0,xmm0,[7FFE97117740]
       vmovups   xmm1,[rcx+18]
       vpternlogq xmm0,xmm1,[7FFE97117750],0F6
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 59
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       edx,edi
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE9751E8F8]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L01
       test      rcx,rcx
       je        short M01_L02
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M01_L02
       add       rcx,0C
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFE971A5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       xor       eax,eax
       jmp       short M01_L00
; Total bytes of code 63
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       cmp       r8,8
       jae       short M02_L03
       cmp       r8,4
       jae       short M02_L02
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L00
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L00:
       test      r8b,1
       je        short M02_L01
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        r8d,eax
       mov       eax,r8d
M02_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L02:
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L03:
       cmp       rcx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L04:
       vzeroupper
       ret
M02_L05:
       mov       eax,1
       vzeroupper
       ret
M02_L06:
       cmp       r8,40
       jb        short M02_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFC0
       je        short M02_L08
M02_L07:
       vmovups   zmm0,[rcx+rax]
       vpcmpnequb k1,zmm0,[rdx+rax]
       kortestq  k1,k1
       nop       dword ptr [rax]
       jne       near ptr M02_L16
       add       rax,40
       cmp       r8,rax
       ja        short M02_L07
M02_L08:
       vmovups   zmm0,[rcx+r8]
       vpcmpeqb  k1,zmm0,[rdx+r8]
       kortestq  k1,k1
       nop       dword ptr [rax]
       jae       near ptr M02_L16
       jmp       short M02_L05
M02_L09:
       cmp       r8,20
       jb        short M02_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L11
M02_L10:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       nop       dword ptr [rax]
       jne       near ptr M02_L16
       add       rax,20
       cmp       r8,rax
       ja        short M02_L10
M02_L11:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       nop       dword ptr [rax]
       jae       short M02_L16
       jmp       near ptr M02_L05
       nop       dword ptr [rax+rax]
       nop       dword ptr [rax+rax]
M02_L12:
       cmp       r8,10
       jb        short M02_L15
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L14
M02_L13:
       vmovups   xmm0,[rcx+rax]
       vpcmpnequb k1,xmm0,[rdx+rax]
       kortestw  k1,k1
       jne       short M02_L16
       add       rax,10
       cmp       r8,rax
       ja        short M02_L13
M02_L14:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jae       short M02_L16
       jmp       near ptr M02_L05
M02_L15:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
M02_L16:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 394
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE9751E910]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      rcx,rcx
       je        short M01_L00
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 19
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       edx,edi
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,[rbx+18]
       call      qword ptr [7FFE974DE928]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 85
```
```assembly
; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L00
       test      rdx,rdx
       je        short M01_L00
       mov       eax,[rcx+8]
       cmp       eax,[rdx+8]
       je        short M01_L03
M01_L00:
       xor       eax,eax
M01_L01:
       add       rsp,28
       ret
M01_L02:
       mov       eax,1
       jmp       short M01_L01
M01_L03:
       lea       rax,[rcx+0C]
       mov       r8d,[rcx+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,rax
       call      qword ptr [7FFE97165068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
; Total bytes of code 67
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jae       short M02_L03
       cmp       r8,4
       jae       short M02_L02
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L00
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L00:
       test      r8b,1
       je        short M02_L01
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        r8d,eax
       mov       eax,r8d
M02_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L02:
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L03:
       cmp       rcx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L04:
       ret
M02_L05:
       mov       eax,1
       ret
M02_L06:
       cmp       r8,10
       jb        short M02_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L08
M02_L07:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L10
       add       rax,10
       cmp       r8,rax
       ja        short M02_L07
M02_L08:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M02_L10
       jmp       short M02_L05
M02_L09:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L10:
       xor       eax,eax
       ret
; Total bytes of code 217
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLength()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE974DE940]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.EmptyByLength(System.String)
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       ret
; Total bytes of code 10
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithChar()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE974FE148]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.StartsWithChar(System.String)
       xor       eax,eax
       cmp       word ptr [rcx+0C],63
       sete      al
       ret
; Total bytes of code 11
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithText()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE9751E970]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.StartsWithText(System.String)
       cmp       dword ptr [rcx+8],0
       jle       short M01_L00
       xor       eax,eax
       cmp       word ptr [rcx+0C],63
       sete      al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 21
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE9740EB50]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 77
```
```assembly
; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0E
       je        short M01_L02
M01_L00:
       xor       eax,eax
M01_L01:
       ret
M01_L02:
       vmovups   xmm0,[rcx+0C]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE970F8C70]
       vpternlogq xmm0,xmm1,[7FFE970F8C80],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 56
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE973EEC28]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L03
       test      rcx,rcx
       je        short M01_L02
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M01_L02
       add       rcx,0C
       add       rdx,0C
       add       r8d,r8d
       cmp       r8,0A
       je        short M01_L00
       call      qword ptr [7FFE9702C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
M01_L00:
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[rdx]
       xor       rax,r8
       xor       rcx,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L01:
       add       rsp,28
       ret
M01_L02:
       xor       eax,eax
       jmp       short M01_L01
M01_L03:
       mov       eax,1
       jmp       short M01_L01
; Total bytes of code 96
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        near ptr M02_L11
       cmp       rcx,rdx
       je        short M02_L02
       cmp       r8,40
       jae       near ptr M02_L07
       cmp       r8,20
       jae       short M02_L04
       cmp       r8,10
       jb        short M02_L03
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L01
M02_L00:
       vmovups   xmm0,[rcx+rax]
       vpcmpnequb k1,xmm0,[rdx+rax]
       kortestw  k1,k1
       jne       near ptr M02_L10
       add       rax,10
       cmp       r8,rax
       ja        short M02_L00
M02_L01:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jae       near ptr M02_L10
M02_L02:
       mov       eax,1
       vzeroupper
       ret
M02_L03:
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L15
M02_L04:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L06
M02_L05:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       jne       short M02_L10
       add       rax,20
       cmp       r8,rax
       ja        short M02_L05
M02_L06:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       jae       short M02_L10
       jmp       short M02_L02
M02_L07:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFC0
       je        short M02_L09
M02_L08:
       vmovups   zmm0,[rcx+rax]
       vpcmpnequb k1,zmm0,[rdx+rax]
       kortestq  k1,k1
       jne       short M02_L10
       add       rax,40
       cmp       r8,rax
       ja        short M02_L08
M02_L09:
       vmovups   zmm0,[rcx+r8]
       vpcmpeqb  k1,zmm0,[rdx+r8]
       kortestq  k1,k1
       jb        near ptr M02_L02
M02_L10:
       xor       eax,eax
       vzeroupper
       ret
M02_L11:
       cmp       r8,4
       jae       short M02_L14
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L12
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L12:
       test      r8b,1
       je        short M02_L13
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M02_L13:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L15
M02_L14:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M02_L15:
       vzeroupper
       ret
; Total bytes of code 358
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE9740EB50]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
M01_L01:
       ret
; Total bytes of code 20
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+18]
       call      qword ptr [7FFE9740EB50]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L05
       test      rcx,rcx
       je        short M01_L00
       test      rdx,rdx
       je        short M01_L00
       mov       eax,[rcx+8]
       cmp       eax,[rdx+8]
       je        short M01_L02
M01_L00:
       xor       eax,eax
M01_L01:
       add       rsp,28
       ret
M01_L02:
       lea       rax,[rcx+0C]
       add       rdx,0C
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       je        short M01_L03
       mov       rcx,rax
       call      qword ptr [7FFE9704C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       r8,[rdx]
       xor       rcx,r8
       xor       rax,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L04:
       jmp       short M01_L01
M01_L05:
       mov       eax,1
       jmp       short M01_L01
; Total bytes of code 102
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L06
       cmp       rcx,rdx
       je        short M02_L04
       cmp       r8,10
       jae       short M02_L01
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L00:
       ret
M02_L01:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L03
M02_L02:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
       add       rax,10
       cmp       r8,rax
       ja        short M02_L02
M02_L03:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  eax,xmm0
       cmp       eax,0FFFF
       jne       short M02_L05
M02_L04:
       mov       eax,1
       ret
M02_L05:
       xor       eax,eax
       ret
M02_L06:
       cmp       r8,4
       jb        short M02_L07
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L00
M02_L07:
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L08
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L08:
       test      r8b,1
       jne       short M02_L10
M02_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L00
M02_L10:
       movzx     ecx,byte ptr [rcx+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        eax,ecx
       jmp       short M02_L09
; Total bytes of code 210
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLength()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE973FEB50]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLength(System.String)
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 11
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithChar()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE9741EC10]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 77
```
```assembly
; JitFoldProof.Subjects.StartsWithChar(System.String)
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 12
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithText()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE973EEC10]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 77
```
```assembly
; JitFoldProof.Subjects.StartsWithText(System.String)
       cmp       dword ptr [rcx+8],0
       jg        short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
M01_L01:
       ret
; Total bytes of code 22
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L03
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       esi
M00_L02:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L03:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC9FC78]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       je        short M00_L02
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EqualsLiteral(System.String)
       cmp       rcx,2CC63D8
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0E
       je        short M01_L01
M01_L00:
       xor       eax,eax
       jmp       short M01_L03
M01_L01:
       vmovups   xmm0,[rcx+0C]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFEAF958C10]
       vpternlogq xmm0,xmm1,[7FFEAF958C20],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L03
M01_L02:
       mov       eax,1
M01_L03:
       ret
; Total bytes of code 72
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L03
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       esi
M00_L02:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L03:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFEAFC7FBA0]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       je        short M00_L02
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L03
       test      rcx,rcx
       je        short M01_L02
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M01_L02
       lea       rax,[rcx+0C]
       add       rdx,0C
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       je        short M01_L00
       mov       rcx,rax
       call      qword ptr [7FFEAF89C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
M01_L00:
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       r8,[rdx]
       xor       rcx,r8
       xor       rax,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L01:
       jmp       short M01_L04
M01_L02:
       xor       eax,eax
       jmp       short M01_L04
M01_L03:
       mov       eax,1
M01_L04:
       add       rsp,28
       ret
; Total bytes of code 104
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L03
       cmp       rcx,rdx
       je        short M02_L02
       cmp       r8,40
       jae       near ptr M02_L08
       cmp       r8,20
       jae       near ptr M02_L11
       cmp       r8,10
       jb        near ptr M02_L15
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L01
       vmovups   xmm0,[rcx]
       vpcmpnequb k1,xmm0,[rdx]
       kortestw  k1,k1
       jne       near ptr M02_L16
M02_L00:
       add       rax,10
       cmp       r8,rax
       ja        near ptr M02_L14
M02_L01:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jae       near ptr M02_L16
M02_L02:
       mov       eax,1
       vzeroupper
       ret
M02_L03:
       cmp       r8,4
       jae       short M02_L06
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L04
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L04:
       test      r8b,1
       je        short M02_L05
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M02_L05:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L07
M02_L06:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M02_L07:
       vzeroupper
       ret
M02_L08:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFC0
       je        short M02_L10
M02_L09:
       vmovups   zmm0,[rcx+rax]
       vpcmpnequb k1,zmm0,[rdx+rax]
       kortestq  k1,k1
       jne       near ptr M02_L16
       add       rax,40
       cmp       r8,rax
       ja        short M02_L09
M02_L10:
       vmovups   zmm0,[rcx+r8]
       vpcmpeqb  k1,zmm0,[rdx+r8]
       kortestq  k1,k1
       jae       near ptr M02_L16
       jmp       near ptr M02_L02
M02_L11:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L13
M02_L12:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       jne       short M02_L16
       add       rax,20
       cmp       r8,rax
       ja        short M02_L12
M02_L13:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       jae       short M02_L16
       jmp       near ptr M02_L02
M02_L14:
       vmovups   xmm0,[rcx+rax]
       vpcmpnequb k1,xmm0,[rdx+rax]
       kortestw  k1,k1
       jne       short M02_L16
       jmp       near ptr M02_L00
M02_L15:
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L07
M02_L16:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 400
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L02
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L02:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC6FC78]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
       jmp       short M00_L01
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       cmp       rcx,2E40008
       je        short M01_L01
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       jmp       short M01_L02
M01_L00:
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
       jmp       short M01_L02
M01_L01:
       mov       eax,1
M01_L02:
       ret
; Total bytes of code 36
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L02
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L02:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+18]
       call      qword ptr [7FFEAFC9FBA0]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
       jmp       short M00_L01
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L00
       test      rdx,rdx
       je        short M01_L00
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       je        short M01_L03
M01_L00:
       xor       eax,eax
M01_L01:
       add       rsp,28
       ret
M01_L02:
       mov       eax,1
       jmp       short M01_L01
M01_L03:
       lea       rax,[rcx+0C]
       add       rdx,0C
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       jne       short M01_L04
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       r8,[rdx]
       xor       rcx,r8
       xor       rax,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       short M01_L05
M01_L04:
       mov       rcx,rax
       call      qword ptr [7FFEAF8BC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M01_L05:
       jmp       short M01_L01
; Total bytes of code 104
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L06
       cmp       rcx,rdx
       je        short M02_L04
       cmp       r8,10
       jae       short M02_L01
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L00:
       ret
M02_L01:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L03
       movups    xmm0,[rcx]
       movups    xmm1,[rdx]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
M02_L02:
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L03:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  eax,xmm0
       cmp       eax,0FFFF
       jne       short M02_L05
M02_L04:
       mov       eax,1
       ret
M02_L05:
       xor       eax,eax
       ret
M02_L06:
       cmp       r8,4
       jb        short M02_L07
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L00
M02_L07:
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L08
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L08:
       test      r8b,1
       je        short M02_L09
       movzx     ecx,byte ptr [rcx+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        eax,ecx
M02_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L00
M02_L10:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
       jmp       near ptr M02_L02
; Total bytes of code 237
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLength()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L02
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L02:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC6FC78]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
       jmp       short M00_L01
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLength(System.String)
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 11
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithChar()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L03
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       esi
M00_L02:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L03:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC8FBA0]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       je        short M00_L02
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.StartsWithChar(System.String)
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 12
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithText()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L03
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       esi
M00_L02:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L03:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC9FC60]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       je        short M00_L02
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.StartsWithText(System.String)
       cmp       dword ptr [rcx+8],0
       jg        short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
M01_L01:
       ret
; Total bytes of code 22
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE974EED90]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EqualsLiteral(System.String)
       vzeroupper
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0E
       jne       short M01_L00
       vmovups   xmm0,[rcx+0C]
       vpxor     xmm0,xmm0,[7FFE970F7780]
       vmovups   xmm1,[rcx+18]
       vpternlogq xmm0,xmm1,[7FFE970F7790],0F6
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 59
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       edx,edi
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE974EE8F8]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L01
       test      rcx,rcx
       je        short M01_L02
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M01_L02
       add       rcx,0C
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFE97175068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       xor       eax,eax
       jmp       short M01_L00
; Total bytes of code 63
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       cmp       r8,8
       jae       short M02_L03
       cmp       r8,4
       jae       short M02_L02
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L00
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L00:
       test      r8b,1
       je        short M02_L01
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        r8d,eax
       mov       eax,r8d
M02_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L02:
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L03:
       cmp       rcx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L04:
       vzeroupper
       ret
M02_L05:
       mov       eax,1
       vzeroupper
       ret
M02_L06:
       cmp       r8,40
       jb        short M02_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFC0
       je        short M02_L08
M02_L07:
       vmovups   zmm0,[rcx+rax]
       vpcmpnequb k1,zmm0,[rdx+rax]
       kortestq  k1,k1
       nop       dword ptr [rax]
       jne       near ptr M02_L16
       add       rax,40
       cmp       r8,rax
       ja        short M02_L07
M02_L08:
       vmovups   zmm0,[rcx+r8]
       vpcmpeqb  k1,zmm0,[rdx+r8]
       kortestq  k1,k1
       nop       dword ptr [rax]
       jae       near ptr M02_L16
       jmp       short M02_L05
M02_L09:
       cmp       r8,20
       jb        short M02_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L11
M02_L10:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       nop       dword ptr [rax]
       jne       near ptr M02_L16
       add       rax,20
       cmp       r8,rax
       ja        short M02_L10
M02_L11:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       nop       dword ptr [rax]
       jae       short M02_L16
       jmp       near ptr M02_L05
       nop       dword ptr [rax+rax]
       nop       dword ptr [rax+rax]
M02_L12:
       cmp       r8,10
       jb        short M02_L15
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L14
M02_L13:
       vmovups   xmm0,[rcx+rax]
       vpcmpnequb k1,xmm0,[rdx+rax]
       kortestw  k1,k1
       jne       short M02_L16
       add       rax,10
       cmp       r8,rax
       ja        short M02_L13
M02_L14:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jae       short M02_L16
       jmp       near ptr M02_L05
M02_L15:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
M02_L16:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 394
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE9750EDC0]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      rcx,rcx
       je        short M01_L00
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 19
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       edx,edi
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,[rbx+18]
       call      qword ptr [7FFE974EEDD8]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 85
```
```assembly
; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L00
       test      rdx,rdx
       je        short M01_L00
       mov       eax,[rcx+8]
       cmp       eax,[rdx+8]
       je        short M01_L03
M01_L00:
       xor       eax,eax
M01_L01:
       add       rsp,28
       ret
M01_L02:
       mov       eax,1
       jmp       short M01_L01
M01_L03:
       lea       rax,[rcx+0C]
       mov       r8d,[rcx+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,rax
       call      qword ptr [7FFE97175068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
; Total bytes of code 67
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jae       short M02_L03
       cmp       r8,4
       jae       short M02_L02
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L00
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L00:
       test      r8b,1
       je        short M02_L01
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        r8d,eax
       mov       eax,r8d
M02_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L02:
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L03:
       cmp       rcx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L04:
       ret
M02_L05:
       mov       eax,1
       ret
M02_L06:
       cmp       r8,10
       jb        short M02_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L08
M02_L07:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L10
       add       rax,10
       cmp       r8,rax
       ja        short M02_L07
M02_L08:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M02_L10
       jmp       short M02_L05
M02_L09:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L10:
       xor       eax,eax
       ret
; Total bytes of code 217
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLength()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE974DE940]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.EmptyByLength(System.String)
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       ret
; Total bytes of code 10
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithChar()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE9750EE08]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.StartsWithChar(System.String)
       xor       eax,eax
       cmp       word ptr [rcx+0C],63
       sete      al
       ret
; Total bytes of code 11
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithText()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE9751EE20]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.StartsWithText(System.String)
       cmp       dword ptr [rcx+8],0
       jle       short M01_L00
       xor       eax,eax
       cmp       word ptr [rcx+0C],63
       sete      al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 21
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE973EEB68]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 77
```
```assembly
; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0E
       je        short M01_L02
M01_L00:
       xor       eax,eax
M01_L01:
       ret
M01_L02:
       vmovups   xmm0,[rcx+0C]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE970D8C70]
       vpternlogq xmm0,xmm1,[7FFE970D8C80],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 56
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE973EEC40]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L03
       test      rcx,rcx
       je        short M01_L02
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M01_L02
       add       rcx,0C
       add       rdx,0C
       add       r8d,r8d
       cmp       r8,0A
       je        short M01_L00
       call      qword ptr [7FFE9702C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
M01_L00:
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[rdx]
       xor       rax,r8
       xor       rcx,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L01:
       add       rsp,28
       ret
M01_L02:
       xor       eax,eax
       jmp       short M01_L01
M01_L03:
       mov       eax,1
       jmp       short M01_L01
; Total bytes of code 96
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        near ptr M02_L11
       cmp       rcx,rdx
       je        short M02_L02
       cmp       r8,40
       jae       near ptr M02_L07
       cmp       r8,20
       jae       short M02_L04
       cmp       r8,10
       jb        short M02_L03
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L01
M02_L00:
       vmovups   xmm0,[rcx+rax]
       vpcmpnequb k1,xmm0,[rdx+rax]
       kortestw  k1,k1
       jne       near ptr M02_L10
       add       rax,10
       cmp       r8,rax
       ja        short M02_L00
M02_L01:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jae       near ptr M02_L10
M02_L02:
       mov       eax,1
       vzeroupper
       ret
M02_L03:
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L15
M02_L04:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L06
M02_L05:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       jne       short M02_L10
       add       rax,20
       cmp       r8,rax
       ja        short M02_L05
M02_L06:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       jae       short M02_L10
       jmp       short M02_L02
M02_L07:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFC0
       je        short M02_L09
M02_L08:
       vmovups   zmm0,[rcx+rax]
       vpcmpnequb k1,zmm0,[rdx+rax]
       kortestq  k1,k1
       jne       short M02_L10
       add       rax,40
       cmp       r8,rax
       ja        short M02_L08
M02_L09:
       vmovups   zmm0,[rcx+r8]
       vpcmpeqb  k1,zmm0,[rdx+r8]
       kortestq  k1,k1
       jb        near ptr M02_L02
M02_L10:
       xor       eax,eax
       vzeroupper
       ret
M02_L11:
       cmp       r8,4
       jae       short M02_L14
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L12
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L12:
       test      r8b,1
       je        short M02_L13
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M02_L13:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L15
M02_L14:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M02_L15:
       vzeroupper
       ret
; Total bytes of code 358
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE9741EC28]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
M01_L01:
       ret
; Total bytes of code 20
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+18]
       call      qword ptr [7FFE9741EC10]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L05
       test      rcx,rcx
       je        short M01_L00
       test      rdx,rdx
       je        short M01_L00
       mov       eax,[rcx+8]
       cmp       eax,[rdx+8]
       je        short M01_L02
M01_L00:
       xor       eax,eax
M01_L01:
       add       rsp,28
       ret
M01_L02:
       lea       rax,[rcx+0C]
       add       rdx,0C
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       je        short M01_L03
       mov       rcx,rax
       call      qword ptr [7FFE9705C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       r8,[rdx]
       xor       rcx,r8
       xor       rax,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L04:
       jmp       short M01_L01
M01_L05:
       mov       eax,1
       jmp       short M01_L01
; Total bytes of code 102
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L06
       cmp       rcx,rdx
       je        short M02_L04
       cmp       r8,10
       jae       short M02_L01
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L00:
       ret
M02_L01:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L03
M02_L02:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
       add       rax,10
       cmp       r8,rax
       ja        short M02_L02
M02_L03:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  eax,xmm0
       cmp       eax,0FFFF
       jne       short M02_L05
M02_L04:
       mov       eax,1
       ret
M02_L05:
       xor       eax,eax
       ret
M02_L06:
       cmp       r8,4
       jb        short M02_L07
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L00
M02_L07:
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L08
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L08:
       test      r8b,1
       jne       short M02_L10
M02_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L00
M02_L10:
       movzx     ecx,byte ptr [rcx+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        eax,ecx
       jmp       short M02_L09
; Total bytes of code 210
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLength()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE973FEC40]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLength(System.String)
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 11
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithChar()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE9740EB68]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 77
```
```assembly
; JitFoldProof.Subjects.StartsWithChar(System.String)
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 12
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithText()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE973EEC40]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 77
```
```assembly
; JitFoldProof.Subjects.StartsWithText(System.String)
       cmp       dword ptr [rcx+8],0
       jg        short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
M01_L01:
       ret
; Total bytes of code 22
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC8FB88]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EqualsLiteral(System.String)
       cmp       rcx,2CB6400
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0E
       je        short M01_L01
M01_L00:
       xor       eax,eax
       jmp       short M01_L03
M01_L01:
       vmovups   xmm0,[rcx+0C]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFEAF948B50]
       vpternlogq xmm0,xmm1,[7FFEAF948B60],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L03
M01_L02:
       mov       eax,1
M01_L03:
       ret
; Total bytes of code 72
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFEAFC6FC60]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L03
       test      rcx,rcx
       je        short M01_L02
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M01_L02
       lea       rax,[rcx+0C]
       add       rdx,0C
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       je        short M01_L00
       mov       rcx,rax
       call      qword ptr [7FFEAF88C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
M01_L00:
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       r8,[rdx]
       xor       rcx,r8
       xor       rax,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L01:
       jmp       short M01_L04
M01_L02:
       xor       eax,eax
       jmp       short M01_L04
M01_L03:
       mov       eax,1
M01_L04:
       add       rsp,28
       ret
; Total bytes of code 104
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L03
       cmp       rcx,rdx
       je        near ptr M02_L15
       cmp       r8,40
       jae       near ptr M02_L08
       cmp       r8,20
       jae       near ptr M02_L11
       cmp       r8,10
       jb        near ptr M02_L16
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L01
       vmovups   xmm0,[rcx]
       vpcmpnequb k1,xmm0,[rdx]
       kortestw  k1,k1
       jne       short M02_L02
M02_L00:
       add       rax,10
       cmp       r8,rax
       ja        near ptr M02_L14
M02_L01:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jb        near ptr M02_L15
M02_L02:
       xor       eax,eax
       vzeroupper
       ret
M02_L03:
       cmp       r8,4
       jae       short M02_L06
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L04
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L04:
       test      r8b,1
       je        short M02_L05
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M02_L05:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L07
M02_L06:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M02_L07:
       vzeroupper
       ret
M02_L08:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFC0
       je        short M02_L10
M02_L09:
       vmovups   zmm0,[rcx+rax]
       vpcmpnequb k1,zmm0,[rdx+rax]
       kortestq  k1,k1
       jne       short M02_L02
       add       rax,40
       cmp       r8,rax
       ja        short M02_L09
M02_L10:
       vmovups   zmm0,[rcx+r8]
       vpcmpeqb  k1,zmm0,[rdx+r8]
       kortestq  k1,k1
       jae       near ptr M02_L02
       jmp       short M02_L15
M02_L11:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L13
M02_L12:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       jne       near ptr M02_L02
       add       rax,20
       cmp       r8,rax
       ja        short M02_L12
M02_L13:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       jae       near ptr M02_L02
       jmp       short M02_L15
M02_L14:
       vmovups   xmm0,[rcx+rax]
       vpcmpnequb k1,xmm0,[rdx+rax]
       kortestw  k1,k1
       jne       near ptr M02_L02
       jmp       near ptr M02_L00
M02_L15:
       mov       eax,1
       vzeroupper
       ret
M02_L16:
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L07
; Total bytes of code 402
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC9FC60]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       cmp       rcx,2D00008
       je        short M01_L01
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       jmp       short M01_L02
M01_L00:
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
       jmp       short M01_L02
M01_L01:
       mov       eax,1
M01_L02:
       ret
; Total bytes of code 36
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+18]
       call      qword ptr [7FFEAFC9FC60]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L00
       test      rdx,rdx
       je        short M01_L00
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       je        short M01_L03
M01_L00:
       xor       eax,eax
M01_L01:
       add       rsp,28
       ret
M01_L02:
       mov       eax,1
       jmp       short M01_L01
M01_L03:
       lea       rax,[rcx+0C]
       add       rdx,0C
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       jne       short M01_L04
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       r8,[rdx]
       xor       rcx,r8
       xor       rax,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       short M01_L05
M01_L04:
       mov       rcx,rax
       call      qword ptr [7FFEAF8BC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M01_L05:
       jmp       short M01_L01
; Total bytes of code 104
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L06
       cmp       rcx,rdx
       je        short M02_L04
       cmp       r8,10
       jae       short M02_L01
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L00:
       ret
M02_L01:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L03
       movups    xmm0,[rcx]
       movups    xmm1,[rdx]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
M02_L02:
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L03:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  eax,xmm0
       cmp       eax,0FFFF
       jne       short M02_L05
M02_L04:
       mov       eax,1
       ret
M02_L05:
       xor       eax,eax
       ret
M02_L06:
       cmp       r8,4
       jb        short M02_L07
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L00
M02_L07:
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L08
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L08:
       test      r8b,1
       je        short M02_L09
       movzx     ecx,byte ptr [rcx+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        eax,ecx
M02_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L00
M02_L10:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
       jmp       near ptr M02_L02
; Total bytes of code 237
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLength()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFCAFC48]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLength(System.String)
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 11
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithChar()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC6FB88]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 77
```
```assembly
; JitFoldProof.Subjects.StartsWithChar(System.String)
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 12
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithText()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC9FC60]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 77
```
```assembly
; JitFoldProof.Subjects.StartsWithText(System.String)
       cmp       dword ptr [rcx+8],0
       jg        short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
M01_L01:
       ret
; Total bytes of code 22
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE7432E8E0]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.EqualsLiteral(System.String)
       vzeroupper
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0E
       jne       short M01_L00
       vmovups   xmm0,[rcx+0C]
       vpxor     xmm0,xmm0,[7FFE73F37600]
       vmovups   xmm1,[rcx+18]
       vpternlogq xmm0,xmm1,[7FFE73F37610],0F6
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 59
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       edx,edi
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE7432E8F8]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 85
```
```assembly
; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L01
       test      rcx,rcx
       je        short M01_L02
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M01_L02
       add       rcx,0C
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFE73FB5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       xor       eax,eax
       jmp       short M01_L00
; Total bytes of code 63
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       cmp       r8,8
       jae       short M02_L03
       cmp       r8,4
       jae       short M02_L02
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L00
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L00:
       test      r8b,1
       je        short M02_L01
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        r8d,eax
       mov       eax,r8d
M02_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L02:
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L03:
       cmp       rcx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L04:
       vzeroupper
       ret
M02_L05:
       mov       eax,1
       vzeroupper
       ret
M02_L06:
       cmp       r8,40
       jb        short M02_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFC0
       je        short M02_L08
M02_L07:
       vmovups   zmm0,[rcx+rax]
       vpcmpnequb k1,zmm0,[rdx+rax]
       kortestq  k1,k1
       nop       dword ptr [rax]
       jne       near ptr M02_L16
       add       rax,40
       cmp       r8,rax
       ja        short M02_L07
M02_L08:
       vmovups   zmm0,[rcx+r8]
       vpcmpeqb  k1,zmm0,[rdx+r8]
       kortestq  k1,k1
       nop       dword ptr [rax]
       jae       near ptr M02_L16
       jmp       short M02_L05
M02_L09:
       cmp       r8,20
       jb        short M02_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L11
M02_L10:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       nop       dword ptr [rax]
       jne       near ptr M02_L16
       add       rax,20
       cmp       r8,rax
       ja        short M02_L10
M02_L11:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       nop       dword ptr [rax]
       jae       short M02_L16
       jmp       near ptr M02_L05
       nop       dword ptr [rax+rax]
       nop       dword ptr [rax+rax]
M02_L12:
       cmp       r8,10
       jb        short M02_L15
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L14
M02_L13:
       vmovups   xmm0,[rcx+rax]
       vpcmpnequb k1,xmm0,[rdx+rax]
       kortestw  k1,k1
       jne       short M02_L16
       add       rax,10
       cmp       r8,rax
       ja        short M02_L13
M02_L14:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jae       short M02_L16
       jmp       near ptr M02_L05
M02_L15:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
M02_L16:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 394
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE7435E430]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      rcx,rcx
       je        short M01_L00
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 19
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       edx,edi
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,[rbx+18]
       call      qword ptr [7FFE7432E928]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 85
```
```assembly
; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L00
       test      rdx,rdx
       je        short M01_L00
       mov       eax,[rcx+8]
       cmp       eax,[rdx+8]
       je        short M01_L03
M01_L00:
       xor       eax,eax
M01_L01:
       add       rsp,28
       ret
M01_L02:
       mov       eax,1
       jmp       short M01_L01
M01_L03:
       lea       rax,[rcx+0C]
       mov       r8d,[rcx+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,rax
       call      qword ptr [7FFE73FB5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
; Total bytes of code 67
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jae       short M02_L03
       cmp       r8,4
       jae       short M02_L02
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L00
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L00:
       test      r8b,1
       je        short M02_L01
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        r8d,eax
       mov       eax,r8d
M02_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L02:
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L03:
       cmp       rcx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L04:
       ret
M02_L05:
       mov       eax,1
       ret
M02_L06:
       cmp       r8,10
       jb        short M02_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L08
M02_L07:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L10
       add       rax,10
       cmp       r8,rax
       ja        short M02_L07
M02_L08:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M02_L10
       jmp       short M02_L05
M02_L09:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L10:
       xor       eax,eax
       ret
; Total bytes of code 217
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLength()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE7432E130]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.EmptyByLength(System.String)
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       ret
; Total bytes of code 10
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithChar()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE7433E148]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.StartsWithChar(System.String)
       xor       eax,eax
       cmp       word ptr [rcx+0C],63
       sete      al
       ret
; Total bytes of code 11
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithText()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE7434E970]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.StartsWithText(System.String)
       cmp       dword ptr [rcx+8],0
       jle       short M01_L00
       xor       eax,eax
       cmp       word ptr [rcx+0C],63
       sete      al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 21
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE7422EB50]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0E
       je        short M01_L02
M01_L00:
       xor       eax,eax
M01_L01:
       ret
M01_L02:
       vmovups   xmm0,[rcx+0C]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE73F18BD0]
       vpternlogq xmm0,xmm1,[7FFE73F18BE0],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 56
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE9740EC28]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L03
       test      rcx,rcx
       je        short M01_L02
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M01_L02
       add       rcx,0C
       add       rdx,0C
       add       r8d,r8d
       cmp       r8,0A
       je        short M01_L00
       call      qword ptr [7FFE9704C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
M01_L00:
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[rdx]
       xor       rax,r8
       xor       rcx,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L01:
       add       rsp,28
       ret
M01_L02:
       xor       eax,eax
       jmp       short M01_L01
M01_L03:
       mov       eax,1
       jmp       short M01_L01
; Total bytes of code 96
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        near ptr M02_L11
       cmp       rcx,rdx
       je        near ptr M02_L10
       cmp       r8,40
       jae       near ptr M02_L07
       cmp       r8,20
       jae       short M02_L04
       cmp       r8,10
       jb        short M02_L03
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L01
M02_L00:
       vmovups   xmm0,[rcx+rax]
       vpcmpnequb k1,xmm0,[rdx+rax]
       kortestw  k1,k1
       jne       short M02_L02
       add       rax,10
       cmp       r8,rax
       ja        short M02_L00
M02_L01:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jb        near ptr M02_L10
M02_L02:
       xor       eax,eax
       vzeroupper
       ret
M02_L03:
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L15
M02_L04:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L06
M02_L05:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       jne       short M02_L02
       add       rax,20
       cmp       r8,rax
       ja        short M02_L05
M02_L06:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       jae       short M02_L02
       jmp       short M02_L10
M02_L07:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFC0
       je        short M02_L09
M02_L08:
       vmovups   zmm0,[rcx+rax]
       vpcmpnequb k1,zmm0,[rdx+rax]
       kortestq  k1,k1
       jne       short M02_L02
       add       rax,40
       cmp       r8,rax
       ja        short M02_L08
M02_L09:
       vmovups   zmm0,[rcx+r8]
       vpcmpeqb  k1,zmm0,[rdx+r8]
       kortestq  k1,k1
       jae       near ptr M02_L02
M02_L10:
       mov       eax,1
       vzeroupper
       ret
M02_L11:
       cmp       r8,4
       jae       short M02_L14
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L12
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L12:
       test      r8b,1
       je        short M02_L13
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M02_L13:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L15
M02_L14:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M02_L15:
       vzeroupper
       ret
; Total bytes of code 358
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE9740EC10]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
M01_L01:
       ret
; Total bytes of code 20
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+18]
       call      qword ptr [7FFE9741EC28]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L05
       test      rcx,rcx
       je        short M01_L00
       test      rdx,rdx
       je        short M01_L00
       mov       eax,[rcx+8]
       cmp       eax,[rdx+8]
       je        short M01_L02
M01_L00:
       xor       eax,eax
M01_L01:
       add       rsp,28
       ret
M01_L02:
       lea       rax,[rcx+0C]
       add       rdx,0C
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       je        short M01_L03
       mov       rcx,rax
       call      qword ptr [7FFE9705C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       r8,[rdx]
       xor       rcx,r8
       xor       rax,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L04:
       jmp       short M01_L01
M01_L05:
       mov       eax,1
       jmp       short M01_L01
; Total bytes of code 102
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L06
       cmp       rcx,rdx
       je        short M02_L04
       cmp       r8,10
       jae       short M02_L01
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L00:
       ret
M02_L01:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L03
M02_L02:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
       add       rax,10
       cmp       r8,rax
       ja        short M02_L02
M02_L03:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  eax,xmm0
       cmp       eax,0FFFF
       jne       short M02_L05
M02_L04:
       mov       eax,1
       ret
M02_L05:
       xor       eax,eax
       ret
M02_L06:
       cmp       r8,4
       jb        short M02_L07
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L00
M02_L07:
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L08
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L08:
       test      r8b,1
       jne       short M02_L10
M02_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L00
M02_L10:
       movzx     ecx,byte ptr [rcx+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        eax,ecx
       jmp       short M02_L09
; Total bytes of code 210
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLength()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE973EEC10]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLength(System.String)
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 11
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithChar()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE9741EC28]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 77
```
```assembly
; JitFoldProof.Subjects.StartsWithChar(System.String)
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 12
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithText()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE9740EB50]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 77
```
```assembly
; JitFoldProof.Subjects.StartsWithText(System.String)
       cmp       dword ptr [rcx+8],0
       jg        short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
M01_L01:
       ret
; Total bytes of code 22
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L02
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L02:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFCAFC60]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
       jmp       short M00_L01
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EqualsLiteral(System.String)
       cmp       rcx,2C56400
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0E
       je        short M01_L01
M01_L00:
       xor       eax,eax
       jmp       short M01_L03
M01_L01:
       vmovups   xmm0,[rcx+0C]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFEAF968C90]
       vpternlogq xmm0,xmm1,[7FFEAF968CA0],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L03
M01_L02:
       mov       eax,1
M01_L03:
       ret
; Total bytes of code 72
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L02
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L02:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFEAFC7FC48]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
       jmp       short M00_L01
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L03
       test      rdx,rdx
       je        short M01_L03
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M01_L03
       add       rcx,0C
       add       rdx,0C
       add       r8d,r8d
       cmp       r8,0A
       je        short M01_L00
       call      qword ptr [7FFEAF89C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
M01_L00:
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[rdx]
       xor       rax,r8
       xor       rcx,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L01:
       add       rsp,28
       ret
M01_L02:
       mov       eax,1
       jmp       short M01_L01
M01_L03:
       xor       eax,eax
       jmp       short M01_L01
; Total bytes of code 96
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L03
       cmp       rcx,rdx
       je        near ptr M02_L15
       cmp       r8,40
       jae       near ptr M02_L08
       cmp       r8,20
       jae       near ptr M02_L11
       cmp       r8,10
       jb        near ptr M02_L16
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L01
       vmovups   xmm0,[rcx]
       vpcmpnequb k1,xmm0,[rdx]
       kortestw  k1,k1
       jne       short M02_L02
M02_L00:
       add       rax,10
       cmp       r8,rax
       ja        near ptr M02_L14
M02_L01:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jb        near ptr M02_L15
M02_L02:
       xor       eax,eax
       vzeroupper
       ret
M02_L03:
       cmp       r8,4
       jae       short M02_L06
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L04
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L04:
       test      r8b,1
       je        short M02_L05
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M02_L05:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L07
M02_L06:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M02_L07:
       vzeroupper
       ret
M02_L08:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFC0
       je        short M02_L10
M02_L09:
       vmovups   zmm0,[rcx+rax]
       vpcmpnequb k1,zmm0,[rdx+rax]
       kortestq  k1,k1
       jne       short M02_L02
       add       rax,40
       cmp       r8,rax
       ja        short M02_L09
M02_L10:
       vmovups   zmm0,[rcx+r8]
       vpcmpeqb  k1,zmm0,[rdx+r8]
       kortestq  k1,k1
       jae       near ptr M02_L02
       jmp       short M02_L15
M02_L11:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L13
M02_L12:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       jne       near ptr M02_L02
       add       rax,20
       cmp       r8,rax
       ja        short M02_L12
M02_L13:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       jae       near ptr M02_L02
       jmp       short M02_L15
M02_L14:
       vmovups   xmm0,[rcx+rax]
       vpcmpnequb k1,xmm0,[rdx+rax]
       kortestw  k1,k1
       jne       near ptr M02_L02
       jmp       near ptr M02_L00
M02_L15:
       mov       eax,1
       vzeroupper
       ret
M02_L16:
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L07
; Total bytes of code 402
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L02
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L02:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC9FC60]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
       jmp       short M00_L01
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       cmp       rcx,2E90008
       je        short M01_L01
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       jmp       short M01_L02
M01_L00:
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
       jmp       short M01_L02
M01_L01:
       mov       eax,1
M01_L02:
       ret
; Total bytes of code 36
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L02
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L02:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+18]
       call      qword ptr [7FFEAFC6FC60]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
       jmp       short M00_L01
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L00
       test      rdx,rdx
       je        short M01_L00
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       je        short M01_L03
M01_L00:
       xor       eax,eax
M01_L01:
       add       rsp,28
       ret
M01_L02:
       mov       eax,1
       jmp       short M01_L01
M01_L03:
       lea       rax,[rcx+0C]
       add       rdx,0C
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       jne       short M01_L04
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       r8,[rdx]
       xor       rcx,r8
       xor       rax,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       short M01_L05
M01_L04:
       mov       rcx,rax
       call      qword ptr [7FFEAF88C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M01_L05:
       jmp       short M01_L01
; Total bytes of code 104
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L06
       cmp       rcx,rdx
       je        short M02_L04
       cmp       r8,10
       jae       short M02_L01
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L00:
       ret
M02_L01:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L03
       movups    xmm0,[rcx]
       movups    xmm1,[rdx]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
M02_L02:
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L03:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  eax,xmm0
       cmp       eax,0FFFF
       jne       short M02_L05
M02_L04:
       mov       eax,1
       ret
M02_L05:
       xor       eax,eax
       ret
M02_L06:
       cmp       r8,4
       jb        short M02_L07
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L00
M02_L07:
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L08
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L08:
       test      r8b,1
       je        short M02_L09
       movzx     ecx,byte ptr [rcx+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        eax,ecx
M02_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L00
M02_L10:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
       jmp       near ptr M02_L02
; Total bytes of code 237
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLength()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L02
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L02:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC6FC60]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
       jmp       short M00_L01
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLength(System.String)
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 11
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithChar()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L03
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       esi
M00_L02:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L03:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC6FB88]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       je        short M00_L02
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.StartsWithChar(System.String)
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 12
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithText()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L03
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       esi
M00_L02:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L03:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC7FB88]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       je        short M00_L02
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.StartsWithText(System.String)
       cmp       dword ptr [rcx+8],0
       jg        short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
M01_L01:
       ret
; Total bytes of code 22
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE6DE4E8E0]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.EqualsLiteral(System.String)
       vzeroupper
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0E
       jne       short M01_L00
       vmovups   xmm0,[rcx+0C]
       vpxor     xmm0,xmm0,[7FFE6DA57740]
       vmovups   xmm1,[rcx+18]
       vpternlogq xmm0,xmm1,[7FFE6DA57750],0F6
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 59
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       edx,edi
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE6DE3E8F8]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 85
```
```assembly
; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L01
       test      rcx,rcx
       je        short M01_L02
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M01_L02
       add       rcx,0C
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFE6DAC5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       xor       eax,eax
       jmp       short M01_L00
; Total bytes of code 63
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       cmp       r8,8
       jae       short M02_L03
       cmp       r8,4
       jae       short M02_L02
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L00
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L00:
       test      r8b,1
       je        short M02_L01
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        r8d,eax
       mov       eax,r8d
M02_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L02:
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L03:
       cmp       rcx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L04:
       vzeroupper
       ret
M02_L05:
       mov       eax,1
       vzeroupper
       ret
M02_L06:
       cmp       r8,40
       jb        short M02_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFC0
       je        short M02_L08
M02_L07:
       vmovups   zmm0,[rcx+rax]
       vpcmpnequb k1,zmm0,[rdx+rax]
       kortestq  k1,k1
       nop       dword ptr [rax]
       jne       near ptr M02_L16
       add       rax,40
       cmp       r8,rax
       ja        short M02_L07
M02_L08:
       vmovups   zmm0,[rcx+r8]
       vpcmpeqb  k1,zmm0,[rdx+r8]
       kortestq  k1,k1
       nop       dword ptr [rax]
       jae       near ptr M02_L16
       jmp       short M02_L05
M02_L09:
       cmp       r8,20
       jb        short M02_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L11
M02_L10:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       nop       dword ptr [rax]
       jne       near ptr M02_L16
       add       rax,20
       cmp       r8,rax
       ja        short M02_L10
M02_L11:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       nop       dword ptr [rax]
       jae       short M02_L16
       jmp       near ptr M02_L05
       nop       dword ptr [rax+rax]
       nop       dword ptr [rax+rax]
M02_L12:
       cmp       r8,10
       jb        short M02_L15
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L14
M02_L13:
       vmovups   xmm0,[rcx+rax]
       vpcmpnequb k1,xmm0,[rdx+rax]
       kortestw  k1,k1
       jne       short M02_L16
       add       rax,10
       cmp       r8,rax
       ja        short M02_L13
M02_L14:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jae       short M02_L16
       jmp       near ptr M02_L05
M02_L15:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
M02_L16:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 394
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE6DE4E910]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      rcx,rcx
       je        short M01_L00
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 19
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       edx,edi
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,[rbx+18]
       call      qword ptr [7FFE6DE6E118]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 85
```
```assembly
; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L00
       test      rdx,rdx
       je        short M01_L00
       mov       eax,[rcx+8]
       cmp       eax,[rdx+8]
       je        short M01_L03
M01_L00:
       xor       eax,eax
M01_L01:
       add       rsp,28
       ret
M01_L02:
       mov       eax,1
       jmp       short M01_L01
M01_L03:
       lea       rax,[rcx+0C]
       mov       r8d,[rcx+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,rax
       call      qword ptr [7FFE6DAF5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
; Total bytes of code 67
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jae       short M02_L03
       cmp       r8,4
       jae       short M02_L02
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L00
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L00:
       test      r8b,1
       je        short M02_L01
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        r8d,eax
       mov       eax,r8d
M02_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L02:
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L03:
       cmp       rcx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L04:
       ret
M02_L05:
       mov       eax,1
       ret
M02_L06:
       cmp       r8,10
       jb        short M02_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L08
M02_L07:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L10
       add       rax,10
       cmp       r8,rax
       ja        short M02_L07
M02_L08:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M02_L10
       jmp       short M02_L05
M02_L09:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L10:
       xor       eax,eax
       ret
; Total bytes of code 217
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLength()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE6DE6E940]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.EmptyByLength(System.String)
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       ret
; Total bytes of code 10
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithChar()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE6DE4E478]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.StartsWithChar(System.String)
       xor       eax,eax
       cmp       word ptr [rcx+0C],63
       sete      al
       ret
; Total bytes of code 11
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithText()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE6DE7E970]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.StartsWithText(System.String)
       cmp       dword ptr [rcx+8],0
       jle       short M01_L00
       xor       eax,eax
       cmp       word ptr [rcx+0C],63
       sete      al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 21
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE972CEC28]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0E
       je        short M01_L02
M01_L00:
       xor       eax,eax
M01_L01:
       ret
M01_L02:
       vmovups   xmm0,[rcx+0C]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE96FB8D20]
       vpternlogq xmm0,xmm1,[7FFE96FB8D30],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 56
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE973EEB50]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L03
       test      rcx,rcx
       je        short M01_L02
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M01_L02
       add       rcx,0C
       add       rdx,0C
       add       r8d,r8d
       cmp       r8,0A
       je        short M01_L00
       call      qword ptr [7FFE9702C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
M01_L00:
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[rdx]
       xor       rax,r8
       xor       rcx,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L01:
       add       rsp,28
       ret
M01_L02:
       xor       eax,eax
       jmp       short M01_L01
M01_L03:
       mov       eax,1
       jmp       short M01_L01
; Total bytes of code 96
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        near ptr M02_L11
       cmp       rcx,rdx
       je        near ptr M02_L10
       cmp       r8,40
       jae       near ptr M02_L07
       cmp       r8,20
       jae       short M02_L04
       cmp       r8,10
       jb        short M02_L03
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L01
M02_L00:
       vmovups   xmm0,[rcx+rax]
       vpcmpnequb k1,xmm0,[rdx+rax]
       kortestw  k1,k1
       jne       short M02_L02
       add       rax,10
       cmp       r8,rax
       ja        short M02_L00
M02_L01:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jb        near ptr M02_L10
M02_L02:
       xor       eax,eax
       vzeroupper
       ret
M02_L03:
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L15
M02_L04:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L06
M02_L05:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       jne       short M02_L02
       add       rax,20
       cmp       r8,rax
       ja        short M02_L05
M02_L06:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       jae       short M02_L02
       jmp       short M02_L10
M02_L07:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFC0
       je        short M02_L09
M02_L08:
       vmovups   zmm0,[rcx+rax]
       vpcmpnequb k1,zmm0,[rdx+rax]
       kortestq  k1,k1
       jne       short M02_L02
       add       rax,40
       cmp       r8,rax
       ja        short M02_L08
M02_L09:
       vmovups   zmm0,[rcx+r8]
       vpcmpeqb  k1,zmm0,[rdx+r8]
       kortestq  k1,k1
       jae       near ptr M02_L02
M02_L10:
       mov       eax,1
       vzeroupper
       ret
M02_L11:
       cmp       r8,4
       jae       short M02_L14
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L12
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L12:
       test      r8b,1
       je        short M02_L13
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M02_L13:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L15
M02_L14:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M02_L15:
       vzeroupper
       ret
; Total bytes of code 358
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE9741EC28]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
M01_L01:
       ret
; Total bytes of code 20
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+18]
       call      qword ptr [7FFE9741EC28]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L05
       test      rcx,rcx
       je        short M01_L00
       test      rdx,rdx
       je        short M01_L00
       mov       eax,[rcx+8]
       cmp       eax,[rdx+8]
       je        short M01_L02
M01_L00:
       xor       eax,eax
M01_L01:
       add       rsp,28
       ret
M01_L02:
       lea       rax,[rcx+0C]
       add       rdx,0C
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       je        short M01_L03
       mov       rcx,rax
       call      qword ptr [7FFE9705C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       r8,[rdx]
       xor       rcx,r8
       xor       rax,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L04:
       jmp       short M01_L01
M01_L05:
       mov       eax,1
       jmp       short M01_L01
; Total bytes of code 102
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L06
       cmp       rcx,rdx
       je        short M02_L04
       cmp       r8,10
       jae       short M02_L01
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L00:
       ret
M02_L01:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L03
M02_L02:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
       add       rax,10
       cmp       r8,rax
       ja        short M02_L02
M02_L03:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  eax,xmm0
       cmp       eax,0FFFF
       jne       short M02_L05
M02_L04:
       mov       eax,1
       ret
M02_L05:
       xor       eax,eax
       ret
M02_L06:
       cmp       r8,4
       jb        short M02_L07
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L00
M02_L07:
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L08
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L08:
       test      r8b,1
       jne       short M02_L10
M02_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L00
M02_L10:
       movzx     ecx,byte ptr [rcx+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        eax,ecx
       jmp       short M02_L09
; Total bytes of code 210
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLength()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE973EEB50]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLength(System.String)
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 11
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithChar()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE973FEC28]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 77
```
```assembly
; JitFoldProof.Subjects.StartsWithChar(System.String)
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 12
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithText()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE9740EB50]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 77
```
```assembly
; JitFoldProof.Subjects.StartsWithText(System.String)
       cmp       dword ptr [rcx+8],0
       jg        short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
M01_L01:
       ret
; Total bytes of code 22
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L02
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L02:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC8FC78]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
       jmp       short M00_L01
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EqualsLiteral(System.String)
       cmp       rcx,2CC6400
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0E
       je        short M01_L01
M01_L00:
       xor       eax,eax
       jmp       short M01_L03
M01_L01:
       vmovups   xmm0,[rcx+0C]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFEAF948C10]
       vpternlogq xmm0,xmm1,[7FFEAF948C20],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L03
M01_L02:
       mov       eax,1
M01_L03:
       ret
; Total bytes of code 72
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L02
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L02:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFEAFC9FBA0]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
       jmp       short M00_L01
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L03
       test      rdx,rdx
       je        short M01_L03
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M01_L03
       add       rcx,0C
       add       rdx,0C
       add       r8d,r8d
       cmp       r8,0A
       je        short M01_L00
       call      qword ptr [7FFEAF8BC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
M01_L00:
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[rdx]
       xor       rax,r8
       xor       rcx,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L01:
       add       rsp,28
       ret
M01_L02:
       mov       eax,1
       jmp       short M01_L01
M01_L03:
       xor       eax,eax
       jmp       short M01_L01
; Total bytes of code 96
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L03
       cmp       rcx,rdx
       je        near ptr M02_L15
       cmp       r8,40
       jae       near ptr M02_L08
       cmp       r8,20
       jae       near ptr M02_L11
       cmp       r8,10
       jb        near ptr M02_L16
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L01
       vmovups   xmm0,[rcx]
       vpcmpnequb k1,xmm0,[rdx]
       kortestw  k1,k1
       jne       short M02_L02
M02_L00:
       add       rax,10
       cmp       r8,rax
       ja        near ptr M02_L14
M02_L01:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jb        near ptr M02_L15
M02_L02:
       xor       eax,eax
       vzeroupper
       ret
M02_L03:
       cmp       r8,4
       jae       short M02_L06
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L04
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L04:
       test      r8b,1
       je        short M02_L05
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M02_L05:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L07
M02_L06:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M02_L07:
       vzeroupper
       ret
M02_L08:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFC0
       je        short M02_L10
M02_L09:
       vmovups   zmm0,[rcx+rax]
       vpcmpnequb k1,zmm0,[rdx+rax]
       kortestq  k1,k1
       jne       short M02_L02
       add       rax,40
       cmp       r8,rax
       ja        short M02_L09
M02_L10:
       vmovups   zmm0,[rcx+r8]
       vpcmpeqb  k1,zmm0,[rdx+r8]
       kortestq  k1,k1
       jae       near ptr M02_L02
       jmp       short M02_L15
M02_L11:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L13
M02_L12:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       jne       near ptr M02_L02
       add       rax,20
       cmp       r8,rax
       ja        short M02_L12
M02_L13:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       jae       near ptr M02_L02
       jmp       short M02_L15
M02_L14:
       vmovups   xmm0,[rcx+rax]
       vpcmpnequb k1,xmm0,[rdx+rax]
       kortestw  k1,k1
       jne       near ptr M02_L02
       jmp       near ptr M02_L00
M02_L15:
       mov       eax,1
       vzeroupper
       ret
M02_L16:
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L07
; Total bytes of code 402
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L02
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L02:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC8FC78]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
       jmp       short M00_L01
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       cmp       rcx,2E10008
       je        short M01_L01
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       jmp       short M01_L02
M01_L00:
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
       jmp       short M01_L02
M01_L01:
       mov       eax,1
M01_L02:
       ret
; Total bytes of code 36
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L02
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L02:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+18]
       call      qword ptr [7FFEAFC7FBA0]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
       jmp       short M00_L01
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L00
       test      rdx,rdx
       je        short M01_L00
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       je        short M01_L03
M01_L00:
       xor       eax,eax
M01_L01:
       add       rsp,28
       ret
M01_L02:
       mov       eax,1
       jmp       short M01_L01
M01_L03:
       lea       rax,[rcx+0C]
       add       rdx,0C
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       jne       short M01_L04
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       r8,[rdx]
       xor       rcx,r8
       xor       rax,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       short M01_L05
M01_L04:
       mov       rcx,rax
       call      qword ptr [7FFEAF89C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M01_L05:
       jmp       short M01_L01
; Total bytes of code 104
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L06
       cmp       rcx,rdx
       je        short M02_L04
       cmp       r8,10
       jae       short M02_L01
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L00:
       ret
M02_L01:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L03
       movups    xmm0,[rcx]
       movups    xmm1,[rdx]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
M02_L02:
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L03:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  eax,xmm0
       cmp       eax,0FFFF
       jne       short M02_L05
M02_L04:
       mov       eax,1
       ret
M02_L05:
       xor       eax,eax
       ret
M02_L06:
       cmp       r8,4
       jb        short M02_L07
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L00
M02_L07:
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L08
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L08:
       test      r8b,1
       je        short M02_L09
       movzx     ecx,byte ptr [rcx+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        eax,ecx
M02_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L00
M02_L10:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
       jmp       near ptr M02_L02
; Total bytes of code 237
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLength()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L02
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L02:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC7FC78]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
       jmp       short M00_L01
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLength(System.String)
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 11
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithChar()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L03
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       esi
M00_L02:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L03:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC7FBA0]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       je        short M00_L02
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.StartsWithChar(System.String)
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 12
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithText()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jg        short M00_L03
M00_L00:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       inc       esi
M00_L02:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jle       short M00_L00
M00_L03:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFEAFC6FBA0]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       je        short M00_L02
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.StartsWithText(System.String)
       cmp       dword ptr [rcx+8],0
       jg        short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
M01_L01:
       ret
; Total bytes of code 22
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE6DE4ED90]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.EqualsLiteral(System.String)
       vzeroupper
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0E
       jne       short M01_L00
       vmovups   xmm0,[rcx+0C]
       vpxor     xmm0,xmm0,[7FFE6DA57780]
       vmovups   xmm1,[rcx+18]
       vpternlogq xmm0,xmm1,[7FFE6DA57790],0F6
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 59
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       edx,edi
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE6DE5EDA8]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 85
```
```assembly
; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L01
       test      rcx,rcx
       je        short M01_L02
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M01_L02
       add       rcx,0C
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFE6DAE5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       xor       eax,eax
       jmp       short M01_L00
; Total bytes of code 63
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       cmp       r8,8
       jae       short M02_L03
       cmp       r8,4
       jae       short M02_L02
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L00
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L00:
       test      r8b,1
       je        short M02_L01
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        r8d,eax
       mov       eax,r8d
M02_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L02:
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L03:
       cmp       rcx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L04:
       vzeroupper
       ret
M02_L05:
       mov       eax,1
       vzeroupper
       ret
M02_L06:
       cmp       r8,40
       jb        short M02_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFC0
       je        short M02_L08
M02_L07:
       vmovups   zmm0,[rcx+rax]
       vpcmpnequb k1,zmm0,[rdx+rax]
       kortestq  k1,k1
       nop       dword ptr [rax]
       jne       near ptr M02_L16
       add       rax,40
       cmp       r8,rax
       ja        short M02_L07
M02_L08:
       vmovups   zmm0,[rcx+r8]
       vpcmpeqb  k1,zmm0,[rdx+r8]
       kortestq  k1,k1
       nop       dword ptr [rax]
       jae       near ptr M02_L16
       jmp       short M02_L05
M02_L09:
       cmp       r8,20
       jb        short M02_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L11
M02_L10:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       nop       dword ptr [rax]
       jne       near ptr M02_L16
       add       rax,20
       cmp       r8,rax
       ja        short M02_L10
M02_L11:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       nop       dword ptr [rax]
       jae       short M02_L16
       jmp       near ptr M02_L05
       nop       dword ptr [rax+rax]
       nop       dword ptr [rax+rax]
M02_L12:
       cmp       r8,10
       jb        short M02_L15
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L14
M02_L13:
       vmovups   xmm0,[rcx+rax]
       vpcmpnequb k1,xmm0,[rdx+rax]
       kortestw  k1,k1
       jne       short M02_L16
       add       rax,10
       cmp       r8,rax
       ja        short M02_L13
M02_L14:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jae       short M02_L16
       jmp       near ptr M02_L05
M02_L15:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
M02_L16:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 394
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE6DE6E910]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      rcx,rcx
       je        short M01_L00
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 19
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       edx,edi
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,[rbx+18]
       call      qword ptr [7FFE6DE7E928]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 85
```
```assembly
; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L02
       test      rcx,rcx
       je        short M01_L00
       test      rdx,rdx
       je        short M01_L00
       mov       eax,[rcx+8]
       cmp       eax,[rdx+8]
       je        short M01_L03
M01_L00:
       xor       eax,eax
M01_L01:
       add       rsp,28
       ret
M01_L02:
       mov       eax,1
       jmp       short M01_L01
M01_L03:
       lea       rax,[rcx+0C]
       mov       r8d,[rcx+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,rax
       call      qword ptr [7FFE6DB05068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
; Total bytes of code 67
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jae       short M02_L03
       cmp       r8,4
       jae       short M02_L02
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L00
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L00:
       test      r8b,1
       je        short M02_L01
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        r8d,eax
       mov       eax,r8d
M02_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L02:
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L03:
       cmp       rcx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L04:
       ret
M02_L05:
       mov       eax,1
       ret
M02_L06:
       cmp       r8,10
       jb        short M02_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L08
M02_L07:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L10
       add       rax,10
       cmp       r8,rax
       ja        short M02_L07
M02_L08:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M02_L10
       jmp       short M02_L05
M02_L09:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       short M02_L04
M02_L10:
       xor       eax,eax
       ret
; Total bytes of code 217
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLength()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE6DE4EDF0]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; JitFoldProof.Subjects.EmptyByLength(System.String)
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       ret
; Total bytes of code 10
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithChar()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE6DE4E958]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.StartsWithChar(System.String)
       xor       eax,eax
       cmp       word ptr [rcx+0C],63
       sete      al
       ret
; Total bytes of code 11
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithText()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE6DE7E970]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.StartsWithText(System.String)
       cmp       dword ptr [rcx+8],0
       jle       short M01_L00
       xor       eax,eax
       cmp       word ptr [rcx+0C],63
       sete      al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 21
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE6DD7EC40]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0E
       je        short M01_L02
M01_L00:
       xor       eax,eax
M01_L01:
       ret
M01_L02:
       vmovups   xmm0,[rcx+0C]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE6DA68C70]
       vpternlogq xmm0,xmm1,[7FFE6DA68C80],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 56
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EqualsOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE9734EB68]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L03
       test      rcx,rcx
       je        short M01_L02
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M01_L02
       add       rcx,0C
       add       rdx,0C
       add       r8d,r8d
       cmp       r8,0A
       je        short M01_L00
       call      qword ptr [7FFE96F8C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
M01_L00:
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[rdx]
       xor       rax,r8
       xor       rcx,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L01:
       add       rsp,28
       ret
M01_L02:
       xor       eax,eax
       jmp       short M01_L01
M01_L03:
       mov       eax,1
       jmp       short M01_L01
; Total bytes of code 96
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        near ptr M02_L11
       cmp       rcx,rdx
       je        near ptr M02_L10
       cmp       r8,40
       jae       near ptr M02_L07
       cmp       r8,20
       jae       short M02_L04
       cmp       r8,10
       jb        short M02_L03
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L01
M02_L00:
       vmovups   xmm0,[rcx+rax]
       vpcmpnequb k1,xmm0,[rdx+rax]
       kortestw  k1,k1
       jne       short M02_L02
       add       rax,10
       cmp       r8,rax
       ja        short M02_L00
M02_L01:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jb        near ptr M02_L10
M02_L02:
       xor       eax,eax
       vzeroupper
       ret
M02_L03:
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L15
M02_L04:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L06
M02_L05:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       jne       short M02_L02
       add       rax,20
       cmp       r8,rax
       ja        short M02_L05
M02_L06:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       jae       short M02_L02
       jmp       short M02_L10
M02_L07:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFC0
       je        short M02_L09
M02_L08:
       vmovups   zmm0,[rcx+rax]
       vpcmpnequb k1,zmm0,[rdx+rax]
       kortestq  k1,k1
       jne       short M02_L02
       add       rax,40
       cmp       r8,rax
       ja        short M02_L08
M02_L09:
       vmovups   zmm0,[rcx+r8]
       vpcmpeqb  k1,zmm0,[rdx+r8]
       kortestq  k1,k1
       jae       near ptr M02_L02
M02_L10:
       mov       eax,1
       vzeroupper
       ret
M02_L11:
       cmp       r8,4
       jae       short M02_L14
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L12
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L12:
       test      r8b,1
       je        short M02_L13
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M02_L13:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L15
M02_L14:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M02_L15:
       vzeroupper
       ret
; Total bytes of code 358
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLiteral()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE9741EB68]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
M01_L01:
       ret
; Total bytes of code 20
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByOpaque()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       mov       rdx,[rbx+18]
       call      qword ptr [7FFE973FEC40]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M01_L05
       test      rcx,rcx
       je        short M01_L00
       test      rdx,rdx
       je        short M01_L00
       mov       eax,[rcx+8]
       cmp       eax,[rdx+8]
       je        short M01_L02
M01_L00:
       xor       eax,eax
M01_L01:
       add       rsp,28
       ret
M01_L02:
       lea       rax,[rcx+0C]
       add       rdx,0C
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       je        short M01_L03
       mov       rcx,rax
       call      qword ptr [7FFE9703C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       r8,[rdx]
       xor       rcx,r8
       xor       rax,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L04:
       jmp       short M01_L01
M01_L05:
       mov       eax,1
       jmp       short M01_L01
; Total bytes of code 102
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L06
       cmp       rcx,rdx
       je        short M02_L04
       cmp       r8,10
       jae       short M02_L01
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L00:
       ret
M02_L01:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L03
M02_L02:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
       add       rax,10
       cmp       r8,rax
       ja        short M02_L02
M02_L03:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  eax,xmm0
       cmp       eax,0FFFF
       jne       short M02_L05
M02_L04:
       mov       eax,1
       ret
M02_L05:
       xor       eax,eax
       ret
M02_L06:
       cmp       r8,4
       jb        short M02_L07
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L00
M02_L07:
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L08
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L08:
       test      r8b,1
       jne       short M02_L10
M02_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L00
M02_L10:
       movzx     ecx,byte ptr [rcx+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        eax,ecx
       jmp       short M02_L09
; Total bytes of code 210
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.EmptyByLength()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L04
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE973FEB68]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       inc       esi
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```
```assembly
; JitFoldProof.Subjects.EmptyByLength(System.String)
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 11
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithChar()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE973EEC40]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 77
```
```assembly
; JitFoldProof.Subjects.StartsWithChar(System.String)
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 12
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.ConstantBench.StartsWithText()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L02
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L03
       mov       rcx,[rcx+rdi*8+10]
       call      qword ptr [7FFE973FEC40]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       je        short M00_L01
       inc       esi
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 77
```
```assembly
; JitFoldProof.Subjects.StartsWithText(System.String)
       cmp       dword ptr [rcx+8],0
       jg        short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       cmp       word ptr [rcx+0C],63
       sete      al
       movzx     eax,al
M01_L01:
       ret
; Total bytes of code 22
```

