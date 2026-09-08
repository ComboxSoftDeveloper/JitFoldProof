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
       call      qword ptr [7FFDF2A7FA50]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       mov       rax,2E036426348
       cmp       rcx,rax
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
       vpxor     xmm1,xmm1,[7FFDF2739960]
       vpternlogq xmm0,xmm1,[7FFDF2739970],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L03
M01_L02:
       mov       eax,1
M01_L03:
       ret
; Total bytes of code 78
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
       call      qword ptr [7FFDF2A4FA68]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFDF266C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       je        near ptr M02_L12
       cmp       r8,20
       jae       near ptr M02_L07
       cmp       r8,10
       jb        near ptr M02_L13
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        near ptr M02_L11
M02_L00:
       vmovups   xmm0,[rcx+rax]
       vpcmpnequb k1,xmm0,[rdx+rax]
       kortestw  k1,k1
       je        near ptr M02_L10
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
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L09
M02_L08:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       jne       short M02_L01
       add       rax,20
       cmp       r8,rax
       ja        short M02_L08
M02_L09:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       jae       near ptr M02_L01
       jmp       short M02_L12
M02_L10:
       add       rax,10
       cmp       r8,rax
       ja        near ptr M02_L00
M02_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jae       near ptr M02_L01
M02_L12:
       mov       eax,1
       vzeroupper
       ret
M02_L13:
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L06
; Total bytes of code 304
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
       call      qword ptr [7FFDF2A4F990]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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
       mov       rax,29F140A0008
       cmp       rcx,rax
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
; Total bytes of code 42
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
       call      qword ptr [7FFDF2A7F990]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFDF269C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDF2A6FA50]; JitFoldProof.Subjects.EmptyByLength(System.String)
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
       call      qword ptr [7FFDF2A6F990]; JitFoldProof.Subjects.StartsWithChar(System.String)
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
       call      qword ptr [7FFDF2A6F990]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E8E8E0]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       vpxor     xmm0,xmm0,[7FFDC8A984C0]
       vmovups   xmm1,[rcx+18]
       vpternlogq xmm0,xmm1,[7FFDC8A984D0],0F6
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E8E8F8]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFDC8B15068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       cmp       r8,20
       jb        short M02_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L08
M02_L07:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       nop       dword ptr [rax]
       jne       near ptr M02_L13
       add       rax,20
       cmp       r8,rax
       ja        short M02_L07
M02_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       nop       dword ptr [rax]
       jae       short M02_L13
       jmp       short M02_L05
       xchg      ax,ax
M02_L09:
       cmp       r8,10
       jb        short M02_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L11
M02_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpnequb k1,xmm0,[rdx+rax]
       kortestw  k1,k1
       jne       short M02_L13
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jae       short M02_L13
       jmp       near ptr M02_L05
M02_L12:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
M02_L13:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 298
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E7E910]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E7E928]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFDC8B05068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E5E940]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E6E148]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E7E970]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD9033ECD0]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       vpxor     xmm1,xmm1,[7FFD90029A20]
       vpternlogq xmm0,xmm1,[7FFD90029A30],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 56
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD9035ECD0]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFD8FF9C180]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jb        near ptr M02_L09
       cmp       rcx,rdx
       je        near ptr M02_L08
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
       jmp       short M02_L08
M02_L04:
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L13
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
M02_L08:
       mov       eax,1
       vzeroupper
       ret
M02_L09:
       cmp       r8,4
       jae       short M02_L12
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L10
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L10:
       test      r8b,1
       je        short M02_L11
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M02_L11:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L13
M02_L12:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M02_L13:
       vzeroupper
       ret
; Total bytes of code 282
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD9034EBF8]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD9032ECD0]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFD8FF6C180]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD9032ECD0]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD9035ECD0]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD9035ECD0]; JitFoldProof.Subjects.StartsWithText(System.String)
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
       call      qword ptr [7FFDF2A5FA68]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       mov       rax,1EED3AC6348
       cmp       rcx,rax
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
       vpxor     xmm1,xmm1,[7FFDF2719AA0]
       vpternlogq xmm0,xmm1,[7FFDF2719AB0],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L03
M01_L02:
       mov       eax,1
M01_L03:
       ret
; Total bytes of code 78
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
       call      qword ptr [7FFDF2A6F990]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFDF268C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       je        near ptr M02_L12
       cmp       r8,20
       jae       near ptr M02_L07
       cmp       r8,10
       jb        near ptr M02_L13
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        near ptr M02_L11
M02_L00:
       vmovups   xmm0,[rcx+rax]
       vpcmpnequb k1,xmm0,[rdx+rax]
       kortestw  k1,k1
       je        near ptr M02_L10
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
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L09
M02_L08:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       jne       short M02_L01
       add       rax,20
       cmp       r8,rax
       ja        short M02_L08
M02_L09:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       jae       near ptr M02_L01
       jmp       short M02_L12
M02_L10:
       add       rax,10
       cmp       r8,rax
       ja        near ptr M02_L00
M02_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jae       near ptr M02_L01
M02_L12:
       mov       eax,1
       vzeroupper
       ret
