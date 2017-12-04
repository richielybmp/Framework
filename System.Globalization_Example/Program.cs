﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace System.Globalization_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Calendar

            DateTime dt1 = DateTime.Now;
            
            System.Globalization.Calendar cal;

            DateTime dt = new DateTime(2012, 1, 1, new JapaneseCalendar());
            dt.AddHours(3);

            DateTime dt2 = DateTime.Now;

            TimeSpan t = dt2.Subtract(dt1);

            #endregion

            #region CultureInfo
            CultureInfo ci = new CultureInfo("pt-BR");

            #endregion

            #region CultureInfo - Threading
            CultureInfo cit = System.Threading.Thread.CurrentThread.CurrentCulture;

            CultureInfo ciUI = Thread.CurrentThread.CurrentUICulture;

            System.Threading.Thread.CurrentThread.CurrentCulture = ci;
            System.Threading.Thread.CurrentThread.CurrentUICulture = ci;

            CultureInfo cinv = CultureInfo.InvariantCulture;

            Console.Write(System.Globalization_Example.Main.DESCRICAO);
            Console.ReadKey();

            #endregion

        }
    }
}
