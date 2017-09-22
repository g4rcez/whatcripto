import base64


class base_64:
    def __init__(self, cipher):
        self.cipher = cipher

    def decipher(self):
        try:
            encode = str(base64.standard_b64decode(str.encode(self.cipher)))
            return encode[2:-3]
        except:
            return ''
