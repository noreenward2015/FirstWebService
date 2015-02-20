using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using consumeWS.NoreenWS;

namespace consumeWS
{
    public partial class Form1 : Form
    {
        private WebService1SoapClient ws = new WebService1SoapClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = ws.add((int)numericUpDown1.Value, (int)numericUpDown2.Value).ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Text = ws.add((int)numericUpDown1.Value, (int)numericUpDown2.Value).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = ws.mul((int)numericUpDown1.Value, (int)numericUpDown2.Value).ToString();
        }

 

    }

}
