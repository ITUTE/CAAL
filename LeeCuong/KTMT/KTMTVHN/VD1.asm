.model small
.stack 100h
.data
	m1 db "Xin chao tat ca cac ban $"
.code
start:
	mov ax,@data
	mov ds,ax
	mov dx,offset m1
	mov ah,09
	int 21h
	mov ah,4ch
	int 21h
	mov ah,4ch
	int 21h
end start