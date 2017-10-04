import filters.text_identifier
from filters.sanitize import sanitize


class Identifier:
    def __init__(self, cipher):
        self.cipher = cipher

    def cipher_bin(self):
        string = sanitize.no_blank(self.cipher)
        return filters.text_identifier.text_identifier.is_binary(string)

    def cipher_hexa(self):
        string = sanitize.no_blank(self.cipher)
        return filters.text_identifier.text_identifier.is_hexa(string)

    def cipher_caesar(self):
        return filters.text_identifier.text_identifier.is_only_alfabetic(self.cipher);

    def cipher_vigenere(self, key):
        if filters.text_identifier.text_identifier.is_only_alfabetic(key) and " " not in key:
            return filters.text_identifier.text_identifier.is_only_alfabetic(self.cipher)
        return False

    def cipher_baconian(self):
        self.cipher = self.cipher.replace("a", "A").replace("b", "B")
        self.cipher = sanitize.no_blank(self.cipher)
        return filters.text_identifier.text_identifier.is_only_args(self.cipher, ["A", "B"])

    def cipher_base64(self):
        dict_accepted = [
            'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'a', 's', 'd', 'f',
            'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm', 'Q', 'W',
            'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', 'A', 'S', 'D', 'F', 'G', 'H',
            'J', 'K', 'L', 'Z', 'X', 'C', 'V', 'B', 'N', 'M', '1', '2', '3', '4',
            '5', '6', '7', '8', '9', '0', '/', '+', '='
        ]
        if ' ' in self.cipher:
            return False
        if len(self.cipher) % 4 == 0 and len(self.cipher) >= 4:
            for correct in self.cipher:
                if correct not in dict_accepted:
                    return False
            return True
        return False

    def cipher_octal(self):
        for correct in self.cipher:
            if correct not in ['0', '1', '2', '3', '4', '5', '6', '7']:
                return False
            return True

    def cipher_morse(self):
        if '.' in self.cipher and '-' in self.cipher:
            return True
        return False

    def cipher_hackerize(self):
        simbols = [ "₪", "¶", "☰", "┏", "⊥", "¥", "ü", 
            "¡", "☐", "þ", "Λ", "§", "Ð", "∲", "ç", "ƴ", "ß", 
            "∏", "ღ", "╫", "¿", "├", "↑", "ᶾ", "✕", "↻"
        ]

        for char in self.cipher:
            if char in self.cipher:
                return True
        return False
