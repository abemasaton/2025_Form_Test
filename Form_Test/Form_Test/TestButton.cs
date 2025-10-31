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
    internal class TestButton : Button
    {
        private Color _onColor = Color.Cyan;

        private Color _offColor = Color.White;

        private bool _enable;
        public void SetEnable(bool on)
        {
            _enable = on;
            if (on) BackColor = _onColor;
            else BackColor = _offColor;
        }

        public TestButton(Point position, Size size, string text)
        {
            Location = position;
            Size = size;
            Text = text;

            SetEnable(false);

            Click += ClickEvent;
            
        }

        private void ClickEvent(object sender, EventArgs e)
        {
            SetEnable(!_enable);
        }
    }
}
