﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyDictionary<TK, TV>
    {
        TK[] keys;
        TV[] values;
        public MyDictionary()
        {
            keys = new TK[0];
            values = new TV[0];
        }

        public void Add(TK key, TV value)
        {
            TK[] tempKeys = keys;
            TV[] tempValues = values;
            keys = new TK[keys.Length + 1];
            values = new TV[values.Length + 1];
            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }
            for (int i = 0; i < tempValues.Length; i++)
            {
                values[i] = tempValues[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
            //Console.WriteLine("{0} {1} eklendi!", key, value); // test amacli
        }
    }
}
