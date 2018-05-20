class stdin:
    # Classe com retorno da string referente ao argumento passado [vetor é aconselhavel]
    def get_opt_value(stdin, parametros):
        try:
            for flag in stdin:
                if flag in parametros:
                    return stdin[stdin.index(flag) + 1]
        except:
            return None

    # Classe com o retorno caso exista o argumento passado [vetor é aconselhavel]
    def get_opt(stdin, parametros):
        try:
            for flag in stdin:
                if flag in parametros:
                    return True
        except:
            return False
