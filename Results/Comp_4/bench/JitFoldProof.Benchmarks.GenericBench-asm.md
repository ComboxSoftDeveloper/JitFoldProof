## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.GenericBench.Numbers()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L02
       mov       ecx,[rcx+rdi*4+10]
       call      qword ptr [7FFEAFC9FBA0]; JitFoldProof.Subjects.Ladder[[System.Int32, System.Private.CoreLib]](Int32)
       add       esi,eax
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 72
```
```assembly
; JitFoldProof.Subjects.Ladder[[System.Int32, System.Private.CoreLib]](Int32)
       sub       rsp,28
       mov       ecx,0D
       call      qword ptr [7FFEAFC9FC18]; JitFoldProof.Subjects.Work(Int32)
       nop
       add       rsp,28
       ret
; Total bytes of code 21
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFEAF7FB0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.GenericBench.Words()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rdx,[rbx+10]
       cmp       dword ptr [rdx+8],0
       jle       short M00_L01
M00_L00:
       mov       rdx,[rbx+10]
       cmp       edi,[rdx+8]
       jae       short M00_L02
       mov       rdx,[rdx+rdi*8+10]
       mov       rcx,7FFEAFD1A818
       call      qword ptr [7FFEAFC6FC78]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       add       esi,eax
       inc       edi
       mov       rax,[rbx+10]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.String
       cmp       [rax],r8
       jne       short M01_L01
       mov       ecx,1
       call      qword ptr [7FFEAFC6FD08]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Object
       cmp       [rax],r8
       jne       short M01_L02
       mov       ecx,2
       call      qword ptr [7FFEAFC6FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Uri
       cmp       [rax],r8
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFEAFC6FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Version
       cmp       [rax],r8
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFEAFC6FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Exception
       cmp       [rax],r8
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFEAFC6FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Type
       cmp       [rax],r8
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFEAFC6FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Int32[]
       cmp       [rax],r8
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFEAFC6FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.String[]
       cmp       [rax],r8
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFEAFC6FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rax],r8
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFEAFC6FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       [rax],r8
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFEAFC6FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Random
       cmp       [rax],r8
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFEAFC6FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,[rcx+18]
       mov       rax,offset MT_System.StringComparer
       cmp       [rcx],rax
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFEAFC6FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFEAFC6FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 445
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFEAF7CB0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.GenericBench.Objects()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rdx,[rbx+18]
       cmp       dword ptr [rdx+8],0
       jle       short M00_L01
M00_L00:
       mov       rdx,[rbx+18]
       cmp       edi,[rdx+8]
       jae       short M00_L02
       mov       rdx,[rdx+rdi*8+10]
       mov       rcx,7FFEAFD262B0
       call      qword ptr [7FFEAFC7FBA0]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       add       esi,eax
       inc       edi
       mov       rax,[rbx+18]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rcx,[rcx+18]
       mov       rbx,[rcx]
       mov       rcx,offset MT_System.String
       cmp       rbx,rcx
       je        short M01_L01
       mov       rcx,offset MT_System.Object
       cmp       rbx,rcx
       jne       short M01_L02
       mov       ecx,2
       call      qword ptr [7FFEAFC7FC30]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,30
       pop       rbx
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFEAFC7FC30]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rcx,offset MT_System.Uri
       cmp       rbx,rcx
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFEAFC7FC30]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rcx,offset MT_System.Version
       cmp       rbx,rcx
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFEAFC7FC30]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rcx,offset MT_System.Exception
       cmp       rbx,rcx
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFEAFC7FC30]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       rcx,offset MT_System.Type
       cmp       rbx,rcx
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFEAFC7FC30]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,offset MT_System.Int32[]
       cmp       rbx,rcx
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFEAFC7FC30]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rcx,offset MT_System.String[]
       cmp       rbx,rcx
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFEAFC7FC30]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rcx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       rbx,rcx
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFEAFC7FC30]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       rbx,rcx
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFEAFC7FC30]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rcx,offset MT_System.Random
       cmp       rbx,rcx
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFEAFC7FC30]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,offset MT_System.StringComparer
       cmp       rbx,rcx
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFEAFC7FC30]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFEAFC7FC30]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 403
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFEAF7DB0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.GenericBench.Unlisted()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rdx,[rbx+20]
       cmp       dword ptr [rdx+8],0
       jle       short M00_L01
M00_L00:
       mov       rdx,[rbx+20]
       cmp       edi,[rdx+8]
       jae       short M00_L02
       mov       rdx,[rdx+rdi*8+10]
       mov       rcx,7FFEAFD2A818
       call      qword ptr [7FFEAFC7FC78]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       add       esi,eax
       inc       edi
       mov       rax,[rbx+20]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rcx,[rcx+18]
       mov       rcx,[rcx]
       mov       rax,offset MT_System.String
       cmp       rcx,rax
       je        near ptr M01_L01
       mov       rax,offset MT_System.Object
       cmp       rcx,rax
       je        near ptr M01_L02
       mov       rax,offset MT_System.Uri
       cmp       rcx,rax
       je        near ptr M01_L03
       mov       rax,offset MT_System.Version
       cmp       rcx,rax
       je        near ptr M01_L04
       mov       rax,offset MT_System.Exception
       cmp       rcx,rax
       je        near ptr M01_L05
       mov       rax,offset MT_System.Type
       cmp       rcx,rax
       je        near ptr M01_L06
       mov       rax,offset MT_System.Int32[]
       cmp       rcx,rax
       je        near ptr M01_L07
       mov       rax,offset MT_System.String[]
       cmp       rcx,rax
       je        near ptr M01_L08
       mov       rax,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       rcx,rax
       je        near ptr M01_L09
       mov       rax,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       rcx,rax
       je        near ptr M01_L10
       mov       rax,offset MT_System.Random
       cmp       rcx,rax
       je        near ptr M01_L11
       mov       rax,offset MT_System.StringComparer
       cmp       rcx,rax
       je        near ptr M01_L12
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFEAFC7FD08]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFEAFC7FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       ecx,2
       call      qword ptr [7FFEAFC7FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       ecx,3
       call      qword ptr [7FFEAFC7FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       ecx,4
       call      qword ptr [7FFEAFC7FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       ecx,5
       call      qword ptr [7FFEAFC7FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L06:
       mov       ecx,6
       call      qword ptr [7FFEAFC7FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFEAFC7FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L08:
       mov       ecx,8
       call      qword ptr [7FFEAFC7FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L09:
       mov       ecx,9
       call      qword ptr [7FFEAFC7FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L10:
       mov       ecx,0A
       call      qword ptr [7FFEAFC7FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,0B
       call      qword ptr [7FFEAFC7FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,0C
       call      qword ptr [7FFEAFC7FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 434
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFEAF7DB0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.GenericBench.Numbers()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L02
       mov       eax,edi
       mov       ecx,[rcx+rax*4+10]
       call      qword ptr [7FFE7407EB08]; JitFoldProof.Subjects.Ladder[[System.Int32, System.Private.CoreLib]](Int32)
       add       esi,eax
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 74
```
```assembly
; JitFoldProof.Subjects.Ladder[[System.Int32, System.Private.CoreLib]](Int32)
       sub       rsp,28
       mov       ecx,0D
       call      qword ptr [7FFE7407EA00]; JitFoldProof.Subjects.Work(Int32)
       nop
       add       rsp,28
       ret
; Total bytes of code 21
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE73E42C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.GenericBench.Words()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rdx,[rbx+10]
       cmp       dword ptr [rdx+8],0
       jle       short M00_L01
M00_L00:
       mov       rdx,[rbx+10]
       cmp       edi,[rdx+8]
       jae       short M00_L02
       mov       ecx,edi
       mov       rdx,[rdx+rcx*8+10]
       mov       rcx,7FFE74088DB0
       call      qword ptr [7FFE7407E628]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       add       esi,eax
       inc       edi
       mov       rax,[rbx+10]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 85
```
```assembly
; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.String
       cmp       [rax],r8
       jne       short M01_L01
       mov       ecx,1
       call      qword ptr [7FFE7407E520]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Object
       cmp       [rax],r8
       jne       short M01_L02
       mov       ecx,2
       call      qword ptr [7FFE7407E520]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Uri
       cmp       [rax],r8
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFE7407E520]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Version
       cmp       [rax],r8
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFE7407E520]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Exception
       cmp       [rax],r8
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFE7407E520]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Type
       cmp       [rax],r8
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFE7407E520]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Int32[]
       cmp       [rax],r8
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFE7407E520]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.String[]
       cmp       [rax],r8
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFE7407E520]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rax],r8
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFE7407E520]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       [rax],r8
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFE7407E520]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Random
       cmp       [rax],r8
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFE7407E520]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,[rcx+10]
       mov       rax,offset MT_System.StringComparer
       cmp       [rcx],rax
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFE7407E520]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFE7407E520]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 445
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE73E42C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.GenericBench.Objects()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rdx,[rbx+18]
       cmp       dword ptr [rdx+8],0
       jle       short M00_L01
