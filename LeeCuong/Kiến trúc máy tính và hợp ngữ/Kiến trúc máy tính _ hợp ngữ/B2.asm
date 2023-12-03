.model small
.stack 100h
.data
    hoten db "Ho Ten : Nguyen Ta Minh Trung$"
    MSSV db "MSSV : 15110347$"
.code
main proc
    mov ax,@data
    mov ds,ax
    ;IN MAU
    MOV     AH,06H
    ADD     BH,13H
    MOV     CX,090AH
    MOV     DX,0940H
    INT     10H
    ; 
    MOV AH,02
    MOV BH,00
    MOV DX,0A18h
    INT 10h
    ; 
    MOV DX,OFFSET hoten
    Mov AH,9
    Int 21h
    MOV AH,02
    MOV BH,00
    MOV DX,0B20h
    INT 10h
    MOV DX,OFFSET MSSV
    Mov AH,9
    Int 21h
    INT 10h
    Mov AH,4Ch
    Int 21h
    ; Bam phim bat ki de ket thuc chuong trinh
    MOV AH,8
    Int 21h
    exit :
        mov AH,4CH
        int 21H
main endp
end main