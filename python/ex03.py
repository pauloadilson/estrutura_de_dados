class Pilha(object):

    def __init__(self, topo=-1, max=50):
        self.topo = topo
        self.vetor = []
        self.max = max
        
    def EstaVazia(self):
        return (self.topo == -1)
    
    def EstaCheia(self):
        return (self.topo == max - 1)

    # Insere um elemento
    def Empilha(self, valor):
        self.vetor.append(valor)
        self.topo += 1

    # Remove um elemento
    def Desempilha(self):
        v = self.vetor[self.topo]
        self.vetor.pop()
        self.topo -= 1
        return v


p = Pilha()
NumInt = int(input("Número: "))
Oper = input("OPERAÇÕES: ")

i = 1
NumResultado = ""
for l in Oper:
    if (l == 'E'):
        p.Empilha(i)
        i += 1
    elif (l == 'D'):
        NumResultado += str(p.Desempilha())
print(NumResultado)