using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watcher
{
    public class Watcher
    {
        public string FileFullName { get; set; }
        public string Filter { get; set; }
        public string Msg { get; set; }
        public Watcher (string fileFullName,string filter)
        {
            FileFullName = fileFullName;
            Filter = filter;
        }
        /// <summary>
        /// 开启文件监控
        /// </summary>
        public void Watching ()
        {
            if (!Directory.Exists(FileFullName))
            {
                Console.WriteLine("没有发现目标文件夹");
                return;
            }

            using (System.IO.FileSystemWatcher wactcher = new FileSystemWatcher())
            {
                wactcher.Path = FileFullName;

                wactcher.NotifyFilter = NotifyFilters.CreationTime | NotifyFilters.FileName;
                wactcher.Filter = Filter;
                wactcher.Created += Wactcher_Created;
                wactcher.EnableRaisingEvents = true;
              //  Console.WriteLine("Press 'q' to quit the sample.");
                while (1 == 1) ;
            }



        }

        private void Wactcher_Created (object sender, FileSystemEventArgs e)
        {
             Msg=$"创建的文件名称为{e.Name}，change的类型{e.ChangeType}";
            if (File.Exists(e.FullPath))
            {
                string fileName = e.FullPath;
                File.AppendAllLines(fileName, new string[] { "this is test" });
            }

        }
    }
}
