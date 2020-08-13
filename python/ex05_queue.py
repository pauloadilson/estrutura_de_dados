from queue import LifoQueue

#expr = input("Expressão: ")
expr = 'a = b + (c -d * (e – f)'
p = LifoQueue(maxsize=len(expr))
result = 1
for l in expr:
    if l == '(' or l == '[' or l == '{':
        p.put(l)
    elif l == ')':
        result = 1 if p.get() == '(' else 0
    elif l == ']':
        result = 1 if p.get() == '[' else 0
    elif l == '}':
        result = 1 if p.get() == '{' else 0
    else:
        result = 1
    if result == 0:
        break
resprint = 'Bem formulada' if p.empty() and result == 1 else "Mal Formulada"
print(resprint)