M02_L13:
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L06
; Total bytes of code 304
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
       call      qword ptr [7FFDF2A5F990]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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
       mov       rax,21CFACF0008
       cmp       rcx,rax
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
; Total bytes of code 42
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
       call      qword ptr [7FFDF2A7FA68]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFDF269C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDF2A7F990]; JitFoldProof.Subjects.EmptyByLength(System.String)
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
       call      qword ptr [7FFDF2A7FA68]; JitFoldProof.Subjects.StartsWithChar(System.String)
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
       call      qword ptr [7FFDF2A5FA50]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E8E8E0]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       vpxor     xmm0,xmm0,[7FFDC8A98600]
       vmovups   xmm1,[rcx+18]
       vpternlogq xmm0,xmm1,[7FFDC8A98610],0F6
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E6E8F8]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFDC8AF5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       cmp       r8,20
       jb        short M02_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L08
M02_L07:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       nop       dword ptr [rax]
       jne       near ptr M02_L13
       add       rax,20
       cmp       r8,rax
       ja        short M02_L07
M02_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       nop       dword ptr [rax]
       jae       short M02_L13
       jmp       short M02_L05
       xchg      ax,ax
M02_L09:
       cmp       r8,10
       jb        short M02_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L11
M02_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpnequb k1,xmm0,[rdx+rax]
       kortestw  k1,k1
       jne       short M02_L13
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jae       short M02_L13
       jmp       near ptr M02_L05
M02_L12:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
M02_L13:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 298
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E8E100]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E6E928]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFDC8AF5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E8E940]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E7E148]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E6E970]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD9032ECD0]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       vpxor     xmm1,xmm1,[7FFD90019B60]
       vpternlogq xmm0,xmm1,[7FFD90019B70],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 56
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD9035ECD0]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFD8FF9C180]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jb        near ptr M02_L09
       cmp       rcx,rdx
       je        near ptr M02_L08
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
       jmp       short M02_L08
M02_L04:
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L13
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
M02_L08:
       mov       eax,1
       vzeroupper
       ret
M02_L09:
       cmp       r8,4
       jae       short M02_L12
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L10
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L10:
       test      r8b,1
       je        short M02_L11
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M02_L11:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L13
M02_L12:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M02_L13:
       vzeroupper
       ret
; Total bytes of code 282
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD9034ECB8]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD925AECD0]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFD921EC180]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD925BECB8]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD925BECB8]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD9259ECD0]; JitFoldProof.Subjects.StartsWithText(System.String)
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
       call      qword ptr [7FFDF2A6FA80]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       mov       rax,2A5ABB36348
       cmp       rcx,rax
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
       vpxor     xmm1,xmm1,[7FFDF2729A00]
       vpternlogq xmm0,xmm1,[7FFDF2729A10],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L03
M01_L02:
       mov       eax,1
M01_L03:
       ret
; Total bytes of code 78
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
       call      qword ptr [7FFDF2A4FA80]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFDF266C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       je        near ptr M02_L12
       cmp       r8,20
       jae       near ptr M02_L07
       cmp       r8,10
       jb        near ptr M02_L13
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        near ptr M02_L11
M02_L00:
       vmovups   xmm0,[rcx+rax]
       vpcmpnequb k1,xmm0,[rdx+rax]
       kortestw  k1,k1
       je        near ptr M02_L10
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
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L09
M02_L08:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       jne       short M02_L01
       add       rax,20
       cmp       r8,rax
       ja        short M02_L08
M02_L09:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       jae       near ptr M02_L01
       jmp       short M02_L12
M02_L10:
       add       rax,10
       cmp       r8,rax
       ja        near ptr M02_L00
M02_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jae       near ptr M02_L01
M02_L12:
       mov       eax,1
       vzeroupper
       ret
M02_L13:
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L06
; Total bytes of code 304
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
       call      qword ptr [7FFDF2A6FA80]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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
       mov       rax,1F54B120008
       cmp       rcx,rax
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
; Total bytes of code 42
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
       call      qword ptr [7FFDF2A5FA80]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFDF267C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDF2A7F9A8]; JitFoldProof.Subjects.EmptyByLength(System.String)
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
       call      qword ptr [7FFDF2A5FA80]; JitFoldProof.Subjects.StartsWithChar(System.String)
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
       call      qword ptr [7FFDF2A4FA68]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E8ED90]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       vpxor     xmm0,xmm0,[7FFDC8A98640]
       vmovups   xmm1,[rcx+18]
       vpternlogq xmm0,xmm1,[7FFDC8A98650],0F6
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E7E8F8]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFDC8B05068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       cmp       r8,20
       jb        short M02_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L08
M02_L07:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       nop       dword ptr [rax]
       jne       near ptr M02_L13
       add       rax,20
       cmp       r8,rax
       ja        short M02_L07
M02_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       nop       dword ptr [rax]
       jae       short M02_L13
       jmp       short M02_L05
       xchg      ax,ax
M02_L09:
       cmp       r8,10
       jb        short M02_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L11
