/*
The MIT License (MIT)

Copyright (c) 2015 @emilybache

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
 */
using System.Collections.Generic;

namespace PimpedRose
{
    public class GildedRose
    {
        IList<Item> _items;
        public GildedRose(IList<Item> items)
        {
            this._items = items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < _items.Count; i++)
            {
                if (_items[i].Name != "Aged Brie" && _items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (_items[i].Quality > 0)
                    {
                        if (_items[i].Name != "Sulfuras, Hand of Ragnaros")
                        {
                            _items[i].Quality = _items[i].Quality - 1;
                        }
                    }
                }
                else
                {
                    if (_items[i].Quality < 50)
                    {
                        _items[i].Quality = _items[i].Quality + 1;

                        if (_items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (_items[i].SellIn < 11)
                            {
                                if (_items[i].Quality < 50)
                                {
                                    _items[i].Quality = _items[i].Quality + 1;
                                }
                            }

                            if (_items[i].SellIn < 6)
                            {
                                if (_items[i].Quality < 50)
                                {
                                    _items[i].Quality = _items[i].Quality + 1;
                                }
                            }
                        }
                    }
                }

                if (_items[i].Name != "Sulfuras, Hand of Ragnaros")
                {
                    _items[i].SellIn = _items[i].SellIn - 1;
                }

                if (_items[i].SellIn < 0)
                {
                    if (_items[i].Name != "Aged Brie")
                    {
                        if (_items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (_items[i].Quality > 0)
                            {
                                if (_items[i].Name != "Sulfuras, Hand of Ragnaros")
                                {
                                    _items[i].Quality = _items[i].Quality - 1;
                                }
                            }
                        }
                        else
                        {
                            _items[i].Quality = _items[i].Quality - _items[i].Quality;
                        }
                    }
                    else
                    {
                        if (_items[i].Quality < 50)
                        {
                            _items[i].Quality = _items[i].Quality + 1;
                        }
                    }
                }
            }
        }
    }
}
