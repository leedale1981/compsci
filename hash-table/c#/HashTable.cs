using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace Lee.CompSci.DataStructures
{
    public abstract class HashTableBase
    {
        protected readonly int _startSize = 1000;

        protected uint GetHashValue(string key)
        {
            return uint.Parse((((uint)key.GetHashCode()).ToString().Substring(0, 3)));
        }
    }

    public class HashTable : HashTableBase
    {
        protected LinkedList<object>[] _store;

        public HashTable()
        {
            _store = new LinkedList<object>[_startSize];
        }

        public void Put(string key, object value)
        {
            uint hashValue = this.GetHashValue(key);

            if (hashValue > _store.Length)
            {
                Array.Resize<LinkedList<object>>(ref _store, ((int)hashValue) * 2);
            }

            LinkedList<object> valueList = _store[hashValue];

            if (valueList == null)
            {
                valueList = new LinkedList<object>();
            }

            valueList.AddLast(new
            {
                Value = value
            });

            _store[hashValue] = valueList;
        }

        public object Get(string key)
        {
            uint hashValue = this.GetHashValue(key);
            LinkedList<object> valueList = _store[hashValue];
            object value = null;

            if (valueList != null)
            {
                value = valueList.First.Value;
            }

            return value;
        }
    }

    public class HashTable<TValue> : HashTableBase
    {
        protected LinkedList<TValue>[] _store;

        public HashTable()
        {
            _store = new LinkedList<TValue>[_startSize];
        }

        public void Put(string key, TValue value)
        {
            uint hashValue = this.GetHashValue(key);

            if (hashValue > _store.Length)
            {
                Array.Resize<LinkedList<TValue>>(ref _store, ((int)hashValue) * 2);
            }

            LinkedList<TValue> valueList = _store[hashValue];

            if (valueList == null)
            {
                valueList = new LinkedList<TValue>();
            }

            valueList.AddLast(new LinkedListNode<TValue>(value));
            _store[hashValue] = valueList;
        }

        public TValue Get(string key)
        {
            uint hashValue = this.GetHashValue(key);
            LinkedList<TValue> valueList = _store[hashValue];
            TValue value = default;

            if (valueList != null)
            {
                value = valueList.First.Value;
            }

            return value;
        }
    }
}