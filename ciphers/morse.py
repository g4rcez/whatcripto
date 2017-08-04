import string
import filters
from filters.sanitize import sanitize
from filters.text_identifier import text_identifier

class morse:
    def __init__(self, cipher):
        self.cipher = cipher
        self.inverseMorseAlphabet = ''

    def decode_morse(self, code, positionInString):
        morseLetter = ""
        if positionInString <= len(code):
            for key,char in enumerate(code[positionInString:]):
                if char == " ":
                    positionInString = key + positionInString + 1
                    letter = self.inverseMorseAlphabet[morseLetter]
                    return letter + str(self.decode_morse(code, positionInString))
                else:
                   morseLetter += char
        return morseLetter

    def decipher(self):
        morseAlphabet = { "A" : ".-","B" : "-...","C" : "-.-.",
                "D" : "-..","E" : ".","F" : "..-.","G" : "--.",
                "H" : "....","I" : "..","J" : ".---","K" : "-.-",
                "L" : ".-..","M" : "--","N" : "-.","O" : "---",
                "P" : ".--.","Q" : "--.-","R" : ".-.","S" : "...",
                "T" : "-","U" : "..-","V" : "...-","W" : ".--",
                "X" : "-..-","Y" : "-.--","Z" : "--.."," " : "/",
                "1" : ".----","2" : "..---","3" : "...--","4" : "....-",
        	    "5" : ".....","6" : "-....","7" : "--...","8" : "---..",
        	    "9" : "----.","0" : "-----","." : ".-.-.-","," : "--..--",
                ":" : "---...","?" : "..--..","'" : ".----.","-" : "-....-",
                "/" : "-..-.","@" : ".--.-.","=" : "-...-"
        }
        text = "/ 0123456789.,:?'-/@="
        morseAlfa = ["a","b","c","d","e","f","g","h","i","j",
                    "k","l","m","n","o","p","q","r","s","t",
                    "u","v","w","x","y","z","á","à","ã","è",
                    "é","ẽ","í","ì","ĩ","ó","ò","õ","ú","ù","ũ"
        ]
        self.inverseMorseAlphabet = dict((v,k) for (k,v) in morseAlphabet.items())
        informacao = self.cipher
        testCode = self.cipher.replace(" /","")
        temporario = self.cipher
        if informacao in text or informacao.isalnum() or " " in informacao:
            inverseMorseAlphabet=dict((v,k) for (k,v) in morseAlphabet.items())
            informacao = informacao.replace("/-","/ -")
            informacao = informacao.replace("/.","/ .")
            informacao = informacao.replace("-/","- /")
            informacao = informacao.replace("./",". /")
        letras,contador = 0,0
        for letratxt in morseAlfa:
            if temporario[letras] == morseAlfa[contador].lower():
                print ("Erro de sintaxe...")
                exit()
        temp = 0
        string = self.decode_morse(testCode + " ", temp)
        return str(string)
