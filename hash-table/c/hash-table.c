#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#define CAPACITY  1000

typedef struct HashTableEntry
{
    char* key;
    char* value;
} HashTableEntry;

typedef struct HashTable
{
    HashTableEntry** entries;
} HashTable;

unsigned int get_hash_value(char* key)
{
    unsigned long i = 0;
    for (int j=0; str[j]; j++)
        i += str[j];
    return i % CAPACITY;
}

void put(char* key, char* value)
{

}

void get(char* key)
{

}

HashTable* create_table(int size)
{
    HashTable* table =  (HashTable*) malloc(sizeof(HashTable));
    table->entries = (HashTableEntry**)calloc(size, sizeof(HashTableEntry*));

    for (int index = 0; index < size; index++)
    {
        table->entries[index] = NULL;
    }
}

int main() 
{

}