M02_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpnequb k1,xmm0,[rdx+rax]
       kortestw  k1,k1
       jne       short M02_L13
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jae       short M02_L13
       jmp       near ptr M02_L05
M02_L12:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
M02_L13:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 298
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E9EDC0]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E8EDD8]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFDC8B15068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E9EDF0]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E5E958]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E5ECA0]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFDB503ECE8]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       vpxor     xmm1,xmm1,[7FFDB4D29AE0]
       vpternlogq xmm0,xmm1,[7FFDB4D29AF0],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 56
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFDB504EC10]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFDB4C8C180]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jb        near ptr M02_L09
       cmp       rcx,rdx
       je        near ptr M02_L08
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
       jmp       short M02_L08
M02_L04:
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L13
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
M02_L08:
       mov       eax,1
       vzeroupper
       ret
M02_L09:
       cmp       r8,4
       jae       short M02_L12
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L10
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L10:
       test      r8b,1
       je        short M02_L11
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M02_L11:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L13
M02_L12:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M02_L13:
       vzeroupper
       ret
; Total bytes of code 282
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFDB505ECE8]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFDB503EC10]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFDB4C7C180]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFDB504ECE8]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFDB505ECE8]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFDB504ECE8]; JitFoldProof.Subjects.StartsWithText(System.String)
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
       call      qword ptr [7FFDF2A7FA68]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       mov       rax,29C45426340
       cmp       rcx,rax
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
       vpxor     xmm1,xmm1,[7FFDF2739530]
       vpternlogq xmm0,xmm1,[7FFDF2739540],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L03
M01_L02:
       mov       eax,1
M01_L03:
       ret
; Total bytes of code 78
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
       call      qword ptr [7FFDF2A4FA68]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFDF266C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDF2A5F990]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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
       mov       rax,2A27D330008
       cmp       rcx,rax
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
; Total bytes of code 42
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
       call      qword ptr [7FFDF2A7F990]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFDF269C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDF2A4F990]; JitFoldProof.Subjects.EmptyByLength(System.String)
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
       call      qword ptr [7FFDF2A6FA68]; JitFoldProof.Subjects.StartsWithChar(System.String)
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
       call      qword ptr [7FFDF2A5FA68]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E6E0D0]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       vpxor     xmm0,xmm0,[7FFDC8A78220]
       vmovups   xmm1,[rcx+18]
       vpternlogq xmm0,xmm1,[7FFDC8A78230],0F6
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E7E8F8]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFDC8B05068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E7E100]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E8E928]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFDC8B15068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E9E940]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E8E958]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E8E970]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFDB503ECD0]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       vpxor     xmm1,xmm1,[7FFDB4D29630]
       vpternlogq xmm0,xmm1,[7FFDB4D29640],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 56
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFDB504ECB8]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFDB4C8C180]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFDB505ECD0]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFDB503EBF8]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFDB4C7C180]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFDB503ECD0]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFDB504ECD0]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFDB503ECD0]; JitFoldProof.Subjects.StartsWithText(System.String)
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
       call      qword ptr [7FFDF2A5FA68]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       mov       rax,2D8F5246340
       cmp       rcx,rax
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
       vpxor     xmm1,xmm1,[7FFDF2719670]
       vpternlogq xmm0,xmm1,[7FFDF2719680],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L03
M01_L02:
       mov       eax,1
M01_L03:
       ret
; Total bytes of code 78
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
       call      qword ptr [7FFDF2A5FA68]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFDF267C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDF2A6F990]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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
       mov       rax,277EB4F0008
       cmp       rcx,rax
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
; Total bytes of code 42
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
       call      qword ptr [7FFDF2A4FA50]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFDF266C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDF2A5FA68]; JitFoldProof.Subjects.EmptyByLength(System.String)
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
       call      qword ptr [7FFDF2A7FA68]; JitFoldProof.Subjects.StartsWithChar(System.String)
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
       call      qword ptr [7FFDF2A7FA68]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E6E8E0]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       vpxor     xmm0,xmm0,[7FFDC8A78170]
       vmovups   xmm1,[rcx+18]
       vpternlogq xmm0,xmm1,[7FFDC8A78180],0F6
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E7E418]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFDC8B05068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E8E910]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E7E118]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFDC8B05068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E8E940]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E5E148]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E6E160]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD9035ECB8]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       vpxor     xmm1,xmm1,[7FFD90049650]
       vpternlogq xmm0,xmm1,[7FFD90049660],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 56
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD9033ECD0]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFD8FF7C180]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD9035ECD0]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD9034ECD0]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFD8FF8C180]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD9034ECD0]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD9033ECD0]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD9035ECD0]; JitFoldProof.Subjects.StartsWithText(System.String)
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
       call      qword ptr [7FFDF2A7FA80]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       mov       rax,235DFFA6340
       cmp       rcx,rax
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
       vpxor     xmm1,xmm1,[7FFDF2739580]
       vpternlogq xmm0,xmm1,[7FFDF2739590],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L03
M01_L02:
       mov       eax,1
M01_L03:
       ret
