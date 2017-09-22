import filters.sanitize
from filters.text_identifier import text_identifier


class binaries:
    def __init__(self, cipher):
        self.cipher = cipher

    def decipher(self):
        if text_identifier.has_blank(self.cipher):
            cipher = self.cipher.split()
            return self.convert_bins(cipher)
        else:
            text = []
            for limit in range(2, 8):
                cipher = filters.sanitize.sanitize.set_spaces(self.cipher, limit).split()
                tmp = self.convert_bins(cipher)
                if tmp != '':
                    text.append(self.convert_bins(cipher))
            return text

    def convert_bins(self, cipher):
        decipher = []
        for translate in cipher:
            if len(translate) > 9:
                return False
            number = int(translate, 2)
            decimal = chr(int(translate, 2))
            if 31 < int(number) < 127:
                decipher.append(decimal)
        return ''.join(decipher)
