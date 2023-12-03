.model small
.code
	org 100h
programstart:
	jmp start
	m1 db "Xin chao tat ca cac ban$"
start:
	mov dx,offset m1
	mov ah,09
	int 21h
	mov ah,4ch
	int 21h
end programstart