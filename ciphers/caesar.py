class caesar:
    def __init__(self, cipher):
        self.cipher = cipher

    def decipher(self):
        text = []
        for count in range(1, 26):
            correct = self.cesarCif(self.cipher, count)
            text.append(correct)
        return text

    def cesarCif(self, cipher, key):
        text_list = list(cipher)
        text_encrypt = ""
        for cont in text_list:
            if ('a' <= cont <= 'z') or ('A' <= cont <= 'Z'):
                if 'a' <= cont <= 'z':
                    ord_c = (ord(cont) - ord('a') - key) % 26
                    text_encrypt += chr(ord_c + ord('a'))
                else:
                    ord_c = (ord(cont) - ord('A') - key) % 26
                    text_encrypt += chr(ord_c + ord('A'))
            else:
                text_encrypt += cont
        return text_encrypt
