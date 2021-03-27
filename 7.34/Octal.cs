using System;

    class Octal
{
    public static string DisplayOctal(int number)
    {
        string result = null;
        string temp = null;
        while (number > 0)
        {
            temp = Convert.ToString(number % 8);
            result = temp + result;
            number /= 8;
        }
        return result;
    }
}
