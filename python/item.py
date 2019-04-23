class Item:

    def __init__(self, name: str, quality: int, sell_in: int):
        self.name = name
        self.quality = quality
        self.sell_in = sell_in

    def __repr__(self):
        return f"Item({self.name!r}, {self.quality!r}, {self.sell_in!r})"
