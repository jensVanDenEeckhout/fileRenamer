using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace songRenamer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.DirectoryInfo d = new System.IO.DirectoryInfo(@"C:\Users\Jens\Downloads\deZwaarsteLijst");//Assuming Test is your Folder
            System.IO.FileInfo[] Files = d.GetFiles("*.mp3").OrderBy( p => p.LastWriteTime).ToArray(); //Getting Text files

            string number;
            for (int i = 0; i < Files.Length; i++)
            {

                if(i < 10)
                {
                    number = "0" + i;
                }
                else
                {
                    number = i.ToString();
                }
                System.IO.File.Move(Files[i].DirectoryName + "\\" + Files[i].Name, Files[i].DirectoryName + "\\" + number + "." +Files[i].Name);
            }

        }
    }
}
