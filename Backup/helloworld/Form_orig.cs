using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace helloworld
{
    public partial class Form_orig : Form
    {
        static log logger;
        static int already_log_started = 0;

        // 利用されそうな変数群。定義されても使われなかったらエラー出るんだっけ？
        static string str_name;
        static string str_start_station;
        static string str_end_station;
        static string str_cost;
        static string str_before;

        static long cost;
        static DateTime before;

        public Form_orig()
        {
            InitializeComponent();
        }

        protected void log(object cur_form, object cur_button, EventArgs e)
        {
            // ログを生成してログ取得インスタンスに渡す
            long cur_tick = (DateTime.Now).Ticks - logger.get_tick();
            logger.write(cur_form.ToString() + ", " + cur_button.ToString() + ", " + cur_tick.ToString());
            return;
        }

        private void Form_orig_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 何らかの方法でウインドウを閉じたらアプリケーションが全部終わるようにする
            // ウインドウが遷移するときは Dispose を呼ぶようにするのでここは呼ばれない。
            Application.Exit();
        }

        protected void start_log()
        {
            // ログを取るインスタンスを作る。１度以上呼ばれない。
            if (0 == already_log_started++)
            {
                logger = new log(Application.StartupPath);
            }
        }
    }

}