; Total bytes of code 78
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
       call      qword ptr [7FFDF2A5FA80]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFDF267C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDF2A5FA80]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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
       mov       rax,2AC4E7E0008
       cmp       rcx,rax
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
; Total bytes of code 42
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
       call      qword ptr [7FFDF2A5F9A8]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFDF267C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDF2A7FA68]; JitFoldProof.Subjects.EmptyByLength(System.String)
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
       call      qword ptr [7FFDF2A6FA68]; JitFoldProof.Subjects.StartsWithChar(System.String)
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
       call      qword ptr [7FFDF2A5F9A8]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E6ED90]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       vpxor     xmm0,xmm0,[7FFDC8A782B0]
       vmovups   xmm1,[rcx+18]
       vpternlogq xmm0,xmm1,[7FFDC8A782C0],0F6
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E8EDA8]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFDC8B15068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E5EDC0]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E7EDD8]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFDC8B05068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E7EDF0]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E8EC88]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E6EE20]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFDB505EC10]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       vpxor     xmm1,xmm1,[7FFDB4D496A0]
       vpternlogq xmm0,xmm1,[7FFDB4D496B0],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 56
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFDB502EC10]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFDB4C6C180]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFDB502EC10]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFDB504ECB8]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFDB4C8C180]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFDB502EC10]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFDB502ECE8]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFDB502ECE8]; JitFoldProof.Subjects.StartsWithText(System.String)
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
       call      qword ptr [7FFDF2A6FA68]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       mov       rax,2B401E36320
       cmp       rcx,rax
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
       vpxor     xmm1,xmm1,[7FFDF2729970]
       vpternlogq xmm0,xmm1,[7FFDF2729980],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L03
M01_L02:
       mov       eax,1
M01_L03:
       ret
; Total bytes of code 78
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
       call      qword ptr [7FFDF2A7FA50]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFDF269C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       cmp       r8,20
       jae       near ptr M02_L08
       cmp       r8,10
       jb        near ptr M02_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L01
       vmovups   xmm0,[rcx]
       vpcmpnequb k1,xmm0,[rdx]
       kortestw  k1,k1
       jne       near ptr M02_L13
M02_L00:
       add       rax,10
       cmp       r8,rax
       ja        near ptr M02_L11
M02_L01:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jae       near ptr M02_L13
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
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L10
M02_L09:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       jne       short M02_L13
       add       rax,20
       cmp       r8,rax
       ja        short M02_L09
M02_L10:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       jae       short M02_L13
       jmp       near ptr M02_L02
M02_L11:
       vmovups   xmm0,[rcx+rax]
       vpcmpnequb k1,xmm0,[rdx+rax]
       kortestw  k1,k1
       jne       short M02_L13
       jmp       near ptr M02_L00
M02_L12:
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       short M02_L07
M02_L13:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 314
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
       call      qword ptr [7FFDF2A5FA50]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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
       mov       rax,31F63260008
       cmp       rcx,rax
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
; Total bytes of code 42
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
       call      qword ptr [7FFDF2A5FA68]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFDF267C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDF2A4FA68]; JitFoldProof.Subjects.EmptyByLength(System.String)
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
       call      qword ptr [7FFDF2A5FA50]; JitFoldProof.Subjects.StartsWithChar(System.String)
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
       call      qword ptr [7FFDF2A7F990]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E8E8E0]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       vpxor     xmm0,xmm0,[7FFDC8A984C0]
       vmovups   xmm1,[rcx+18]
       vpternlogq xmm0,xmm1,[7FFDC8A984D0],0F6
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E9E8F8]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFDC8B25068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       cmp       r8,20
       jb        short M02_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L08
M02_L07:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       nop       dword ptr [rax]
       jne       near ptr M02_L13
       add       rax,20
       cmp       r8,rax
       ja        short M02_L07
M02_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       nop       dword ptr [rax]
       jae       short M02_L13
       jmp       short M02_L05
       xchg      ax,ax
M02_L09:
       cmp       r8,10
       jb        short M02_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L11
M02_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpnequb k1,xmm0,[rdx+rax]
       kortestw  k1,k1
       jne       short M02_L13
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jae       short M02_L13
       jmp       near ptr M02_L05
M02_L12:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
M02_L13:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 298
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E6E100]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E5E928]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFDC8AE5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E5E940]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E7E958]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E9E970]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFDB503ECD0]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       vpxor     xmm1,xmm1,[7FFDB4D29A10]
       vpternlogq xmm0,xmm1,[7FFDB4D29A20],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 56
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFDB503EBF8]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFDB4C7C180]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jb        near ptr M02_L08
       cmp       rcx,rdx
       je        short M02_L02
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
       jne       near ptr M02_L07
       add       rax,10
       cmp       r8,rax
       ja        short M02_L00
M02_L01:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jae       short M02_L07
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
       jmp       near ptr M02_L12
M02_L04:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L06
M02_L05:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       jne       short M02_L07
       add       rax,20
       cmp       r8,rax
       ja        short M02_L05
M02_L06:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       jb        short M02_L02
M02_L07:
       xor       eax,eax
       vzeroupper
       ret
