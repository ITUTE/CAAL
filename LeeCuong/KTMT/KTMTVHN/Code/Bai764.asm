.model small
.stack 100h
.data
	m1 db "Nhap vao so nguyen duong 1:  $"
	m2 db 10,13, "Nhap vao so nguyen duong 2: $"
	m3 db 10,13, "Tong 2 so la: $"
	
        m4 db 10,13, "Hieu 2 so la: $"
	kq dw 0
	kqq dw 0
	kqtru dw 0
	kqcong dw 0
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

;----------------------------------------------
		mov dx,offset m2
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
		jz l4

	l3:	inc bx
		mul di
		mov dl,[bx]
		sub dl,30h
		add ax,dx
		loop l3	
              
               

	l4:	mov kqq,ax

		mov ax,kq
		mov bx,kqq
		add ax,bx	
;=============================================
		mov di,10
		xor cx,cx

	lchia:	xor dx,dx
		div di
		push dx
		inc cx
		cmp ax,0
		jnz lchia

		mov dx,offset m3
		mov ah,09
		int 21h
      
               
	lin:	
		pop dx
		xor dh,dh
		add dl,30h
		mov ah,02h
		int 21h
		loop lin
               
;=============================================
		mov ax,kq
		mov bx,kqq
		sub ax,bx	
;=============================================
		mov di,10
		xor cx,cx

	lchiasub:	
		xor dx,dx
		div di
		push dx
		inc cx
		cmp ax,0
		jnz lchiasub

		mov dx,offset m4
		mov ah,09
		int 21h
      
               
	linsub:
		pop dx
		xor dh,dh
		add dl,30h
		mov ah,02h
		int 21h
		loop linsub
;=============================================
		mov ax,kq
		mov bx,kqq
		sub ax,bx	
;=============================================
		mov ah,4ch
		int 21h
end start