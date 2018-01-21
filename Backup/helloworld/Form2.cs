using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace helloworld
{
    public partial class Form2 : helloworld.Form_orig
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ボタンを押したときのログを取る
            this.log(this, sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ボタンを押したときのログを取る
            this.log(this, sender, e);

            // 次の画面に移動する
            Form3 newform = new Form3();    // ここで次に表示するフォームを生成している
            newform.Show();
            this.Dispose();
        }
    }
}

