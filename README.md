# WhatCripto
#### Desenvolvedor: VandalVNL
#### Linguagem Utilizada: Python3
#### Versão Atual: 2.0.0
#### Licença: GPL
#### Ambiente de testes: Arch Linux, Manjaro, CentOS e Debian
---
### Chamada da ferramenta
> uname@kurupira[~]: whatcripto (texto criptografado) (chave, quando existir)

***Cifras que caracteres especiais devem ser colocadas entre aspas duplas, afim
de evitar erros na identificação/decifragem***

### Atualização
WhatCripto foi reescrito, utilizando o paradigma orientado a objetos, facilitando
a varredura desnecessária de cifras que não podem ser de um tipo, logo, aumentando
o desempenho e garantindo maior confiabilidade na resposta.

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
