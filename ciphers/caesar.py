import base64
import string
import filters
from filters.sanitize import sanitize
from filters.text_identifier import text_identifier

class caesar:
    def __init__(self, cipher):
        self.cipher = cipher

    def decipher(self):
        text = []
        for count in range(1,26):
            correct = self.cesarCif(self.cipher, count)
            text.append(correct)
        return text

    def cesarCif(self, cipher, key):
        text_list = list(cipher)
        text_encrypt = ""
        for cont in text_list:
            if (cont >= 'a' and cont <= 'z') or (cont>= 'A' and cont <= 'Z'):
                if (cont >= 'a' and cont <= 'z'):
                    ord_c = (ord(cont) - ord('a') - key) % 26
                    text_encrypt += chr(ord_c + ord('a'))
                else:
                    ord_c = (ord(cont) - ord('A') - key) % 26
                    text_encrypt += chr(ord_c + ord('A'))
            else:
                text_encrypt += cont
        return text_encrypt
