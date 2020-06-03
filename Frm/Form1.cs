using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Frm
{
    public partial class Form1 : Form
    {Watcher.Watcher Watcher = new Watcher.Watcher(@"e:\\watcher", "*.txt");
        public Form1 ()
        {
            InitializeComponent();
        }

        private void Form1_Load (object sender, EventArgs e)
        {
        //    Thread t1 = new Thread(new ThreadStart(Watcher.Watching));
        //    t1.Start();
            //this.ricTextBox.Text = Watcher.Msg;
           this.backgroundWorker1.RunWorkerAsync();
            
        }

        private void backgroundWorker1_DoWork (object sender, DoWorkEventArgs e)
        {
            Watcher.Watching();
            this.ricTextBox.Text = Watcher.Msg;
        }
    }
}
