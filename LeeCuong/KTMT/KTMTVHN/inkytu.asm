DOSSEG
.model small
.stack 100
.data
	m1 db "nhap 1 ki tu: $"
	m2 db 10,13, "ki tu sau no la: $"
	m3 db 10,13, "ki tu truoc no la: $"
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

	mov ah,09
	mov dx,offset m2
	int 21h

	pop dx
	inc dl
	mov ah,02
	int 21h
	push ax
	
	mov ah,09
	mov dx,offset m3
	int 21h

	pop dx
	dec dl
	dec dl
	mov ah,02
	int 21h

	mov ah,4ch
	int 21h
end batdau