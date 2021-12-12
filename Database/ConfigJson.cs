using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_Helper.Database
{
    public class ConfigJson
    {
        /// <summary>
        /// 一模
        /// </summary>
        public string TimerName { get; set; }

        /// <summary>
        /// 点名器模式 0直接 1滚动
        /// </summary>
        public int RollCallMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long Date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<String> NameList { get; set; }
    }
}
