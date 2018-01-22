using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace helloworld
{
    public partial class formEnd : helloworld.Form_orig
    {
        public formEnd()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ボタンを押したときのログを取る
            this.log(this, sender, e);
            insertMoney newform = new insertMoney();
            newform.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ボタンを押したときのログを取る
            this.log(this, sender, e);
            this.Close();
        }

        private void formEnd_Load(object sender, EventArgs e)
        {
            textBox1.Text = item_name;
            textBox2.Text = user_money.ToString();
        }
    }
}
