## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DBFB70]; JitFoldProof.Subjects.Ladder[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FFAD7DBFBE8]; JitFoldProof.Subjects.Work(Int32)
       nop
       add       rsp,28
       ret
; Total bytes of code 21
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFAD798B0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       mov       rcx,7FFAD7E07E60
       call      qword ptr [7FFAD7DAFB88]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFAD7DAFC18]; JitFoldProof.Subjects.Work(Int32)
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
       call      qword ptr [7FFAD7DAFC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Uri
       cmp       [rax],r8
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFAD7DAFC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Version
       cmp       [rax],r8
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFAD7DAFC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Exception
       cmp       [rax],r8
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFAD7DAFC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Type
       cmp       [rax],r8
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFAD7DAFC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Int32[]
       cmp       [rax],r8
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFAD7DAFC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.String[]
       cmp       [rax],r8
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFAD7DAFC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rax],r8
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFAD7DAFC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       [rax],r8
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFAD7DAFC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Random
       cmp       [rax],r8
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFAD7DAFC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,[rcx+18]
       mov       rax,offset MT_System.StringComparer
       cmp       [rcx],rax
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFAD7DAFC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFAD7DAFC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 445
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFAD797B0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       mov       rcx,7FFAD7E170D0
       call      qword ptr [7FFAD7DBFA98]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFAD7DBFB28]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,30
       pop       rbx
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFAD7DBFB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rcx,offset MT_System.Uri
       cmp       rbx,rcx
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFAD7DBFB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rcx,offset MT_System.Version
       cmp       rbx,rcx
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFAD7DBFB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rcx,offset MT_System.Exception
       cmp       rbx,rcx
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFAD7DBFB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       rcx,offset MT_System.Type
       cmp       rbx,rcx
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFAD7DBFB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,offset MT_System.Int32[]
       cmp       rbx,rcx
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFAD7DBFB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rcx,offset MT_System.String[]
       cmp       rbx,rcx
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFAD7DBFB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rcx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       rbx,rcx
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFAD7DBFB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       rbx,rcx
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFAD7DBFB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rcx,offset MT_System.Random
       cmp       rbx,rcx
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFAD7DBFB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,offset MT_System.StringComparer
       cmp       rbx,rcx
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFAD7DBFB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFAD7DBFB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 403
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFAD798B0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       mov       rcx,7FFAD7E170D0
       call      qword ptr [7FFAD7DBFA98]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFAD7DBFB28]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFAD7DBFB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       ecx,2
       call      qword ptr [7FFAD7DBFB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       ecx,3
       call      qword ptr [7FFAD7DBFB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       ecx,4
       call      qword ptr [7FFAD7DBFB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       ecx,5
       call      qword ptr [7FFAD7DBFB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L06:
       mov       ecx,6
       call      qword ptr [7FFAD7DBFB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFAD7DBFB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L08:
       mov       ecx,8
       call      qword ptr [7FFAD7DBFB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L09:
       mov       ecx,9
       call      qword ptr [7FFAD7DBFB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L10:
       mov       ecx,0A
       call      qword ptr [7FFAD7DBFB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,0B
       call      qword ptr [7FFAD7DBFB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,0C
       call      qword ptr [7FFAD7DBFB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 434
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFAD798B0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAB75CCE10]; JitFoldProof.Subjects.Ladder[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FFAB75CCD08]; JitFoldProof.Subjects.Work(Int32)
       nop
       add       rsp,28
       ret
; Total bytes of code 21
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFAB7392C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       mov       rcx,7FFAB75E5FC0
       call      qword ptr [7FFAB75DCE10]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFAB75DCD08]; JitFoldProof.Subjects.Work(Int32)
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
       call      qword ptr [7FFAB75DCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Uri
       cmp       [rax],r8
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFAB75DCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Version
       cmp       [rax],r8
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFAB75DCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Exception
       cmp       [rax],r8
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFAB75DCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Type
       cmp       [rax],r8
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFAB75DCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Int32[]
       cmp       [rax],r8
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFAB75DCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.String[]
       cmp       [rax],r8
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFAB75DCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rax],r8
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFAB75DCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       [rax],r8
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFAB75DCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Random
       cmp       [rax],r8
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFAB75DCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,[rcx+10]
       mov       rax,offset MT_System.StringComparer
       cmp       [rcx],rax
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFAB75DCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFAB75DCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 445
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFAB73A2C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       mov       rcx,7FFAC0BB62A0
       call      qword ptr [7FFAC0BAD080]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFAC0BACF78]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,30
       pop       rbx
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFAC0BACF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rcx,offset MT_System.Uri
       cmp       rbx,rcx
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFAC0BACF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rcx,offset MT_System.Version
       cmp       rbx,rcx
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFAC0BACF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rcx,offset MT_System.Exception
       cmp       rbx,rcx
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFAC0BACF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       rcx,offset MT_System.Type
       cmp       rbx,rcx
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFAC0BACF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,offset MT_System.Int32[]
       cmp       rbx,rcx
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFAC0BACF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rcx,offset MT_System.String[]
       cmp       rbx,rcx
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFAC0BACF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rcx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       rbx,rcx
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFAC0BACF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       rbx,rcx
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFAC0BACF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rcx,offset MT_System.Random
       cmp       rbx,rcx
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFAC0BACF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,offset MT_System.StringComparer
       cmp       rbx,rcx
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFAC0BACF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFAC0BACF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 403
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFAC0972C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       mov       rcx,7FFAC0CD5FC0
       call      qword ptr [7FFAC0CCCE10]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFAC0CCCD08]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFAC0CCCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       ecx,2
       call      qword ptr [7FFAC0CCCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       ecx,3
       call      qword ptr [7FFAC0CCCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       ecx,4
       call      qword ptr [7FFAC0CCCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       ecx,5
       call      qword ptr [7FFAC0CCCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L06:
       mov       ecx,6
       call      qword ptr [7FFAC0CCCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFAC0CCCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L08:
       mov       ecx,8
       call      qword ptr [7FFAC0CCCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L09:
       mov       ecx,9
       call      qword ptr [7FFAC0CCCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L10:
       mov       ecx,0A
       call      qword ptr [7FFAC0CCCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,0B
       call      qword ptr [7FFAC0CCCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,0C
       call      qword ptr [7FFAC0CCCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 434
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFAC0A92C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC0C9EB98]; JitFoldProof.Subjects.Ladder[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FFAC0C9EC10]; JitFoldProof.Subjects.Work(Int32)
       nop
       add       rsp,28
       ret
; Total bytes of code 21
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFAC082B0D0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       mov       rcx,7FFAC0D4E800
       call      qword ptr [7FFAC0CBEC70]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFAC0CBED00]; JitFoldProof.Subjects.Work(Int32)
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
       call      qword ptr [7FFAC0CBED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L02:
       mov       ecx,0C
       call      qword ptr [7FFAC0CBED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L03:
       mov       ecx,0B
       call      qword ptr [7FFAC0CBED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,0A
       call      qword ptr [7FFAC0CBED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       ecx,9
       call      qword ptr [7FFAC0CBED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       ecx,8
       call      qword ptr [7FFAC0CBED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFAC0CBED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       ecx,6
       call      qword ptr [7FFAC0CBED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       ecx,5
       call      qword ptr [7FFAC0CBED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       ecx,4
       call      qword ptr [7FFAC0CBED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,3
       call      qword ptr [7FFAC0CBED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,2
       call      qword ptr [7FFAC0CBED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 486
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFAC084B0D0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       mov       rcx,7FFAC0D4E170
       call      qword ptr [7FFAC0CBEC70]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFAC0CBED00]; JitFoldProof.Subjects.Work(Int32)
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
       call      qword ptr [7FFAC0CBED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L02:
       mov       ecx,0C
       call      qword ptr [7FFAC0CBED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L03:
       mov       ecx,0B
       call      qword ptr [7FFAC0CBED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,0A
       call      qword ptr [7FFAC0CBED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       ecx,9
       call      qword ptr [7FFAC0CBED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       ecx,8
       call      qword ptr [7FFAC0CBED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFAC0CBED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       ecx,6
       call      qword ptr [7FFAC0CBED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       ecx,5
       call      qword ptr [7FFAC0CBED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       ecx,4
       call      qword ptr [7FFAC0CBED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,3
       call      qword ptr [7FFAC0CBED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,1
       call      qword ptr [7FFAC0CBED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 443
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFAC084B0D0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       mov       rcx,7FFAC0D2E170
       call      qword ptr [7FFAC0C9EC70]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFAC0C9ED00]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       ecx,0C
       call      qword ptr [7FFAC0C9ED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       ecx,0B
       call      qword ptr [7FFAC0C9ED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       ecx,0A
       call      qword ptr [7FFAC0C9ED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       ecx,9
       call      qword ptr [7FFAC0C9ED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       ecx,8
       call      qword ptr [7FFAC0C9ED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L06:
       mov       ecx,7
       call      qword ptr [7FFAC0C9ED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L07:
       mov       ecx,6
       call      qword ptr [7FFAC0C9ED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L08:
       mov       ecx,5
       call      qword ptr [7FFAC0C9ED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L09:
       mov       ecx,4
       call      qword ptr [7FFAC0C9ED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L10:
       mov       ecx,3
       call      qword ptr [7FFAC0C9ED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,2
       call      qword ptr [7FFAC0C9ED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,1
       call      qword ptr [7FFAC0C9ED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 418
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFAC082B0D0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7D9FB88]; JitFoldProof.Subjects.Ladder[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FFAD7D9FC00]; JitFoldProof.Subjects.Work(Int32)
       nop
       add       rsp,28
       ret
; Total bytes of code 21
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFAD796B0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       mov       rcx,7FFAD7E17E60
       call      qword ptr [7FFAD7DBFB88]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFAD7DBFC18]; JitFoldProof.Subjects.Work(Int32)
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
       call      qword ptr [7FFAD7DBFC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Uri
       cmp       [rax],r8
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFAD7DBFC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Version
       cmp       [rax],r8
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFAD7DBFC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Exception
       cmp       [rax],r8
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFAD7DBFC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Type
       cmp       [rax],r8
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFAD7DBFC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Int32[]
       cmp       [rax],r8
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFAD7DBFC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.String[]
       cmp       [rax],r8
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFAD7DBFC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rax],r8
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFAD7DBFC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       [rax],r8
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFAD7DBFC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Random
       cmp       [rax],r8
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFAD7DBFC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,[rcx+18]
       mov       rax,offset MT_System.StringComparer
       cmp       [rcx],rax
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFAD7DBFC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFAD7DBFC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 445
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFAD798B0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       mov       rcx,7FFAD7DE7E60
       call      qword ptr [7FFAD7D8FB88]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFAD7D8FC18]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,30
       pop       rbx
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFAD7D8FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rcx,offset MT_System.Uri
       cmp       rbx,rcx
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFAD7D8FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rcx,offset MT_System.Version
       cmp       rbx,rcx
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFAD7D8FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rcx,offset MT_System.Exception
       cmp       rbx,rcx
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFAD7D8FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       rcx,offset MT_System.Type
       cmp       rbx,rcx
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFAD7D8FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,offset MT_System.Int32[]
       cmp       rbx,rcx
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFAD7D8FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rcx,offset MT_System.String[]
       cmp       rbx,rcx
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFAD7D8FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rcx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       rbx,rcx
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFAD7D8FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       rbx,rcx
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFAD7D8FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rcx,offset MT_System.Random
       cmp       rbx,rcx
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFAD7D8FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,offset MT_System.StringComparer
       cmp       rbx,rcx
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFAD7D8FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFAD7D8FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 403
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFAD795B0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       mov       rcx,7FFAD7E17E60
       call      qword ptr [7FFAD7DBFB88]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFAD7DBFC18]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFAD7DBFC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       ecx,2
       call      qword ptr [7FFAD7DBFC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       ecx,3
       call      qword ptr [7FFAD7DBFC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       ecx,4
       call      qword ptr [7FFAD7DBFC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       ecx,5
       call      qword ptr [7FFAD7DBFC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L06:
       mov       ecx,6
       call      qword ptr [7FFAD7DBFC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFAD7DBFC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L08:
       mov       ecx,8
       call      qword ptr [7FFAD7DBFC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L09:
       mov       ecx,9
       call      qword ptr [7FFAD7DBFC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L10:
       mov       ecx,0A
       call      qword ptr [7FFAD7DBFC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,0B
       call      qword ptr [7FFAD7DBFC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,0C
       call      qword ptr [7FFAD7DBFC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 434
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFAD798B0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAB75CD080]; JitFoldProof.Subjects.Ladder[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FFAB75CCF78]; JitFoldProof.Subjects.Work(Int32)
       nop
       add       rsp,28
       ret
; Total bytes of code 21
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFAB7392C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       mov       rcx,7FFAB75C62A0
       call      qword ptr [7FFAB75BD080]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFAB75BCF78]; JitFoldProof.Subjects.Work(Int32)
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
       call      qword ptr [7FFAB75BCF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Uri
       cmp       [rax],r8
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFAB75BCF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Version
       cmp       [rax],r8
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFAB75BCF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Exception
       cmp       [rax],r8
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFAB75BCF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Type
       cmp       [rax],r8
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFAB75BCF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Int32[]
       cmp       [rax],r8
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFAB75BCF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.String[]
       cmp       [rax],r8
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFAB75BCF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rax],r8
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFAB75BCF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       [rax],r8
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFAB75BCF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Random
       cmp       [rax],r8
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFAB75BCF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,[rcx+10]
       mov       rax,offset MT_System.StringComparer
       cmp       [rcx],rax
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFAB75BCF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFAB75BCF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 445
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFAB7382C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       mov       rcx,7FFAB75B62A0
       call      qword ptr [7FFAB75AD080]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFAB75ACF78]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,30
       pop       rbx
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFAB75ACF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rcx,offset MT_System.Uri
       cmp       rbx,rcx
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFAB75ACF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rcx,offset MT_System.Version
       cmp       rbx,rcx
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFAB75ACF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rcx,offset MT_System.Exception
       cmp       rbx,rcx
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFAB75ACF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       rcx,offset MT_System.Type
       cmp       rbx,rcx
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFAB75ACF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,offset MT_System.Int32[]
       cmp       rbx,rcx
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFAB75ACF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rcx,offset MT_System.String[]
       cmp       rbx,rcx
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFAB75ACF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rcx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       rbx,rcx
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFAB75ACF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       rbx,rcx
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFAB75ACF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rcx,offset MT_System.Random
       cmp       rbx,rcx
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFAB75ACF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,offset MT_System.StringComparer
       cmp       rbx,rcx
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFAB75ACF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFAB75ACF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 403
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFAB7372C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       mov       rcx,7FFAB75C5FC0
       call      qword ptr [7FFAB75BCE10]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFAB75BCD08]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFAB75BCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       ecx,2
       call      qword ptr [7FFAB75BCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       ecx,3
       call      qword ptr [7FFAB75BCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       ecx,4
       call      qword ptr [7FFAB75BCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       ecx,5
       call      qword ptr [7FFAB75BCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L06:
       mov       ecx,6
       call      qword ptr [7FFAB75BCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFAB75BCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L08:
       mov       ecx,8
       call      qword ptr [7FFAB75BCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L09:
       mov       ecx,9
       call      qword ptr [7FFAB75BCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L10:
       mov       ecx,0A
       call      qword ptr [7FFAB75BCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,0B
       call      qword ptr [7FFAB75BCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,0C
       call      qword ptr [7FFAB75BCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 434
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFAB7382C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAC0CAEC70]; JitFoldProof.Subjects.Ladder[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FFAC0CAECE8]; JitFoldProof.Subjects.Work(Int32)
       nop
       add       rsp,28
       ret
; Total bytes of code 21
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFAC083B0D0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       mov       rcx,7FFAC0D4E170
       call      qword ptr [7FFAC0CBEC70]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFAC0CBED00]; JitFoldProof.Subjects.Work(Int32)
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
       call      qword ptr [7FFAC0CBED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L02:
       mov       ecx,0C
       call      qword ptr [7FFAC0CBED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L03:
       mov       ecx,0B
       call      qword ptr [7FFAC0CBED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,0A
       call      qword ptr [7FFAC0CBED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       ecx,9
       call      qword ptr [7FFAC0CBED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       ecx,8
       call      qword ptr [7FFAC0CBED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFAC0CBED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       ecx,6
       call      qword ptr [7FFAC0CBED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       ecx,5
       call      qword ptr [7FFAC0CBED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       ecx,4
       call      qword ptr [7FFAC0CBED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,3
       call      qword ptr [7FFAC0CBED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,2
       call      qword ptr [7FFAC0CBED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 486
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFAC084B0D0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       mov       rcx,7FFAC0D4A798
       call      qword ptr [7FFAC0CBEB98]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFAC0CBEC28]; JitFoldProof.Subjects.Work(Int32)
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
       call      qword ptr [7FFAC0CBEC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L02:
       mov       ecx,0C
       call      qword ptr [7FFAC0CBEC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L03:
       mov       ecx,0B
       call      qword ptr [7FFAC0CBEC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,0A
       call      qword ptr [7FFAC0CBEC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       ecx,9
       call      qword ptr [7FFAC0CBEC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       ecx,8
       call      qword ptr [7FFAC0CBEC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFAC0CBEC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       ecx,6
       call      qword ptr [7FFAC0CBEC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       ecx,5
       call      qword ptr [7FFAC0CBEC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       ecx,4
       call      qword ptr [7FFAC0CBEC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,3
       call      qword ptr [7FFAC0CBEC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,1
       call      qword ptr [7FFAC0CBEC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 443
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFAC084B0D0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       mov       rcx,7FFAC0D3A798
       call      qword ptr [7FFAC0CAEB98]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFAC0CAEC28]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       ecx,0C
       call      qword ptr [7FFAC0CAEC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       ecx,0B
       call      qword ptr [7FFAC0CAEC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       ecx,0A
       call      qword ptr [7FFAC0CAEC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       ecx,9
       call      qword ptr [7FFAC0CAEC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       ecx,8
       call      qword ptr [7FFAC0CAEC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L06:
       mov       ecx,7
       call      qword ptr [7FFAC0CAEC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L07:
       mov       ecx,6
       call      qword ptr [7FFAC0CAEC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L08:
       mov       ecx,5
       call      qword ptr [7FFAC0CAEC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L09:
       mov       ecx,4
       call      qword ptr [7FFAC0CAEC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L10:
       mov       ecx,3
       call      qword ptr [7FFAC0CAEC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,2
       call      qword ptr [7FFAC0CAEC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,1
       call      qword ptr [7FFAC0CAEC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 418
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFAC083B0D0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFAD7DAFCC0]; JitFoldProof.Subjects.Ladder[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FFAD7DAFD38]; JitFoldProof.Subjects.Work(Int32)
       nop
       add       rsp,28
       ret
; Total bytes of code 21
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFAD797B0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       mov       rcx,7FFAD7E23338
       call      qword ptr [7FFAD7DAFDB0]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFAD7DAFE40]; JitFoldProof.Subjects.Work(Int32)
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
       call      qword ptr [7FFAD7DAFE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Uri
       cmp       [rax],r8
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFAD7DAFE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Version
       cmp       [rax],r8
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFAD7DAFE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Exception
       cmp       [rax],r8
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFAD7DAFE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Type
       cmp       [rax],r8
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFAD7DAFE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Int32[]
       cmp       [rax],r8
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFAD7DAFE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.String[]
       cmp       [rax],r8
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFAD7DAFE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rax],r8
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFAD7DAFE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       [rax],r8
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFAD7DAFE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Random
       cmp       [rax],r8
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFAD7DAFE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,[rcx+18]
       mov       rax,offset MT_System.StringComparer
       cmp       [rcx],rax
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFAD7DAFE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFAD7DAFE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 445
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFAD797B0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       mov       rcx,7FFAD7E02AB8
       call      qword ptr [7FFAD7D8FCC0]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFAD7D8FD50]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,30
       pop       rbx
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFAD7D8FD50]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rcx,offset MT_System.Uri
       cmp       rbx,rcx
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFAD7D8FD50]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rcx,offset MT_System.Version
       cmp       rbx,rcx
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFAD7D8FD50]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rcx,offset MT_System.Exception
       cmp       rbx,rcx
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFAD7D8FD50]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       rcx,offset MT_System.Type
       cmp       rbx,rcx
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFAD7D8FD50]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,offset MT_System.Int32[]
       cmp       rbx,rcx
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFAD7D8FD50]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rcx,offset MT_System.String[]
       cmp       rbx,rcx
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFAD7D8FD50]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rcx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       rbx,rcx
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFAD7D8FD50]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       rbx,rcx
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFAD7D8FD50]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rcx,offset MT_System.Random
       cmp       rbx,rcx
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFAD7D8FD50]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,offset MT_System.StringComparer
       cmp       rbx,rcx
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFAD7D8FD50]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFAD7D8FD50]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 403
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFAD795B0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       mov       rcx,7FFAD7E03328
       call      qword ptr [7FFAD7D8FD98]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFAD7D8FE28]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFAD7D8FE28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       ecx,2
       call      qword ptr [7FFAD7D8FE28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       ecx,3
       call      qword ptr [7FFAD7D8FE28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       ecx,4
       call      qword ptr [7FFAD7D8FE28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       ecx,5
       call      qword ptr [7FFAD7D8FE28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L06:
       mov       ecx,6
       call      qword ptr [7FFAD7D8FE28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFAD7D8FE28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L08:
       mov       ecx,8
       call      qword ptr [7FFAD7D8FE28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L09:
       mov       ecx,9
       call      qword ptr [7FFAD7D8FE28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L10:
       mov       ecx,0A
       call      qword ptr [7FFAD7D8FE28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,0B
       call      qword ptr [7FFAD7D8FE28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,0C
       call      qword ptr [7FFAD7D8FE28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 434
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFAD795B0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFAB75FFA08]; JitFoldProof.Subjects.Ladder[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FFAB75FF900]; JitFoldProof.Subjects.Work(Int32)
       nop
       add       rsp,28
       ret
; Total bytes of code 21
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFAB73A2C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       mov       rcx,7FFAB7637030
       call      qword ptr [7FFAB762FA08]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFAB762F900]; JitFoldProof.Subjects.Work(Int32)
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
       call      qword ptr [7FFAB762F900]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Uri
       cmp       [rax],r8
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFAB762F900]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Version
       cmp       [rax],r8
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFAB762F900]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Exception
       cmp       [rax],r8
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFAB762F900]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Type
       cmp       [rax],r8
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFAB762F900]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Int32[]
       cmp       [rax],r8
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFAB762F900]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.String[]
       cmp       [rax],r8
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFAB762F900]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rax],r8
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFAB762F900]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       [rax],r8
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFAB762F900]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Random
       cmp       [rax],r8
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFAB762F900]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,[rcx+10]
       mov       rax,offset MT_System.StringComparer
       cmp       [rcx],rax
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFAB762F900]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFAB762F900]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 445
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFAB73D2C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       mov       rcx,7FFAB7626C40
       call      qword ptr [7FFAB761F900]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFAB761F7F8]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,30
       pop       rbx
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFAB761F7F8]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rcx,offset MT_System.Uri
       cmp       rbx,rcx
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFAB761F7F8]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rcx,offset MT_System.Version
       cmp       rbx,rcx
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFAB761F7F8]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rcx,offset MT_System.Exception
       cmp       rbx,rcx
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFAB761F7F8]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       rcx,offset MT_System.Type
       cmp       rbx,rcx
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFAB761F7F8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,offset MT_System.Int32[]
       cmp       rbx,rcx
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFAB761F7F8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rcx,offset MT_System.String[]
       cmp       rbx,rcx
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFAB761F7F8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rcx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       rbx,rcx
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFAB761F7F8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       rbx,rcx
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFAB761F7F8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rcx,offset MT_System.Random
       cmp       rbx,rcx
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFAB761F7F8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,offset MT_System.StringComparer
       cmp       rbx,rcx
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFAB761F7F8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFAB761F7F8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 403
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFAB73C2C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       mov       rcx,7FFAB8307030
       call      qword ptr [7FFAB82FFA08]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFAB82FF900]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFAB82FF900]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       ecx,2
       call      qword ptr [7FFAB82FF900]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       ecx,3
       call      qword ptr [7FFAB82FF900]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       ecx,4
       call      qword ptr [7FFAB82FF900]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       ecx,5
       call      qword ptr [7FFAB82FF900]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L06:
       mov       ecx,6
       call      qword ptr [7FFAB82FF900]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFAB82FF900]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L08:
       mov       ecx,8
       call      qword ptr [7FFAB82FF900]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L09:
       mov       ecx,9
       call      qword ptr [7FFAB82FF900]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L10:
       mov       ecx,0A
       call      qword ptr [7FFAB82FF900]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,0B
       call      qword ptr [7FFAB82FF900]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,0C
       call      qword ptr [7FFAB82FF900]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 434
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFAB80A2C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFAB81EED18]; JitFoldProof.Subjects.Ladder[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FFAB81EED90]; JitFoldProof.Subjects.Work(Int32)
       nop
       add       rsp,28
       ret
; Total bytes of code 21
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFAB7D6B0D0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       mov       rcx,7FFAB829BB30
       call      qword ptr [7FFAB81FED18]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFAB81FEDA8]; JitFoldProof.Subjects.Work(Int32)
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
       call      qword ptr [7FFAB81FEDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L02:
       mov       ecx,0C
       call      qword ptr [7FFAB81FEDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L03:
       mov       ecx,0B
       call      qword ptr [7FFAB81FEDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,0A
       call      qword ptr [7FFAB81FEDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       ecx,9
       call      qword ptr [7FFAB81FEDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       ecx,8
       call      qword ptr [7FFAB81FEDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFAB81FEDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       ecx,6
       call      qword ptr [7FFAB81FEDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       ecx,5
       call      qword ptr [7FFAB81FEDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       ecx,4
       call      qword ptr [7FFAB81FEDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,3
       call      qword ptr [7FFAB81FEDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,2
       call      qword ptr [7FFAB81FEDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 486
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFAB7D7B0D0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       mov       rcx,7FFAB828BB30
       call      qword ptr [7FFAB81EED18]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFAB81EEDA8]; JitFoldProof.Subjects.Work(Int32)
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
       call      qword ptr [7FFAB81EEDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L02:
       mov       ecx,0C
       call      qword ptr [7FFAB81EEDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L03:
       mov       ecx,0B
       call      qword ptr [7FFAB81EEDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,0A
       call      qword ptr [7FFAB81EEDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       ecx,9
       call      qword ptr [7FFAB81EEDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       ecx,8
       call      qword ptr [7FFAB81EEDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFAB81EEDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       ecx,6
       call      qword ptr [7FFAB81EEDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       ecx,5
       call      qword ptr [7FFAB81EEDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       ecx,4
       call      qword ptr [7FFAB81EEDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,3
       call      qword ptr [7FFAB81EEDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,1
       call      qword ptr [7FFAB81EEDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 443
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFAB7D6B0D0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       mov       rcx,7FFAB827BB30
       call      qword ptr [7FFAB81DED18]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFAB81DEDA8]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       ecx,0C
       call      qword ptr [7FFAB81DEDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       ecx,0B
       call      qword ptr [7FFAB81DEDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       ecx,0A
       call      qword ptr [7FFAB81DEDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       ecx,9
       call      qword ptr [7FFAB81DEDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       ecx,8
       call      qword ptr [7FFAB81DEDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L06:
       mov       ecx,7
       call      qword ptr [7FFAB81DEDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L07:
       mov       ecx,6
       call      qword ptr [7FFAB81DEDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L08:
       mov       ecx,5
       call      qword ptr [7FFAB81DEDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L09:
       mov       ecx,4
       call      qword ptr [7FFAB81DEDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L10:
       mov       ecx,3
       call      qword ptr [7FFAB81DEDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,2
       call      qword ptr [7FFAB81DEDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,1
       call      qword ptr [7FFAB81DEDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 418
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFAB7D5B0D0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

