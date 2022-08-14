from collections import deque
from curses import noecho
from unittest.loader import VALID_MODULE_NAME

class HashTable:
    store = [1000]
        
    def get_hash_value(self, key):
        initialHash = hash(key)
        return int(str(initialHash)[0:3])

    def put(self, key, value):
        hash = self.get_hash_value(key)
        valueList = self.store[hash]

        if valueList is None:
            valueList = deque()

        valueList.append(value)
        self.store[hash] = valueList

    def get(self, key):
        hash = self.get_hash_value(key)
        valueList = self.store[hash]

        if valueList is not None:
            return valueList.pop()
        else:
            return None

hashTable = HashTable()
hashTable.put("word", 2)
wordCount = hashTable.get("word")
print(wordCount)