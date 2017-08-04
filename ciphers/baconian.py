import string
import filters
from filters.sanitize import sanitize
from filters.text_identifier import text_identifier

class baconian:
    def __init__(self, cipher):
        self.cipher = cipher
        self.dict_bacon = {
            "AAAAA":"A","AAAAB":"B","AAABA":"C","AAABB":"D","AABAA":"E",
            "AABAB":"F","AABBA":"G","AABBB":"H","ABAAA":"I","ABAAA":"J",
            "ABAAB":"K","ABABA":"L","ABABB":"M","ABBAA":"N","ABBAB":"O",
            "ABBBA":"P","ABBBB":"Q","BAAAA":"R","BAAAB":"S","BAABA":"T",
            "BAABB":"U","BAABB":"V","BABAA":"W","BABAB":"X","BABBA":"Y",
            "BABBB":"Z"
        }

    def decipher(self):
        text = ""
        baconian = sanitize.set_spaces(self.cipher, 5).split()
        for correct in baconian:
            if len(correct) != 5:
                return False
            elif correct not in self.dict_bacon.keys():
                return False
            text += self.dict_bacon.get(correct)
        return text
