using System;
using System.Collections.Generic;
using System.Text;

namespace Day4_Homework5
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;
        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            TKey[] tempKey = keys;
            TValue[] tempVal = values;
            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
            }
            for (int i = 0; i < tempVal.Length; i++)
            {
                values[i] = tempVal[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }
        public void ToList()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i] + " , " + values[i]);
            }
        }
    }
}
