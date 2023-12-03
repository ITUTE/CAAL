.model small
.stack 100h
.data
    ;dexter db "Hello world$"
    day1 db 3,4,8,7,7
    len EQU $-day1
    day2 db 3,5,2,3,1 
    tong DB len-1 DUP(0)
     hoten db "Ho Ten: Nguyen Thi Yen Nhi$";26
    mssv db "MSSV: 15110269$";14
.code
start:
    mov ax,@data
    mov ds,ax
    xor ax,ax
    mov cx,3
    mov si,4
not_change:
    mov al,ds:day2[si]
    sbb al,ds:day1[si]
    aas
    mov tong[si-1],al
    dec si
    loop not_change
    mov al,0h
    sbb al,al
    mov tong[si-1],al 
    mov cx,3
    mov al,ds:tong[0]
    cmp al,00h
    jz kt1
    mov si,1
    mov ah,02h
    mov dl,2dh
    int 21h
    kt1:
    mov al,ds:tong[0]
    cmp al,01h
    jz kt2
    mov si,1
    mov ah,02h
    mov dl,ds:tong[0]
    or dl,30h
    int 21h
    kt2:
    mov dl,2bh
    mov ds:tong[0],dl
nhan:
    mov ah,02h
    mov dl,ds:tong[si]
    or dl,30h
    int 21h
    inc si
    loop nhan
    
    ;
    
    mov ah,00 ;
    mov al,02 ; che do 80 cot * 25 hang.
    int 10h ; Dat che do xong
    
    ;ve khung
    mov ah,6
    mov al,00h
    mov bh,4eh
    mov ch,0d;hang tren
    mov cl,27d;cot trai
    mov dh,3d;hang duoi
    mov dl,52d;cot phai
    int 10h
    
    mov ah,2
    mov dh,1;dong in ten
    mov dl,27;cot in ten
    mov bh,0
    int 10h
    
    ;in ho ten
    mov ah,9
    lea dx,hoten
    int 21h
    
    mov ah,2
    mov dh,2;dong in ho ten
    mov dl,33;cot in ho ten
    mov bh,0
    int 10h
    
    ;int mssv
    mov ah,9
    lea dx,mssv
    int 21h
    ;
    mov ax,4C00h
    int 21h
end start