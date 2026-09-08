## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1258FC30]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       mov       rax,29B3F996348
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
       vpxor     xmm0,xmm0,[7FFE1227C700]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE1227C710]
       vpor      xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L03
M01_L02:
       mov       eax,1
M01_L03:
       ret
; Total bytes of code 79
```

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1258FA80]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       je        short M01_L01
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
       call      qword ptr [7FFE1221C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
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
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       short M02_L01
       add       rax,20
       cmp       r8,rax
       ja        short M02_L08
M02_L09:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb eax,ymm0
       cmp       eax,0FFFFFFFF
       jne       near ptr M02_L01
       jmp       short M02_L12
M02_L10:
       add       rax,10
       cmp       r8,rax
       ja        near ptr M02_L00
M02_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       near ptr M02_L01
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
; Total bytes of code 314
```

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1256FB70]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       mov       rax,22E5CC30008
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1256FA80]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       mov       r8d,[rcx+8]
       add       r8d,r8d
       mov       rcx,rax
       call      qword ptr [7FFE121FC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
; Total bytes of code 69
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1256FB70]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1256FA80]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1256FB70]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE1094CE58]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       vpxor     xmm0,xmm0,[7FFE10549550]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE10549560]
       vpor      xmm0,xmm0,xmm1
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 60
```

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE1093CC00]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFE105C5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M02_L13
       add       rax,20
       cmp       r8,rax
       ja        short M02_L07
M02_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M02_L13
       nop       dword ptr [rax]
       jmp       short M02_L05
       nop       dword ptr [rax]
M02_L09:
       cmp       r8,10
       jb        short M02_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L11
M02_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L13
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M02_L13
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
; Total bytes of code 307
```

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE1093CE88]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE1094CEA0]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFE105D5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE1095CEB8]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE1095CED0]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE1095CEE8]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1085ED30]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       vpxor     xmm0,xmm0,[7FFE1053BE60]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE1053BE70]
       vpor      xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 57
```

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1083EC40]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFE1047C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       vpcmpeqb  xmm0,xmm0,[rdx+r10]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
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
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M02_L01
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
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       short M02_L01
       add       rax,20
       cmp       r8,rax
       ja        short M02_L06
M02_L07:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb eax,ymm0
       cmp       eax,0FFFFFFFF
       jne       near ptr M02_L01
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
; Total bytes of code 295
```

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1083EC58]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1084EC58]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFE1048C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1085EC58]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1083EB80]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1083EB80]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1256FA80]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       mov       rax,2156E986348
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
       vpxor     xmm0,xmm0,[7FFE12269E80]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE12269E90]
       vpor      xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L03
M01_L02:
       mov       eax,1
M01_L03:
       ret
; Total bytes of code 79
```

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1257FB70]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       je        short M01_L01
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
       call      qword ptr [7FFE1220C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
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
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       short M02_L01
       add       rax,20
       cmp       r8,rax
       ja        short M02_L08
M02_L09:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb eax,ymm0
       cmp       eax,0FFFFFFFF
       jne       near ptr M02_L01
       jmp       short M02_L12
M02_L10:
       add       rax,10
       cmp       r8,rax
       ja        near ptr M02_L00
M02_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       near ptr M02_L01
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
; Total bytes of code 314
```

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1256FA80]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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
       mov       rax,2066C6E0008
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1258FB70]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       mov       r8d,[rcx+8]
       add       r8d,r8d
       mov       rcx,rax
       call      qword ptr [7FFE1221C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
; Total bytes of code 69
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1256FB58]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1254FA80]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1257FA80]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0FEECBE8]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       vpxor     xmm0,xmm0,[7FFE0FAF8610]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE0FAF8620]
       vpor      xmm0,xmm0,xmm1
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 60
```

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0FEFCE70]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFE0FB85068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M02_L13
       add       rax,20
       cmp       r8,rax
       ja        short M02_L07
M02_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M02_L13
       nop       dword ptr [rax]
       jmp       short M02_L05
       nop       dword ptr [rax]
M02_L09:
       cmp       r8,10
       jb        short M02_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L11
M02_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L13
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M02_L13
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
; Total bytes of code 307
```

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0FEDCE88]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0FEECEA0]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFE0FB75068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0FECCEB8]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0FECCED0]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0FEDCEE8]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE0FDCEC58]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       vpxor     xmm0,xmm0,[7FFE0FAB9B00]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE0FAB9B10]
       vpor      xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 57