M02_L08:
       cmp       r8,4
       jae       short M02_L11
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L09
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L09:
       test      r8b,1
       je        short M02_L10
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M02_L10:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L12
M02_L11:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M02_L12:
       vzeroupper
       ret
; Total bytes of code 278
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFDB502EBF8]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFDB505ECD0]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFDB4C9C180]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFDB502EBF8]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFDB503EBF8]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFDB505ECD0]; JitFoldProof.Subjects.StartsWithText(System.String)
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
       call      qword ptr [7FFDF2A7F990]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       mov       rax,1E280466320
       cmp       rcx,rax
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
       vpxor     xmm1,xmm1,[7FFDF2739A10]
       vpternlogq xmm0,xmm1,[7FFDF2739A20],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L03
M01_L02:
       mov       eax,1
M01_L03:
       ret
; Total bytes of code 78
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
       call      qword ptr [7FFDF2A5FA68]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFDF267C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       cmp       r8,20
       jae       near ptr M02_L08
       cmp       r8,10
       jb        near ptr M02_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L01
       vmovups   xmm0,[rcx]
       vpcmpnequb k1,xmm0,[rdx]
       kortestw  k1,k1
       jne       near ptr M02_L13
M02_L00:
       add       rax,10
       cmp       r8,rax
       ja        near ptr M02_L11
M02_L01:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jae       near ptr M02_L13
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
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L10
M02_L09:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       jne       short M02_L13
       add       rax,20
       cmp       r8,rax
       ja        short M02_L09
M02_L10:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       jae       short M02_L13
       jmp       near ptr M02_L02
M02_L11:
       vmovups   xmm0,[rcx+rax]
       vpcmpnequb k1,xmm0,[rdx+rax]
       kortestw  k1,k1
       jne       short M02_L13
       jmp       near ptr M02_L00
M02_L12:
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       short M02_L07
M02_L13:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 314
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
       call      qword ptr [7FFDF2A7F990]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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
       mov       rax,190EB540008
       cmp       rcx,rax
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
; Total bytes of code 42
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
       call      qword ptr [7FFDF2A7F990]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFDF269C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDF2A4FA68]; JitFoldProof.Subjects.EmptyByLength(System.String)
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
       call      qword ptr [7FFDF2A6FA68]; JitFoldProof.Subjects.StartsWithChar(System.String)
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
       call      qword ptr [7FFDF2A5F990]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E6E8E0]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       vpxor     xmm0,xmm0,[7FFDC8A78600]
       vmovups   xmm1,[rcx+18]
       vpternlogq xmm0,xmm1,[7FFDC8A78610],0F6
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E6E8F8]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFDC8AF5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       cmp       r8,20
       jb        short M02_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L08
M02_L07:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       nop       dword ptr [rax]
       jne       near ptr M02_L13
       add       rax,20
       cmp       r8,rax
       ja        short M02_L07
M02_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       nop       dword ptr [rax]
       jae       short M02_L13
       jmp       short M02_L05
       xchg      ax,ax
M02_L09:
       cmp       r8,10
       jb        short M02_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L11
M02_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpnequb k1,xmm0,[rdx+rax]
       kortestw  k1,k1
       jne       short M02_L13
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jae       short M02_L13
       jmp       near ptr M02_L05
M02_L12:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
M02_L13:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 298
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E5E100]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E8E118]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFDC8B15068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E9E940]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E7E958]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E7E160]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD925CECD0]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       vpxor     xmm1,xmm1,[7FFD922B9AB0]
       vpternlogq xmm0,xmm1,[7FFD922B9AC0],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 56
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD925AECD0]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFD921EC180]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jb        near ptr M02_L08
       cmp       rcx,rdx
       je        short M02_L02
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
       jne       near ptr M02_L07
       add       rax,10
       cmp       r8,rax
       ja        short M02_L00
M02_L01:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jae       short M02_L07
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
       jmp       near ptr M02_L12
M02_L04:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L06
M02_L05:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       jne       short M02_L07
       add       rax,20
       cmp       r8,rax
       ja        short M02_L05
M02_L06:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       jb        short M02_L02
M02_L07:
       xor       eax,eax
       vzeroupper
       ret
M02_L08:
       cmp       r8,4
       jae       short M02_L11
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L09
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L09:
       test      r8b,1
       je        short M02_L10
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M02_L10:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L12
M02_L11:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M02_L12:
       vzeroupper
       ret
; Total bytes of code 278
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD9259ECD0]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD925AECB8]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFD921EC180]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD9259EBF8]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD925BEBF8]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD925AECD0]; JitFoldProof.Subjects.StartsWithText(System.String)
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
       call      qword ptr [7FFDF2A7FA80]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       mov       rax,20AAEDB6320
       cmp       rcx,rax
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
       vpxor     xmm1,xmm1,[7FFDF2739A10]
       vpternlogq xmm0,xmm1,[7FFDF2739A20],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L03
M01_L02:
       mov       eax,1
M01_L03:
       ret
