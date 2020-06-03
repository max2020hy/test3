using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Watcher;
namespace test_FileSystemWatcher
{
    class Program
    {
        static void Main (string[] args)
        {

            Watcher.Watcher Watcher = new Watcher.Watcher(@"e:\\watcher", "*.txt");
            Watcher.Watching();
            //if (!Directory.Exists("e:\\watcher"))
            //{
            //    Console.WriteLine("没有发现目标文件夹");
            //    return;
            //} 
            
            //using (System.IO.FileSystemWatcher wactcher = new FileSystemWatcher())
            //{
            //    wactcher.Path = "e:\\watcher";
               
            //    wactcher.NotifyFilter = NotifyFilters.CreationTime | NotifyFilters.FileName;
            //    wactcher.Filter = "*.txt";
            //    wactcher.Created += Wactcher_Created;
            //    wactcher.EnableRaisingEvents = true;
            //    Console.WriteLine("Press 'q' to quit the sample.");
            //    while (1==1) ;
            //}
          

        }

       

        
    }
}
