﻿using System;

namespace conplement.snippets.Date
{
    /// <summary>
    /// Partial class for date snippets
    /// </summary>
    public static partial class Date
    {
        /// <summary>
        /// Check if a date is before another date.
        /// </summary>
        /// Documentation for DateTime: https://docs.microsoft.com/de-de/dotnet/api/system.datetime
        public static bool IsBeforeDate(this DateTime dateTime1, DateTime dateTime2)
        {
            return dateTime1 < dateTime2;
        }
    }
}
