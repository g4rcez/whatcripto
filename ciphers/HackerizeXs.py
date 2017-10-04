class HackerizeXs:
    def __init__(self, cipher):
        self.simbols = {
            '₪': 'w', '¶': 'q', '☰': 'e', '┏': 'r',
            '⊥': 't', '¥': 'y', 'ü': 'u', '¡': 'i',
            '☐': 'o', 'þ': 'p', 'Λ': 'a', '§': 's',
            'Ð': 'd', '∲': 'f', 'ç': 'g', 'ƴ': 'v',
            'ß': 'b', '∏': 'n', 'ღ': 'm', '╫': 'h',
            '¿': 'j', '├': 'k', '↑': 'l', 'ᶾ': 'z',
            '✕': 'x', '↻': 'c',
        }
        self.cipher = cipher
    
    def decipher(self):
        decipherList = []
        for char in self.cipher:
            try:
                decipherList.append(
                    self.simbols[char.lower()]
                )
            except KeyError:
                decipherList.append(char)
        return ''.join(decipherList)
