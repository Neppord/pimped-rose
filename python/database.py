from itertools import product
from random import choice, sample

PREFIXES = [
    "Master",
    "Oger",
    "Majors",
    "Ocarina",
    "Sword",
    "Textbook",
    "Worn",
]

POSTFIXES = [
    "Shield",
    "Sword",
    "Club Card",
    "Mask",
    "of Mime",
    "of Stone",
]

NAMES = [pre + " " + post for pre, post in product(PREFIXES, POSTFIXES)]
QUALITIES = list(range(50))
SELL_INS = list(range(360))


class Database:

    def get_items(self):
        return sample(list(product(
            NAMES,
            QUALITIES,
            SELL_INS,
        )), 100)
