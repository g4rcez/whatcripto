from itertools import starmap, cycle


class Vigenere:
    def __init__(self, cipher, key):
        self.original = cipher
        self.cipher = cipher.replace(' ', '')
        self.key = key

    def decipher(self):
        message = self.cipher
        key = self.key

        def dec(c, k):
            return chr(((ord(c) - ord(k) - 2 * ord('A')) % 26) + ord('A'))

        self.cipher = "".join(starmap(dec, zip(message, cycle(key))))
        cont, esp = 0, []
        for especial in self.original:
            if especial == " ":
                esp.append(cont)
            cont += 1
        self.cipher = list(self.cipher)
        for cont in esp:
            self.cipher.insert(cont, ' ')
        return [self.original, " || ", ''.join(self.cipher).lower()]
