.model small
.stack 100h
.data
	m1 db "Nhap vao so nguyen duong:  $"
	m2 db 10,13, "So nguyen da nhap la: $"
	kq dw 0
	buff	db 6
		db 0
		db 5 dup(?)
.code
start:
		mov ax,@data
		mov ds,ax
		
		mov dx,offset m1
		mov ah,09
		int 21h
		mov ah,0ah
		mov dx,offset buff
		int 21h

		mov bx,offset buff
		xor cx,cx
		xor ax,ax
		xor dx,dx
		inc bx
		mov cl,[bx]
		inc bx
		mov al,[bx]
		sub al,30h
		dec cx
		mov di,10
		cmp cx,0
		jz l2

	l1:	inc bx
		mul di
		mov dl,[bx]
		sub dl,30h
		add ax,dx
		loop l1	
		
	l2:	mov kq,ax
		
;=============================================
		mov ax,kq
		mov di,10
		xor cx,cx

	lchia:	xor dx,dx
		div di
		push dx
		inc cx
		cmp ax,0
		jnz lchia

		mov dx,offset m2
		mov ah,09
		int 21h

	lin:	pop dx
		xor dh,dh
		add dl,30h
		mov ah,02h
		int 21h
		loop lin
;=============================================


		mov ah,4ch
		int 21h
end start