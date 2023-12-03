 stack segment
db  100h dup (?)
stack ends

data segment
    
        square db 0h, 1h, 4h, 9h, 16h, 25h, 36h, 42h, 64h, 81h


 names db "Ho va ten: Tran Thi To Uyen$"
    codes db "MSSV: 15110361$"
 

data ends

code segment
    assume cs:code, ds:data, ss:stack
main:
    mov ax, @data
    mov ds,ax
 
    
    mov ah, 08h
    int 21h
    
    and al, 0fh
    lea bx, byte ptr ds:square
    xlat
    mov bl, al
    
    mov ah, 02h
    mov dl, bl
    and dl, 0f0h
    shr dl, 04h
    or dl, 30h
    int 21h
    
    mov dl, bl
    and dl, 0fh
    or dl, 30h
    int 21h    
 
mov ah, 08h
int 21h 


;BAT DAU B2
mov ah,02
    mov dh,11
    mov dl,26
    mov bh,0h
    int 10h
    ; them nen mau cho chu
    mov ah, 06h
    mov al, 00h ;xoa chu o kqa bai1 roi in mau kqa bai2
    mov bh, 0f4h  ;so1 la nen mau blue,4 la chu mau Red   (tra trong bang help )
    mov ch, 08d ;4 dong tiep theo la toa do cua nen mau
    mov cl, 20d
    mov dh, 16d
    mov dl, 60d
    int 10h
     ;ket thuc them nen mau
    mov ah,9
    mov dx,word ptr ds:offset names
    int 21h
    
    mov ah,2
    mov dl,0ah
    int 21h  
    mov ah,02h
    mov dh,12
    mov dl,32
    mov bh,0h
    int 10h
    mov ah,09
    mov dx,word ptr ds:offset codes
    int 21h 
    

;KET THUC B2
mov ax,004ch
int 21h
    
code ends

end main