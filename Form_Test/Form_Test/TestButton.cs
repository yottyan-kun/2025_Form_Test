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
        private Color _onColor = Color.Orange;
        private Color _offColor = Color.White;

        private bool _enable;
        private Form1 _form1;

        private int _x;
        private int _y;

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

        public void Toggle()
        {
            SetEnable(!_enable);
        }

        public TestButton(Form1 form1,int x, int y, Size size, string text)
        {
            _form1 = form1;
            _x = x;
            _y = y;
            Location = new Point(x * size.Width, y * size.Height);
            Size = size;
            Text = text;

            Click += ClickEvent;
            SetEnable(false);
        }
        private void ClickEvent(object sender, EventArgs e)
        {
            _form1.GetTestButton(_x, _y).SetEnable(true);
          
        }
        private void ClickEvent(object sender, EventArgs e)
        {
            //楽な書き方
            _form1.GetTestButton(_x, _y)?.Toggle();
            _form1.GetTestButton(_x+1, _y)?.Toggle();
            _form1.GetTestButton(_x-1, _y)?.Toggle();
            _form1.GetTestButton(_x, _y)?.Toggle();
            _form1.GetTestButton(_x, _y)?.Toggle();

        }
        private int[][] _toggleDate =
        {
            new int[]{0,0},
            new int[]{1,0},
            new int[]{-1,0},
            new int[]{0,1},
            new int[]{0,-1},
           
        };
    }
}
