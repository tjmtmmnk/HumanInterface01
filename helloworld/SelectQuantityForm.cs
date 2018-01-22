using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace helloworld
{
    public partial class SelectQuantityForm : helloworld.Form_orig
    {
        private Button[] quantity_button;
        private MainForm main;

        public SelectQuantityForm(String item_name, MainForm main)
        {
            InitializeComponent();
            this.main = main;
            quantity_button = new Button[8];
            quantity_button[0] = button1; quantity_button[1] = button2; quantity_button[2] = button4; quantity_button[3] = button3;
            quantity_button[4] = button6; quantity_button[5] = button5; quantity_button[6] = button8; quantity_button[7] = button7;
            label1.Text = item_name + "の数量を選択してください";
        }

        private void setQuantity(object sender, EventArgs e) {
            int tag = int.Parse(((Button)sender).Tag.ToString());
            purchase_item_num = int.Parse(quantity_button[tag].Text);
            Console.WriteLine("num " + purchase_item_num);
        }

        private void button10_Click(object sender, EventArgs e) //確定ボタン
        {
            is_selected_item_num = true;
            this.main.Show();
            this.Dispose();
        }

        private void button9_Click(object sender, EventArgs e) //戻るボタン
        {
            is_selected_item_num = false;
            this.main.Show();
            this.Dispose();
        }
    }
}
