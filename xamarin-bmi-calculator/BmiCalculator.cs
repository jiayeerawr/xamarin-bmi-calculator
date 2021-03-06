﻿using System.Text;
using System;

namespace Core
{
    public static class BmiCalculator
    {
        public static string Calculate(string h, string w)
        {
            double height, weight, bmi;
            if (string.IsNullOrWhiteSpace(h) || string.IsNullOrWhiteSpace(w))
            {
                return "unavailable because you are naughty!";
            }
            else
            {
                if (double.TryParse(h, out height) && double.TryParse(w, out weight))
                {
                    bmi = weight / Math.Pow(height, 2);
                    return bmi.ToString();
                }
                else
                {
                    return "unavailable because you are naughty!";
                }
            }
        }
    }
}