```

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE0FDBEC58]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFE0F9FC090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       vpcmpeqb  xmm0,xmm0,[rdx+r10]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
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
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M02_L01
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
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       short M02_L01
       add       rax,20
       cmp       r8,rax
       ja        short M02_L06
M02_L07:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb eax,ymm0
       cmp       eax,0FFFFFFFF
       jne       near ptr M02_L01
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
; Total bytes of code 295
```

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE0FDCEB80]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE0FDCEB80]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFE0FA0C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE0FDDEB80]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE0FDFEC58]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE0FDEEB80]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1258FB88]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       mov       rax,27542A66348
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
       vpxor     xmm0,xmm0,[7FFE12289E20]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE12289E30]
       vpor      xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L03
M01_L02:
       mov       eax,1
M01_L03:
       ret
; Total bytes of code 79
```

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1258FB70]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       je        short M01_L01
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
       call      qword ptr [7FFE1221C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
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
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       short M02_L01
       add       rax,20
       cmp       r8,rax
       ja        short M02_L08
M02_L09:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb eax,ymm0
       cmp       eax,0FFFFFFFF
       jne       near ptr M02_L01
       jmp       short M02_L12
M02_L10:
       add       rax,10
       cmp       r8,rax
       ja        near ptr M02_L00
M02_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       near ptr M02_L01
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
; Total bytes of code 314
```

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1255FA98]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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
       mov       rax,26248A00008
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1256FB88]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       mov       r8d,[rcx+8]
       add       r8d,r8d
       mov       rcx,rax
       call      qword ptr [7FFE121FC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
; Total bytes of code 69
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1255FA98]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1257FB88]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1254FB88]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0D7ECEE8]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       vpxor     xmm0,xmm0,[7FFE0D3F8670]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE0D3F8680]
       vpor      xmm0,xmm0,xmm1
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 60
```

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0D7DCF00]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFE0D465068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M02_L13
       add       rax,20
       cmp       r8,rax
       ja        short M02_L07
M02_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M02_L13
       nop       dword ptr [rax]
       jmp       short M02_L05
       nop       dword ptr [rax]
M02_L09:
       cmp       r8,10
       jb        short M02_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L11
M02_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L13
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M02_L13
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
; Total bytes of code 307
```

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0D7ECE88]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0D7DCF30]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFE0D465068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0D7DCF48]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0D7CCF60]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0D7CCEE8]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE0FDEEC58]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       vpxor     xmm0,xmm0,[7FFE0FAD9A80]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE0FAD9A90]
       vpor      xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 57
```

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE0FDFEC70]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFE0FA3C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       vpcmpeqb  xmm0,xmm0,[rdx+r10]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
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
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M02_L01
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
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       short M02_L01
       add       rax,20
       cmp       r8,rax
       ja        short M02_L06
M02_L07:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb eax,ymm0
       cmp       eax,0FFFFFFFF
       jne       near ptr M02_L01
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
; Total bytes of code 295
```

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1085EB98]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1085EC70]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFE1049C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1085EC70]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1083EB98]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1086EB98]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1256FA80]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       mov       rax,135F90D6340
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
       vpxor     xmm0,xmm0,[7FFE12269920]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE12269930]
       vpor      xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L03
M01_L02:
       mov       eax,1
M01_L03:
       ret
