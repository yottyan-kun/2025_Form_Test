using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Test
{
    internal class TestButton : Button
    {
        private Color _onColor = Color.LightBlue;
        private Color _offColor = Color.White;

        private bool _enable;

        public void SetEnable(bool on)
        {
            _enable = on;
            if(on)
            {
                BackColor = _onColor;
            }
            else
            {
                BackColor = _offColor;
            }
           
        }

        public TestButton(Point position, Size size, string text)
        {
            Location = position;
            Size = size;
            Text = text;

            Click += hogehogeClick;
            SetEnable(false);
        }
        private void hogehogeClick(object sender, EventArgs e)
        {
            SetEnable(!_enable);
        }

    }
}
