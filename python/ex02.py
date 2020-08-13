from queue import LifoQueue

numInt = int(input("Informe um número decimal: "))
b = LifoQueue(maxsize=numInt)
numBin = ""

while(numInt != 0):
    b.put(numInt%2)
    numInt = int(numInt / 2)

while(not b.empty()):
    numBin += str(b.get())

print(f"Número binário: {numBin}.")