; Total bytes of code 79
```

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1255FB70]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       mov       r8d,[rcx+8]
       add       r8d,r8d
       mov       rcx,rax
       call      qword ptr [7FFE121EC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
; Total bytes of code 69
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1256FB70]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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
       mov       rax,22674300008
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1257FB70]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       mov       r8d,[rcx+8]
       add       r8d,r8d
       mov       rcx,rax
       call      qword ptr [7FFE1220C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L00
; Total bytes of code 69
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1254FB70]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1255FA80]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1255FA80]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE1093CBE8]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       vpxor     xmm0,xmm0,[7FFE10548220]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE10548230]
       vpor      xmm0,xmm0,xmm1
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 60
```

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE1095CC00]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFE105E5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE1096CE88]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE1094CEA0]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFE105D5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE1093CEB8]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE1093CC60]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE1096CC78]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1083EB80]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       vpxor     xmm0,xmm0,[7FFE105295D0]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE105295E0]
       vpor      xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 57
```

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1086EB80]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFE104AC090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1084EC58]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1085EB80]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFE1049C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1086EC40]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1083EB80]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1085EC58]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1256FB70]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       mov       rax,1E4610E6340
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
       vpxor     xmm0,xmm0,[7FFE12269A70]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE12269A80]
       vpor      xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L03
M01_L02:
       mov       eax,1
M01_L03:
       ret
; Total bytes of code 79
```

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1256FA80]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       mov       r8d,[rcx+8]
       add       r8d,r8d
       mov       rcx,rax
       call      qword ptr [7FFE121FC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
; Total bytes of code 69
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1254FB58]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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
       mov       rax,25069540008
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1256FB58]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       mov       r8d,[rcx+8]
       add       r8d,r8d
       mov       rcx,rax
       call      qword ptr [7FFE121FC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L00
; Total bytes of code 69
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1256FB70]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1255FA80]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1255FB70]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE1093CE58]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       vpxor     xmm0,xmm0,[7FFE10548360]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE10548370]
       vpor      xmm0,xmm0,xmm1
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 60
```

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE1096CE70]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFE105F5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE1095CE88]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE1093CC30]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFE105C5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE1093CC48]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE1093CC60]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE1092CEE8]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1083EC40]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       vpxor     xmm0,xmm0,[7FFE10529720]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE10529730]
       vpor      xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 57
```

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1084EC58]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFE1048C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1085EC40]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1086EC58]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFE104AC090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1084EB80]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1083EC58]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1086EB80]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1256FB88]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       mov       rax,2525EEF6340
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
       vpxor     xmm0,xmm0,[7FFE12269990]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE122699A0]
       vpor      xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L03
M01_L02:
       mov       eax,1
M01_L03:
       ret
; Total bytes of code 79
```

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1256FB88]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       mov       r8d,[rcx+8]
       add       r8d,r8d
       mov       rcx,rax
       call      qword ptr [7FFE121FC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
; Total bytes of code 69
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1256FB70]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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
       mov       rax,27BFB500008
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1256FB88]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       mov       r8d,[rcx+8]
       add       r8d,r8d
       mov       rcx,rax
       call      qword ptr [7FFE121FC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L00
; Total bytes of code 69
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1255FB88]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1255FB70]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1256FA98]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0FEFCBE8]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       vpxor     xmm0,xmm0,[7FFE0FB082B0]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE0FB082C0]
       vpor      xmm0,xmm0,xmm1
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 60
```

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0FEDCC00]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFE0FB65068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0FECCC18]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0FEFCEA0]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFE0FB85068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0FECCEB8]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0FEDCED0]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0FEFCEE8]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE0FDDEB98]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       vpxor     xmm0,xmm0,[7FFE0FAC9640]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE0FAC9650]
       vpor      xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 57
