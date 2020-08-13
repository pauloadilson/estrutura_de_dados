from queueclass import Fila

fila = Fila()
filaNMe = Fila()
filaNMa = Fila()

while True:
    if not fila.isFull():
        numIns = input("Insira um número na fila ou 'S' para sair: ").upper()
        if numIns != 'S':
            fila.Enqueue(int(numIns))
        else:
            break
    else:
        print('A fila está cheia')
        break

numP = int(input('\nInforme um número para que a fila seja divida em duas (maiores e menores): '))
while not fila.isEmpty():
    remove = fila.Dequeue()
    if remove < numP:
        filaNMe.Enqueue(remove)
    elif remove > numP:
        filaNMa.Enqueue(remove)

print(f'Os seguintes números são menores que {numP}:') 
while not filaNMe.isEmpty():
    print(filaNMe.Dequeue(), end='\n')
print(f'\nOs seguintes números são maiores que {numP}:') 
while not filaNMa.isEmpty():
    print(filaNMa.Dequeue(), end='\n')
print()
