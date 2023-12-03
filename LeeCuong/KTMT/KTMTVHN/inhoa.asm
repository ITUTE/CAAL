DOSSEG
.model small
.stack 100
.data
	m1 db "Nhap 1 ky tu: $"
	m2 db 10,13, "Ky tu thuong la: $"
.code
batdau:
	mov ax,@data
	mov ds,ax

	mov ah,09
	mov dx,offset m1
	int 21h

	mov ah,01
	int 21h
	push ax

	pop dx
	sub al,20h
	push ax

	mov ah,09
	mov dx,offset m2
	int 21h

	pop dx
	mov ah,02
	int 21h

	mov ah,4ch
	int 21h
end batdau
	