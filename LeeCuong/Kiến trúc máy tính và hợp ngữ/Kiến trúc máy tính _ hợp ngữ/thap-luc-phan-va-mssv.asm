 stack segment
db  100h dup (?)
stack ends

data segment
    
    hexal db 30h, 31h, 32h, 33h, 34h, 35h, 36h, 37h, 38h, 39h, 41h, 42h, 43h, 44h, 45h, 46h
    decimal db 3, ?, ?, ?, ?
    names db "Ho va ten:Nguyen Thi Truc$"
    codes db "MSSV: 15110349$"                    
 

data ends

code segment
    assume cs:code, ds:data, ss:stack
main:
    mov ax, @data
    mov ds,ax 
   
    
    
    ;BAT DAU B2
    
    ; them nen mau cho chu
    mov ah, 06h
    mov al, 00h ;xoa chu o kqa bai1 roi in mau kqa bai2
    mov bh, 21h  ;so1 la nen mau blue,4 la chu mau Red   (tra trong bang help )
    mov ch, 10d ;4 dong tiep theo la toa do cua nen mau
    mov cl, 40d
    mov dh, 13d
    mov dl, 79d
    int 10h
     ;ket thuc them nen mau
    mov ah,02h
    mov dh,11         ; hang
    mov dl,47
    mov bh,0h
    int 10h
    mov ah,09h
    mov dx,word ptr ds:offset names
    int 21h
    
    mov ah,2
    mov dl,0ah
    int 21h  
    mov ah,02h
    mov dh,12        ; hang
    mov dl,52
    mov bh,0h
    int 10h
    mov ah,09h
    mov dx,word ptr ds:offset codes
    int 21h 
    

    ;KET THUC B2
    mov ax,004ch
    int 21h
    
code ends

end main