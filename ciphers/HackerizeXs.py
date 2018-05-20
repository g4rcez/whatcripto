class HackerizeXs:
    def __init__(self, cipher):
        self.symbols = {
            'Λ': 'a',
            '₪': 'w',
            '¶': 'q',
            '☰': 'e',
            '┏': 'r',
            '⊥': 't',
            '¥': 'y',
            'ü': 'u',
            '¡': 'i',
            '☐': 'o',
            'þ': 'p',
            '§': 's',
            'Ð': 'd',
            '∲': 'f',
            'ç': 'g',
            'ƴ': 'v',
            'ß': 'b',
            '∏': 'n',
            'ღ': 'm',
            '╫': 'h',
            '¿': 'j',
            '├': 'k',
            '↑': 'l',
            'ᶾ': 'z',
            '✕': 'x',
            '↻': 'c',
            ' ': ' ',
            '{': '{',
            '}': '}',
            '[': '[',
            ']': ']',
            "!": "!",
            "?": "?",
            "▪": '.',
            "_": "_",
            '0': '0',
            '1': '1',
            '2': '2',
            '3': '3',
            '4': '4',
            '5': '5',
            '6': '6',
            '7': '7',
            '8': '8',
            '9': '9'
        }
        self.cipher = cipher

    def decipher(self):
        decipherList = []
        for char in self.cipher:
            try:
                decipherList.append(self.symbols.get(char))
            except:
                decipherList.append(char)
        return ''.join(decipherList)
