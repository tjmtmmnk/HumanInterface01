using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace helloworld
{
    // このフォームはサンプルです。これを参考にして作成してください
    // 特に変更・削除などする必要はありません

    public partial class Form3 : helloworld.Form_orig
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ボタンを押したときのログを取る
            this.log(this, sender, e);

            // 終了するときは、次のコマンド1行でよい
            this.Close();
        }
    }
}

