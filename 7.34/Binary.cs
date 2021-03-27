using System;

class Binary

{
    public static string DisplayBinary(int number)
    {
        string result = null;
        string temp = null;
        while (number > 0)
        {
            temp = Convert.ToString(number % 2);
            result = temp + result;
            number /= 2;
        }
        return result;
    }
}
