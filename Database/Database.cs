using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Web.Script.Serialization;

namespace Class_Helper.Database
{
    class Saver
    {
        private string path;
        private string configFilePath;
        public ConfigJson data;
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="defaultData">默认数据</param>
        public Saver(ConfigJson defaultData)
        {
            // 运行程序所在的目录
            // path = Environment.CurrentDirectory;
            path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "LKZStudio", "Class Helper");
            configFilePath = Path.Combine(path, "config.json");
            DirectoryInfo directory = new DirectoryInfo(path);
            if (!directory.Exists)
            {
                directory.Create();
            }
            if (File.Exists(configFilePath))
            {
                string json = ReadFile();
                JavaScriptSerializer js = new JavaScriptSerializer();
                this.data = js.Deserialize<ConfigJson>(json);
            }
            else
            {
                data = defaultData;
                WriteFile();
            }
        }
        
        #region 对外具体功能

        /// <summary>
        /// 更改倒计时时间
        /// </summary>
        /// <param name="timeStamp">时间戳</param>
        public void ChangeDate(long timeStamp)
        {
            data.Date = timeStamp;
            WriteFile();
        }

        /// <summary>
        /// 更改倒计时名字
        /// </summary>
        /// <param name="timerName">倒计时名字</param>
        public void ChangeTimerName(string timerName)
        {
            data.TimerName = timerName;
            WriteFile();
        }

        /// <summary>
        /// 增加名字
        /// </summary>
        /// <param name="name">名字</param>
        public void AddName(string name)
        {
            data.NameList.Add(name);
            WriteFile();
        }

        /// <summary>
        /// 通过选择文件导入名字
        /// </summary>
        /// <param name="filePath">文件目录</param>
        public void AddNamesByFile(string filePath)
        {
            try
            {
                StreamReader sr = new StreamReader(new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read));
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    data.NameList.Add(line);
                }
                sr.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                WriteFile();
            }
        }

        /// <summary>
        /// 清除名单
        /// </summary>
        public void CleanNameList()
        {
            data.NameList = new List<string>();
            WriteFile();
        }

        /// <summary>
        /// 更改点名器模式
        /// </summary>
        /// <param name="mode">模式</param>
        public void ChangeRollCallMode(int mode)
        {
            data.RollCallMode = mode;
            WriteFile();
        }

        #endregion
        
        /// <summary>
        /// 获取文件内容
        /// </summary>
        private string ReadFile()
        {
            string content = "";
            try
            {
                StreamReader sr = new StreamReader(new FileStream(this.configFilePath, FileMode.OpenOrCreate, FileAccess.Read));
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    content = content + line + "\n";
                }
                sr.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            return content;
        }

        /// <summary>
        /// 文件写入
        /// </summary>
        /// <param name="content">内容</param>
        private void WriteFile()
        {
            try
            {
                File.Delete(this.configFilePath);
                StreamWriter sw = new StreamWriter(new FileStream(this.configFilePath, FileMode.OpenOrCreate, FileAccess.Write));
                StringBuilder sb = new StringBuilder();
                JavaScriptSerializer js = new JavaScriptSerializer();
                js.Serialize(data, sb);
                sw.WriteLine(sb.ToString());
                sw.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
