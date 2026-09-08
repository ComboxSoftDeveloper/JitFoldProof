## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DAFB70]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       mov       rax,29EEF056348
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
       vpxor     xmm0,xmm0,[7FFAD7AA9D40]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFAD7AA9D50]
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DAFA80]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFAD7A3C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7D8FB70]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       mov       rax,201B9FE0008
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DBFB58]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFAD7A4C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DBFB70]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7D9FB70]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DBFB58]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFABE48CE58]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       vpxor     xmm0,xmm0,[7FFABE0984D0]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFABE0984E0]
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFABE48CC00]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFABE115068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFABE4ACE88]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC3F2CEA0]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFAC3BB5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC3F2CC48]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC3F3CED0]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC3F4CC78]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC3E5EC28]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       vpxor     xmm0,xmm0,[7FFAC3B499C0]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFAC3B499D0]
       vpor      xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 57
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC3E3EB80]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFAC3A7C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC3E3EB80]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC3E5EB80]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFAC3A9C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC9C3EB80]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC9C5EB80]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC9C2EB80]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DAFB70]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       mov       rax,2C82C936348
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
       vpxor     xmm0,xmm0,[7FFAD7AA9E80]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFAD7AA9E90]
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DCFB70]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFAD7A5C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7D9FB70]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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
       mov       rax,1BBA1280008
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DBFA80]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFAD7A4C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DCFB40]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DAFB70]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7D9FA80]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC3F5CE58]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       vpxor     xmm0,xmm0,[7FFAC3B68610]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFAC3B68620]
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC3F5CE70]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFAC3BE5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC3F5CE88]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC3F1CEA0]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFAC3BA5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC3F3CEB8]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC3F1CED0]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC3F2CEE8]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC3E5EB80]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       vpxor     xmm0,xmm0,[7FFAC3B49A60]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFAC3B49A70]
       vpor      xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 57
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC3E3EC58]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFAC3A7C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC3E5EB80]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC3E3EB80]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFAC3A7C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC3E3EC58]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC3E4EC58]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC3E5EC58]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DCFB88]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       mov       rax,1BFD8416348
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
       vpxor     xmm0,xmm0,[7FFAD7AC9E20]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFAD7AC9E30]
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7D8FB70]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFAD7A1C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7D9FA98]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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
       mov       rax,29C45EC0008
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DCFA98]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFAD7A5C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DCFB88]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DBFA98]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DAFB88]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFABE48CEE8]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       vpxor     xmm0,xmm0,[7FFABE098610]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFABE098620]
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFABE46CF00]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFABE0F5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFABE48CF18]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFABE48CF30]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFABE115068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFABE49CF48]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFABE48CF60]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFABE48CEE8]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFABE37EB98]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       vpxor     xmm0,xmm0,[7FFABE069A80]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFABE069A90]
       vpor      xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 57
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFABE38EB98]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFABDFCC090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFABE37EB98]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFABE3AEB98]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFABDFEC090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFABE3AEC70]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFABE37EC70]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFABE39EB98]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7D8FB70]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       mov       rax,1B29D7C6340
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
       vpxor     xmm0,xmm0,[7FFAD7A89920]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFAD7A89930]
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DAFA80]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFAD7A3C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DBFA80]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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
       mov       rax,16FF9FA0008
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DBFB58]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFAD7A4C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7D8FB70]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7D9FA80]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7D8FA80]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFABE47CE58]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       vpxor     xmm0,xmm0,[7FFABE088220]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFABE088230]
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFABE47CC00]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFABE105068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFABE49CE88]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFABE47CEA0]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFABE105068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFABE49CF78]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFABE47CED0]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFABE49CEE8]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFABE37EB80]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       vpxor     xmm0,xmm0,[7FFABE0695D0]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFABE0695E0]
       vpor      xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 57
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFABE37EB80]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFABDFBC090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFABE37EC58]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFABE39EC58]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFABDFDC090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFABE37EC58]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC3E5EB80]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC3E5EC58]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DAFA80]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       mov       rax,3145C5B6340
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
       vpxor     xmm0,xmm0,[7FFAD7AA9A70]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFAD7AA9A80]
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7D9FB70]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFAD7A2C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DAFB70]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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
       mov       rax,15F233C0008
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DBFB70]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFAD7A4C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7D9FB70]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7D9FB70]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DCFA80]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFABE47CE58]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       vpxor     xmm0,xmm0,[7FFABE0882C0]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFABE0882D0]
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC3F4CC00]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFAC3BD5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC3F3CE88]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC3F5CEA0]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFAC3BE5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC3F5CEB8]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC3F2CED0]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC3F3CEE8]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC3E5EC40]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       vpxor     xmm0,xmm0,[7FFAC3B49580]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFAC3B49590]
       vpor      xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 57
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC3E4EC40]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFAC3A8C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC3E5EC58]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC3E3EC58]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFAC3A7C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC3E5EC58]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC3E5EC58]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC3E2EC40]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7D8FB88]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       mov       rax,1DFC7B76340
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
       vpxor     xmm0,xmm0,[7FFAD7A89990]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFAD7A899A0]
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DBFB70]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFAD7A4C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7D9FB88]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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
       mov       rax,1A14C450008
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7D9FA98]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFAD7A2C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DBFB70]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7D8FB70]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DBFA98]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC3F5CF18]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       vpxor     xmm0,xmm0,[7FFAC3B682B0]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFAC3B682C0]
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC3F4CC00]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFAC3BD5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC3F1CE88]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC3F4CF60]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFAC3BD5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC3F1CC48]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC3F5CED0]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC3F4CEE8]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC3E2EC70]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       vpxor     xmm0,xmm0,[7FFAC3B19640]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFAC3B19650]
       vpor      xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 57
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC3E2EC70]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFAC3A6C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC3E2EB98]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC3E5EC58]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFAC3A9C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC3E3EC58]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC3E5EC70]; JitFoldProof.Subjects.StartsWithChar(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC3E3EC70]; JitFoldProof.Subjects.StartsWithText(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DBFB70]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       mov       rax,22209096320
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
       vpxor     xmm0,xmm0,[7FFAD7AB9D50]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFAD7AB9D60]
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DCFB70]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFAD7A5C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DAFB58]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       mov       rax,15234760008
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DBFA80]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFAD7A4C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DBFA80]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DAFB70]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DAFB58]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAB7B0CE58]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       vpxor     xmm0,xmm0,[7FFAB77184D0]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFAB77184E0]
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAB7B0CE70]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFAB7795068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAB7B0CE88]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC3F4CC30]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFAC3BD5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC3F1CEB8]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC3F4CED0]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC3F2CEE8]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC3E3EC40]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       vpxor     xmm0,xmm0,[7FFAC3B299B0]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFAC3B299C0]
       vpor      xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 57
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC3E2EB80]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFAC3A6C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC7FBEC58]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC7FEEC58]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFAC7C2C090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC7FCEC58]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC7FBEC58]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC7FBEC58]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7D9FA80]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       mov       rax,29199F76320
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
       vpxor     xmm0,xmm0,[7FFAD7A99E90]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFAD7A99EA0]
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DAFB58]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFAD7A3C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DAFB70]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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
       mov       rax,2AEEA420008
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DAFB58]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFAD7A3C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DAFB70]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7D9FB70]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7D8FB70]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC063CBE8]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       vpxor     xmm0,xmm0,[7FFAC0248620]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFAC0248630]
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC0DACE70]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFAC0A35068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC0DBCC18]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC0D8CEA0]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFAC0A15068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC0D9CEB8]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC0D9CC60]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC0DBCEE8]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC0CCEC58]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       vpxor     xmm0,xmm0,[7FFAC09B9A50]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFAC09B9A60]
       vpor      xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 57
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC0C9EC58]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFAC08DC090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC0CBEC58]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC0CBEC40]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFAC08FC090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC0CAEC40]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC0CAEC58]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC0CCEC58]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DAFB88]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       mov       rax,280AC996320
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
       vpxor     xmm0,xmm0,[7FFAD7AA9E30]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFAD7AA9E40]
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7D8FA98]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFAD7A1C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DBFB88]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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
       mov       rax,1E2B4DE0008
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7D8FA98]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFAD7A1C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DBFA98]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7D8FA98]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7D8FA98]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAB717CE58]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       vpxor     xmm0,xmm0,[7FFAB6D88670]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFAB6D88680]
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAB717CE70]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFAB6E05068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAB717CE88]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAB730CF30]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFAB6F95068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAB730CF48]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAB733CF60]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC05DCF78]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC058EB98]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       vpxor     xmm0,xmm0,[7FFAC0279A70]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFAC0279A80]
       vpor      xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 57
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC056EB98]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFAC01AC090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC056EB98]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC058EC70]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFAC01CC090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC057EB98]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC059EB98]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC056EB98]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DAFB70]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       mov       rax,28EE91A6348
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
       vpxor     xmm0,xmm0,[7FFAD7AA9D50]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFAD7AA9D60]
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DCFB70]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFAD7A5C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DBFB70]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       mov       rax,20DC16C0008
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DBFB70]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFAD7A4C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DAFB58]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7D9FB70]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7D9FB70]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAB3A9CBE8]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       vpxor     xmm0,xmm0,[7FFAB36A84D0]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFAB36A84E0]
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAB3A9CE70]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFAB3725068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAB3A9CC18]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAB3A7CF60]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFAB3705068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAB3A9CEB8]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAB3A9CED0]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAB3A8CEE8]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAB397EC58]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       vpxor     xmm0,xmm0,[7FFAB36699B0]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFAB36699C0]
       vpor      xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 57
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAB39AEB80]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFAB35EC090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAB39AEB80]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAB39AEC58]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFAB35EC090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAB758EC58]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAB756EB80]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAB758EC58]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7D8FB70]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       mov       rax,30CB4B76348
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
       vpxor     xmm0,xmm0,[7FFAD7A89E90]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFAD7A89EA0]
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DAFB70]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFAD7A3C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7D9FA80]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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
       mov       rax,289C0E60008
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DAFB70]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFAD7A3C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7D9FA80]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DAFA80]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DBFA80]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAB179CE58]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       vpxor     xmm0,xmm0,[7FFAB13A8610]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFAB13A8620]
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAB176CC00]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFAB13F5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC0DCCE88]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC0DACEA0]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFAC0A35068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC0DBCEB8]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC0DCCED0]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC0DACC78]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC0CAEC58]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       vpxor     xmm0,xmm0,[7FFAC0999B00]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFAC0999B10]
       vpor      xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 57
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC0CAEB80]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFAC08EC090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC0CAEC40]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC0C9EC58]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFAC08DC090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC0C9EB80]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC0C9EC58]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC0C9EC40]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7D9FA98]; JitFoldProof.Subjects.EqualsLiteral(System.String)
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
       mov       rax,31CC6E86348
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
       vpxor     xmm0,xmm0,[7FFAD7A99E30]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFAD7A99E40]
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7D8FB88]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
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
       call      qword ptr [7FFAD7A1C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DAFB88]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
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
       mov       rax,2A0DEFF0008
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DAFB88]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
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
       call      qword ptr [7FFAD7A3C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DBFB88]; JitFoldProof.Subjects.EmptyByLength(System.String)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DAFA98]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DBFB88]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC0D8CEE8]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       vpxor     xmm0,xmm0,[7FFAC0998670]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFAC0998680]
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC0DBCE70]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFAC0A45068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC0DCCF18]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC0DACEA0]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFAC0A35068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC0DACEB8]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC0DBCF60]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAC0DBCF78]; JitFoldProof.Subjects.StartsWithText(System.String)
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC0CBEC70]; JitFoldProof.Subjects.EqualsLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       vpxor     xmm0,xmm0,[7FFAC09A9A70]
       vmovups   xmm1,[rcx+18]
       vpxor     xmm1,xmm1,[7FFAC09A9A80]
       vpor      xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 57
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC0CBEC70]; JitFoldProof.Subjects.EqualsOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFAC08FC090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC0C9EB98]; JitFoldProof.Subjects.EmptyByLiteral(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC0C9EB98]; JitFoldProof.Subjects.EmptyByOpaque(System.String, System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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
       call      qword ptr [7FFAC08DC090]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC0CAEB98]; JitFoldProof.Subjects.EmptyByLength(System.String)
       test      eax,eax
       jne       short M00_L03
M00_L01:
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L02:
       mov       eax,esi
       add       rsp,20
       pop       rbx
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC0CCEC70]; JitFoldProof.Subjects.StartsWithChar(System.String)
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

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC0CCEC70]; JitFoldProof.Subjects.StartsWithText(System.String)
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

