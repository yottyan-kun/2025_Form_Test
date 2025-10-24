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


            for (int j = 0; j < 4; j++)
            {


                for (int i = 0; i < 6; i++)
                {
                    //インスタンスの生成
                    TestButton testButton = new TestButton();

                    //ボタンの位置を設定
                    testButton.Location = new Point(50 * i, 50 * j);

                    //ボタンの大きさを設定
                    testButton.Size = new Size(50, 50);

                    //ボタン内のテキストを設定
                    testButton.Text = "あいうえお";

                    //コントロールにボタンを追加
                    Controls.Add(testButton);

                }
            }
        }

     

        private void テストボタン_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("おはようございます");
        }
    }
}
