class HackerizeXs:
    def __init__(self, cipher):
        self.simbols = {
            'Λ': 'a','₪': 'w', '¶': 'q', '☰': 'e', '┏': 'r',
            '⊥': 't', '¥': 'y', 'ü': 'u', '¡': 'i',
            '☐': 'o', 'þ': 'p', '§': 's',
            'Ð': 'd', '∲': 'f', 'ç': 'g', 'ƴ': 'v',
            'ß': 'b', '∏': 'n', 'ღ': 'm', '╫': 'h',
            '¿': 'j', '├': 'k', '↑': 'l', 'ᶾ': 'z',
            '✕': 'x', '↻': 'c', ' ': ' ', '{':'{',
            '}':'}','[':'[',']':']',"!":"!","?":"?","▪":'.'
        }
        self.cipher = cipher
    def decipher(self):
        decipherList = []
        for char in self.cipher:
            try:
                decipherList.append(self.simbols.get(char))
            except:
                pass
        return ''.join(decipherList)
