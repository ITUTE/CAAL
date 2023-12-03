DOSSEG
.model small
.stack 100h
.data
	m1 db "Ki tu 1 la: $"
	m2 db 10,13, "Ki tu 2 la: $"
	m3 db 10,13,"Tong hai ky tu la: $"
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

	mov ah,01
	int 21h
	push ax

	pop ax
	pop bx
	add ax,bx
	push ax

	mov ah,09
	mov dx,offset m3
	int 21h

	pop dx
	mov ah,02
	int 21h

	mov ah,4ch
	int 21h
end batdau