```

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE0FDCEB98]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFE0FA0C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1086EC70]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1085EB98]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFE1049C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1082EC70]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1085EB98]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1086EC70]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1256FB58]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       mov       rax,21F4EF66320
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
       vpxor     xmm0,xmm0,[7FFE12269D50]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE12269D60]
       vpor      xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L03
M01_L02:
       mov       eax,1
M01_L03:
       ret
; Total bytes of code 79
```

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1254FB70]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       je        short M01_L01
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
       call      qword ptr [7FFE121DC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       vpcmpeqb  xmm0,xmm0,[rdx]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       near ptr M02_L13
M02_L00:
       add       rax,10
       cmp       r8,rax
       ja        near ptr M02_L11
M02_L01:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       near ptr M02_L13
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
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       short M02_L13
       add       rax,20
       cmp       r8,rax
       ja        short M02_L09
M02_L10:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb eax,ymm0
       cmp       eax,0FFFFFFFF
       jne       short M02_L13
       jmp       near ptr M02_L02
M02_L11:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
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
; Total bytes of code 328
```

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1258FB70]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       mov       rax,268B8740008
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1255FA80]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       mov       r8d,[rcx+8]
       add       r8d,r8d
       mov       rcx,rax
       call      qword ptr [7FFE121EC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
; Total bytes of code 69
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1255FB70]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1256FB58]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1257FB70]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0D2ECBE8]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       vpxor     xmm0,xmm0,[7FFE0CEF84D0]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE0CEF84E0]
       vpor      xmm0,xmm0,xmm1
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 60
```

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0D2CCC00]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFE0CF55068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M02_L13
       add       rax,20
       cmp       r8,rax
       ja        short M02_L07
M02_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M02_L13
       nop       dword ptr [rax]
       jmp       short M02_L05
       nop       dword ptr [rax]
M02_L09:
       cmp       r8,10
       jb        short M02_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L11
M02_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L13
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M02_L13
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
; Total bytes of code 307
```

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0D2ECE88]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0D2BCEA0]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFE0CF45068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0D2BCEB8]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0D2ECC60]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0D2CCC78]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE0D6DEB80]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       vpxor     xmm0,xmm0,[7FFE0D3C99B0]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE0D3C99C0]
       vpor      xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 57
```

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE0D6FEC58]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFE0D33C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       near ptr M02_L07
       add       rax,10
       cmp       r8,rax
       ja        short M02_L00
M02_L01:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
       jne       short M02_L07
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
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       short M02_L07
       add       rax,20
       cmp       r8,rax
       ja        short M02_L05
M02_L06:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb eax,ymm0
       cmp       eax,0FFFFFFFF
       je        short M02_L02
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
; Total bytes of code 287
```

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE0D6EEC58]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1085EC58]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFE1049C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1086EC58]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1084EC40]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1085EB80]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1258FA80]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       mov       rax,229758D6320
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
       vpxor     xmm0,xmm0,[7FFE12289E90]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE12289EA0]
       vpor      xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L03
M01_L02:
       mov       eax,1
M01_L03:
       ret
; Total bytes of code 79
```

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1254FA80]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       je        short M01_L01
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
       call      qword ptr [7FFE121DC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       vpcmpeqb  xmm0,xmm0,[rdx]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       near ptr M02_L13
M02_L00:
       add       rax,10
       cmp       r8,rax
       ja        near ptr M02_L11
M02_L01:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       near ptr M02_L13
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
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       short M02_L13
       add       rax,20
       cmp       r8,rax
       ja        short M02_L09
M02_L10:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb eax,ymm0
       cmp       eax,0FFFFFFFF
       jne       short M02_L13
       jmp       near ptr M02_L02
M02_L11:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
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
; Total bytes of code 328
```

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1254FA80]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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
       mov       rax,211622C0008
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1256FB70]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       mov       r8d,[rcx+8]
       add       r8d,r8d
       mov       rcx,rax
       call      qword ptr [7FFE121FC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
; Total bytes of code 69
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1255FB70]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1257FB70]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1256FB70]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE1095CBE8]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       vpxor     xmm0,xmm0,[7FFE10568610]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE10568620]
       vpor      xmm0,xmm0,xmm1
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 60
```

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE1093CE70]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFE105C5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M02_L13
       add       rax,20
       cmp       r8,rax
       ja        short M02_L07
