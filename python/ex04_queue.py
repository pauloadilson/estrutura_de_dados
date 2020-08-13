from queue import LifoQueue

#FraseOD = input("Frase original: ")
FraseOD = 'Paulo Adilson da Silva'
p = LifoQueue(maxsize=len(FraseOD))
FrasePOI = ''

for l in FraseOD:
    if (l != ' '):
        p.put(l)
    else:
        while not p.empty():
            FrasePOI += p.get()
        FrasePOI += ' '
while not p.empty():
    FrasePOI += p.get()
            
print(FrasePOI)