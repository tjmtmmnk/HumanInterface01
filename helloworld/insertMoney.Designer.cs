namespace helloworld
{
    partial class insertMoney
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 40F);
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "金額を入力してください";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 40F);
            this.button1.Location = new System.Drawing.Point(383, 511);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(613, 200);
            this.button1.TabIndex = 1;
            this.button1.Text = "食券を選ぶ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 40F);
            this.button2.Location = new System.Drawing.Point(45, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 100);
            this.button2.TabIndex = 2;
            this.button2.Text = "10";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.inputMoney);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("MS UI Gothic", 40F);
            this.button3.Location = new System.Drawing.Point(231, 319);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 100);
            this.button3.TabIndex = 3;
            this.button3.Text = "50";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.inputMoney);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("MS UI Gothic", 40F);
            this.button4.Location = new System.Drawing.Point(417, 319);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 100);
            this.button4.TabIndex = 4;
            this.button4.Text = "100";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.inputMoney);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("MS UI Gothic", 40F);
            this.button5.Location = new System.Drawing.Point(603, 319);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(180, 100);
            this.button5.TabIndex = 5;
            this.button5.Text = "500";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.inputMoney);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("MS UI Gothic", 40F);
            this.button6.Location = new System.Drawing.Point(789, 319);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(180, 100);
            this.button6.TabIndex = 6;
            this.button6.Text = "1000";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.inputMoney);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 80F);
            this.textBox1.Location = new System.Drawing.Point(326, 176);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(406, 100);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "1000";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 40F);
            this.label2.Location = new System.Drawing.Point(738, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 54);
            this.label2.TabIndex = 8;
            this.label2.Text = "円";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 40F);
            this.label3.Location = new System.Drawing.Point(54, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 54);
            this.label3.TabIndex = 9;
            this.label3.Text = "投入金額：";
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.button7.Location = new System.Drawing.Point(836, 176);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(150, 100);
            this.button7.TabIndex = 10;
            this.button7.Text = "取り消し";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.button8.Location = new System.Drawing.Point(12, 611);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(250, 100);
            this.button8.TabIndex = 11;
            this.button8.Text = "購入をやめる";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // insertMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "insertMoney";
            this.Text = "お金を入れる";
            this.Load += new System.EventHandler(this.insertMoney_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}
