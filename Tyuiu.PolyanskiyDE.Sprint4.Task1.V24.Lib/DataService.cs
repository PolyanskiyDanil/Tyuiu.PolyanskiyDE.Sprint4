﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.PolyanskiyDE.Sprint4.Task1.V24.Lib
{
    public class DataService : ISprint4Task1V24
    {
        public int Calculate(int[] array)
        {
            int multArray = 1;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 != 0)
                {
                    multArray *= array[i];
                }
            }
            return multArray; 
        }
    }
}