; Total bytes of code 78
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
       call      qword ptr [7FFDF2A4F9A8]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFDF266C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       cmp       r8,20
       jae       near ptr M02_L08
       cmp       r8,10
       jb        near ptr M02_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L01
       vmovups   xmm0,[rcx]
       vpcmpnequb k1,xmm0,[rdx]
       kortestw  k1,k1
       jne       near ptr M02_L13
M02_L00:
       add       rax,10
       cmp       r8,rax
       ja        near ptr M02_L11
M02_L01:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jae       near ptr M02_L13
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
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L10
M02_L09:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       jne       short M02_L13
       add       rax,20
       cmp       r8,rax
       ja        short M02_L09
M02_L10:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       jae       short M02_L13
       jmp       near ptr M02_L02
M02_L11:
       vmovups   xmm0,[rcx+rax]
       vpcmpnequb k1,xmm0,[rdx+rax]
       kortestw  k1,k1
       jne       short M02_L13
       jmp       near ptr M02_L00
M02_L12:
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       short M02_L07
M02_L13:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 314
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
       call      qword ptr [7FFDF2A6F9A8]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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
       mov       rax,29909480008
       cmp       rcx,rax
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
; Total bytes of code 42
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
       call      qword ptr [7FFDF2A4FA68]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFDF266C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDF2A4F9A8]; JitFoldProof.Subjects.EmptyByLength(System.String)
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
       call      qword ptr [7FFDF2A4FA80]; JitFoldProof.Subjects.StartsWithChar(System.String)
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
       call      qword ptr [7FFDF2A7FA68]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E7ED90]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       vpxor     xmm0,xmm0,[7FFDC8A88640]
       vmovups   xmm1,[rcx+18]
       vpternlogq xmm0,xmm1,[7FFDC8A88650],0F6
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E6EDA8]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFDC8AF5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       cmp       r8,20
       jb        short M02_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L08
M02_L07:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       nop       dword ptr [rax]
       jne       near ptr M02_L13
       add       rax,20
       cmp       r8,rax
       ja        short M02_L07
M02_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       nop       dword ptr [rax]
       jae       short M02_L13
       jmp       short M02_L05
       xchg      ax,ax
M02_L09:
       cmp       r8,10
       jb        short M02_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L11
M02_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpnequb k1,xmm0,[rdx+rax]
       kortestw  k1,k1
       jne       short M02_L13
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jae       short M02_L13
       jmp       near ptr M02_L05
M02_L12:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
M02_L13:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 298
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E5E910]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E6EDD8]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFDC8AF5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E7E940]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E6EC88]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E5EE20]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD925CECD0]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       vpxor     xmm1,xmm1,[7FFD922B9AD0]
       vpternlogq xmm0,xmm1,[7FFD922B9AE0],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 56
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD9259ECE8]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFD921DC180]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jb        near ptr M02_L08
       cmp       rcx,rdx
       je        short M02_L02
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
       jne       near ptr M02_L07
       add       rax,10
       cmp       r8,rax
       ja        short M02_L00
M02_L01:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jae       short M02_L07
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
       jmp       near ptr M02_L12
M02_L04:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L06
M02_L05:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       jne       short M02_L07
       add       rax,20
       cmp       r8,rax
       ja        short M02_L05
M02_L06:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       jb        short M02_L02
M02_L07:
       xor       eax,eax
       vzeroupper
       ret
M02_L08:
       cmp       r8,4
       jae       short M02_L11
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L09
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L09:
       test      r8b,1
       je        short M02_L10
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M02_L10:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L12
M02_L11:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M02_L12:
       vzeroupper
       ret
; Total bytes of code 278
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD925CEC10]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD9259EC10]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFD921DC180]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD925CEC10]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD925AECE8]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD925CEC10]; JitFoldProof.Subjects.StartsWithText(System.String)
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
       call      qword ptr [7FFDF2A4FA68]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       mov       rax,20BA68C6348
       cmp       rcx,rax
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
       vpxor     xmm1,xmm1,[7FFDF2709970]
       vpternlogq xmm0,xmm1,[7FFDF2709980],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L03
M01_L02:
       mov       eax,1
M01_L03:
       ret
; Total bytes of code 78
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
       call      qword ptr [7FFDF2A5FA68]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFDF267C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       je        near ptr M02_L12
       cmp       r8,20
       jae       near ptr M02_L08
       cmp       r8,10
       jb        near ptr M02_L13
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
       ja        near ptr M02_L11
M02_L01:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jb        near ptr M02_L12
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
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L10
M02_L09:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       jne       short M02_L02
       add       rax,20
       cmp       r8,rax
       ja        short M02_L09
M02_L10:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       jae       near ptr M02_L02
       jmp       short M02_L12
M02_L11:
       vmovups   xmm0,[rcx+rax]
       vpcmpnequb k1,xmm0,[rdx+rax]
       kortestw  k1,k1
       jne       near ptr M02_L02
       jmp       near ptr M02_L00
M02_L12:
       mov       eax,1
       vzeroupper
       ret
