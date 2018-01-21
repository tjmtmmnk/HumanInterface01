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
        static menuManager mm;
        static int already_menu_created = 0;

        // 利用されそうな変数群。定義されても使われなかったらエラー出るんだっけ？
        //static string str_start_station;
        //static string str_end_station;
        //static string str_cost;
        //static string str_before;
        //protected static string str_name;
        //static DateTime before;
        protected static string item_name;	// 購入した食券の商品名
        protected static int user_money = 0;	// 券売機への投入金額
        protected static int purchase_item_num = 1;
        protected static int purchase_price = 0;
        protected static bool is_selected_item_num = false;

        // 商品のサイズ
        protected const int SS = 0;
        protected const int S = 1;
        protected const int M = 2;
        protected const int L = 3;

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

        protected int get_price(string name)
        {
			// 商品名から値段を取得（存在しない場合は0を返す）
            return mm.get_price(name);
        }

        protected int get_price(string name, int size)
        {
            // 商品名とそのサイズから値段を取得（存在しない場合は0を返す）
            return mm.get_price(name, size);
        }

        protected bool canBuy(string name)
        {
            // その商品が現在の投入金額で変えるかどうか
            bool retValue = false;
            if(this.get_price(name) <= money)
                retValue = true;
            return retValue;
        }

        protected void buy_ticket(string name)
        {
            // お金を消費して商品名の食券を購入
            money -= this.get_price(name);
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

        protected void create_menulist()
        {
            // メニューリストを作る。１度以上呼ばれない。
            if (0 == already_menu_created++)
            {
                mm = new menuManager("menu.csv");
            }
        }
    }
}