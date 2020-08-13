class Fila():

    def __init__(self, inicio=1, fim=1, max=50):
        self.inicio = inicio
        self.fim = fim
        self.dic = {}
        self.max = max
        
    def isEmpty(self):
        return self.inicio == self.fim
    
    def isFull(self):
        return self.fim == self.max - 1

    # Insere um elemento
    def Enqueue(self, valor):
        self.dic[self.fim] = valor
        self.fim += 1

    # Remove um elemento
    def Dequeue(self):
        if self.inicio == 0:
            return None
        v = self.dic[self.inicio]
        self.inicio += 1
        return v