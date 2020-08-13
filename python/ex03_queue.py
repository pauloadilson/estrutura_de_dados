from queue import LifoQueue

NumInt = int(input("Número: "))
p = LifoQueue(maxsize=NumInt)
Oper = input("OPERAÇÕES: ")

i = 1
NumResultado = ""
for l in Oper:
    if (l == 'E'):
        p.put(i)
        i += 1
    elif (l == 'D'):
        NumResultado += str(p.get())
print(NumResultado)