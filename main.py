from event import EventHandler
from gildedrose import update_quality
from item import Item
from report import Report


class MainEventHandler(EventHandler):
    def on_database_ready(self, time, database):
        items = []
        for name, quality, sell_in in database.get_items():
            items.append(Item(name, quality, sell_in))
        return items

    def on_update(self, items):
        return update_quality(items)

    def on_report(self, items):
        return str(Report(items))

    def on_write_file(self, text):
        with open("report.txt", "w") as f:
            f.write(text)


if __name__ == "__main__":
    MainEventHandler().run_handler()
