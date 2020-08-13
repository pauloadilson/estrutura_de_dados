class Pilha():

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

'''if __name__ == '__main__':
    Pilha()'''