using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Form_Test
{
    // Buttonクラスを継承した
    // TestButtonを生成
    public class TestButton : Button
    {
        // ランダムのインスタンス?
        Random random = new Random();

        private Color _onColor = Color.Cyan;

        private Color _offColor = Color.White;

        private bool _enable;  // 背景色設定用

        private bool samecolor;  // 全色一致判定用

        private Color iro;

        private Form1 _form1;

        // 縦位置
        private int _x;
        // 横位置
        private int _y;
        // 行数
        private int tate;
        // 列数
        private int yoko;

        public TestButton(Form1 form1, int x, int y,int BOARD_X,int BOARD_Y, Size size, string text)
        {
            // Form1の参照
            _form1 = form1;
            // 縦位置を保管
            _x = x;
            // 横位置を保管
            _y = y;
            // 行数を保存
            tate = BOARD_X;
            // 列数を保存
            yoko = BOARD_Y;
            // ボタンの位置を指定
            Location = new Point(y * size.Width + 10,x * size.Height + 10); // 横, 縦
            // ボタンの大きさを指定　
            Size = size;
            // テキストを設定
            Text = text;

            //if (x == 2 && y == 1 || x == 1 && y == 2 || x == 2 && y == 2) SetEnable(true);　
            //else SetEnable(false);  // 検証用の2行
            Thread.Sleep(10);  // 10ミリ秒待機
            if (random.Next(2) == 0)  // ランダムに0か1 
            {
                SetEnable(false);  // 0ならオフ
            }
            else
            {
                SetEnable(true);  // 1ならオン
            }

                Click += ClickEvent;
            
        }
        public void SetEnable(bool on)
        {
            _enable = on;
            if (on) BackColor = _onColor;
            else BackColor = _offColor;
        }
        
        public void Toggle()
        {
            SetEnable(!_enable);
        }

        private void ClickEvent(object sender, EventArgs e)
        {
            // 十字色変換の楽な書き方
            _form1.GetTestButton(_x - 1, _y)?.Toggle();
            _form1.GetTestButton(_x, _y - 1)?.Toggle();
            _form1.GetTestButton(_x, _y)?.Toggle();
            _form1.GetTestButton(_x + 1, _y)?.Toggle();
            _form1.GetTestButton(_x, _y + 1)?.Toggle();

            // ここから色がそろってるか判定
            int i = 0, j;
            Color ptr = _form1.GetTestButton(0, 0).BackColor; ;
            bool same = true;
            while (i < tate && same)
            {
                for(j = 0; j < yoko; j++)
                {
                    // MessageBox.Show("i"); // 検証用noメッセージ
                    if (ptr != _form1.GetTestButton(i, j).BackColor)
                    {
                        same = false;
                        break;
                    }
                }
                i++;
            }
            Thread.Sleep(1);  // これがないと検証で変になる
            if (same == true)
            {
                MessageBox.Show("君の勝ちだ");
            }





            // 十字色変換の別の書き方part1
            //for (int i = 0; i < _toggleData.Length; i++)
            //{
            //    var data = _toggleData[i];
            //    var button = _form1.GetTestButton(_x + data[0], _y + data[1]);

            //    if (button != null)
            //    {
            //        button.Toggle();
            //    }
            //}
        }


        // 十字色変換の別の書き方part2
        //private int[][] _toggleData=
        //{
        //    new int[]{ 0, 0},
        //    new int[]{ 1, 0},
        //    new int[]{-1, 0},
        //    new int[]{ 0, 1},    
        //    new int[]{ 0,-1}
        //};
    }
}
