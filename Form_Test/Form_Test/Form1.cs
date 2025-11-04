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

        private TestButton[,] _buttonArray;
        public Form1()
        {
            InitializeComponent();
            _buttonArray = new TestButton[BOARD_SIZE_X, BOARD_SIZE_Y];

            int i, j;
            for (i = 0; i < BOARD_SIZE_X; i++)
            {
                for (j = 0; j < BOARD_SIZE_Y; j++)
                {
                    // インスタンスの生成
                    TestButton testButton = new TestButton(
                        this,
                        new Point(j * BUTTON_SIZE_X + 10, i * BUTTON_SIZE_X + 10),
                        new Size(BUTTON_SIZE_X, BUTTON_SIZE_Y), Text = ("Bton"));

                    // 配列にボタンの参照を追加
                    _buttonArray[i, j] = testButton;

                    Controls.Add(testButton);
                }
            }
        }
        
        public TestButton GetTestButton(int x, int y)
        {
            return _buttonArray[x, y];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("t");
        }
    }
}