M02_L13:
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L07
; Total bytes of code 322
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
       call      qword ptr [7FFDF2A4FA68]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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
       mov       rax,27314780008
       cmp       rcx,rax
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
; Total bytes of code 42
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
       call      qword ptr [7FFDF2A4F990]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFDF266C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDF2A6F990]; JitFoldProof.Subjects.EmptyByLength(System.String)
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
       call      qword ptr [7FFDF2A5F990]; JitFoldProof.Subjects.StartsWithChar(System.String)
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
       call      qword ptr [7FFDF2A7FA68]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E7E8E0]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       vpxor     xmm0,xmm0,[7FFDC8A884C0]
       vmovups   xmm1,[rcx+18]
       vpternlogq xmm0,xmm1,[7FFDC8A884D0],0F6
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E8E8F8]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFDC8B15068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       cmp       r8,20
       jb        short M02_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L08
M02_L07:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       nop       dword ptr [rax]
       jne       near ptr M02_L13
       add       rax,20
       cmp       r8,rax
       ja        short M02_L07
M02_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       nop       dword ptr [rax]
       jae       short M02_L13
       jmp       short M02_L05
       xchg      ax,ax
M02_L09:
       cmp       r8,10
       jb        short M02_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L11
M02_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpnequb k1,xmm0,[rdx+rax]
       kortestw  k1,k1
       jne       short M02_L13
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jae       short M02_L13
       jmp       near ptr M02_L05
M02_L12:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
M02_L13:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 298
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E7E910]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E7E928]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFDC8B05068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E8E940]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E7E148]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E8E490]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD925CEBF8]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       vpxor     xmm1,xmm1,[7FFD922B9A10]
       vpternlogq xmm0,xmm1,[7FFD922B9A20],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 56
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD925BEBF8]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFD921FC180]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jb        near ptr M02_L08
       cmp       rcx,rdx
       je        near ptr M02_L07
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
       jb        short M02_L07
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
       jmp       near ptr M02_L12
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
M02_L07:
       mov       eax,1
       vzeroupper
       ret
M02_L08:
       cmp       r8,4
       jae       short M02_L11
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L09
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L09:
       test      r8b,1
       je        short M02_L10
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M02_L10:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L12
M02_L11:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M02_L12:
       vzeroupper
       ret
; Total bytes of code 278
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD925CEBF8]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD925BECD0]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFD921FC180]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD925CECD0]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD925CEBF8]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD9259EBF8]; JitFoldProof.Subjects.StartsWithText(System.String)
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
       call      qword ptr [7FFDF2A4F990]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       mov       rax,1F7D1366348
       cmp       rcx,rax
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
       vpxor     xmm1,xmm1,[7FFDF2709AB0]
       vpternlogq xmm0,xmm1,[7FFDF2709AC0],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L03
M01_L02:
       mov       eax,1
M01_L03:
       ret
; Total bytes of code 78
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
       call      qword ptr [7FFDF2A6FA68]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFDF268C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       je        near ptr M02_L12
       cmp       r8,20
       jae       near ptr M02_L08
       cmp       r8,10
       jb        near ptr M02_L13
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
       ja        near ptr M02_L11
M02_L01:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jb        near ptr M02_L12
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
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L10
M02_L09:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       jne       short M02_L02
       add       rax,20
       cmp       r8,rax
       ja        short M02_L09
M02_L10:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       jae       near ptr M02_L02
       jmp       short M02_L12
M02_L11:
       vmovups   xmm0,[rcx+rax]
       vpcmpnequb k1,xmm0,[rdx+rax]
       kortestw  k1,k1
       jne       near ptr M02_L02
       jmp       near ptr M02_L00
M02_L12:
       mov       eax,1
       vzeroupper
       ret
M02_L13:
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L07
; Total bytes of code 322
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
       call      qword ptr [7FFDF2A6F990]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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
       mov       rax,26027460008
       cmp       rcx,rax
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
; Total bytes of code 42
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
       call      qword ptr [7FFDF2A6F990]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFDF268C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDF2A4F990]; JitFoldProof.Subjects.EmptyByLength(System.String)
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
       call      qword ptr [7FFDF2A4FA68]; JitFoldProof.Subjects.StartsWithChar(System.String)
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
       call      qword ptr [7FFDF2A5F990]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E5E8E0]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       vpxor     xmm0,xmm0,[7FFDC8A68600]
       vmovups   xmm1,[rcx+18]
       vpternlogq xmm0,xmm1,[7FFDC8A68610],0F6
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E7E8F8]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFDC8B05068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       cmp       r8,20
       jb        short M02_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L08
M02_L07:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       nop       dword ptr [rax]
       jne       near ptr M02_L13
       add       rax,20
       cmp       r8,rax
       ja        short M02_L07
M02_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       nop       dword ptr [rax]
       jae       short M02_L13
       jmp       short M02_L05
       xchg      ax,ax
M02_L09:
       cmp       r8,10
       jb        short M02_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L11
M02_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpnequb k1,xmm0,[rdx+rax]
       kortestw  k1,k1
       jne       short M02_L13
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jae       short M02_L13
       jmp       near ptr M02_L05
