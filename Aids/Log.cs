﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AgileWorks.Aids
{
    public static class Log
    {
        internal static ILogBook logBook;

        public static void Message(string message)
        {
            logBook?.WriteEntry(message);
        }

        public static void Exception(Exception e)
        {
            logBook?.WriteEntry(e);
        }
    }
}