M00_L00:
       mov       rdx,[rbx+18]
       cmp       edi,[rdx+8]
       jae       short M00_L02
       mov       ecx,edi
       mov       rdx,[rdx+rcx*8+10]
       mov       rcx,7FFE74098980
       call      qword ptr [7FFE7408E2F8]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       add       esi,eax
       inc       edi
       mov       rax,[rbx+18]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 85
```
```assembly
; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rcx,[rcx+10]
       mov       rbx,[rcx]
       mov       rcx,offset MT_System.String
       cmp       rbx,rcx
       je        short M01_L01
       mov       rcx,offset MT_System.Object
       cmp       rbx,rcx
       jne       short M01_L02
       mov       ecx,2
       call      qword ptr [7FFE7408E1F0]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,30
       pop       rbx
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFE7408E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rcx,offset MT_System.Uri
       cmp       rbx,rcx
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFE7408E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rcx,offset MT_System.Version
       cmp       rbx,rcx
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFE7408E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rcx,offset MT_System.Exception
       cmp       rbx,rcx
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFE7408E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       rcx,offset MT_System.Type
       cmp       rbx,rcx
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFE7408E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,offset MT_System.Int32[]
       cmp       rbx,rcx
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFE7408E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rcx,offset MT_System.String[]
       cmp       rbx,rcx
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFE7408E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rcx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       rbx,rcx
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFE7408E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       rbx,rcx
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFE7408E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rcx,offset MT_System.Random
       cmp       rbx,rcx
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFE7408E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,offset MT_System.StringComparer
       cmp       rbx,rcx
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFE7408E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFE7408E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 403
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE73E52C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.GenericBench.Unlisted()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rdx,[rbx+20]
       cmp       dword ptr [rdx+8],0
       jle       short M00_L01
M00_L00:
       mov       rdx,[rbx+20]
       cmp       edi,[rdx+8]
       jae       short M00_L02
       mov       ecx,edi
       mov       rdx,[rdx+rcx*8+10]
       mov       rcx,7FFE74088DD8
       call      qword ptr [7FFE7407EB08]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       add       esi,eax
       inc       edi
       mov       rax,[rbx+20]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 85
