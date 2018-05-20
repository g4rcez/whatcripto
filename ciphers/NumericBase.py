class NumericBase:
    def __init__(self, cipher, base, spaces=2):
        self.cipher = cipher
        self.base = base
        self.spaces = spaces

    def decipher(self):
        decipher = self.split_str(self.cipher, self.spaces)
        decipher_list = []
        for string in decipher:
            hexadecimal = hex(int(bin(int(string, 16))[2:], 2))[2:]
            decipher_list.append(chr(int(hexadecimal, self.base)))
        return ''.join(decipher_list)

    def make_split(self, string, cut):
        for start in range(0, len(string), cut):
            yield string[start:start + cut]

    def split_str(self, string, cut):
        striped = []
        for char in self.make_split(string, cut):
            striped.append(char)
        return striped
