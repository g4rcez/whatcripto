import base64


class Base64:
    def __init__(self, cipher):
        self.cipher = cipher

    def decipher(self):
        try:
            return base64.standard_b64decode(str.encode(self.cipher))
        except:
            return ''
