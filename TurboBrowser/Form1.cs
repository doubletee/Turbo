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

namespace TurboBrowser
{
    public partial class BrowserContainer : Form
    {

        System.IO.StreamWriter filew = new System.IO.StreamWriter("vor.txt");

        string vor;
        string urlvor;
        string urlvor2;
        string nach;
        int count = 0;

        public BrowserContainer()
        {
            InitializeComponent();
        }

        private void BrowserContainer_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                webBrowser1.Navigate(textBox1.Text);
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                count = 1;
                webBrowser1.Navigate(textBox1.Text);
                vor = textBox1.Text + "<" + vor;
                nach = "";
                Console.WriteLine(count);


            }
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {


            if (count == 1)
            {
                Console.WriteLine(count);
                while (vor.First() != '<')
                {

                    urlvor = urlvor + vor.ElementAt(0).ToString();
                    vor = vor.Remove(0, 1);
                }
                urlvor = urlvor + vor.ElementAt(0).ToString();
                vor = vor.Remove(0, 1);
                nach = nach + urlvor;
                urlvor = "";
                while (vor.First() != '<')
                {

                    urlvor = urlvor + vor.ElementAt(0).ToString();
                    vor = vor.Remove(0, 1);
                }
                webBrowser1.Navigate(urlvor);
                urlvor = urlvor + vor.ElementAt(0).ToString();
                vor = vor.Remove(0, 1);
                nach = nach + urlvor;
                urlvor = "";
                count = 0;
            }
            else
            {
                Console.WriteLine(count+"fe");
                while (vor.First() != '<')
                {

                    urlvor = urlvor + vor.ElementAt(0).ToString();
                    vor = vor.Remove(0, 1);
                }
                webBrowser1.Navigate(urlvor);
                urlvor = urlvor + vor.ElementAt(0).ToString();
                vor = vor.Remove(0, 1);
                nach = nach + urlvor;
                urlvor = "";
                count = 0;
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