M02_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M02_L13
       nop       dword ptr [rax]
       jmp       short M02_L05
       nop       dword ptr [rax]
M02_L09:
       cmp       r8,10
       jb        short M02_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L11
M02_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L13
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M02_L13
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
; Total bytes of code 307
```

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE1093CC18]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE1095CC30]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFE105E5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE1095CC48]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE1094CC60]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE1093CEE8]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1085EB80]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       vpxor     xmm0,xmm0,[7FFE10549A50]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE10549A60]
       vpor      xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 57
```

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1086EC58]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFE104AC090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       near ptr M02_L07
       add       rax,10
       cmp       r8,rax
       ja        short M02_L00
M02_L01:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
       jne       short M02_L07
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
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       short M02_L07
       add       rax,20
       cmp       r8,rax
       ja        short M02_L05
M02_L06:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb eax,ymm0
       cmp       eax,0FFFFFFFF
       je        short M02_L02
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
; Total bytes of code 287
```

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1085EB80]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1084EB80]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFE1048C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1085EB80]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1084EB80]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1085EC58]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1257FB70]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       mov       rax,1A857A06320
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
       vpxor     xmm0,xmm0,[7FFE12279E30]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE12279E40]
       vpor      xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L03
M01_L02:
       mov       eax,1
M01_L03:
       ret
; Total bytes of code 79
```

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1257FA98]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       je        short M01_L01
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
       call      qword ptr [7FFE1220C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       vpcmpeqb  xmm0,xmm0,[rdx]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       near ptr M02_L13
M02_L00:
       add       rax,10
       cmp       r8,rax
       ja        near ptr M02_L11
M02_L01:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       near ptr M02_L13
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
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       short M02_L13
       add       rax,20
       cmp       r8,rax
       ja        short M02_L09
M02_L10:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb eax,ymm0
       cmp       eax,0FFFFFFFF
       jne       short M02_L13
       jmp       near ptr M02_L02
M02_L11:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
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
; Total bytes of code 328
```

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1254FB88]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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
       mov       rax,19C7D300008
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1255FA98]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       mov       r8d,[rcx+8]
       add       r8d,r8d
       mov       rcx,rax
       call      qword ptr [7FFE121EC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
; Total bytes of code 69
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1255FB88]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1257FB88]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1258FB88]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE1093CEE8]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       vpxor     xmm0,xmm0,[7FFE10548670]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE10548680]
       vpor      xmm0,xmm0,xmm1
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 60
```

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE1096CE70]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFE105F5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M02_L13
       add       rax,20
       cmp       r8,rax
       ja        short M02_L07
M02_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M02_L13
       nop       dword ptr [rax]
       jmp       short M02_L05
       nop       dword ptr [rax]
M02_L09:
       cmp       r8,10
       jb        short M02_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L11
M02_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L13
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M02_L13
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
; Total bytes of code 307
```

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE1093CF18]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE1095CF30]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFE105E5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE1094CEB8]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE1095CF60]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE1094CEE8]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1085EC70]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       vpxor     xmm0,xmm0,[7FFE10549A70]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE10549A80]
       vpor      xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 57
```

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1086EC70]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFE104AC090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       near ptr M02_L07
       add       rax,10
       cmp       r8,rax
       ja        short M02_L00
M02_L01:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
       jne       short M02_L07
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
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       short M02_L07
       add       rax,20
       cmp       r8,rax
       ja        short M02_L05
