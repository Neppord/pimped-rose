from itertools import product
from random import choice, sample


NAMES = [
    "Master sword",
    "Oger Club Card",
    "Majors Mask",
    "Ocarina of Mime"
]
QUALITIES = list(range(50))
SELL_INS = list(range(360))


class Database:

    def get_items(self):
        return sample(list(product(
            NAMES,
            QUALITIES,
            SELL_INS,
        )), 100)
