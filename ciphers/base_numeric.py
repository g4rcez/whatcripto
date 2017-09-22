import filters.sanitize
from filters.text_identifier import text_identifier


class base_numeric:
    def __init__(self, cipher, limit, spaces=3):
        self.cipher = cipher
        self.limit = limit
        self.spaces = spaces

    def decipher(self):
        if text_identifier.has_blank(self.cipher):
            cipher = self.cipher.split()
            return self.convert_base(cipher)
        else:
            cipher = filters.sanitize.sanitize.set_spaces(self.cipher, self.spaces).split()
            return self.convert_base(cipher)

    def convert_base(self, cipher):
        decipher = []
        for translate in cipher:
            if len(translate) > 9:
                return False
            number = int(translate, self.limit)
            decimal = chr(int(translate, self.limit))
            if 31 < int(number) < 127:
                decipher.append(decimal)
        return ''.join(decipher)