```
```assembly
; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rcx,[rcx+10]
       mov       rcx,[rcx]
       mov       rax,offset MT_System.String
       cmp       rcx,rax
       je        near ptr M01_L01
       mov       rax,offset MT_System.Object
       cmp       rcx,rax
       je        near ptr M01_L02
       mov       rax,offset MT_System.Uri
       cmp       rcx,rax
       je        near ptr M01_L03
       mov       rax,offset MT_System.Version
       cmp       rcx,rax
       je        near ptr M01_L04
       mov       rax,offset MT_System.Exception
       cmp       rcx,rax
       je        near ptr M01_L05
       mov       rax,offset MT_System.Type
       cmp       rcx,rax
       je        near ptr M01_L06
       mov       rax,offset MT_System.Int32[]
       cmp       rcx,rax
       je        near ptr M01_L07
       mov       rax,offset MT_System.String[]
       cmp       rcx,rax
       je        near ptr M01_L08
       mov       rax,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       rcx,rax
       je        near ptr M01_L09
       mov       rax,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       rcx,rax
       je        near ptr M01_L10
       mov       rax,offset MT_System.Random
       cmp       rcx,rax
       je        near ptr M01_L11
       mov       rax,offset MT_System.StringComparer
       cmp       rcx,rax
       je        near ptr M01_L12
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFE7407EA00]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFE7407EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       ecx,2
       call      qword ptr [7FFE7407EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       ecx,3
       call      qword ptr [7FFE7407EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       ecx,4
       call      qword ptr [7FFE7407EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       ecx,5
       call      qword ptr [7FFE7407EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L06:
       mov       ecx,6
       call      qword ptr [7FFE7407EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFE7407EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L08:
       mov       ecx,8
       call      qword ptr [7FFE7407EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L09:
       mov       ecx,9
       call      qword ptr [7FFE7407EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L10:
       mov       ecx,0A
       call      qword ptr [7FFE7407EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,0B
       call      qword ptr [7FFE7407EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,0C
       call      qword ptr [7FFE7407EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 434
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE73E42C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.GenericBench.Numbers()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L02
       mov       ecx,[rcx+rdi*4+10]
       call      qword ptr [7FFE73F8EB68]; JitFoldProof.Subjects.Ladder[[System.Int32, System.Private.CoreLib]](Int32)
       add       esi,eax
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 72
```
```assembly
; JitFoldProof.Subjects.Ladder[[System.Int32, System.Private.CoreLib]](Int32)
       sub       rsp,28
       mov       ecx,0D
       call      qword ptr [7FFE73F8EBE0]; JitFoldProof.Subjects.Work(Int32)
       nop
       add       rsp,28
       ret
; Total bytes of code 21
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE73B1B0D0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.GenericBench.Words()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rdx,[rbx+10]
       cmp       dword ptr [rdx+8],0
       jle       short M00_L01
M00_L00:
       mov       rdx,[rbx+10]
       cmp       edi,[rdx+8]
       jae       short M00_L02
       mov       rdx,[rdx+rdi*8+10]
       mov       rcx,7FFE740308F0
       call      qword ptr [7FFE73F8EC40]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       add       esi,eax
       inc       edi
       mov       rax,[rbx+10]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.String
       cmp       [rax],r8
       jne       short M01_L01
       mov       ecx,1
       call      qword ptr [7FFE73F8ECD0]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Object
       cmp       [rax],r8
       je        near ptr M01_L12
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Uri
       cmp       [rax],r8
       je        near ptr M01_L11
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Version
       cmp       [rax],r8
       je        near ptr M01_L10
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Exception
       cmp       [rax],r8
       je        near ptr M01_L09
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Type
       cmp       [rax],r8
       je        near ptr M01_L08
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Int32[]
       cmp       [rax],r8
       je        near ptr M01_L07
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.String[]
       cmp       [rax],r8
       je        near ptr M01_L06
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rax],r8
       je        near ptr M01_L05
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       [rax],r8
       je        short M01_L04
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Random
       cmp       [rax],r8
       je        short M01_L03
       mov       rcx,[rcx+18]
       mov       rax,offset MT_System.StringComparer
       cmp       [rcx],rax
       je        short M01_L02
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFE73F8ECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L02:
       mov       ecx,0C
       call      qword ptr [7FFE73F8ECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L03:
       mov       ecx,0B
       call      qword ptr [7FFE73F8ECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,0A
       call      qword ptr [7FFE73F8ECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       ecx,9
       call      qword ptr [7FFE73F8ECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       ecx,8
       call      qword ptr [7FFE73F8ECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFE73F8ECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       ecx,6
       call      qword ptr [7FFE73F8ECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       ecx,5
       call      qword ptr [7FFE73F8ECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       ecx,4
       call      qword ptr [7FFE73F8ECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,3
       call      qword ptr [7FFE73F8ECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,2
       call      qword ptr [7FFE73F8ECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 486
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE73B1B0D0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.GenericBench.Objects()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rdx,[rbx+18]
       cmp       dword ptr [rdx+8],0
       jle       short M00_L01
M00_L00:
       mov       rdx,[rbx+18]
       cmp       edi,[rdx+8]
       jae       short M00_L02
       mov       rdx,[rdx+rdi*8+10]
       mov       rcx,7FFE974BC878
       call      qword ptr [7FFE9741EB68]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       add       esi,eax
       inc       edi
       mov       rax,[rbx+18]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rcx,[rcx+18]
       mov       rbx,[rcx]
       mov       rcx,offset MT_System.String
       cmp       rbx,rcx
       je        near ptr M01_L12
       mov       rcx,offset MT_System.Object
       cmp       rbx,rcx
       jne       short M01_L01
       mov       ecx,2
       call      qword ptr [7FFE9741EBF8]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,30
       pop       rbx
       ret
M01_L01:
       mov       rcx,offset MT_System.Uri
       cmp       rbx,rcx
       je        near ptr M01_L11
       mov       rcx,offset MT_System.Version
       cmp       rbx,rcx
       je        near ptr M01_L10
       mov       rcx,offset MT_System.Exception
       cmp       rbx,rcx
       je        near ptr M01_L09
       mov       rcx,offset MT_System.Type
       cmp       rbx,rcx
       je        near ptr M01_L08
       mov       rcx,offset MT_System.Int32[]
       cmp       rbx,rcx
       je        near ptr M01_L07
       mov       rcx,offset MT_System.String[]
       cmp       rbx,rcx
       je        near ptr M01_L06
       mov       rcx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       rbx,rcx
       je        short M01_L05
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       rbx,rcx
       je        short M01_L04
       mov       rcx,offset MT_System.Random
       cmp       rbx,rcx
       je        short M01_L03
       mov       rcx,offset MT_System.StringComparer
       cmp       rbx,rcx
       je        short M01_L02
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFE9741EBF8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L02:
       mov       ecx,0C
       call      qword ptr [7FFE9741EBF8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L03:
       mov       ecx,0B
       call      qword ptr [7FFE9741EBF8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,0A
       call      qword ptr [7FFE9741EBF8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       ecx,9
       call      qword ptr [7FFE9741EBF8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       ecx,8
       call      qword ptr [7FFE9741EBF8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFE9741EBF8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       ecx,6
       call      qword ptr [7FFE9741EBF8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       ecx,5
       call      qword ptr [7FFE9741EBF8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       ecx,4
       call      qword ptr [7FFE9741EBF8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,3
       call      qword ptr [7FFE9741EBF8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,1
       call      qword ptr [7FFE9741EBF8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 443
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE96FAB0D0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.GenericBench.Unlisted()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rdx,[rbx+20]
       cmp       dword ptr [rdx+8],0
       jle       short M00_L01
M00_L00:
       mov       rdx,[rbx+20]
       cmp       edi,[rdx+8]
       jae       short M00_L02
       mov       rdx,[rdx+rdi*8+10]
       mov       rcx,7FFE974A08F0
       call      qword ptr [7FFE973FEC40]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       add       esi,eax
       inc       edi
       mov       rax,[rbx+20]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rcx,[rcx+18]
       mov       rcx,[rcx]
       mov       rax,offset MT_System.String
       cmp       rcx,rax
       je        near ptr M01_L12
       mov       rax,offset MT_System.Object
       cmp       rcx,rax
       je        near ptr M01_L11
       mov       rax,offset MT_System.Uri
       cmp       rcx,rax
       je        near ptr M01_L10
       mov       rax,offset MT_System.Version
       cmp       rcx,rax
       je        near ptr M01_L09
       mov       rax,offset MT_System.Exception
       cmp       rcx,rax
       je        near ptr M01_L08
       mov       rax,offset MT_System.Type
       cmp       rcx,rax
       je        near ptr M01_L07
       mov       rax,offset MT_System.Int32[]
       cmp       rcx,rax
       je        near ptr M01_L06
       mov       rax,offset MT_System.String[]
       cmp       rcx,rax
       je        near ptr M01_L05
       mov       rax,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       rcx,rax
       je        short M01_L04
       mov       rax,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       rcx,rax
       je        short M01_L03
       mov       rax,offset MT_System.Random
       cmp       rcx,rax
       je        short M01_L02
       mov       rax,offset MT_System.StringComparer
       cmp       rcx,rax
       je        short M01_L01
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFE973FECD0]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       ecx,0C
       call      qword ptr [7FFE973FECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       ecx,0B
       call      qword ptr [7FFE973FECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       ecx,0A
       call      qword ptr [7FFE973FECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       ecx,9
       call      qword ptr [7FFE973FECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       ecx,8
       call      qword ptr [7FFE973FECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L06:
       mov       ecx,7
       call      qword ptr [7FFE973FECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L07:
       mov       ecx,6
       call      qword ptr [7FFE973FECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L08:
       mov       ecx,5
       call      qword ptr [7FFE973FECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L09:
       mov       ecx,4
       call      qword ptr [7FFE973FECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L10:
       mov       ecx,3
       call      qword ptr [7FFE973FECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,2
       call      qword ptr [7FFE973FECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,1
       call      qword ptr [7FFE973FECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 418
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE96F8B0D0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.GenericBench.Numbers()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L02
       mov       ecx,[rcx+rdi*4+10]
       call      qword ptr [7FFEAFC6FBA0]; JitFoldProof.Subjects.Ladder[[System.Int32, System.Private.CoreLib]](Int32)
       add       esi,eax
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 72
```
```assembly
; JitFoldProof.Subjects.Ladder[[System.Int32, System.Private.CoreLib]](Int32)
       sub       rsp,28
       mov       ecx,0D
       call      qword ptr [7FFEAFC6FC18]; JitFoldProof.Subjects.Work(Int32)
       nop
       add       rsp,28
       ret
; Total bytes of code 21
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFEAF7CB0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.GenericBench.Words()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rdx,[rbx+10]
       cmp       dword ptr [rdx+8],0
       jle       short M00_L01
M00_L00:
       mov       rdx,[rbx+10]
       cmp       edi,[rdx+8]
       jae       short M00_L02
       mov       rdx,[rdx+rdi*8+10]
       mov       rcx,7FFEAFD1A808
       call      qword ptr [7FFEAFC6FC60]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       add       esi,eax
       inc       edi
       mov       rax,[rbx+10]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.String
       cmp       [rax],r8
       jne       short M01_L01
       mov       ecx,1
       call      qword ptr [7FFEAFC6FCF0]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Object
       cmp       [rax],r8
       jne       short M01_L02
       mov       ecx,2
       call      qword ptr [7FFEAFC6FCF0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Uri
       cmp       [rax],r8
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFEAFC6FCF0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Version
       cmp       [rax],r8
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFEAFC6FCF0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Exception
       cmp       [rax],r8
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFEAFC6FCF0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Type
       cmp       [rax],r8
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFEAFC6FCF0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Int32[]
       cmp       [rax],r8
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFEAFC6FCF0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.String[]
       cmp       [rax],r8
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFEAFC6FCF0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rax],r8
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFEAFC6FCF0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       [rax],r8
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFEAFC6FCF0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Random
       cmp       [rax],r8
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFEAFC6FCF0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,[rcx+18]
       mov       rax,offset MT_System.StringComparer
       cmp       [rcx],rax
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFEAFC6FCF0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFEAFC6FCF0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 445
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFEAF7CB0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.GenericBench.Objects()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rdx,[rbx+18]
       cmp       dword ptr [rdx+8],0
       jle       short M00_L01
M00_L00:
       mov       rdx,[rbx+18]
       cmp       edi,[rdx+8]
       jae       short M00_L02
       mov       rdx,[rdx+rdi*8+10]
       mov       rcx,7FFEAFD1A818
       call      qword ptr [7FFEAFC6FC78]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       add       esi,eax
       inc       edi
       mov       rax,[rbx+18]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rcx,[rcx+18]
       mov       rbx,[rcx]
       mov       rcx,offset MT_System.String
       cmp       rbx,rcx
       je        short M01_L01
       mov       rcx,offset MT_System.Object
       cmp       rbx,rcx
       jne       short M01_L02
       mov       ecx,2
       call      qword ptr [7FFEAFC6FD08]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,30
       pop       rbx
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFEAFC6FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rcx,offset MT_System.Uri
       cmp       rbx,rcx
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFEAFC6FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rcx,offset MT_System.Version
       cmp       rbx,rcx
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFEAFC6FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rcx,offset MT_System.Exception
       cmp       rbx,rcx
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFEAFC6FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       rcx,offset MT_System.Type
       cmp       rbx,rcx
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFEAFC6FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,offset MT_System.Int32[]
       cmp       rbx,rcx
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFEAFC6FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rcx,offset MT_System.String[]
       cmp       rbx,rcx
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFEAFC6FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rcx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       rbx,rcx
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFEAFC6FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       rbx,rcx
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFEAFC6FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rcx,offset MT_System.Random
       cmp       rbx,rcx
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFEAFC6FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,offset MT_System.StringComparer
       cmp       rbx,rcx
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFEAFC6FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFEAFC6FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 403
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFEAF7CB0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.GenericBench.Unlisted()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rdx,[rbx+20]
       cmp       dword ptr [rdx+8],0
       jle       short M00_L01
M00_L00:
       mov       rdx,[rbx+20]
       cmp       edi,[rdx+8]
       jae       short M00_L02
       mov       rdx,[rdx+rdi*8+10]
       mov       rcx,7FFEAFD1A818
       call      qword ptr [7FFEAFC6FC78]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       add       esi,eax
       inc       edi
       mov       rax,[rbx+20]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rcx,[rcx+18]
       mov       rcx,[rcx]
       mov       rax,offset MT_System.String
       cmp       rcx,rax
       je        near ptr M01_L01
       mov       rax,offset MT_System.Object
       cmp       rcx,rax
       je        near ptr M01_L02
       mov       rax,offset MT_System.Uri
       cmp       rcx,rax
       je        near ptr M01_L03
       mov       rax,offset MT_System.Version
       cmp       rcx,rax
       je        near ptr M01_L04
       mov       rax,offset MT_System.Exception
       cmp       rcx,rax
       je        near ptr M01_L05
       mov       rax,offset MT_System.Type
       cmp       rcx,rax
       je        near ptr M01_L06
       mov       rax,offset MT_System.Int32[]
       cmp       rcx,rax
       je        near ptr M01_L07
       mov       rax,offset MT_System.String[]
       cmp       rcx,rax
       je        near ptr M01_L08
       mov       rax,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       rcx,rax
       je        near ptr M01_L09
       mov       rax,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       rcx,rax
       je        near ptr M01_L10
       mov       rax,offset MT_System.Random
       cmp       rcx,rax
       je        near ptr M01_L11
       mov       rax,offset MT_System.StringComparer
       cmp       rcx,rax
       je        near ptr M01_L12
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFEAFC6FD08]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFEAFC6FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       ecx,2
       call      qword ptr [7FFEAFC6FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       ecx,3
       call      qword ptr [7FFEAFC6FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       ecx,4
       call      qword ptr [7FFEAFC6FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       ecx,5
       call      qword ptr [7FFEAFC6FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L06:
       mov       ecx,6
       call      qword ptr [7FFEAFC6FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFEAFC6FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L08:
       mov       ecx,8
       call      qword ptr [7FFEAFC6FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L09:
       mov       ecx,9
       call      qword ptr [7FFEAFC6FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L10:
       mov       ecx,0A
       call      qword ptr [7FFEAFC6FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,0B
       call      qword ptr [7FFEAFC6FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,0C
       call      qword ptr [7FFEAFC6FD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 434
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFEAF7CB0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.GenericBench.Numbers()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L02
       mov       eax,edi
       mov       ecx,[rcx+rax*4+10]
       call      qword ptr [7FFE73ECEB08]; JitFoldProof.Subjects.Ladder[[System.Int32, System.Private.CoreLib]](Int32)
       add       esi,eax
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 74
```
```assembly
; JitFoldProof.Subjects.Ladder[[System.Int32, System.Private.CoreLib]](Int32)
       sub       rsp,28
       mov       ecx,0D
       call      qword ptr [7FFE73ECEA00]; JitFoldProof.Subjects.Work(Int32)
       nop
       add       rsp,28
       ret
; Total bytes of code 21
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE73C92C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.GenericBench.Words()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rdx,[rbx+10]
       cmp       dword ptr [rdx+8],0
       jle       short M00_L01
M00_L00:
       mov       rdx,[rbx+10]
       cmp       edi,[rdx+8]
       jae       short M00_L02
       mov       ecx,edi
       mov       rdx,[rdx+rcx*8+10]
       mov       rcx,7FFE73E98980
       call      qword ptr [7FFE73E8E2F8]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       add       esi,eax
       inc       edi
       mov       rax,[rbx+10]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 85
```
```assembly
; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.String
       cmp       [rax],r8
       jne       short M01_L01
       mov       ecx,1
       call      qword ptr [7FFE73E8E1F0]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Object
       cmp       [rax],r8
       jne       short M01_L02
       mov       ecx,2
       call      qword ptr [7FFE73E8E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Uri
       cmp       [rax],r8
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFE73E8E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Version
       cmp       [rax],r8
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFE73E8E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Exception
       cmp       [rax],r8
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFE73E8E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Type
       cmp       [rax],r8
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFE73E8E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Int32[]
       cmp       [rax],r8
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFE73E8E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.String[]
       cmp       [rax],r8
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFE73E8E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rax],r8
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFE73E8E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       [rax],r8
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFE73E8E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Random
       cmp       [rax],r8
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFE73E8E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,[rcx+10]
       mov       rax,offset MT_System.StringComparer
       cmp       [rcx],rax
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFE73E8E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFE73E8E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 445
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE73C52C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.GenericBench.Objects()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rdx,[rbx+18]
       cmp       dword ptr [rdx+8],0
       jle       short M00_L01
M00_L00:
       mov       rdx,[rbx+18]
       cmp       edi,[rdx+8]
       jae       short M00_L02
       mov       ecx,edi
       mov       rdx,[rdx+rcx*8+10]
       mov       rcx,7FFE73ED8DD8
       call      qword ptr [7FFE73ECEB08]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       add       esi,eax
       inc       edi
       mov       rax,[rbx+18]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 85
```
```assembly
; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rcx,[rcx+10]
       mov       rbx,[rcx]
       mov       rcx,offset MT_System.String
       cmp       rbx,rcx
       je        short M01_L01
       mov       rcx,offset MT_System.Object
       cmp       rbx,rcx
       jne       short M01_L02
       mov       ecx,2
       call      qword ptr [7FFE73ECEA00]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,30
       pop       rbx
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFE73ECEA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rcx,offset MT_System.Uri
       cmp       rbx,rcx
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFE73ECEA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rcx,offset MT_System.Version
       cmp       rbx,rcx
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFE73ECEA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rcx,offset MT_System.Exception
       cmp       rbx,rcx
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFE73ECEA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       rcx,offset MT_System.Type
       cmp       rbx,rcx
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFE73ECEA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,offset MT_System.Int32[]
       cmp       rbx,rcx
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFE73ECEA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rcx,offset MT_System.String[]
       cmp       rbx,rcx
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFE73ECEA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rcx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       rbx,rcx
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFE73ECEA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       rbx,rcx
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFE73ECEA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rcx,offset MT_System.Random
       cmp       rbx,rcx
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFE73ECEA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,offset MT_System.StringComparer
       cmp       rbx,rcx
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFE73ECEA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFE73ECEA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 403
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE73C92C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.GenericBench.Unlisted()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rdx,[rbx+20]
       cmp       dword ptr [rdx+8],0
       jle       short M00_L01
M00_L00:
       mov       rdx,[rbx+20]
       cmp       edi,[rdx+8]
       jae       short M00_L02
       mov       ecx,edi
       mov       rdx,[rdx+rcx*8+10]
       mov       rcx,7FFE73EA8DD8
       call      qword ptr [7FFE73E9EB08]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       add       esi,eax
       inc       edi
       mov       rax,[rbx+20]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 85
```
```assembly
; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rcx,[rcx+10]
       mov       rcx,[rcx]
       mov       rax,offset MT_System.String
       cmp       rcx,rax
       je        near ptr M01_L01
       mov       rax,offset MT_System.Object
       cmp       rcx,rax
       je        near ptr M01_L02
       mov       rax,offset MT_System.Uri
       cmp       rcx,rax
       je        near ptr M01_L03
       mov       rax,offset MT_System.Version
       cmp       rcx,rax
       je        near ptr M01_L04
       mov       rax,offset MT_System.Exception
       cmp       rcx,rax
       je        near ptr M01_L05
       mov       rax,offset MT_System.Type
       cmp       rcx,rax
       je        near ptr M01_L06
       mov       rax,offset MT_System.Int32[]
       cmp       rcx,rax
       je        near ptr M01_L07
       mov       rax,offset MT_System.String[]
       cmp       rcx,rax
       je        near ptr M01_L08
       mov       rax,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       rcx,rax
       je        near ptr M01_L09
       mov       rax,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       rcx,rax
       je        near ptr M01_L10
       mov       rax,offset MT_System.Random
       cmp       rcx,rax
       je        near ptr M01_L11
       mov       rax,offset MT_System.StringComparer
       cmp       rcx,rax
       je        near ptr M01_L12
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFE73E9EA00]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFE73E9EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       ecx,2
       call      qword ptr [7FFE73E9EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       ecx,3
       call      qword ptr [7FFE73E9EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       ecx,4
       call      qword ptr [7FFE73E9EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       ecx,5
       call      qword ptr [7FFE73E9EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L06:
       mov       ecx,6
       call      qword ptr [7FFE73E9EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFE73E9EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L08:
       mov       ecx,8
       call      qword ptr [7FFE73E9EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L09:
       mov       ecx,9
       call      qword ptr [7FFE73E9EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L10:
       mov       ecx,0A
       call      qword ptr [7FFE73E9EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,0B
       call      qword ptr [7FFE73E9EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,0C
       call      qword ptr [7FFE73E9EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 434
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE73C62C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.GenericBench.Numbers()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L02
       mov       ecx,[rcx+rdi*4+10]
       call      qword ptr [7FFE973EEC40]; JitFoldProof.Subjects.Ladder[[System.Int32, System.Private.CoreLib]](Int32)
       add       esi,eax
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 72
```
```assembly
; JitFoldProof.Subjects.Ladder[[System.Int32, System.Private.CoreLib]](Int32)
       sub       rsp,28
       mov       ecx,0D
       call      qword ptr [7FFE973EECB8]; JitFoldProof.Subjects.Work(Int32)
       nop
       add       rsp,28
       ret
; Total bytes of code 21
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE96F7B0D0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.GenericBench.Words()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rdx,[rbx+10]
       cmp       dword ptr [rdx+8],0
       jle       short M00_L01
M00_L00:
       mov       rdx,[rbx+10]
       cmp       edi,[rdx+8]
       jae       short M00_L02
       mov       rdx,[rdx+rdi*8+10]
       mov       rcx,7FFE974B08F0
       call      qword ptr [7FFE9740EC40]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       add       esi,eax
       inc       edi
       mov       rax,[rbx+10]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.String
       cmp       [rax],r8
       jne       short M01_L01
       mov       ecx,1
       call      qword ptr [7FFE9740ECD0]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Object
       cmp       [rax],r8
       je        near ptr M01_L12
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Uri
       cmp       [rax],r8
       je        near ptr M01_L11
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Version
       cmp       [rax],r8
       je        near ptr M01_L10
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Exception
       cmp       [rax],r8
       je        near ptr M01_L09
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Type
       cmp       [rax],r8
       je        near ptr M01_L08
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Int32[]
       cmp       [rax],r8
       je        near ptr M01_L07
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.String[]
       cmp       [rax],r8
       je        near ptr M01_L06
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rax],r8
       je        near ptr M01_L05
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       [rax],r8
       je        short M01_L04
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Random
       cmp       [rax],r8
       je        short M01_L03
       mov       rcx,[rcx+18]
       mov       rax,offset MT_System.StringComparer
       cmp       [rcx],rax
       je        short M01_L02
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFE9740ECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L02:
       mov       ecx,0C
       call      qword ptr [7FFE9740ECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L03:
       mov       ecx,0B
       call      qword ptr [7FFE9740ECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,0A
       call      qword ptr [7FFE9740ECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       ecx,9
       call      qword ptr [7FFE9740ECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       ecx,8
       call      qword ptr [7FFE9740ECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFE9740ECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       ecx,6
       call      qword ptr [7FFE9740ECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       ecx,5
       call      qword ptr [7FFE9740ECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       ecx,4
       call      qword ptr [7FFE9740ECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,3
       call      qword ptr [7FFE9740ECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,2
       call      qword ptr [7FFE9740ECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 486
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE96F9B0D0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.GenericBench.Objects()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rdx,[rbx+18]
       cmp       dword ptr [rdx+8],0
       jle       short M00_L01
M00_L00:
       mov       rdx,[rbx+18]
       cmp       edi,[rdx+8]
       jae       short M00_L02
       mov       rdx,[rdx+rdi*8+10]
       mov       rcx,7FFE974B08F0
       call      qword ptr [7FFE9740EC40]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       add       esi,eax
       inc       edi
       mov       rax,[rbx+18]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rcx,[rcx+18]
       mov       rbx,[rcx]
       mov       rcx,offset MT_System.String
       cmp       rbx,rcx
       je        near ptr M01_L12
       mov       rcx,offset MT_System.Object
       cmp       rbx,rcx
       jne       short M01_L01
       mov       ecx,2
       call      qword ptr [7FFE9740ECD0]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,30
       pop       rbx
       ret
M01_L01:
       mov       rcx,offset MT_System.Uri
       cmp       rbx,rcx
       je        near ptr M01_L11
       mov       rcx,offset MT_System.Version
       cmp       rbx,rcx
       je        near ptr M01_L10
       mov       rcx,offset MT_System.Exception
       cmp       rbx,rcx
       je        near ptr M01_L09
       mov       rcx,offset MT_System.Type
       cmp       rbx,rcx
       je        near ptr M01_L08
       mov       rcx,offset MT_System.Int32[]
       cmp       rbx,rcx
       je        near ptr M01_L07
       mov       rcx,offset MT_System.String[]
       cmp       rbx,rcx
       je        near ptr M01_L06
       mov       rcx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       rbx,rcx
       je        short M01_L05
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       rbx,rcx
       je        short M01_L04
       mov       rcx,offset MT_System.Random
       cmp       rbx,rcx
       je        short M01_L03
       mov       rcx,offset MT_System.StringComparer
       cmp       rbx,rcx
       je        short M01_L02
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFE9740ECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L02:
       mov       ecx,0C
       call      qword ptr [7FFE9740ECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L03:
       mov       ecx,0B
       call      qword ptr [7FFE9740ECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,0A
       call      qword ptr [7FFE9740ECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       ecx,9
       call      qword ptr [7FFE9740ECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       ecx,8
       call      qword ptr [7FFE9740ECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFE9740ECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       ecx,6
       call      qword ptr [7FFE9740ECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       ecx,5
       call      qword ptr [7FFE9740ECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       ecx,4
       call      qword ptr [7FFE9740ECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,3
       call      qword ptr [7FFE9740ECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,1
       call      qword ptr [7FFE9740ECD0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 443
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE96F9B0D0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.GenericBench.Unlisted()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rdx,[rbx+20]
       cmp       dword ptr [rdx+8],0
       jle       short M00_L01
M00_L00:
       mov       rdx,[rbx+20]
       cmp       edi,[rdx+8]
       jae       short M00_L02
       mov       rdx,[rdx+rdi*8+10]
       mov       rcx,7FFE974AC878
       call      qword ptr [7FFE9740EB68]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       add       esi,eax
       inc       edi
       mov       rax,[rbx+20]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rcx,[rcx+18]
       mov       rcx,[rcx]
       mov       rax,offset MT_System.String
       cmp       rcx,rax
       je        near ptr M01_L12
       mov       rax,offset MT_System.Object
       cmp       rcx,rax
       je        near ptr M01_L11
       mov       rax,offset MT_System.Uri
       cmp       rcx,rax
       je        near ptr M01_L10
       mov       rax,offset MT_System.Version
       cmp       rcx,rax
       je        near ptr M01_L09
       mov       rax,offset MT_System.Exception
       cmp       rcx,rax
       je        near ptr M01_L08
       mov       rax,offset MT_System.Type
       cmp       rcx,rax
       je        near ptr M01_L07
       mov       rax,offset MT_System.Int32[]
       cmp       rcx,rax
       je        near ptr M01_L06
       mov       rax,offset MT_System.String[]
       cmp       rcx,rax
       je        near ptr M01_L05
       mov       rax,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       rcx,rax
       je        short M01_L04
       mov       rax,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       rcx,rax
       je        short M01_L03
       mov       rax,offset MT_System.Random
       cmp       rcx,rax
       je        short M01_L02
       mov       rax,offset MT_System.StringComparer
       cmp       rcx,rax
       je        short M01_L01
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFE9740EBF8]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       ecx,0C
       call      qword ptr [7FFE9740EBF8]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       ecx,0B
       call      qword ptr [7FFE9740EBF8]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       ecx,0A
       call      qword ptr [7FFE9740EBF8]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       ecx,9
       call      qword ptr [7FFE9740EBF8]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       ecx,8
       call      qword ptr [7FFE9740EBF8]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L06:
       mov       ecx,7
       call      qword ptr [7FFE9740EBF8]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L07:
       mov       ecx,6
       call      qword ptr [7FFE9740EBF8]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L08:
       mov       ecx,5
       call      qword ptr [7FFE9740EBF8]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L09:
       mov       ecx,4
       call      qword ptr [7FFE9740EBF8]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L10:
       mov       ecx,3
       call      qword ptr [7FFE9740EBF8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,2
       call      qword ptr [7FFE9740EBF8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,1
       call      qword ptr [7FFE9740EBF8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 418
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE96F9B0D0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.GenericBench.Numbers()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L02
       mov       ecx,[rcx+rdi*4+10]
       call      qword ptr [7FFEAFC6FEA0]; JitFoldProof.Subjects.Ladder[[System.Int32, System.Private.CoreLib]](Int32)
       add       esi,eax
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 72
```
```assembly
; JitFoldProof.Subjects.Ladder[[System.Int32, System.Private.CoreLib]](Int32)
       sub       rsp,28
       mov       ecx,0D
       call      qword ptr [7FFEAFC6FF18]; JitFoldProof.Subjects.Work(Int32)
       nop
       add       rsp,28
       ret
; Total bytes of code 21
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFEAF7CB0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.GenericBench.Words()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rdx,[rbx+10]
       cmp       dword ptr [rdx+8],0
       jle       short M00_L01
M00_L00:
       mov       rdx,[rbx+10]
       cmp       edi,[rdx+8]
       jae       short M00_L02
       mov       rdx,[rdx+rdi*8+10]
       mov       rcx,7FFEAFD38890
       call      qword ptr [7FFEAFC7FDC8]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       add       esi,eax
       inc       edi
       mov       rax,[rbx+10]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.String
       cmp       [rax],r8
       jne       short M01_L01
       mov       ecx,1
       call      qword ptr [7FFEAFC7FE58]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Object
       cmp       [rax],r8
       jne       short M01_L02
       mov       ecx,2
       call      qword ptr [7FFEAFC7FE58]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Uri
       cmp       [rax],r8
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFEAFC7FE58]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Version
       cmp       [rax],r8
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFEAFC7FE58]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Exception
       cmp       [rax],r8
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFEAFC7FE58]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Type
       cmp       [rax],r8
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFEAFC7FE58]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Int32[]
       cmp       [rax],r8
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFEAFC7FE58]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.String[]
       cmp       [rax],r8
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFEAFC7FE58]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rax],r8
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFEAFC7FE58]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       [rax],r8
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFEAFC7FE58]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Random
       cmp       [rax],r8
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFEAFC7FE58]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,[rcx+18]
       mov       rax,offset MT_System.StringComparer
       cmp       [rcx],rax
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFEAFC7FE58]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFEAFC7FE58]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 445
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFEAF7DB0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.GenericBench.Objects()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rdx,[rbx+18]
       cmp       dword ptr [rdx+8],0
       jle       short M00_L01
M00_L00:
       mov       rdx,[rbx+18]
       cmp       edi,[rdx+8]
       jae       short M00_L02
       mov       rdx,[rdx+rdi*8+10]
       mov       rcx,7FFEAFD28890
       call      qword ptr [7FFEAFC6FDC8]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       add       esi,eax
       inc       edi
       mov       rax,[rbx+18]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rcx,[rcx+18]
       mov       rbx,[rcx]
       mov       rcx,offset MT_System.String
       cmp       rbx,rcx
       je        short M01_L01
       mov       rcx,offset MT_System.Object
       cmp       rbx,rcx
       jne       short M01_L02
       mov       ecx,2
       call      qword ptr [7FFEAFC6FE58]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,30
       pop       rbx
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFEAFC6FE58]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rcx,offset MT_System.Uri
       cmp       rbx,rcx
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFEAFC6FE58]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rcx,offset MT_System.Version
       cmp       rbx,rcx
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFEAFC6FE58]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rcx,offset MT_System.Exception
       cmp       rbx,rcx
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFEAFC6FE58]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       rcx,offset MT_System.Type
       cmp       rbx,rcx
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFEAFC6FE58]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,offset MT_System.Int32[]
       cmp       rbx,rcx
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFEAFC6FE58]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rcx,offset MT_System.String[]
       cmp       rbx,rcx
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFEAFC6FE58]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rcx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       rbx,rcx
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFEAFC6FE58]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       rbx,rcx
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFEAFC6FE58]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rcx,offset MT_System.Random
       cmp       rbx,rcx
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFEAFC6FE58]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,offset MT_System.StringComparer
       cmp       rbx,rcx
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFEAFC6FE58]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFEAFC6FE58]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 403
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFEAF7CB0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; JitFoldProof.Benchmarks.GenericBench.Unlisted()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rdx,[rbx+20]
       cmp       dword ptr [rdx+8],0
       jle       short M00_L01
M00_L00:
       mov       rdx,[rbx+20]
       cmp       edi,[rdx+8]
       jae       short M00_L02
       mov       rdx,[rdx+rdi*8+10]
       mov       rcx,7FFEAFD38890
       call      qword ptr [7FFEAFC7FDC8]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       add       esi,eax
       inc       edi
       mov       rax,[rbx+20]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rcx,[rcx+18]
       mov       rcx,[rcx]
       mov       rax,offset MT_System.String
       cmp       rcx,rax
       je        near ptr M01_L01
       mov       rax,offset MT_System.Object
       cmp       rcx,rax
       je        near ptr M01_L02
       mov       rax,offset MT_System.Uri
       cmp       rcx,rax
       je        near ptr M01_L03
       mov       rax,offset MT_System.Version
       cmp       rcx,rax
       je        near ptr M01_L04
       mov       rax,offset MT_System.Exception
       cmp       rcx,rax
       je        near ptr M01_L05
       mov       rax,offset MT_System.Type
       cmp       rcx,rax
       je        near ptr M01_L06
       mov       rax,offset MT_System.Int32[]
       cmp       rcx,rax
       je        near ptr M01_L07
       mov       rax,offset MT_System.String[]
       cmp       rcx,rax
       je        near ptr M01_L08
       mov       rax,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       rcx,rax
       je        near ptr M01_L09
       mov       rax,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       rcx,rax
       je        near ptr M01_L10
       mov       rax,offset MT_System.Random
       cmp       rcx,rax
       je        near ptr M01_L11
       mov       rax,offset MT_System.StringComparer
       cmp       rcx,rax
       je        near ptr M01_L12
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFEAFC7FE58]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFEAFC7FE58]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       ecx,2
       call      qword ptr [7FFEAFC7FE58]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       ecx,3
       call      qword ptr [7FFEAFC7FE58]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       ecx,4
       call      qword ptr [7FFEAFC7FE58]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       ecx,5
       call      qword ptr [7FFEAFC7FE58]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L06:
       mov       ecx,6
       call      qword ptr [7FFEAFC7FE58]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFEAFC7FE58]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L08:
       mov       ecx,8
       call      qword ptr [7FFEAFC7FE58]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L09:
       mov       ecx,9
       call      qword ptr [7FFEAFC7FE58]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L10:
       mov       ecx,0A
       call      qword ptr [7FFEAFC7FE58]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,0B
       call      qword ptr [7FFEAFC7FE58]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,0C
       call      qword ptr [7FFEAFC7FE58]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 434
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFEAF7DB0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.GenericBench.Numbers()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L02
       mov       eax,edi
       mov       ecx,[rcx+rax*4+10]
       call      qword ptr [7FFE97535680]; JitFoldProof.Subjects.Ladder[[System.Int32, System.Private.CoreLib]](Int32)
       add       esi,eax
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 74
```
```assembly
; JitFoldProof.Subjects.Ladder[[System.Int32, System.Private.CoreLib]](Int32)
       sub       rsp,28
       mov       ecx,0D
       call      qword ptr [7FFE97535578]; JitFoldProof.Subjects.Work(Int32)
       nop
       add       rsp,28
       ret
; Total bytes of code 21
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE972C2C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.GenericBench.Words()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rdx,[rbx+10]
       cmp       dword ptr [rdx+8],0
       jle       short M00_L01
M00_L00:
       mov       rdx,[rbx+10]
       cmp       edi,[rdx+8]
       jae       short M00_L02
       mov       ecx,edi
       mov       rdx,[rdx+rcx*8+10]
       mov       rcx,7FFE975292E8
       call      qword ptr [7FFE97535680]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       add       esi,eax
       inc       edi
       mov       rax,[rbx+10]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 85
```
```assembly
; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.String
       cmp       [rax],r8
       jne       short M01_L01
       mov       ecx,1
       call      qword ptr [7FFE97535578]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Object
       cmp       [rax],r8
       jne       short M01_L02
       mov       ecx,2
       call      qword ptr [7FFE97535578]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Uri
       cmp       [rax],r8
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFE97535578]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Version
       cmp       [rax],r8
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFE97535578]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Exception
       cmp       [rax],r8
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFE97535578]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Type
       cmp       [rax],r8
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFE97535578]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Int32[]
       cmp       [rax],r8
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFE97535578]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.String[]
       cmp       [rax],r8
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFE97535578]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rax],r8
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFE97535578]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       [rax],r8
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFE97535578]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Random
       cmp       [rax],r8
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFE97535578]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,[rcx+10]
       mov       rax,offset MT_System.StringComparer
       cmp       [rcx],rax
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFE97535578]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFE97535578]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 445
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE972C2C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.GenericBench.Objects()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rdx,[rbx+18]
       cmp       dword ptr [rdx+8],0
       jle       short M00_L01
M00_L00:
       mov       rdx,[rbx+18]
       cmp       edi,[rdx+8]
       jae       short M00_L02
       mov       ecx,edi
       mov       rdx,[rdx+rcx*8+10]
       mov       rcx,7FFE97518F10
       call      qword ptr [7FFE975253C8]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       add       esi,eax
       inc       edi
       mov       rax,[rbx+18]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 85
```
```assembly
; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rcx,[rcx+10]
       mov       rbx,[rcx]
       mov       rcx,offset MT_System.String
       cmp       rbx,rcx
       je        short M01_L01
       mov       rcx,offset MT_System.Object
       cmp       rbx,rcx
       jne       short M01_L02
       mov       ecx,2
       call      qword ptr [7FFE975252C0]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,30
       pop       rbx
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFE975252C0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rcx,offset MT_System.Uri
       cmp       rbx,rcx
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFE975252C0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rcx,offset MT_System.Version
       cmp       rbx,rcx
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFE975252C0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rcx,offset MT_System.Exception
       cmp       rbx,rcx
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFE975252C0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       rcx,offset MT_System.Type
       cmp       rbx,rcx
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFE975252C0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,offset MT_System.Int32[]
       cmp       rbx,rcx
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFE975252C0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rcx,offset MT_System.String[]
       cmp       rbx,rcx
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFE975252C0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rcx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       rbx,rcx
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFE975252C0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       rbx,rcx
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFE975252C0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rcx,offset MT_System.Random
       cmp       rbx,rcx
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFE975252C0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,offset MT_System.StringComparer
       cmp       rbx,rcx
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFE975252C0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFE975252C0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 403
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE972B2C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; JitFoldProof.Benchmarks.GenericBench.Unlisted()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rdx,[rbx+20]
       cmp       dword ptr [rdx+8],0
       jle       short M00_L01
M00_L00:
       mov       rdx,[rbx+20]
       cmp       edi,[rdx+8]
       jae       short M00_L02
       mov       ecx,edi
       mov       rdx,[rdx+rcx*8+10]
       mov       rcx,7FFE975392E8
       call      qword ptr [7FFE97545680]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       add       esi,eax
       inc       edi
       mov       rax,[rbx+20]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 85
```
```assembly
; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rcx,[rcx+10]
       mov       rcx,[rcx]
       mov       rax,offset MT_System.String
       cmp       rcx,rax
       je        near ptr M01_L01
       mov       rax,offset MT_System.Object
       cmp       rcx,rax
       je        near ptr M01_L02
       mov       rax,offset MT_System.Uri
       cmp       rcx,rax
       je        near ptr M01_L03
       mov       rax,offset MT_System.Version
       cmp       rcx,rax
       je        near ptr M01_L04
       mov       rax,offset MT_System.Exception
       cmp       rcx,rax
       je        near ptr M01_L05
       mov       rax,offset MT_System.Type
       cmp       rcx,rax
       je        near ptr M01_L06
       mov       rax,offset MT_System.Int32[]
       cmp       rcx,rax
       je        near ptr M01_L07
       mov       rax,offset MT_System.String[]
       cmp       rcx,rax
       je        near ptr M01_L08
       mov       rax,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       rcx,rax
       je        near ptr M01_L09
       mov       rax,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       rcx,rax
       je        near ptr M01_L10
       mov       rax,offset MT_System.Random
       cmp       rcx,rax
       je        near ptr M01_L11
       mov       rax,offset MT_System.StringComparer
       cmp       rcx,rax
       je        near ptr M01_L12
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFE97545578]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFE97545578]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       ecx,2
       call      qword ptr [7FFE97545578]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       ecx,3
       call      qword ptr [7FFE97545578]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       ecx,4
       call      qword ptr [7FFE97545578]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       ecx,5
       call      qword ptr [7FFE97545578]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L06:
       mov       ecx,6
       call      qword ptr [7FFE97545578]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFE97545578]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L08:
       mov       ecx,8
       call      qword ptr [7FFE97545578]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L09:
       mov       ecx,9
       call      qword ptr [7FFE97545578]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L10:
       mov       ecx,0A
       call      qword ptr [7FFE97545578]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,0B
       call      qword ptr [7FFE97545578]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,0C
       call      qword ptr [7FFE97545578]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 434
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE972D2C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.GenericBench.Numbers()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       short M00_L02
       mov       ecx,[rcx+rdi*4+10]
       call      qword ptr [7FFE973FEDC0]; JitFoldProof.Subjects.Ladder[[System.Int32, System.Private.CoreLib]](Int32)
       add       esi,eax
       inc       edi
       mov       rax,[rbx+8]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 72
```
```assembly
; JitFoldProof.Subjects.Ladder[[System.Int32, System.Private.CoreLib]](Int32)
       sub       rsp,28
       mov       ecx,0D
       call      qword ptr [7FFE973FEE38]; JitFoldProof.Subjects.Work(Int32)
       nop
       add       rsp,28
       ret
; Total bytes of code 21
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE96F7B0D0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.GenericBench.Words()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rdx,[rbx+10]
       cmp       dword ptr [rdx+8],0
       jle       short M00_L01
M00_L00:
       mov       rdx,[rbx+10]
       cmp       edi,[rdx+8]
       jae       short M00_L02
       mov       rdx,[rdx+rdi*8+10]
       mov       rcx,7FFE974CDD00
       call      qword ptr [7FFE9742ECE8]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       add       esi,eax
       inc       edi
       mov       rax,[rbx+10]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.String
       cmp       [rax],r8
       jne       short M01_L01
       mov       ecx,1
       call      qword ptr [7FFE9742ED78]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Object
       cmp       [rax],r8
       je        near ptr M01_L12
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Uri
       cmp       [rax],r8
       je        near ptr M01_L11
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Version
       cmp       [rax],r8
       je        near ptr M01_L10
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Exception
       cmp       [rax],r8
       je        near ptr M01_L09
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Type
       cmp       [rax],r8
       je        near ptr M01_L08
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Int32[]
       cmp       [rax],r8
       je        near ptr M01_L07
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.String[]
       cmp       [rax],r8
       je        near ptr M01_L06
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rax],r8
       je        near ptr M01_L05
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       [rax],r8
       je        short M01_L04
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Random
       cmp       [rax],r8
       je        short M01_L03
       mov       rcx,[rcx+18]
       mov       rax,offset MT_System.StringComparer
       cmp       [rcx],rax
       je        short M01_L02
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFE9742ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L02:
       mov       ecx,0C
       call      qword ptr [7FFE9742ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L03:
       mov       ecx,0B
       call      qword ptr [7FFE9742ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,0A
       call      qword ptr [7FFE9742ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       ecx,9
       call      qword ptr [7FFE9742ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       ecx,8
       call      qword ptr [7FFE9742ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFE9742ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       ecx,6
       call      qword ptr [7FFE9742ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       ecx,5
       call      qword ptr [7FFE9742ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       ecx,4
       call      qword ptr [7FFE9742ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,3
       call      qword ptr [7FFE9742ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,2
       call      qword ptr [7FFE9742ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 486
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE96FAB0D0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.GenericBench.Objects()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rdx,[rbx+18]
       cmp       dword ptr [rdx+8],0
       jle       short M00_L01
M00_L00:
       mov       rdx,[rbx+18]
       cmp       edi,[rdx+8]
       jae       short M00_L02
       mov       rdx,[rdx+rdi*8+10]
       mov       rcx,7FFE974C1D10
       call      qword ptr [7FFE9741EDC0]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       add       esi,eax
       inc       edi
       mov       rax,[rbx+18]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rcx,[rcx+18]
       mov       rbx,[rcx]
       mov       rcx,offset MT_System.String
       cmp       rbx,rcx
       je        near ptr M01_L12
       mov       rcx,offset MT_System.Object
       cmp       rbx,rcx
       jne       short M01_L01
       mov       ecx,2
       call      qword ptr [7FFE9741EE50]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,30
       pop       rbx
       ret
M01_L01:
       mov       rcx,offset MT_System.Uri
       cmp       rbx,rcx
       je        near ptr M01_L11
       mov       rcx,offset MT_System.Version
       cmp       rbx,rcx
       je        near ptr M01_L10
       mov       rcx,offset MT_System.Exception
       cmp       rbx,rcx
       je        near ptr M01_L09
       mov       rcx,offset MT_System.Type
       cmp       rbx,rcx
       je        near ptr M01_L08
       mov       rcx,offset MT_System.Int32[]
       cmp       rbx,rcx
       je        near ptr M01_L07
       mov       rcx,offset MT_System.String[]
       cmp       rbx,rcx
       je        near ptr M01_L06
       mov       rcx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       rbx,rcx
       je        short M01_L05
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       rbx,rcx
       je        short M01_L04
       mov       rcx,offset MT_System.Random
       cmp       rbx,rcx
       je        short M01_L03
       mov       rcx,offset MT_System.StringComparer
       cmp       rbx,rcx
       je        short M01_L02
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFE9741EE50]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L02:
       mov       ecx,0C
       call      qword ptr [7FFE9741EE50]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L03:
       mov       ecx,0B
       call      qword ptr [7FFE9741EE50]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,0A
       call      qword ptr [7FFE9741EE50]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       ecx,9
       call      qword ptr [7FFE9741EE50]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       ecx,8
       call      qword ptr [7FFE9741EE50]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFE9741EE50]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       ecx,6
       call      qword ptr [7FFE9741EE50]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       ecx,5
       call      qword ptr [7FFE9741EE50]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       ecx,4
       call      qword ptr [7FFE9741EE50]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,3
       call      qword ptr [7FFE9741EE50]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,1
       call      qword ptr [7FFE9741EE50]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 443
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE96F9B0D0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; JitFoldProof.Benchmarks.GenericBench.Unlisted()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       mov       rdx,[rbx+20]
       cmp       dword ptr [rdx+8],0
       jle       short M00_L01
M00_L00:
       mov       rdx,[rbx+20]
       cmp       edi,[rdx+8]
       jae       short M00_L02
       mov       rdx,[rdx+rdi*8+10]
       mov       rcx,7FFE974CDD00
       call      qword ptr [7FFE9742ECE8]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       add       esi,eax
       inc       edi
       mov       rax,[rbx+20]
       cmp       [rax+8],edi
       jg        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 83
```
```assembly
; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rcx,[rcx+18]
       mov       rcx,[rcx]
       mov       rax,offset MT_System.String
       cmp       rcx,rax
       je        near ptr M01_L12
       mov       rax,offset MT_System.Object
       cmp       rcx,rax
       je        near ptr M01_L11
       mov       rax,offset MT_System.Uri
       cmp       rcx,rax
       je        near ptr M01_L10
       mov       rax,offset MT_System.Version
       cmp       rcx,rax
       je        near ptr M01_L09
       mov       rax,offset MT_System.Exception
       cmp       rcx,rax
       je        near ptr M01_L08
       mov       rax,offset MT_System.Type
       cmp       rcx,rax
       je        near ptr M01_L07
       mov       rax,offset MT_System.Int32[]
       cmp       rcx,rax
       je        near ptr M01_L06
       mov       rax,offset MT_System.String[]
       cmp       rcx,rax
       je        near ptr M01_L05
       mov       rax,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       rcx,rax
       je        short M01_L04
       mov       rax,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       rcx,rax
       je        short M01_L03
       mov       rax,offset MT_System.Random
       cmp       rcx,rax
       je        short M01_L02
       mov       rax,offset MT_System.StringComparer
       cmp       rcx,rax
       je        short M01_L01
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFE9742ED78]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       ecx,0C
       call      qword ptr [7FFE9742ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       ecx,0B
       call      qword ptr [7FFE9742ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       ecx,0A
       call      qword ptr [7FFE9742ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       ecx,9
       call      qword ptr [7FFE9742ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       ecx,8
       call      qword ptr [7FFE9742ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L06:
       mov       ecx,7
       call      qword ptr [7FFE9742ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L07:
       mov       ecx,6
       call      qword ptr [7FFE9742ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L08:
       mov       ecx,5
       call      qword ptr [7FFE9742ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L09:
       mov       ecx,4
       call      qword ptr [7FFE9742ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L10:
       mov       ecx,3
       call      qword ptr [7FFE9742ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,2
       call      qword ptr [7FFE9742ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,1
       call      qword ptr [7FFE9742ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 418
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE96FAB0D0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

