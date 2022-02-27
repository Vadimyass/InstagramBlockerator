using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace InstBlocker
{
    public partial class Form1 : Form
    {
        bool Start = false;

        public Form1()
        {
            InitializeComponent();
        }

        void Send(string Text)
        {
            richTextBox1.AppendText($"{Text}");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Check();
            if(Start==true)
            {
                //string[] Data = OpenFile();
                Send(inst.Auth(textBox1.Text, textBox2.Text));
            }
        }
        void Check()
        {
            if (textBox1.Text.Length == 0)
                Send("Логин пуст");
            else if (textBox2.Text.Length == 0)
                Send("Пароль пуст");
            else
                Start = true;
        }

        static string[] OpenFile()
        {
            string[] Data = File.ReadAllLines("Acc.txt");
            return Data;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
