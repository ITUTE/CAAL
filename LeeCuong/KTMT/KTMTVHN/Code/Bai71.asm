.model small
.stack 100h
.data
	
.code
start:
		mov ax,1256
		mov di,10
		xor cx,cx

	LChia:	xor dx,dx
		div di
		push dx
		inc cx
		cmp ax,0
		jnz LChia

	LIn:	pop dx
		xor dh,dh
		add dl,30h
		mov ah,02h
		int 21h
		loop LIn

		mov ah,4ch
		int 21h
end start