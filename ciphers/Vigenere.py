from itertools import starmap, cycle
from filters.sanitize import sanitize

class Vigenere:
    def __init__(self, cipher, key):
        self.original = cipher.upper()
        self.cipher = cipher.replace(' ', '').upper()
        self.key = key.upper()

    def decipher(self):
        def dec(c, k):
            return chr(((ord(c) - ord(k) - 2 * ord('A')) % 26) + ord('A'))

        self.cipher = sanitize.removesimbols(self.cipher)
        self.cipher = "".join(starmap(dec, zip(self.cipher, cycle(self.key))))
        cont, esp = 0, []
        for especial in self.original:
            if especial.upper() in sanitize.charespecial():
                esp.append(cont)
            cont += 1
        self.cipher = list(self.cipher)
        for cont in esp:
            self.cipher.insert(cont, self.original[cont])
        return [self.original, " || ", ''.join(self.cipher)]
