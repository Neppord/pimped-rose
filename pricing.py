from random import random


class PricingRegistry:
    @staticmethod
    def get_price(item):
        return random() * 100
