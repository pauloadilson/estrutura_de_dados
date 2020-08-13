from stack import Pilha
from memory_profiler import profile

@profile
def main():
    p = Pilha()
    #FraseOD = input("Frase original: ")
    FraseOD = 'Paulo Adilson da Silva'
    FrasePOI = ''

    for l in FraseOD:
        if (l != ' '):
            p.Empilha(l)
        else:
            while not p.EstaVazia():
                FrasePOI += p.Desempilha()
            FrasePOI += ' '
            
    while not p.EstaVazia():
        FrasePOI += p.Desempilha()
                
    print(FrasePOI)

if __name__ == "__main__":
    main()