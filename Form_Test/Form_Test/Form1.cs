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
        const int BUTTON_SIZE_X = 100;
        const int BUTTON_SIZE_Y = 100;

        const int BOARD_SIZE_X = 3;
        const int BOARD_SIZE_Y = 3;


        private TestButton[,] _buttonArray;


        public Form1()
        {
            InitializeComponent();

            _buttonArray = new TestButton[BOARD_SIZE_Y, BOARD_SIZE_X];


            for (int j = 0; j < BOARD_SIZE_Y; j++)
            {


                for (int i = 0; i < BOARD_SIZE_X; i++)
                {
                    //インスタンスの生成
                    TestButton testButton = new TestButton(this,i,j,new Point(BUTTON_SIZE_X * i, BUTTON_SIZE_Y * j), new Size(100, 100 )," ");


                    //配列にボタンの参照を追加
                    _buttonArray[j, i] = testButton;

                    //コントロールにボタンを追加
                    Controls.Add(testButton);
                    
                }
            }
           
        }
        public TestButton GetTestButton(int x, int y)
        {
            if (x < 0 || x >= BOARD_SIZE_X) return null;
            if (y < 0 || y >= BOARD_SIZE_Y) return null;
            return _buttonArray[y, x];
        }

        private void hogehogeClick(object sender , EventArgs e)
        {
            MessageBox.Show("ゆっくりしていってね");
        }

     

        private void テストボタン_Click_1(object sender, EventArgs e)
        {
           
        }
    }
}
