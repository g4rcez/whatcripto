import binascii


class Binaries:
    def __init__(self, cipher):
        self.cipher = cipher

    def decipher(self):
        binary = int(str(self.cipher.replace(' ', '')), 2)
        return str(binascii.unhexlify('%x' % binary))[2:-1]
