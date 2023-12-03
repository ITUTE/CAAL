code 	segment
	org 100h
assume cs:code,ds:code,ss:code
programstart:
	jmp start
	m1 db "Day la chuong trinh lam quen voi assembly"
	db 10,13, "De chay duoc 1 CT hop ngu ban can thuc hien cac buoc sau:"
	db 10,13, "1) Dich file ASM thanh file OBJ"
	db 10,13, "2) Lien ket file OBJ thanh file EXE"
	db 10,13, "3) Chay file EXE"
	db 10,13, "Moi truong thuc hanh Editplus$"
start:
	mov dx,offset m1
	mov ah,09
	int 21h
	mov ah,4ch
	int 21h
code ends
end programstart
