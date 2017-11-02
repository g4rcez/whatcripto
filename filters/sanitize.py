class sanitize:
    def set_spaces(string, length):
        cont, chars = 1, []
        if string.find(" ") == -1:
            for character in string:
                chars.append(character)
                if (cont % length) == 0:
                    chars.append(" ");
                cont+=1;
            string = ''.join(chars).strip();
        return string

    def no_blank(text):
        return text.replace(" ","").replace("\t","");

    def print_nonone(text):
        try:
            text = ''.join(text)
        except:
            pass
        if text != None or text != '' or text != '\t' or text != []:
            return text

    def removesimbols(string):
        simbols = sanitize.charespecial()
        for simbol in simbols:
            string = string.replace(simbol, '')
        return string

    def charespecial():
        return ["{","}","-","=",'ç',"[","]","_"]
