﻿using System;
using Program2;

public class GreatestProduct
{
    public int greatestAdjacentDigitsProduct(string large)
    {
        int maximum = 0, product = 0;

        if (large.Length == 4)
        {
            maximum = (large[0] - '0') * (large[1] - '0') * (large[2] - '0') * (large[3] - '0');
        }

        else
        {
            for (int i = 0; i < large.Length-3; i++)
            {
                product = (large[i] - '0') * (large[i + 1] - '0') * (large[i + 2] - '0') * (large[i + 3] - '0');
                
                if (maximum < product)
                {
                    maximum = product;
                }
            }
        }

        return maximum;
    }
}
