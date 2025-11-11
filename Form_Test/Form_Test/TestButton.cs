using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Form_Test
{
    public class TestButton : Button
    {
        private Color _onColor = Color.Orange;
        private Color _offColor = Color.White;

        private bool _enable;
        private Form1 _form1;

        private int _x;
        private int _y;
        private int tate;
        private int yoko;

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

        public TestButton(Form1 form1,int x, int y,int BOARD_X,int BOARD_Y, Size size, string text)
        {
            _form1 = form1;
            _x = x;
            _y = y;
            tate = BOARD_X;
            yoko = BOARD_Y;
            Location = new Point(x * size.Width, y * size.Height);
            Size = size;
            Text = text;

            Click += ClickEvent;
            SetEnable(false);
        }
       

        private void ClickEvent(object sender, EventHandler e)
        {
            _form1.GetTestButton(_x, _y).SetEnable(true);
          
        }


        /// <summary>
        /// 各ボタンがクリックされた時に呼び出される関数
        /// クリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void ClickEvent(object sender, EventArgs e)
        {
            //楽な書き方
            _form1.GetTestButton(_x, _y)?.Toggle();
            _form1.GetTestButton(_x+1, _y)?.Toggle();
            _form1.GetTestButton(_x-1, _y)?.Toggle();
            _form1.GetTestButton(_x, _y+1)?.Toggle();
            _form1.GetTestButton(_x, _y-1)?.Toggle();
            //クリアと伝えるメッセージ
            int i=0, j;

            Color same = _form1.GetTestButton(0, 0).BackColor;

            bool s = true;
            while(i < tate && s)
            {
                for(j = 0; j < yoko; j++)
                {
                    if(same != _form1.GetTestButton(i,j).BackColor)
                    {
                        s = false;
                        break;
                    }
                }
                i++;
            }

            if (s == true)
            {
                MessageBox.Show("クリア");
            }

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
