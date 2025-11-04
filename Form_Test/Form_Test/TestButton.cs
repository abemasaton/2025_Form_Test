using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Test
{
    // Buttonクラスを継承した
    // TestButtonを生成
    public class TestButton : Button
    {
        private Color _onColor = Color.Cyan;

        private Color _offColor = Color.White;

        private bool _enable;

        private Form1 _form1;

        // 縦位置
        private int _x;
        // 横位置
        private int _y;

        public TestButton(Form1 form1, int x, int y, Size size, string text)
        {
            // Form1の参照
            _form1 = form1;
            // 縦位置を保管
            _x = x;
            // 横位置を保管
            _y = y;
            // ボタンの位置を指定
            Location = new Point(x * size.Width + 10,y * size.Height + 10);
            // ボタンの大きさを指定　
            Size = size;
            // テキストを設定
            Text = text;

            SetEnable(false);

            Click += ClickEvent;
            
        }
        public void SetEnable(bool on)
        {
            _enable = on;
            if (on) BackColor = _onColor;
            else BackColor = _offColor;
        }

        

        private void ClickEvent(object sender, EventArgs e)
        {
            _form1.GetTestButton(_x, _y).SetEnable(true);
        }
    }
}
