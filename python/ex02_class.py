from stack import Pilha

numInt = int(input("Informe um número decimal: "))
b = Pilha()
numBin = ""

while(numInt != 0):
    b.Empilha(numInt%2)
    numInt = int(numInt / 2)

while(not b.EstaVazia()):
    numBin += str(b.Desempilha())

print(f"Número binário: {numBin}.")