M02_L06:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb eax,ymm0
       cmp       eax,0FFFFFFFF
       je        short M02_L02
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
; Total bytes of code 287
```

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1085EB98]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1085EC70]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFE1049C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1085EB98]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1084EB98]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1085EB98]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1256FB70]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       mov       rax,221C38C6348
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
       vpxor     xmm0,xmm0,[7FFE12269D50]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE12269D60]
       vpor      xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L03
M01_L02:
       mov       eax,1
M01_L03:
       ret
; Total bytes of code 79
```

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1256FB58]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       je        short M01_L01
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
       call      qword ptr [7FFE121FC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       vpcmpeqb  xmm0,xmm0,[rdx]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L02
M02_L00:
       add       rax,10
       cmp       r8,rax
       ja        near ptr M02_L11
M02_L01:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       je        near ptr M02_L12
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
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       short M02_L02
       add       rax,20
       cmp       r8,rax
       ja        short M02_L09
M02_L10:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb eax,ymm0
       cmp       eax,0FFFFFFFF
       jne       near ptr M02_L02
       jmp       short M02_L12
M02_L11:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
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
; Total bytes of code 336
```

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1257FB70]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       mov       rax,238FB400008
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1255FB58]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       mov       r8d,[rcx+8]
       add       r8d,r8d
       mov       rcx,rax
       call      qword ptr [7FFE121EC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
; Total bytes of code 69
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1254FB70]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1257FB70]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1254FB70]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0D41CBE8]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       vpxor     xmm0,xmm0,[7FFE0D0284D0]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE0D0284E0]
       vpor      xmm0,xmm0,xmm1
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 60
```

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0D40CE70]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFE0D095068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M02_L13
       add       rax,20
       cmp       r8,rax
       ja        short M02_L07
M02_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M02_L13
       nop       dword ptr [rax]
       jmp       short M02_L05
       nop       dword ptr [rax]
M02_L09:
       cmp       r8,10
       jb        short M02_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L11
M02_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L13
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M02_L13
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
; Total bytes of code 307
```

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0D42CC18]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0D40CEA0]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFE0D095068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0D40CC48]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0D42CC60]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0D7ECEE8]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE0FDCEC58]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       vpxor     xmm0,xmm0,[7FFE0FAB99B0]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE0FAB99C0]
       vpor      xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 57
```

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE0FDDEC58]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFE0FA1C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L02
       add       rax,10
       cmp       r8,rax
       ja        short M02_L00
M02_L01:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
       je        short M02_L07
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
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       short M02_L02
       add       rax,20
       cmp       r8,rax
       ja        short M02_L05
M02_L06:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb eax,ymm0
       cmp       eax,0FFFFFFFF
       jne       short M02_L02
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
; Total bytes of code 287
```

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE0FDFEB80]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE0FDEEB80]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFE0FA2C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE0FDCEC58]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE0FDDEC58]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE0FDBEB80]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1257FB70]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       mov       rax,15FF5E06348
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
       vpxor     xmm0,xmm0,[7FFE12279E90]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE12279EA0]
       vpor      xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L03
M01_L02:
       mov       eax,1
M01_L03:
       ret
; Total bytes of code 79
```

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1258FA80]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       je        short M01_L01
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
       call      qword ptr [7FFE1221C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       vpcmpeqb  xmm0,xmm0,[rdx]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L02
M02_L00:
       add       rax,10
       cmp       r8,rax
       ja        near ptr M02_L11
M02_L01:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       je        near ptr M02_L12
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
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       short M02_L02
       add       rax,20
       cmp       r8,rax
       ja        short M02_L09
M02_L10:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb eax,ymm0
       cmp       eax,0FFFFFFFF
       jne       near ptr M02_L02
       jmp       short M02_L12
M02_L11:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
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
; Total bytes of code 336
```

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1255FB70]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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
       mov       rax,152D9160008
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1255FB70]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       mov       r8d,[rcx+8]
       add       r8d,r8d
       mov       rcx,rax
       call      qword ptr [7FFE121EC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
; Total bytes of code 69
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1258FB58]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1254FA80]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1254FA80]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0FEECBE8]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       vpxor     xmm0,xmm0,[7FFE0FAF8610]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE0FAF8620]
       vpor      xmm0,xmm0,xmm1
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 60
```

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0FEFCE70]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFE0FB85068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M02_L13
       add       rax,20
       cmp       r8,rax
       ja        short M02_L07
