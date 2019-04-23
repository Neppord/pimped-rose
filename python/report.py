from item import Item
from pricing import PricingRegistry


class Report:

    def __init__(self, items: [Item]):
        self.items = items
        self.pricing_registry = PricingRegistry()

    def __str__(self):
        header = f"{'name': <20}{'quality': >10}{'sell in': >10}{'price': >10}\n"
        table = "\n".join(
            f"{item.name: <20}" +
            f"{item.quality: >10}" +
            f"{item.sell_in: >10}" +
            f"{self.pricing_registry.get_price(item): >10.2f}"
            for item in self.items
        )
        return header + table

