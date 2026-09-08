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
       call      qword ptr [7FFDF2A4FA68]; JitFoldProof.Subjects.Ladder[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FFDF2A4FAE0]; JitFoldProof.Subjects.Work(Int32)
       nop
       add       rsp,28
       ret
; Total bytes of code 21
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFDF25AB0F0
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
       mov       rcx,7FFDF2ADEE60
       call      qword ptr [7FFDF2A4F9A8]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFDF2A4FA38]; JitFoldProof.Subjects.Work(Int32)
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
       call      qword ptr [7FFDF2A4FA38]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Uri
       cmp       [rax],r8
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFDF2A4FA38]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Version
       cmp       [rax],r8
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFDF2A4FA38]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Exception
       cmp       [rax],r8
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFDF2A4FA38]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Type
       cmp       [rax],r8
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFDF2A4FA38]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Int32[]
       cmp       [rax],r8
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFDF2A4FA38]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.String[]
       cmp       [rax],r8
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFDF2A4FA38]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rax],r8
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFDF2A4FA38]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       [rax],r8
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFDF2A4FA38]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Random
       cmp       [rax],r8
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFDF2A4FA38]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,[rcx+18]
       mov       rax,offset MT_System.StringComparer
       cmp       [rcx],rax
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFDF2A4FA38]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFDF2A4FA38]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 445
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFDF25AB0F0
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
       mov       rcx,7FFDF2B23278
       call      qword ptr [7FFDF2A7FA50]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFDF2A7FAE0]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,30
       pop       rbx
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFDF2A7FAE0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rcx,offset MT_System.Uri
       cmp       rbx,rcx
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFDF2A7FAE0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rcx,offset MT_System.Version
       cmp       rbx,rcx
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFDF2A7FAE0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rcx,offset MT_System.Exception
       cmp       rbx,rcx
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFDF2A7FAE0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       rcx,offset MT_System.Type
       cmp       rbx,rcx
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFDF2A7FAE0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,offset MT_System.Int32[]
       cmp       rbx,rcx
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFDF2A7FAE0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rcx,offset MT_System.String[]
       cmp       rbx,rcx
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFDF2A7FAE0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rcx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       rbx,rcx
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFDF2A7FAE0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       rbx,rcx
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFDF2A7FAE0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rcx,offset MT_System.Random
       cmp       rbx,rcx
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFDF2A7FAE0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,offset MT_System.StringComparer
       cmp       rbx,rcx
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFDF2A7FAE0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFDF2A7FAE0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 403
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFDF25DB0F0
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
       mov       rcx,7FFDF2B13288
       call      qword ptr [7FFDF2A6FA80]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFDF2A6FB10]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFDF2A6FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       ecx,2
       call      qword ptr [7FFDF2A6FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       ecx,3
       call      qword ptr [7FFDF2A6FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       ecx,4
       call      qword ptr [7FFDF2A6FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       ecx,5
       call      qword ptr [7FFDF2A6FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L06:
       mov       ecx,6
       call      qword ptr [7FFDF2A6FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFDF2A6FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L08:
       mov       ecx,8
       call      qword ptr [7FFDF2A6FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L09:
       mov       ecx,9
       call      qword ptr [7FFDF2A6FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L10:
       mov       ecx,0A
       call      qword ptr [7FFDF2A6FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,0B
       call      qword ptr [7FFDF2A6FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,0C
       call      qword ptr [7FFDF2A6FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 434
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFDF25CB0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E8E2F8]; JitFoldProof.Subjects.Ladder[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FFDC8E8E1F0]; JitFoldProof.Subjects.Work(Int32)
       nop
       add       rsp,28
       ret
; Total bytes of code 21
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFDC8C52C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       mov       rcx,7FFDC8E78CC8
       call      qword ptr [7FFDC8E6EB08]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFDC8E6EA00]; JitFoldProof.Subjects.Work(Int32)
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
       call      qword ptr [7FFDC8E6EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Uri
       cmp       [rax],r8
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFDC8E6EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Version
       cmp       [rax],r8
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFDC8E6EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Exception
       cmp       [rax],r8
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFDC8E6EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Type
       cmp       [rax],r8
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFDC8E6EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Int32[]
       cmp       [rax],r8
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFDC8E6EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.String[]
       cmp       [rax],r8
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFDC8E6EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rax],r8
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFDC8E6EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       [rax],r8
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFDC8E6EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Random
       cmp       [rax],r8
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFDC8E6EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,[rcx+10]
       mov       rax,offset MT_System.StringComparer
       cmp       [rcx],rax
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFDC8E6EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFDC8E6EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 445
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFDC8C32C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       mov       rcx,7FFDC8E88970
       call      qword ptr [7FFDC8E7E2F8]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFDC8E7E1F0]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,30
       pop       rbx
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFDC8E7E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rcx,offset MT_System.Uri
       cmp       rbx,rcx
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFDC8E7E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rcx,offset MT_System.Version
       cmp       rbx,rcx
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFDC8E7E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rcx,offset MT_System.Exception
       cmp       rbx,rcx
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFDC8E7E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       rcx,offset MT_System.Type
       cmp       rbx,rcx
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFDC8E7E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,offset MT_System.Int32[]
       cmp       rbx,rcx
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFDC8E7E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rcx,offset MT_System.String[]
       cmp       rbx,rcx
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFDC8E7E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rcx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       rbx,rcx
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFDC8E7E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       rbx,rcx
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFDC8E7E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rcx,offset MT_System.Random
       cmp       rbx,rcx
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFDC8E7E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,offset MT_System.StringComparer
       cmp       rbx,rcx
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFDC8E7E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFDC8E7E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 403
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFDC8C42C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       mov       rcx,7FFDC8EA8CC8
       call      qword ptr [7FFDC8E9EB08]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFDC8E9EA00]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFDC8E9EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       ecx,2
       call      qword ptr [7FFDC8E9EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       ecx,3
       call      qword ptr [7FFDC8E9EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       ecx,4
       call      qword ptr [7FFDC8E9EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       ecx,5
       call      qword ptr [7FFDC8E9EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L06:
       mov       ecx,6
       call      qword ptr [7FFDC8E9EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFDC8E9EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L08:
       mov       ecx,8
       call      qword ptr [7FFDC8E9EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L09:
       mov       ecx,9
       call      qword ptr [7FFDC8E9EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L10:
       mov       ecx,0A
       call      qword ptr [7FFDC8E9EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,0B
       call      qword ptr [7FFDC8E9EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,0C
       call      qword ptr [7FFDC8E9EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 434
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFDC8C62C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD9033EC10]; JitFoldProof.Subjects.Ladder[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FFD9033EC88]; JitFoldProof.Subjects.Work(Int32)
       nop
       add       rsp,28
       ret
; Total bytes of code 21
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFD8FECB0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       mov       rcx,7FFD94FF22A0
       call      qword ptr [7FFD94F4ECD0]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFD94F4ED60]; JitFoldProof.Subjects.Work(Int32)
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
       call      qword ptr [7FFD94F4ED60]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L02:
       mov       ecx,0C
       call      qword ptr [7FFD94F4ED60]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L03:
       mov       ecx,0B
       call      qword ptr [7FFD94F4ED60]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,0A
       call      qword ptr [7FFD94F4ED60]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       ecx,9
       call      qword ptr [7FFD94F4ED60]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       ecx,8
       call      qword ptr [7FFD94F4ED60]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFD94F4ED60]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       ecx,6
       call      qword ptr [7FFD94F4ED60]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       ecx,5
       call      qword ptr [7FFD94F4ED60]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       ecx,4
       call      qword ptr [7FFD94F4ED60]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,3
       call      qword ptr [7FFD94F4ED60]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,2
       call      qword ptr [7FFD94F4ED60]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 486
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFD94ADB0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       mov       rcx,7FFD94FF22B0
       call      qword ptr [7FFD94F4ECE8]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFD94F4ED78]; JitFoldProof.Subjects.Work(Int32)
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
       call      qword ptr [7FFD94F4ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L02:
       mov       ecx,0C
       call      qword ptr [7FFD94F4ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L03:
       mov       ecx,0B
       call      qword ptr [7FFD94F4ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,0A
       call      qword ptr [7FFD94F4ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       ecx,9
       call      qword ptr [7FFD94F4ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       ecx,8
       call      qword ptr [7FFD94F4ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFD94F4ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       ecx,6
       call      qword ptr [7FFD94F4ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       ecx,5
       call      qword ptr [7FFD94F4ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       ecx,4
       call      qword ptr [7FFD94F4ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,3
       call      qword ptr [7FFD94F4ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,1
       call      qword ptr [7FFD94F4ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 443
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFD94ADB0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       mov       rcx,7FFD94FF22B0
       call      qword ptr [7FFD94F4ECE8]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFD94F4ED78]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       ecx,0C
       call      qword ptr [7FFD94F4ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       ecx,0B
       call      qword ptr [7FFD94F4ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       ecx,0A
       call      qword ptr [7FFD94F4ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       ecx,9
       call      qword ptr [7FFD94F4ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       ecx,8
       call      qword ptr [7FFD94F4ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L06:
       mov       ecx,7
       call      qword ptr [7FFD94F4ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L07:
       mov       ecx,6
       call      qword ptr [7FFD94F4ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L08:
       mov       ecx,5
       call      qword ptr [7FFD94F4ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L09:
       mov       ecx,4
       call      qword ptr [7FFD94F4ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L10:
       mov       ecx,3
       call      qword ptr [7FFD94F4ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,2
       call      qword ptr [7FFD94F4ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,1
       call      qword ptr [7FFD94F4ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 418
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFD94ADB0F0
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
       call      qword ptr [7FFDF2A4FA80]; JitFoldProof.Subjects.Ladder[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FFDF2A4FAF8]; JitFoldProof.Subjects.Work(Int32)
       nop
       add       rsp,28
       ret
; Total bytes of code 21
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFDF25AB0F0
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
       mov       rcx,7FFDF2B23288
       call      qword ptr [7FFDF2A7FA80]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFDF2A7FB10]; JitFoldProof.Subjects.Work(Int32)
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
       call      qword ptr [7FFDF2A7FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Uri
       cmp       [rax],r8
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFDF2A7FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Version
       cmp       [rax],r8
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFDF2A7FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Exception
       cmp       [rax],r8
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFDF2A7FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Type
       cmp       [rax],r8
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFDF2A7FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Int32[]
       cmp       [rax],r8
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFDF2A7FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.String[]
       cmp       [rax],r8
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFDF2A7FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rax],r8
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFDF2A7FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       [rax],r8
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFDF2A7FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Random
       cmp       [rax],r8
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFDF2A7FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,[rcx+18]
       mov       rax,offset MT_System.StringComparer
       cmp       [rcx],rax
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFDF2A7FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFDF2A7FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 445
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFDF25DB0F0
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
       mov       rcx,7FFDF2B23288
       call      qword ptr [7FFDF2A7FA80]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFDF2A7FB10]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,30
       pop       rbx
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFDF2A7FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rcx,offset MT_System.Uri
       cmp       rbx,rcx
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFDF2A7FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rcx,offset MT_System.Version
       cmp       rbx,rcx
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFDF2A7FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rcx,offset MT_System.Exception
       cmp       rbx,rcx
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFDF2A7FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       rcx,offset MT_System.Type
       cmp       rbx,rcx
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFDF2A7FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,offset MT_System.Int32[]
       cmp       rbx,rcx
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFDF2A7FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rcx,offset MT_System.String[]
       cmp       rbx,rcx
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFDF2A7FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rcx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       rbx,rcx
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFDF2A7FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       rbx,rcx
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFDF2A7FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rcx,offset MT_System.Random
       cmp       rbx,rcx
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFDF2A7FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,offset MT_System.StringComparer
       cmp       rbx,rcx
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFDF2A7FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFDF2A7FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 403
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFDF25DB0F0
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
       mov       rcx,7FFDF2AF3288
       call      qword ptr [7FFDF2A4FA80]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFDF2A4FB10]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFDF2A4FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       ecx,2
       call      qword ptr [7FFDF2A4FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       ecx,3
       call      qword ptr [7FFDF2A4FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       ecx,4
       call      qword ptr [7FFDF2A4FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       ecx,5
       call      qword ptr [7FFDF2A4FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L06:
       mov       ecx,6
       call      qword ptr [7FFDF2A4FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFDF2A4FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L08:
       mov       ecx,8
       call      qword ptr [7FFDF2A4FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L09:
       mov       ecx,9
       call      qword ptr [7FFDF2A4FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L10:
       mov       ecx,0A
       call      qword ptr [7FFDF2A4FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,0B
       call      qword ptr [7FFDF2A4FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,0C
       call      qword ptr [7FFDF2A4FB10]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 434
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFDF25AB0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8E8EB08]; JitFoldProof.Subjects.Ladder[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FFDC8E8EA00]; JitFoldProof.Subjects.Work(Int32)
       nop
       add       rsp,28
       ret
; Total bytes of code 21
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFDC8C52C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       mov       rcx,7FFDC8E98CC8
       call      qword ptr [7FFDC8E8EB08]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFDC8E8EA00]; JitFoldProof.Subjects.Work(Int32)
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
       call      qword ptr [7FFDC8E8EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Uri
       cmp       [rax],r8
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFDC8E8EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Version
       cmp       [rax],r8
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFDC8E8EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Exception
       cmp       [rax],r8
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFDC8E8EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Type
       cmp       [rax],r8
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFDC8E8EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Int32[]
       cmp       [rax],r8
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFDC8E8EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.String[]
       cmp       [rax],r8
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFDC8E8EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rax],r8
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFDC8E8EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       [rax],r8
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFDC8E8EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Random
       cmp       [rax],r8
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFDC8E8EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,[rcx+10]
       mov       rax,offset MT_System.StringComparer
       cmp       [rcx],rax
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFDC8E8EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFDC8E8EA00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 445
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFDC8C52C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       mov       rcx,7FFDC8E68970
       call      qword ptr [7FFDC8E5E2F8]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFDC8E5E1F0]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,30
       pop       rbx
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFDC8E5E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rcx,offset MT_System.Uri
       cmp       rbx,rcx
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFDC8E5E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rcx,offset MT_System.Version
       cmp       rbx,rcx
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFDC8E5E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rcx,offset MT_System.Exception
       cmp       rbx,rcx
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFDC8E5E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       rcx,offset MT_System.Type
       cmp       rbx,rcx
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFDC8E5E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,offset MT_System.Int32[]
       cmp       rbx,rcx
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFDC8E5E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rcx,offset MT_System.String[]
       cmp       rbx,rcx
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFDC8E5E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rcx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       rbx,rcx
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFDC8E5E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       rbx,rcx
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFDC8E5E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rcx,offset MT_System.Random
       cmp       rbx,rcx
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFDC8E5E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,offset MT_System.StringComparer
       cmp       rbx,rcx
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFDC8E5E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFDC8E5E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 403
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFDC8C22C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       mov       rcx,7FFDC8E98970
       call      qword ptr [7FFDC8E8E2F8]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFDC8E8E1F0]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFDC8E8E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       ecx,2
       call      qword ptr [7FFDC8E8E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       ecx,3
       call      qword ptr [7FFDC8E8E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       ecx,4
       call      qword ptr [7FFDC8E8E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       ecx,5
       call      qword ptr [7FFDC8E8E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L06:
       mov       ecx,6
       call      qword ptr [7FFDC8E8E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFDC8E8E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L08:
       mov       ecx,8
       call      qword ptr [7FFDC8E8E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L09:
       mov       ecx,9
       call      qword ptr [7FFDC8E8E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L10:
       mov       ecx,0A
       call      qword ptr [7FFDC8E8E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,0B
       call      qword ptr [7FFDC8E8E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,0C
       call      qword ptr [7FFDC8E8E1F0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 434
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFDC8C52C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD94F5ECD0]; JitFoldProof.Subjects.Ladder[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FFD94F5ED48]; JitFoldProof.Subjects.Work(Int32)
       nop
       add       rsp,28
       ret
; Total bytes of code 21
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFD94AEB0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       mov       rcx,7FFD94FCE238
       call      qword ptr [7FFD94F3EC10]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFD94F3ECA0]; JitFoldProof.Subjects.Work(Int32)
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
       call      qword ptr [7FFD94F3ECA0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L02:
       mov       ecx,0C
       call      qword ptr [7FFD94F3ECA0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L03:
       mov       ecx,0B
       call      qword ptr [7FFD94F3ECA0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,0A
       call      qword ptr [7FFD94F3ECA0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       ecx,9
       call      qword ptr [7FFD94F3ECA0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       ecx,8
       call      qword ptr [7FFD94F3ECA0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFD94F3ECA0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       ecx,6
       call      qword ptr [7FFD94F3ECA0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       ecx,5
       call      qword ptr [7FFD94F3ECA0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       ecx,4
       call      qword ptr [7FFD94F3ECA0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,3
       call      qword ptr [7FFD94F3ECA0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,2
       call      qword ptr [7FFD94F3ECA0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 486
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFD94ACB0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       mov       rcx,7FFD94FF2390
       call      qword ptr [7FFD94F4ECE8]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFD94F4ED78]; JitFoldProof.Subjects.Work(Int32)
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
       call      qword ptr [7FFD94F4ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L02:
       mov       ecx,0C
       call      qword ptr [7FFD94F4ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L03:
       mov       ecx,0B
       call      qword ptr [7FFD94F4ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,0A
       call      qword ptr [7FFD94F4ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       ecx,9
       call      qword ptr [7FFD94F4ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       ecx,8
       call      qword ptr [7FFD94F4ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFD94F4ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       ecx,6
       call      qword ptr [7FFD94F4ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       ecx,5
       call      qword ptr [7FFD94F4ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       ecx,4
       call      qword ptr [7FFD94F4ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,3
       call      qword ptr [7FFD94F4ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,1
       call      qword ptr [7FFD94F4ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 443
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFD94ADB0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       mov       rcx,7FFD950022B0
       call      qword ptr [7FFD94F5ECE8]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFD94F5ED78]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       ecx,0C
       call      qword ptr [7FFD94F5ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       ecx,0B
       call      qword ptr [7FFD94F5ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       ecx,0A
       call      qword ptr [7FFD94F5ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       ecx,9
       call      qword ptr [7FFD94F5ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       ecx,8
       call      qword ptr [7FFD94F5ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L06:
       mov       ecx,7
       call      qword ptr [7FFD94F5ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L07:
       mov       ecx,6
       call      qword ptr [7FFD94F5ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L08:
       mov       ecx,5
       call      qword ptr [7FFD94F5ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L09:
       mov       ecx,4
       call      qword ptr [7FFD94F5ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L10:
       mov       ecx,3
       call      qword ptr [7FFD94F5ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,2
       call      qword ptr [7FFD94F5ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,1
       call      qword ptr [7FFD94F5ED78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 418
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFD94AEB0F0
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
       call      qword ptr [7FFDF2A5FCA8]; JitFoldProof.Subjects.Ladder[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FFDF2A5FD20]; JitFoldProof.Subjects.Work(Int32)
       nop
       add       rsp,28
       ret
; Total bytes of code 21
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFDF25BB0F0
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
       mov       rcx,7FFDF2B00158
       call      qword ptr [7FFDF2A4FBD0]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFDF2A4FC60]; JitFoldProof.Subjects.Work(Int32)
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
       call      qword ptr [7FFDF2A4FC60]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Uri
       cmp       [rax],r8
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFDF2A4FC60]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Version
       cmp       [rax],r8
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFDF2A4FC60]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Exception
       cmp       [rax],r8
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFDF2A4FC60]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Type
       cmp       [rax],r8
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFDF2A4FC60]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Int32[]
       cmp       [rax],r8
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFDF2A4FC60]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.String[]
       cmp       [rax],r8
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFDF2A4FC60]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rax],r8
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFDF2A4FC60]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       [rax],r8
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFDF2A4FC60]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Random
       cmp       [rax],r8
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFDF2A4FC60]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,[rcx+18]
       mov       rax,offset MT_System.StringComparer
       cmp       [rcx],rax
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFDF2A4FC60]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFDF2A4FC60]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 445
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFDF25AB0F0
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
       mov       rcx,7FFDF2B20158
       call      qword ptr [7FFDF2A6FBD0]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFDF2A6FC60]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,30
       pop       rbx
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFDF2A6FC60]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rcx,offset MT_System.Uri
       cmp       rbx,rcx
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFDF2A6FC60]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rcx,offset MT_System.Version
       cmp       rbx,rcx
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFDF2A6FC60]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rcx,offset MT_System.Exception
       cmp       rbx,rcx
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFDF2A6FC60]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       rcx,offset MT_System.Type
       cmp       rbx,rcx
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFDF2A6FC60]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,offset MT_System.Int32[]
       cmp       rbx,rcx
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFDF2A6FC60]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rcx,offset MT_System.String[]
       cmp       rbx,rcx
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFDF2A6FC60]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rcx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       rbx,rcx
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFDF2A6FC60]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       rbx,rcx
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFDF2A6FC60]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rcx,offset MT_System.Random
       cmp       rbx,rcx
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFDF2A6FC60]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,offset MT_System.StringComparer
       cmp       rbx,rcx
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFDF2A6FC60]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFDF2A6FC60]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 403
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFDF25CB0F0
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
       mov       rcx,7FFDF2B141C0
       call      qword ptr [7FFDF2A5FCA8]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFDF2A5FD38]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFDF2A5FD38]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       ecx,2
       call      qword ptr [7FFDF2A5FD38]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       ecx,3
       call      qword ptr [7FFDF2A5FD38]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       ecx,4
       call      qword ptr [7FFDF2A5FD38]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       ecx,5
       call      qword ptr [7FFDF2A5FD38]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L06:
       mov       ecx,6
       call      qword ptr [7FFDF2A5FD38]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFDF2A5FD38]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L08:
       mov       ecx,8
       call      qword ptr [7FFDF2A5FD38]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L09:
       mov       ecx,9
       call      qword ptr [7FFDF2A5FD38]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L10:
       mov       ecx,0A
       call      qword ptr [7FFDF2A5FD38]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,0B
       call      qword ptr [7FFDF2A5FD38]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,0C
       call      qword ptr [7FFDF2A5FD38]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 434
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFDF25BB0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFDC8EB53C8]; JitFoldProof.Subjects.Ladder[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FFDC8EB52C0]; JitFoldProof.Subjects.Work(Int32)
       nop
       add       rsp,28
       ret
; Total bytes of code 21
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFDC8C42C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       mov       rcx,7FFDC8EB92E8
       call      qword ptr [7FFDC8EC5680]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFDC8EC5578]; JitFoldProof.Subjects.Work(Int32)
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
       call      qword ptr [7FFDC8EC5578]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Uri
       cmp       [rax],r8
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFDC8EC5578]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Version
       cmp       [rax],r8
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFDC8EC5578]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Exception
       cmp       [rax],r8
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFDC8EC5578]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Type
       cmp       [rax],r8
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFDC8EC5578]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Int32[]
       cmp       [rax],r8
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFDC8EC5578]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.String[]
       cmp       [rax],r8
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFDC8EC5578]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rax],r8
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFDC8EC5578]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       [rax],r8
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFDC8EC5578]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Random
       cmp       [rax],r8
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFDC8EC5578]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,[rcx+10]
       mov       rax,offset MT_System.StringComparer
       cmp       [rcx],rax
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFDC8EC5578]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFDC8EC5578]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 445
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFDC8C52C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       mov       rcx,7FFDC8E892E8
       call      qword ptr [7FFDC8E95680]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFDC8E95578]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,30
       pop       rbx
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFDC8E95578]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rcx,offset MT_System.Uri
       cmp       rbx,rcx
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFDC8E95578]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rcx,offset MT_System.Version
       cmp       rbx,rcx
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFDC8E95578]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rcx,offset MT_System.Exception
       cmp       rbx,rcx
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFDC8E95578]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       rcx,offset MT_System.Type
       cmp       rbx,rcx
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFDC8E95578]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,offset MT_System.Int32[]
       cmp       rbx,rcx
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFDC8E95578]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rcx,offset MT_System.String[]
       cmp       rbx,rcx
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFDC8E95578]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rcx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       rbx,rcx
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFDC8E95578]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       rbx,rcx
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFDC8E95578]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rcx,offset MT_System.Random
       cmp       rbx,rcx
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFDC8E95578]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,offset MT_System.StringComparer
       cmp       rbx,rcx
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFDC8E95578]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFDC8E95578]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 403
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFDC8C22C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

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
       mov       rcx,7FFDC8EC8F10
       call      qword ptr [7FFDC8ED53C8]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFDC8ED52C0]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFDC8ED52C0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       ecx,2
       call      qword ptr [7FFDC8ED52C0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       ecx,3
       call      qword ptr [7FFDC8ED52C0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       ecx,4
       call      qword ptr [7FFDC8ED52C0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       ecx,5
       call      qword ptr [7FFDC8ED52C0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L06:
       mov       ecx,6
       call      qword ptr [7FFDC8ED52C0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFDC8ED52C0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L08:
       mov       ecx,8
       call      qword ptr [7FFDC8ED52C0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L09:
       mov       ecx,9
       call      qword ptr [7FFDC8ED52C0]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L10:
       mov       ecx,0A
       call      qword ptr [7FFDC8ED52C0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,0B
       call      qword ptr [7FFDC8ED52C0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,0C
       call      qword ptr [7FFDC8ED52C0]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 434
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFDC8C62C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFD94BFEE68]; JitFoldProof.Subjects.Ladder[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FFD94BFEEE0]; JitFoldProof.Subjects.Work(Int32)
       nop
       add       rsp,28
       ret
; Total bytes of code 21
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFD9477B0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       mov       rcx,7FFD94CA1D10
       call      qword ptr [7FFD94BFEE68]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFD94BFEEF8]; JitFoldProof.Subjects.Work(Int32)
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
       call      qword ptr [7FFD94BFEEF8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L02:
       mov       ecx,0C
       call      qword ptr [7FFD94BFEEF8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L03:
       mov       ecx,0B
       call      qword ptr [7FFD94BFEEF8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,0A
       call      qword ptr [7FFD94BFEEF8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       ecx,9
       call      qword ptr [7FFD94BFEEF8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       ecx,8
       call      qword ptr [7FFD94BFEEF8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFD94BFEEF8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       ecx,6
       call      qword ptr [7FFD94BFEEF8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       ecx,5
       call      qword ptr [7FFD94BFEEF8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       ecx,4
       call      qword ptr [7FFD94BFEEF8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,3
       call      qword ptr [7FFD94BFEEF8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,2
       call      qword ptr [7FFD94BFEEF8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 486
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFD9477B0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       mov       rcx,7FFD94CADD00
       call      qword ptr [7FFD94C0ED90]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFD94C0EE20]; JitFoldProof.Subjects.Work(Int32)
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
       call      qword ptr [7FFD94C0EE20]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L02:
       mov       ecx,0C
       call      qword ptr [7FFD94C0EE20]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L03:
       mov       ecx,0B
       call      qword ptr [7FFD94C0EE20]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,0A
       call      qword ptr [7FFD94C0EE20]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       ecx,9
       call      qword ptr [7FFD94C0EE20]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       ecx,8
       call      qword ptr [7FFD94C0EE20]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFD94C0EE20]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       ecx,6
       call      qword ptr [7FFD94C0EE20]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       ecx,5
       call      qword ptr [7FFD94C0EE20]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       ecx,4
       call      qword ptr [7FFD94C0EE20]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,3
       call      qword ptr [7FFD94C0EE20]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,1
       call      qword ptr [7FFD94C0EE20]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 443
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFD9478B0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

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
       mov       rcx,7FFD94C8DD00
       call      qword ptr [7FFD94BEED90]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFD94BEEE20]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       ecx,0C
       call      qword ptr [7FFD94BEEE20]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       ecx,0B
       call      qword ptr [7FFD94BEEE20]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       ecx,0A
       call      qword ptr [7FFD94BEEE20]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       ecx,9
       call      qword ptr [7FFD94BEEE20]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       ecx,8
       call      qword ptr [7FFD94BEEE20]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L06:
       mov       ecx,7
       call      qword ptr [7FFD94BEEE20]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L07:
       mov       ecx,6
       call      qword ptr [7FFD94BEEE20]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L08:
       mov       ecx,5
       call      qword ptr [7FFD94BEEE20]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L09:
       mov       ecx,4
       call      qword ptr [7FFD94BEEE20]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L10:
       mov       ecx,3
       call      qword ptr [7FFD94BEEE20]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,2
       call      qword ptr [7FFD94BEEE20]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,1
       call      qword ptr [7FFD94BEEE20]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 418
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFD9476B0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

