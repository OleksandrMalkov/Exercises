using System;

    class Hexademical
    {
    public static string DisplayHexademical(int number)
    {
        string result = null;
        int remainder;
        string temp = null;

        while (number > 0)
        {
            remainder = number % 16;
            switch (remainder)
            {
                case 15:
                    result = "F" + result;
                    break;
                case 14:
                    result = "E" + result;
                    break;
                case 13:
                    result = "D" + result;
                    break;
                case 12:
                    result = "C" + result;
                    break;
                case 11:
                    result = "B" + result;
                    break;
                case 10:
                    result = "A" + result;
                    break;
                default:
                    temp = Convert.ToString(remainder);
                    result = temp + result;
                    break;
            }
            number /= 16;
        }
        return result;
    }
}
