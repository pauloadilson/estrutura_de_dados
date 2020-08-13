from stack import Pilha

p = Pilha()
expr = input("Expressão: ")
#expr = 'a = b + (c -d) * (e – f)'
result = 1
for l in expr:
    if l == '(' or l == '[' or l == '{':
        p.Empilha(l)
    elif l == ')':
        result = 0 if p.EstaVazia() else (1 if p.Desempilha() == '(' else 0) 
    elif l == ']':
        result = 0 if p.EstaVazia() else (1 if p.Desempilha() == '[' else 0)
    elif l == '}':
        result = 0 if p.EstaVazia() else (1 if p.Desempilha() == '{' else 0)
    else:
        result = 1
    if result == 0:
        break
resprint = 'Bem formulada' if p.EstaVazia() and result == 1 else "Mal Formulada"
print(resprint)