from filters.sanitize import sanitize


class text_identifier:
    def is_binary(text):
        for correct in text:
            if correct not in ("0", "1"):
                return False
        return True

    def is_hexa(text):
        for correct in text.upper():
            dict_accepted = [
                '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', "A", "B",
                "C", "D", "E", "F"
            ]
            if correct not in dict_accepted:
                return False
        return True

    def is_only_alfabetic(text):
        text = sanitize.no_blank(text)
        return text.isalpha()

    def is_space_tab(text):
        for correct in text:
            if correct != (" ", "\t", "\n"):
                return False
        return True

    def is_only_args(text, args):
        for correct in text:
            if not correct in args:
                return False
        return True

    def has_blank(text):
        if text.count(' ') > 0 or text.count('\t') > 0:
            return True
        return False

    def is_numeric(text):
        text = sanitize.no_blank(text)
        if text.isdecimal():
            return True
        return False
