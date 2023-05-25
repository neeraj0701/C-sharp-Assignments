using System;
using Program2;

/// <summary>
/// contains methods which implememts solution
/// </summary>
public class GreatestProduct
{
    public int GreatestAdjacentDigitsProduct(string large)
    {
        UtilityFunctions utilityFunctions = new UtilityFunctions();
        int maximumProduct = 0, product = 0;

        if (utilityFunctions.LengthOfString(large) == 4)
        {
            maximumProduct = (large[0] - '0') * (large[1] - '0') * (large[2] - '0') * (large[3] - '0');
        }

        else
        {
            for (int iterator = 0; iterator < large.Length - 3; iterator++)
            {
                product = (large[iterator] - '0') * (large[iterator + 1] - '0') * (large[iterator + 2] - '0') * (large[iterator + 3] - '0');

                if (maximumProduct < product)
                {
                    maximumProduct = product;
                }
            }
        }

        return maximumProduct;
    }
}
