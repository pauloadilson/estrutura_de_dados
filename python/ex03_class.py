from stack import Pilha

p = Pilha()
NumInt = int(input("Número: "))
Oper = input("OPERAÇÕES: ").upper()
#NumInt = 4
#Oper = "EEEDDEDD"

i = 1
NumResultado = ""
for l in Oper:
    if (l == 'E'):
        p.Empilha(i)
        i += 1
    elif (l == 'D'):
        NumResultado += str(p.Desempilha())
print(NumResultado)