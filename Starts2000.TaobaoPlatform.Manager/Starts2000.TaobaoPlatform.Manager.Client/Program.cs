﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Starts2000.TaobaoPlatform.Manager.Client
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
