DOSSEG
.model small
.stack 100
.data
	m1 db "Xin chao tat ca moi nguoi $"
.code
batdau:
	mov ax,@data
	mov ds,ax
	
	mov ah,09
	mov dx,offset m1
	int 21h

	mov ah,4ch
	int 21h
end batdau