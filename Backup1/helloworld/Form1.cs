using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace helloworld
{
    // このフォームは実験のためのデータを取得するために必要です．
    // デザインは変更してもかまいません（実験に影響はない）が，削除したり
    // （よくわからないまま）イベントハンドラを変更しないこと．
    //                                      by kuramoto (20080414)

    public partial class Form1 : helloworld.Form_orig
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form1 が作られたときに初めてログファイルを作成する。
            // このコード（とイベントハンドラ）は変更してはならない。
            this.start_log();
			this.create_menulist();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ボタンを押したときのログを取る
            this.log(this, sender, e);

            // 次の画面に移動する
            insertMoney newform = new insertMoney();
            newform.Show();
            this.Hide();    // このコードはForm1と他のフォームで違うので注意
        }


    }
}

