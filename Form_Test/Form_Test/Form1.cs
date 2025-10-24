using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int i, j;
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 6; j++)
                {
                    TestButton testButton = new TestButton();

                    testButton.Location = new Point(j * 45 + 10, i * 25 + 10);

                    testButton.Size = new Size(40, 20);

                    testButton.Text = ("Bton");

                    testButton.MouseDown += hogehogeClick;

                    Controls.Add(testButton);
                }
            }
        }
        private void hogehogeClick(object sender, EventArgs e)
        {
            MessageBox.Show("l");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("t");
        }
    }
}
