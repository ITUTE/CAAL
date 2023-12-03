DOSSEG
.model small
.stack 100
.data

	m1 db 'Nhap so thu nhat: $'
	m2 db 10, 13, 'Nhap so thu hai: $'
	m3 db 10, 13, 'Hieu hai so la: $'
.code
batdau:
	mov ax, @data
	mov ds, ax
	
	mov ah, 09
	mov dx, offset m1
	int 21h

	mov ah, 01
	int 21h
	sub al, 30h
	push ax

	mov ah, 09
	mov dx, offset m2
	int 21h

	mov ah, 01
	int 21h
	sub al, 30h
	push ax

	mov ah, 09
	mov dx, offset m3
	int 21h

	pop ax
	pop dx	
	sub dl, al
	add dl, 30h
	mov ah, 02
	int 21h

	mov ah, 4ch
	int 21h

end batdau