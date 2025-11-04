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

        public TestButton(Form1 form1,Point position, Size size, string text)
        {
            _form1 = form1;
            Location = position;
            Size = size;
            Text = text;

            Click += hogehogeClick;
            SetEnable(false);
        }
        private void hogehogeClick(object sender, EventArgs e)
        {
            _form1.GetTextButton(1, 1).SetEnable(true);
          
        }

    }
}
