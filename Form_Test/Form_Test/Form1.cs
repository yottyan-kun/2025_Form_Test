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
        public Form1()
        {
            InitializeComponent();


            for (int j = 0; j < 3; j++)
            {


                for (int i = 0; i < 3; i++)
                {
                    //インスタンスの生成
                    TestButton testButton = new TestButton(new Point(50 * i, 50 * j), new Size(50, 50 )," ");


                    testButton.Click += テストボタン_Click_1;

                    //コントロールにボタンを追加
                    Controls.Add(testButton);

                }
            }
        }

        private void hogehogeClick(object sender , EventArgs e)
        {
            MessageBox.Show("ゆっくりしていってね");
        }

     

        private void テストボタン_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("おはようございます");
        }
    }
}