M02_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M02_L13
       nop       dword ptr [rax]
       jmp       short M02_L05
       nop       dword ptr [rax]
M02_L09:
       cmp       r8,10
       jb        short M02_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L11
M02_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L13
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M02_L13
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
; Total bytes of code 307
```

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0FECCE88]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0FEDCC30]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFE0FB65068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0FEDCEB8]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0FEECED0]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0FEFCEE8]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE0FDCEC58]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       vpxor     xmm0,xmm0,[7FFE0FAB9AF0]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE0FAB9B00]
       vpor      xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 57
```

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE0FDDEC58]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFE0FA1C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L02
       add       rax,10
       cmp       r8,rax
       ja        short M02_L00
M02_L01:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
       je        short M02_L07
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
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       short M02_L02
       add       rax,20
       cmp       r8,rax
       ja        short M02_L05
M02_L06:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb eax,ymm0
       cmp       eax,0FFFFFFFF
       jne       short M02_L02
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
; Total bytes of code 287
```

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE0FDDEC58]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE0FDEEC58]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFE0FA2C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE0FDCEC40]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE0FDDEB80]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE0FDDEB80]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1255FB88]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       mov       rax,1FDC19B6348
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
       vpxor     xmm0,xmm0,[7FFE12259E30]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE12259E40]
       vpor      xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L03
M01_L02:
       mov       eax,1
M01_L03:
       ret
; Total bytes of code 79
```

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1256FB88]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       je        short M01_L01
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
       call      qword ptr [7FFE121FC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       vpcmpeqb  xmm0,xmm0,[rdx]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L02
M02_L00:
       add       rax,10
       cmp       r8,rax
       ja        near ptr M02_L11
M02_L01:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       je        near ptr M02_L12
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
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       short M02_L02
       add       rax,20
       cmp       r8,rax
       ja        short M02_L09
M02_L10:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb eax,ymm0
       cmp       eax,0FFFFFFFF
       jne       near ptr M02_L02
       jmp       short M02_L12
M02_L11:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
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
; Total bytes of code 336
```

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1257FA98]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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
       mov       rax,29271ED0008
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1255FB88]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       mov       r8d,[rcx+8]
       add       r8d,r8d
       mov       rcx,rax
       call      qword ptr [7FFE121EC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L01
; Total bytes of code 69
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1256FB88]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1257FB88]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1257FA98]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0D7DCEE8]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       vpxor     xmm0,xmm0,[7FFE0D3E8670]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE0D3E8680]
       vpor      xmm0,xmm0,xmm1
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       ret
; Total bytes of code 60
```

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0D7DD1A0]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFE0D465068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M02_L13
       add       rax,20
       cmp       r8,rax
       ja        short M02_L07
M02_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M02_L13
       nop       dword ptr [rax]
       jmp       short M02_L05
       nop       dword ptr [rax]
M02_L09:
       cmp       r8,10
       jb        short M02_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L11
M02_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L13
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M02_L13
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
; Total bytes of code 307
```

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0D7FCF18]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0D7DCF30]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFE0D465068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0D7DCF48]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0D7ECF60]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0D7FCF78]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1084EB98]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       vpxor     xmm0,xmm0,[7FFE10539A70]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFE10539A80]
       vpor      xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 57
```

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1086EC70]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFE104AC090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L02
       add       rax,10
       cmp       r8,rax
       ja        short M02_L00
M02_L01:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
       je        short M02_L07
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
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       short M02_L02
       add       rax,20
       cmp       r8,rax
       ja        short M02_L05
M02_L06:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb eax,ymm0
       cmp       eax,0FFFFFFFF
       jne       short M02_L02
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
; Total bytes of code 287
```

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1086EC70]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1083EC70]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFE1047C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1085EC58]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1083EB98]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1085EC70]; JitFoldProof.Subjects.StartsWithText(System.String)
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

