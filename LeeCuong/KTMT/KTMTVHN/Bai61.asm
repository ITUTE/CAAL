.model small
.stack 100
.data
	m1 db 'nhap 1 ky tu:$'
	m2 db 10,13, 'Ma ASCII dang Hex:$'
	m3 db 10,13, 'Ma ASCII dang Dec:$'
	m4 db 10,13, 'Ma ASCII dang Bin:$'
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

	mov ah,4ch
	int 21h
end batdau