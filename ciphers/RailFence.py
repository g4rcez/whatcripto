class RailFence:
    def __init__(self, cipher):
        self.cipher = cipher
        self.list = []

    def decipher(self):
        length = 1
        n = len(self.cipher)
        for maximo in range(1,24):
            length += 1
            Mat = [[] for i in range(length)]
            Msg = [''] * n
            j = 0
            d = +1
            for i in range(0, n):
                Mat[j].append(i)
                j += d
                if j == 0 or j == length - 1:
                    d = -d
            l = 0
            for j in range(0, length):
                for i in range(0, len(Mat[j])):
                    Msg[Mat[j][i]] = self.cipher[l]
                    l += 1
            if ''.join(Msg) in self.list:
                break
            else:
                self.list.append(''.join(Msg))
        return list(set(self.list))
