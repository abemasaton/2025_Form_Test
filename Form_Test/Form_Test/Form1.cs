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
        // constをつけると初期化時のみ値を変更可能
        const int BUTTON_SIZE_X = 60;
        const int BUTTON_SIZE_Y = 60;

        const int BOARD_SIZE_X = 3;
        const int BOARD_SIZE_Y = 3;
        public Form1()
        {
            InitializeComponent();
            int i, j;
            for (i = 0; i < BOARD_SIZE_X; i++)
            {
                for (j = 0; j < BOARD_SIZE_Y; j++)
                {
                    // インスタンスの生成
                    TestButton testButton = new TestButton(new Point(j * BUTTON_SIZE_X + 10, i * BUTTON_SIZE_X + 10), new Size(BUTTON_SIZE_X, BUTTON_SIZE_Y), Text = ("Bton"));

                    Controls.Add(testButton);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("t");
        }
    }
}