M02_L12:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
M02_L13:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 298
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E6E910]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E5E928]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFDC8AE5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E7E940]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E5E958]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E7E160]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD925CEBF8]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       vpxor     xmm1,xmm1,[7FFD922B9B60]
       vpternlogq xmm0,xmm1,[7FFD922B9B70],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 56
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD925AEBF8]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFD921EC180]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jb        near ptr M02_L08
       cmp       rcx,rdx
       je        near ptr M02_L07
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
       jb        short M02_L07
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
       jmp       near ptr M02_L12
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
M02_L07:
       mov       eax,1
       vzeroupper
       ret
M02_L08:
       cmp       r8,4
       jae       short M02_L11
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L09
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L09:
       test      r8b,1
       je        short M02_L10
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M02_L10:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L12
M02_L11:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M02_L12:
       vzeroupper
       ret
; Total bytes of code 278
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD9259EBF8]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD925BEBF8]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFD921FC180]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD9259EBF8]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD925BECD0]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD925BECB8]; JitFoldProof.Subjects.StartsWithText(System.String)
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
       call      qword ptr [7FFDF2A6F9A8]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       mov       rax,232795C6348
       cmp       rcx,rax
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
       vpxor     xmm1,xmm1,[7FFDF2729A10]
       vpternlogq xmm0,xmm1,[7FFDF2729A20],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L03
M01_L02:
       mov       eax,1
M01_L03:
       ret
; Total bytes of code 78
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
       call      qword ptr [7FFDF2A5F9A8]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFDF267C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       je        near ptr M02_L12
       cmp       r8,20
       jae       near ptr M02_L08
       cmp       r8,10
       jb        near ptr M02_L13
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
       ja        near ptr M02_L11
M02_L01:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jb        near ptr M02_L12
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
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L10
M02_L09:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       jne       short M02_L02
       add       rax,20
       cmp       r8,rax
       ja        short M02_L09
M02_L10:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       jae       near ptr M02_L02
       jmp       short M02_L12
M02_L11:
       vmovups   xmm0,[rcx+rax]
       vpcmpnequb k1,xmm0,[rdx+rax]
       kortestw  k1,k1
       jne       near ptr M02_L02
       jmp       near ptr M02_L00
M02_L12:
       mov       eax,1
       vzeroupper
       ret
M02_L13:
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L07
; Total bytes of code 322
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
       call      qword ptr [7FFDF2A7F9A8]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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
       mov       rax,1CACB690008
       cmp       rcx,rax
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
; Total bytes of code 42
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
       call      qword ptr [7FFDF2A6FA80]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFDF268C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDF2A7FA68]; JitFoldProof.Subjects.EmptyByLength(System.String)
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
       call      qword ptr [7FFDF2A5FA80]; JitFoldProof.Subjects.StartsWithChar(System.String)
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
       call      qword ptr [7FFDF2A4F9A8]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E7ED90]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       vpxor     xmm0,xmm0,[7FFDC8A88640]
       vmovups   xmm1,[rcx+18]
       vpternlogq xmm0,xmm1,[7FFDC8A88650],0F6
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E9EDA8]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFDC8B25068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       cmp       r8,20
       jb        short M02_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L08
M02_L07:
       vmovups   ymm0,[rcx+rax]
       vpcmpnequb k1,ymm0,[rdx+rax]
       kortestd  k1,k1
       nop       dword ptr [rax]
       jne       near ptr M02_L13
       add       rax,20
       cmp       r8,rax
       ja        short M02_L07
M02_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  k1,ymm0,[rdx+r8]
       kortestd  k1,k1
       nop       dword ptr [rax]
       jae       short M02_L13
       jmp       short M02_L05
       xchg      ax,ax
M02_L09:
       cmp       r8,10
       jb        short M02_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L11
M02_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpnequb k1,xmm0,[rdx+rax]
       kortestw  k1,k1
       jne       short M02_L13
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  k1,xmm0,[rdx+r8]
       kortestw  k1,k1
       jae       short M02_L13
       jmp       near ptr M02_L05
M02_L12:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
M02_L13:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 298
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E8EDC0]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E7E928]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFDC8B05068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E6EDF0]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E5EE08]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E5EE20]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD925CECE8]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       vpxor     xmm1,xmm1,[7FFD922B9AD0]
       vpternlogq xmm0,xmm1,[7FFD922B9AE0],0DE
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 56
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD925CECE8]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFD9220C180]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jb        near ptr M02_L08
       cmp       rcx,rdx
       je        near ptr M02_L07
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
       jb        short M02_L07
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
       jmp       near ptr M02_L12
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
M02_L07:
       mov       eax,1
       vzeroupper
       ret
M02_L08:
       cmp       r8,4
       jae       short M02_L11
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L09
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L09:
       test      r8b,1
       je        short M02_L10
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M02_L10:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L12
M02_L11:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M02_L12:
       vzeroupper
       ret
; Total bytes of code 278
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD925BECD0]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD925BECE8]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFD921FC180]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD925AECE8]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD925BECE8]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD925BEC10]; JitFoldProof.Subjects.StartsWithText(System.String)
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

