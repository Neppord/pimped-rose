from abc import ABC, abstractmethod
from datetime import datetime

from database import Database


class EventHandler(ABC):

    @abstractmethod
    def on_database_ready(self, time, database):
        pass

    @abstractmethod
    def on_update(self, items):
        pass

    @abstractmethod
    def on_report(self, items):
        pass

    @abstractmethod
    def on_write_file(self, text):
        pass

    def run_handler(self):
        items = self.on_database_ready(datetime.today(), Database())
        updated_items = self.on_update(items)
        report = self.on_report(updated_items)
        self.on_write_file(report)
