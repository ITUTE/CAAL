.model small
.stack 100h
.data
    BinhPhuong db 0,1,4,9,16H,25H,36H,49H,64H,81H
.code
main proc 
    mov ax,@data
    mov ds,ax
    
    mov ah,8
    int 21h
    and al,0fh
    mov bx,offset BinhPhuong
    xlat
    mov bl,al
    mov dl,bl
    mov cl,4
    shr dl,cl
    or dl,30h
    mov ah,2
    int 21h
    mov dl,bl
    and dl,0fh
    or dl,30h
    mov ah,2
    int 21h
    exit :
        mov ax,4c00h
        int 21h
main endp
end main