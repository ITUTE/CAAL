.MODEL SMALL
.STACK 100
.DATA
	M1 DB "Nhap vao so nguyen duong: $"
	M2 DB 10,13, "giai thua la: $"
	KQ DW 0
	buff	DB 6
			DB 0
			DB	5 DUP(?)
.CODE
Batdau:
	MOV AX,@DATA
	MOV DS,AX
	
	MOV DX,OFFSET M1
	MOV AH,09
	INT 21H

	mov ah,0ah
	mov dx, offset buff
	int 21H
	
	mov bx, offset buff
	xor cx,cx
	xor ax,ax
	xor dx,dx
	inc bx
	mov cl,[bx]
	inc bx
	mov al, [bx]
	sub al,30h
	dec cx
	mov di,10
	cmp cx, 0
	jz L2
	
L1:
	inc bx
	mul di
	mov dl,[bx]
	sub dl,30h
	add ax,dx
	loop L1
	
L2: mov KQ,ax
	mov cx,KQ
	mov ax,1
	cmp cx,2
	jb Lchia
Lap:
	mul cx
	loop Lap
	mov di,10
	xor cx,cx
Lchia:	xor dx,dx
	div di
	push dx
	inc cx
	cmp ax,0
	jnz Lchia
	
	MOV DX,OFFSET M2
	MOV AH,09
	INT 21H
Lin:	pop dx
	xor dh,dh
	add dl,30h
	
	
	mov ah,02h
	int 21h
	loop Lin

	MOV AH,4CH
	INT 21H
END Batdau