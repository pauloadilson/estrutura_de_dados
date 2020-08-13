from queue import Queue

fila = Queue(maxsize = 50)
filaNMe = Queue(maxsize = 50)
filaNMa = Queue(maxsize = 50)

while True:
    if not fila.full():
        numIns = input("Insira um número na fila ou 'S' para sair: ").upper()
        if numIns != 'S':
            fila.put(int(numIns))
        else:
            break
    else:
        print('A fila está cheia')
        break

numP = int(input('\nInforme um número para que a fila seja divida em duas (maiores e menores): '))
while not fila.empty():
    remove = fila.get()
    if remove < numP:
        filaNMe.put(remove)
    elif remove > numP:
        filaNMa.put(remove)

print(f'Os seguintes números são menores que {numP}:') 
while not filaNMe.empty():
    print(filaNMe.get(), end='\n')
print(f'\nOs seguintes números são maiores que {numP}:') 
while not filaNMa.empty():
    print(filaNMa.get(), end='\n')
print()
