Nganxep segment word "stack"
	db 100 dup(?)
Nganxep ends
Dulieu segment para common "data"
	m1 db "Day la chuong trinh lam quen voi assembly"
	db 10,13, "De chay duoc 1 CT hop ngu ban can thuc hien cac buoc sau:"
	db 10,13, "1) Dich file ASM thanh file OBJ"
	db 10,13, "2) Lien ket file OBJ thanh file EXE"
	db 10,13, "3) Chay file EXE"
	db 10,13, "Moi truong thuc hanh Editplus$"
Dulieu ends
Ma 	segment "code"
	assume cs:Ma, ds:Dulieu, ss:Nganxep
Batdau:
	mov ax,Dulieu
	mov ds,ax
	mov dx,offset m1
	mov ah,09
	int 21h
	mov ah,4ch
	int 21h
Ma ends
end Batdau