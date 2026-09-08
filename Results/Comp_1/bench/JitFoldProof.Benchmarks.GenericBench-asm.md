## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1256FB88]; JitFoldProof.Subjects.Ladder[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FFE1256FC00]; JitFoldProof.Subjects.Work(Int32)
       nop
       add       rsp,28
       ret
; Total bytes of code 21
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE1213B0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       mov       rcx,7FFE125B7418
       call      qword ptr [7FFE1255FA98]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFE1255FB28]; JitFoldProof.Subjects.Work(Int32)
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
       call      qword ptr [7FFE1255FB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Uri
       cmp       [rax],r8
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFE1255FB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Version
       cmp       [rax],r8
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFE1255FB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Exception
       cmp       [rax],r8
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFE1255FB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Type
       cmp       [rax],r8
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFE1255FB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Int32[]
       cmp       [rax],r8
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFE1255FB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.String[]
       cmp       [rax],r8
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFE1255FB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rax],r8
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFE1255FB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       [rax],r8
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFE1255FB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Random
       cmp       [rax],r8
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFE1255FB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,[rcx+18]
       mov       rax,offset MT_System.StringComparer
       cmp       [rcx],rax
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFE1255FB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFE1255FB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 445
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE1212B0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       mov       rcx,7FFE125C7E60
       call      qword ptr [7FFE1256FB88]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFE1256FC18]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,30
       pop       rbx
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFE1256FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rcx,offset MT_System.Uri
       cmp       rbx,rcx
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFE1256FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rcx,offset MT_System.Version
       cmp       rbx,rcx
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFE1256FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rcx,offset MT_System.Exception
       cmp       rbx,rcx
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFE1256FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       rcx,offset MT_System.Type
       cmp       rbx,rcx
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFE1256FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,offset MT_System.Int32[]
       cmp       rbx,rcx
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFE1256FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rcx,offset MT_System.String[]
       cmp       rbx,rcx
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFE1256FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rcx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       rbx,rcx
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFE1256FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       rbx,rcx
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFE1256FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rcx,offset MT_System.Random
       cmp       rbx,rcx
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFE1256FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,offset MT_System.StringComparer
       cmp       rbx,rcx
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFE1256FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFE1256FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 403
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE1213B0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       mov       rcx,7FFE125C7E50
       call      qword ptr [7FFE1256FB70]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFE1256FC00]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFE1256FC00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       ecx,2
       call      qword ptr [7FFE1256FC00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       ecx,3
       call      qword ptr [7FFE1256FC00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       ecx,4
       call      qword ptr [7FFE1256FC00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       ecx,5
       call      qword ptr [7FFE1256FC00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L06:
       mov       ecx,6
       call      qword ptr [7FFE1256FC00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFE1256FC00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L08:
       mov       ecx,8
       call      qword ptr [7FFE1256FC00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L09:
       mov       ecx,9
       call      qword ptr [7FFE1256FC00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L10:
       mov       ecx,0A
       call      qword ptr [7FFE1256FC00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,0B
       call      qword ptr [7FFE1256FC00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,0C
       call      qword ptr [7FFE1256FC00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 434
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE1213B0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE0FEBD080]; JitFoldProof.Subjects.Ladder[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FFE0FEBCF78]; JitFoldProof.Subjects.Work(Int32)
       nop
       add       rsp,28
       ret
; Total bytes of code 21
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE0FC82C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       mov       rcx,7FFE0FED5FC0
       call      qword ptr [7FFE0FECCE10]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFE0FECCD08]; JitFoldProof.Subjects.Work(Int32)
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
       call      qword ptr [7FFE0FECCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Uri
       cmp       [rax],r8
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFE0FECCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Version
       cmp       [rax],r8
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFE0FECCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Exception
       cmp       [rax],r8
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFE0FECCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Type
       cmp       [rax],r8
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFE0FECCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Int32[]
       cmp       [rax],r8
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFE0FECCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.String[]
       cmp       [rax],r8
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFE0FECCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rax],r8
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFE0FECCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       [rax],r8
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFE0FECCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Random
       cmp       [rax],r8
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFE0FECCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,[rcx+10]
       mov       rax,offset MT_System.StringComparer
       cmp       [rcx],rax
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFE0FECCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFE0FECCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 445
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE0FC92C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       mov       rcx,7FFE0FEE5FC0
       call      qword ptr [7FFE0FEDCE10]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFE0FEDCD08]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,30
       pop       rbx
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFE0FEDCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rcx,offset MT_System.Uri
       cmp       rbx,rcx
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFE0FEDCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rcx,offset MT_System.Version
       cmp       rbx,rcx
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFE0FEDCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rcx,offset MT_System.Exception
       cmp       rbx,rcx
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFE0FEDCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       rcx,offset MT_System.Type
       cmp       rbx,rcx
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFE0FEDCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,offset MT_System.Int32[]
       cmp       rbx,rcx
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFE0FEDCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rcx,offset MT_System.String[]
       cmp       rbx,rcx
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFE0FEDCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rcx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       rbx,rcx
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFE0FEDCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       rbx,rcx
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFE0FEDCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rcx,offset MT_System.Random
       cmp       rbx,rcx
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFE0FEDCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,offset MT_System.StringComparer
       cmp       rbx,rcx
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFE0FEDCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFE0FEDCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 403
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE0FCA2C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       mov       rcx,7FFE0FF05FC0
       call      qword ptr [7FFE0FEFCE10]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFE0FEFCD08]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFE0FEFCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       ecx,2
       call      qword ptr [7FFE0FEFCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       ecx,3
       call      qword ptr [7FFE0FEFCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       ecx,4
       call      qword ptr [7FFE0FEFCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       ecx,5
       call      qword ptr [7FFE0FEFCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L06:
       mov       ecx,6
       call      qword ptr [7FFE0FEFCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFE0FEFCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L08:
       mov       ecx,8
       call      qword ptr [7FFE0FEFCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L09:
       mov       ecx,9
       call      qword ptr [7FFE0FEFCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L10:
       mov       ecx,0A
       call      qword ptr [7FFE0FEFCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,0B
       call      qword ptr [7FFE0FEFCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,0C
       call      qword ptr [7FFE0FEFCD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 434
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE0FCC2C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE0FDFEB98]; JitFoldProof.Subjects.Ladder[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FFE0FDFEC10]; JitFoldProof.Subjects.Work(Int32)
       nop
       add       rsp,28
       ret
; Total bytes of code 21
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE0F98B0D0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       mov       rcx,7FFE0FE6A798
       call      qword ptr [7FFE0FDDEB98]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFE0FDDEC28]; JitFoldProof.Subjects.Work(Int32)
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
       call      qword ptr [7FFE0FDDEC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L02:
       mov       ecx,0C
       call      qword ptr [7FFE0FDDEC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L03:
       mov       ecx,0B
       call      qword ptr [7FFE0FDDEC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,0A
       call      qword ptr [7FFE0FDDEC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       ecx,9
       call      qword ptr [7FFE0FDDEC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       ecx,8
       call      qword ptr [7FFE0FDDEC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFE0FDDEC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       ecx,6
       call      qword ptr [7FFE0FDDEC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       ecx,5
       call      qword ptr [7FFE0FDDEC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       ecx,4
       call      qword ptr [7FFE0FDDEC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,3
       call      qword ptr [7FFE0FDDEC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,2
       call      qword ptr [7FFE0FDDEC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 486
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE0F96B0D0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       mov       rcx,7FFE0FE6E170
       call      qword ptr [7FFE0FDDEC70]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFE0FDDED00]; JitFoldProof.Subjects.Work(Int32)
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
       call      qword ptr [7FFE0FDDED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L02:
       mov       ecx,0C
       call      qword ptr [7FFE0FDDED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L03:
       mov       ecx,0B
       call      qword ptr [7FFE0FDDED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,0A
       call      qword ptr [7FFE0FDDED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       ecx,9
       call      qword ptr [7FFE0FDDED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       ecx,8
       call      qword ptr [7FFE0FDDED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFE0FDDED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       ecx,6
       call      qword ptr [7FFE0FDDED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       ecx,5
       call      qword ptr [7FFE0FDDED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       ecx,4
       call      qword ptr [7FFE0FDDED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,3
       call      qword ptr [7FFE0FDDED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,1
       call      qword ptr [7FFE0FDDED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 443
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE0F96B0D0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       mov       rcx,7FFE0FE6E170
       call      qword ptr [7FFE0FDDEC70]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFE0FDDED00]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       ecx,0C
       call      qword ptr [7FFE0FDDED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       ecx,0B
       call      qword ptr [7FFE0FDDED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       ecx,0A
       call      qword ptr [7FFE0FDDED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       ecx,9
       call      qword ptr [7FFE0FDDED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       ecx,8
       call      qword ptr [7FFE0FDDED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L06:
       mov       ecx,7
       call      qword ptr [7FFE0FDDED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L07:
       mov       ecx,6
       call      qword ptr [7FFE0FDDED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L08:
       mov       ecx,5
       call      qword ptr [7FFE0FDDED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L09:
       mov       ecx,4
       call      qword ptr [7FFE0FDDED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L10:
       mov       ecx,3
       call      qword ptr [7FFE0FDDED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,2
       call      qword ptr [7FFE0FDDED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,1
       call      qword ptr [7FFE0FDDED00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 418
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE0F96B0D0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1256FB88]; JitFoldProof.Subjects.Ladder[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FFE1256FC00]; JitFoldProof.Subjects.Work(Int32)
       nop
       add       rsp,28
       ret
; Total bytes of code 21
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE1213B0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       mov       rcx,7FFE125C7E60
       call      qword ptr [7FFE1256FB88]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFE1256FC18]; JitFoldProof.Subjects.Work(Int32)
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
       call      qword ptr [7FFE1256FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Uri
       cmp       [rax],r8
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFE1256FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Version
       cmp       [rax],r8
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFE1256FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Exception
       cmp       [rax],r8
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFE1256FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Type
       cmp       [rax],r8
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFE1256FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Int32[]
       cmp       [rax],r8
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFE1256FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.String[]
       cmp       [rax],r8
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFE1256FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rax],r8
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFE1256FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       [rax],r8
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFE1256FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Random
       cmp       [rax],r8
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFE1256FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,[rcx+18]
       mov       rax,offset MT_System.StringComparer
       cmp       [rcx],rax
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFE1256FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFE1256FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 445
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE1213B0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       mov       rcx,7FFE125B7E60
       call      qword ptr [7FFE1255FB88]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFE1255FC18]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,30
       pop       rbx
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFE1255FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rcx,offset MT_System.Uri
       cmp       rbx,rcx
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFE1255FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rcx,offset MT_System.Version
       cmp       rbx,rcx
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFE1255FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rcx,offset MT_System.Exception
       cmp       rbx,rcx
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFE1255FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       rcx,offset MT_System.Type
       cmp       rbx,rcx
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFE1255FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,offset MT_System.Int32[]
       cmp       rbx,rcx
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFE1255FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rcx,offset MT_System.String[]
       cmp       rbx,rcx
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFE1255FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rcx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       rbx,rcx
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFE1255FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       rbx,rcx
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFE1255FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rcx,offset MT_System.Random
       cmp       rbx,rcx
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFE1255FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,offset MT_System.StringComparer
       cmp       rbx,rcx
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFE1255FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFE1255FC18]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 403
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE1212B0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       mov       rcx,7FFE125C7E50
       call      qword ptr [7FFE1256FB70]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFE1256FC00]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFE1256FC00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       ecx,2
       call      qword ptr [7FFE1256FC00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       ecx,3
       call      qword ptr [7FFE1256FC00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       ecx,4
       call      qword ptr [7FFE1256FC00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       ecx,5
       call      qword ptr [7FFE1256FC00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L06:
       mov       ecx,6
       call      qword ptr [7FFE1256FC00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFE1256FC00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L08:
       mov       ecx,8
       call      qword ptr [7FFE1256FC00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L09:
       mov       ecx,9
       call      qword ptr [7FFE1256FC00]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L10:
       mov       ecx,0A
       call      qword ptr [7FFE1256FC00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,0B
       call      qword ptr [7FFE1256FC00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,0C
       call      qword ptr [7FFE1256FC00]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 434
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE1213B0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE1094D080]; JitFoldProof.Subjects.Ladder[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FFE1094CF78]; JitFoldProof.Subjects.Work(Int32)
       nop
       add       rsp,28
       ret
; Total bytes of code 21
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE10712C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       mov       rcx,7FFE10955FC0
       call      qword ptr [7FFE1094CE10]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFE1094CD08]; JitFoldProof.Subjects.Work(Int32)
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
       call      qword ptr [7FFE1094CD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Uri
       cmp       [rax],r8
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFE1094CD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Version
       cmp       [rax],r8
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFE1094CD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Exception
       cmp       [rax],r8
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFE1094CD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Type
       cmp       [rax],r8
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFE1094CD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Int32[]
       cmp       [rax],r8
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFE1094CD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.String[]
       cmp       [rax],r8
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFE1094CD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rax],r8
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFE1094CD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       [rax],r8
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFE1094CD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Random
       cmp       [rax],r8
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFE1094CD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,[rcx+10]
       mov       rax,offset MT_System.StringComparer
       cmp       [rcx],rax
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFE1094CD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFE1094CD08]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 445
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE10712C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       mov       rcx,7FFE109662A0
       call      qword ptr [7FFE1095D080]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFE1095CF78]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,30
       pop       rbx
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFE1095CF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rcx,offset MT_System.Uri
       cmp       rbx,rcx
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFE1095CF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rcx,offset MT_System.Version
       cmp       rbx,rcx
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFE1095CF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rcx,offset MT_System.Exception
       cmp       rbx,rcx
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFE1095CF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       rcx,offset MT_System.Type
       cmp       rbx,rcx
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFE1095CF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,offset MT_System.Int32[]
       cmp       rbx,rcx
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFE1095CF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rcx,offset MT_System.String[]
       cmp       rbx,rcx
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFE1095CF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rcx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       rbx,rcx
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFE1095CF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       rbx,rcx
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFE1095CF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rcx,offset MT_System.Random
       cmp       rbx,rcx
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFE1095CF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,offset MT_System.StringComparer
       cmp       rbx,rcx
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFE1095CF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFE1095CF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 403
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE10722C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       mov       rcx,7FFE109662A0
       call      qword ptr [7FFE1095D080]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFE1095CF78]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFE1095CF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       ecx,2
       call      qword ptr [7FFE1095CF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       ecx,3
       call      qword ptr [7FFE1095CF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       ecx,4
       call      qword ptr [7FFE1095CF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       ecx,5
       call      qword ptr [7FFE1095CF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L06:
       mov       ecx,6
       call      qword ptr [7FFE1095CF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFE1095CF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L08:
       mov       ecx,8
       call      qword ptr [7FFE1095CF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L09:
       mov       ecx,9
       call      qword ptr [7FFE1095CF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L10:
       mov       ecx,0A
       call      qword ptr [7FFE1095CF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,0B
       call      qword ptr [7FFE1095CF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,0C
       call      qword ptr [7FFE1095CF78]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 434
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE10722C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1085EB98]; JitFoldProof.Subjects.Ladder[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FFE1085EC10]; JitFoldProof.Subjects.Work(Int32)
       nop
       add       rsp,28
       ret
; Total bytes of code 21
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE103EB0D0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       mov       rcx,7FFE108EA798
       call      qword ptr [7FFE1085EB98]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFE1085EC28]; JitFoldProof.Subjects.Work(Int32)
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
       call      qword ptr [7FFE1085EC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L02:
       mov       ecx,0C
       call      qword ptr [7FFE1085EC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L03:
       mov       ecx,0B
       call      qword ptr [7FFE1085EC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,0A
       call      qword ptr [7FFE1085EC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       ecx,9
       call      qword ptr [7FFE1085EC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       ecx,8
       call      qword ptr [7FFE1085EC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFE1085EC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       ecx,6
       call      qword ptr [7FFE1085EC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       ecx,5
       call      qword ptr [7FFE1085EC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       ecx,4
       call      qword ptr [7FFE1085EC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,3
       call      qword ptr [7FFE1085EC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,2
       call      qword ptr [7FFE1085EC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 486
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE103EB0D0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       mov       rcx,7FFE108CA798
       call      qword ptr [7FFE1083EB98]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFE1083EC28]; JitFoldProof.Subjects.Work(Int32)
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
       call      qword ptr [7FFE1083EC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L02:
       mov       ecx,0C
       call      qword ptr [7FFE1083EC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L03:
       mov       ecx,0B
       call      qword ptr [7FFE1083EC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,0A
       call      qword ptr [7FFE1083EC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       ecx,9
       call      qword ptr [7FFE1083EC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       ecx,8
       call      qword ptr [7FFE1083EC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFE1083EC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       ecx,6
       call      qword ptr [7FFE1083EC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       ecx,5
       call      qword ptr [7FFE1083EC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       ecx,4
       call      qword ptr [7FFE1083EC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,3
       call      qword ptr [7FFE1083EC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,1
       call      qword ptr [7FFE1083EC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 443
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE103CB0D0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       mov       rcx,7FFE108DA798
       call      qword ptr [7FFE1084EB98]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFE1084EC28]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       ecx,0C
       call      qword ptr [7FFE1084EC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       ecx,0B
       call      qword ptr [7FFE1084EC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       ecx,0A
       call      qword ptr [7FFE1084EC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       ecx,9
       call      qword ptr [7FFE1084EC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       ecx,8
       call      qword ptr [7FFE1084EC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L06:
       mov       ecx,7
       call      qword ptr [7FFE1084EC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L07:
       mov       ecx,6
       call      qword ptr [7FFE1084EC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L08:
       mov       ecx,5
       call      qword ptr [7FFE1084EC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L09:
       mov       ecx,4
       call      qword ptr [7FFE1084EC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L10:
       mov       ecx,3
       call      qword ptr [7FFE1084EC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,2
       call      qword ptr [7FFE1084EC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,1
       call      qword ptr [7FFE1084EC28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 418
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE103DB0D0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       call      qword ptr [7FFE1254FDB0]; JitFoldProof.Subjects.Ladder[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FFE1254FE28]; JitFoldProof.Subjects.Work(Int32)
       nop
       add       rsp,28
       ret
; Total bytes of code 21
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE1211B0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       mov       rcx,7FFE125E3338
       call      qword ptr [7FFE1256FDB0]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFE1256FE40]; JitFoldProof.Subjects.Work(Int32)
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
       call      qword ptr [7FFE1256FE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Uri
       cmp       [rax],r8
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFE1256FE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Version
       cmp       [rax],r8
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFE1256FE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Exception
       cmp       [rax],r8
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFE1256FE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Type
       cmp       [rax],r8
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFE1256FE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Int32[]
       cmp       [rax],r8
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFE1256FE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.String[]
       cmp       [rax],r8
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFE1256FE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rax],r8
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFE1256FE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       [rax],r8
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFE1256FE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rax,[rcx+18]
       mov       r8,offset MT_System.Random
       cmp       [rax],r8
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFE1256FE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,[rcx+18]
       mov       rax,offset MT_System.StringComparer
       cmp       [rcx],rax
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFE1256FE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFE1256FE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 445
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE1213B0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       mov       rcx,7FFE125F3338
       call      qword ptr [7FFE1257FDB0]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFE1257FE40]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,30
       pop       rbx
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFE1257FE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rcx,offset MT_System.Uri
       cmp       rbx,rcx
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFE1257FE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rcx,offset MT_System.Version
       cmp       rbx,rcx
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFE1257FE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rcx,offset MT_System.Exception
       cmp       rbx,rcx
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFE1257FE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       rcx,offset MT_System.Type
       cmp       rbx,rcx
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFE1257FE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,offset MT_System.Int32[]
       cmp       rbx,rcx
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFE1257FE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rcx,offset MT_System.String[]
       cmp       rbx,rcx
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFE1257FE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rcx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       rbx,rcx
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFE1257FE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       rbx,rcx
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFE1257FE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rcx,offset MT_System.Random
       cmp       rbx,rcx
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFE1257FE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,offset MT_System.StringComparer
       cmp       rbx,rcx
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFE1257FE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFE1257FE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 403
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE1214B0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

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
       mov       rcx,7FFE125E3338
       call      qword ptr [7FFE1256FDB0]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFE1256FE40]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFE1256FE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       ecx,2
       call      qword ptr [7FFE1256FE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       ecx,3
       call      qword ptr [7FFE1256FE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       ecx,4
       call      qword ptr [7FFE1256FE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       ecx,5
       call      qword ptr [7FFE1256FE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L06:
       mov       ecx,6
       call      qword ptr [7FFE1256FE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFE1256FE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L08:
       mov       ecx,8
       call      qword ptr [7FFE1256FE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L09:
       mov       ecx,9
       call      qword ptr [7FFE1256FE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L10:
       mov       ecx,0A
       call      qword ptr [7FFE1256FE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,0B
       call      qword ptr [7FFE1256FE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,0C
       call      qword ptr [7FFE1256FE40]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 434
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE1213B0F0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       call      qword ptr [7FFE1098F900]; JitFoldProof.Subjects.Ladder[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FFE1098F7F8]; JitFoldProof.Subjects.Work(Int32)
       nop
       add       rsp,28
       ret
; Total bytes of code 21
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE10732C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       mov       rcx,7FFE10977030
       call      qword ptr [7FFE1096FA08]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFE1096F900]; JitFoldProof.Subjects.Work(Int32)
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
       call      qword ptr [7FFE1096F900]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Uri
       cmp       [rax],r8
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFE1096F900]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Version
       cmp       [rax],r8
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFE1096F900]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Exception
       cmp       [rax],r8
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFE1096F900]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Type
       cmp       [rax],r8
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFE1096F900]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Int32[]
       cmp       [rax],r8
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFE1096F900]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.String[]
       cmp       [rax],r8
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFE1096F900]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rax],r8
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFE1096F900]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       [rax],r8
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFE1096F900]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rax,[rcx+10]
       mov       r8,offset MT_System.Random
       cmp       [rax],r8
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFE1096F900]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,[rcx+10]
       mov       rax,offset MT_System.StringComparer
       cmp       [rcx],rax
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFE1096F900]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFE1096F900]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 445
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE10712C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       mov       rcx,7FFE10967070
       call      qword ptr [7FFE1095FC30]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFE1095FB28]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,30
       pop       rbx
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFE1095FB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       rcx,offset MT_System.Uri
       cmp       rbx,rcx
       jne       short M01_L03
       mov       ecx,3
       call      qword ptr [7FFE1095FB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       rcx,offset MT_System.Version
       cmp       rbx,rcx
       jne       short M01_L04
       mov       ecx,4
       call      qword ptr [7FFE1095FB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rcx,offset MT_System.Exception
       cmp       rbx,rcx
       jne       short M01_L05
       mov       ecx,5
       call      qword ptr [7FFE1095FB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       rcx,offset MT_System.Type
       cmp       rbx,rcx
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFE1095FB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,offset MT_System.Int32[]
       cmp       rbx,rcx
       jne       short M01_L07
       mov       ecx,7
       call      qword ptr [7FFE1095FB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       rcx,offset MT_System.String[]
       cmp       rbx,rcx
       jne       short M01_L08
       mov       ecx,8
       call      qword ptr [7FFE1095FB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       rcx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       rbx,rcx
       jne       short M01_L09
       mov       ecx,9
       call      qword ptr [7FFE1095FB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Int32>
       cmp       rbx,rcx
       jne       short M01_L10
       mov       ecx,0A
       call      qword ptr [7FFE1095FB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       rcx,offset MT_System.Random
       cmp       rbx,rcx
       jne       short M01_L11
       mov       ecx,0B
       call      qword ptr [7FFE1095FB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,offset MT_System.StringComparer
       cmp       rbx,rcx
       jne       short M01_L12
       mov       ecx,0C
       call      qword ptr [7FFE1095FB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       xor       ecx,ecx
       mov       eax,0D
       test      rdx,rdx
       cmovne    ecx,eax
       call      qword ptr [7FFE1095FB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 403
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE10702C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

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
       mov       rcx,7FFE10967070
       call      qword ptr [7FFE1095FC30]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFE1095FB28]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       ecx,1
       call      qword ptr [7FFE1095FB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       ecx,2
       call      qword ptr [7FFE1095FB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       ecx,3
       call      qword ptr [7FFE1095FB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       ecx,4
       call      qword ptr [7FFE1095FB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       ecx,5
       call      qword ptr [7FFE1095FB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L06:
       mov       ecx,6
       call      qword ptr [7FFE1095FB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFE1095FB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L08:
       mov       ecx,8
       call      qword ptr [7FFE1095FB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L09:
       mov       ecx,9
       call      qword ptr [7FFE1095FB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L10:
       mov       ecx,0A
       call      qword ptr [7FFE1095FB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,0B
       call      qword ptr [7FFE1095FB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,0C
       call      qword ptr [7FFE1095FB28]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 434
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE10702C10
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       call      qword ptr [7FFE1085EDF0]; JitFoldProof.Subjects.Ladder[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FFE1085EE68]; JitFoldProof.Subjects.Work(Int32)
       nop
       add       rsp,28
       ret
; Total bytes of code 21
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE103DB0D0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       mov       rcx,7FFE1091BB30
       call      qword ptr [7FFE1087ED18]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFE1087EDA8]; JitFoldProof.Subjects.Work(Int32)
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
       call      qword ptr [7FFE1087EDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L02:
       mov       ecx,0C
       call      qword ptr [7FFE1087EDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L03:
       mov       ecx,0B
       call      qword ptr [7FFE1087EDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,0A
       call      qword ptr [7FFE1087EDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       ecx,9
       call      qword ptr [7FFE1087EDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       ecx,8
       call      qword ptr [7FFE1087EDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFE1087EDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       ecx,6
       call      qword ptr [7FFE1087EDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       ecx,5
       call      qword ptr [7FFE1087EDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       ecx,4
       call      qword ptr [7FFE1087EDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,3
       call      qword ptr [7FFE1087EDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,2
       call      qword ptr [7FFE1087EDA8]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 486
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE103FB0D0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       mov       rcx,7FFE1091F988
       call      qword ptr [7FFE1087EDF0]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFE1087EE80]; JitFoldProof.Subjects.Work(Int32)
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
       call      qword ptr [7FFE1087EE80]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L02:
       mov       ecx,0C
       call      qword ptr [7FFE1087EE80]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L03:
       mov       ecx,0B
       call      qword ptr [7FFE1087EE80]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,0A
       call      qword ptr [7FFE1087EE80]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L05:
       mov       ecx,9
       call      qword ptr [7FFE1087EE80]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L06:
       mov       ecx,8
       call      qword ptr [7FFE1087EE80]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFE1087EE80]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L08:
       mov       ecx,6
       call      qword ptr [7FFE1087EE80]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       ecx,5
       call      qword ptr [7FFE1087EE80]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L10:
       mov       ecx,4
       call      qword ptr [7FFE1087EE80]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,3
       call      qword ptr [7FFE1087EE80]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,1
       call      qword ptr [7FFE1087EE80]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 443
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE103FB0D0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

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
       mov       rcx,7FFE108FF988
       call      qword ptr [7FFE1085EDF0]; JitFoldProof.Subjects.Ladder[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFE1085EE80]; JitFoldProof.Subjects.Work(Int32)
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       ecx,0C
       call      qword ptr [7FFE1085EE80]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L02:
       mov       ecx,0B
       call      qword ptr [7FFE1085EE80]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L03:
       mov       ecx,0A
       call      qword ptr [7FFE1085EE80]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L04:
       mov       ecx,9
       call      qword ptr [7FFE1085EE80]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L05:
       mov       ecx,8
       call      qword ptr [7FFE1085EE80]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L06:
       mov       ecx,7
       call      qword ptr [7FFE1085EE80]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L07:
       mov       ecx,6
       call      qword ptr [7FFE1085EE80]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L08:
       mov       ecx,5
       call      qword ptr [7FFE1085EE80]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L09:
       mov       ecx,4
       call      qword ptr [7FFE1085EE80]; JitFoldProof.Subjects.Work(Int32)
       jmp       short M01_L00
M01_L10:
       mov       ecx,3
       call      qword ptr [7FFE1085EE80]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L11:
       mov       ecx,2
       call      qword ptr [7FFE1085EE80]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,1
       call      qword ptr [7FFE1085EE80]; JitFoldProof.Subjects.Work(Int32)
       jmp       near ptr M01_L00
; Total bytes of code 418
```
```assembly
; JitFoldProof.Subjects.Work(Int32)
       mov       rax,7FFE103DB0D0
       inc       qword ptr [rax]
       mov       eax,ecx
       ret
; Total bytes of code 16
```

