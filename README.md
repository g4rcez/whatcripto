# WhatCripto
#### Desenvolvedor: VandalVNL
#### Linguagem Utilizada: Python3
#### Versão Atual: 1.0.0
#### Licença: GPL
#### Ambiente de testes: Arch Linux, Manjaro, CentOS e Debian
---
### Chamada da ferramenta
> uname@kurupira[~]: whatcripto (texto criptografado) (chave, quando existir)

---
### Descrição da Ferramenta
WhatCripto é uma ferramenta para descobrir e decifrar alguns tipos de cifras criptográficas. Seu uso é bastante simples e o princípio foi baseado no "HashID", ao invés de hashs, ele identifica cifras.

### Menu de ajuda
> Uso: whatcripto [escrita cifrada]
Parâmetro de uso:
-k, --key: Informe para quando houver uma chave para a cifra
Exemplo de uso:
root@uname[~]# whatacripto 'Tqxxa Tmowqd'
[12]-> Hello Hacker

### Dependências
- Python3
- Libs do Python: 
	- Math
	- Sys
	- String
	- Locale
	- Re(Regex)
	- Base64
	- Random
	- Itertools	
