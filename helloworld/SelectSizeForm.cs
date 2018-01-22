using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace helloworld
{
    public partial class SelectSizeForm : helloworld.Form_orig
    {
        public SelectSizeForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e) //確定ボタン
        {
            is_selected_item_num = true;
            this.Dispose();

        }
    }
}
