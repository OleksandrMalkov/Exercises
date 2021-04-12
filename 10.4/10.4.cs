/*10.4 (Modifying the Internal Data Representation of a Class) It would be perfectly reasonable for the Time2 class of Fig. 10.5 to represent
       the time internally as the number of seconds since midnight rather than the three integer values hour, minute and second.
       Clients could use the same public methods and properties to get the same results. 
       Modify the Time2 class of Fig. 10.5 to implement the Time2 as the number of seconds since midnight and show that no change is visible
       to the clients of the class by using the same test app from Fig. 10.6.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Time2
{
    public int SecondAfMid { get; set; }  

    public Time2(int h = 0, int m = 0, int s = 0)
    {
        if (h < 0 | h > 24)
            throw new ArgumentOutOfRangeException("Hour", h, "Hour must Ье 0-23");
        else if (m < 0 | m > 60)
            throw new ArgumentOutOfRangeException("Minute", m, "Minute must Ье 0-59");
        else if (s < 0 | s > 60)
            throw new ArgumentOutOfRangeException("5econd", s, "Second must Ье 0-59");
        else
            SetTime(h, m, s);
    }

    public Time2(Time2 time) : this(time.SecondAfMid / 3600, (time.SecondAfMid % 3600) / 60, (time.SecondAfMid % 3600) % 60) { }

    public void SetTime(int h, int m, int s)
    {

        for (int i = 0; i < h; i++)
        {
            SecondAfMid += 3600;
        }
        for (int i = 0; i < m; i++)
        {
            SecondAfMid += 60;
        }
        SecondAfMid += s;
    }

    public string ToUniversalString()
    {
        return string.Format("{0:D2}:{1:D2}:{2:D2}", SecondAfMid / 3600, (SecondAfMid % 3600) / 60, (SecondAfMid % 3600) % 60);
    }

    public override string ToString()
    {
        return string.Format("{0}:{1:D2}:{2:D2} {3}",
            (((SecondAfMid / 3600) == 0 || (SecondAfMid / 3600) == 12) ? 12 : (SecondAfMid / 3600) % 12),
           (SecondAfMid % 3600) / 60, (SecondAfMid % 3600) % 60, (SecondAfMid / 3600 < 12 ? "АМ" : "РМ"));
    }
}
