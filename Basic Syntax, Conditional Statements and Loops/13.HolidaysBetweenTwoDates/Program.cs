﻿using System;

using System.Globalization;

class HolidaysBetweenTwoDates

{

    static void Main()

    {/*
    1.05.2016
    15.05.2016
    */

        var startDate = DateTime.ParseExact(Console.ReadLine(),

            "d.M.yyyy", CultureInfo.InvariantCulture);

        var endDate = DateTime.ParseExact(Console.ReadLine(),

            "d.M.yyyy", CultureInfo.InvariantCulture);

        var holidaysCount = 0;

        for (var date = startDate; date <= endDate;date = date.AddDays(1))

            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                holidaysCount++;
            }

        Console.WriteLine(holidaysCount);

    }

}
