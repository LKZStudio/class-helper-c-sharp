﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Class_Helper
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool createNew;
            using (System.Threading.Mutex m = new System.Threading.Mutex(true, Application.ProductName, out createNew))
            {
                if (createNew)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Settings());
                }
                else
                {
                    MessageBox.Show("程序已启动！", "信息");
                }
            }
        }
    }
}
