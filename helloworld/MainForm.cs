﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace helloworld
{



    public partial class MainForm : helloworld.Form_orig
    {
        class PuchaseItem
        {
            public string name;
            public int num;
            public int price;
            public int total_price;
        }

        private const int UDON_FLAG_ID = 1;
        private const int RAMEN_FLAG_ID = 21;
        private const int RICE_FLAG_ID = 27;
        private const int SIDE_DISH_FLAG_ID = 56;
        private const int SMALL_BOWL_FLAG_ID = 76;
        private const int DESSERT_FLAG_ID = 91;
        private const int SOUP_FLAG_ID = 95;

        private const int GRID_NUM = 20;
        private const int TAB_NUM = 5;
        private const int PURCHASE_LIST_NUM = 6;

        private Button[] change_button;
        private Button[] purchase_button;
        private Button[] delete_button;
        private Label[] menu_name_label;
        private Label[] menu_price_label;
        private Label[] purchase_menu_name_label;
        private Label[] purchase_menu_price_label;
        private Label[] purchase_menu_num_label;
        private Panel[] menu_panel;
        private Panel[] tab_button;
        private Panel[] purchase_menu_panel;
        private myMenuManager menu_manager;
        private ArrayList menu_list;
        private List<PuchaseItem> purchase_list;

        private static int side_dish_cnt = 0;
        private static int now_purchase_page = 1;


        public MainForm()
        {
            InitializeComponent();
            menu_manager = new myMenuManager();
            menu_list = new ArrayList();
            purchase_list = new List<PuchaseItem>();
            change_button = new Button[GRID_NUM];
            purchase_button = new Button[GRID_NUM];
            delete_button = new Button[PURCHASE_LIST_NUM];
            tab_button = new Panel[TAB_NUM];
            menu_name_label = new Label[GRID_NUM];
            menu_price_label = new Label[GRID_NUM];
            purchase_menu_name_label = new Label[PURCHASE_LIST_NUM];
            purchase_menu_price_label = new Label[PURCHASE_LIST_NUM];
            purchase_menu_num_label = new Label[PURCHASE_LIST_NUM];
            purchase_menu_panel = new Panel[PURCHASE_LIST_NUM];
            menu_panel = new Panel[GRID_NUM];
            menu_manager.makeMenuList("menu.csv");
            menu_list = menu_manager.getMenuList();

            change_button[0] = button27; change_button[1] = button28; change_button[2] = button29; change_button[3] = button30;
            change_button[4] = button31; change_button[5] = button32; change_button[6] = button33; change_button[7] = button34;
            change_button[8] = button35; change_button[9] = button36; change_button[10] = button37; change_button[11] = button38;
            change_button[12] = button39; change_button[13] = button40; change_button[14] = button41; change_button[15] = button42;
            change_button[16] = button43; change_button[17] = button44; change_button[18] = button45; change_button[19] = button46;

            purchase_button[0] = button6; purchase_button[1] = button7; purchase_button[2] = button8; purchase_button[3] = button9;
            purchase_button[4] = button10; purchase_button[5] = button11; purchase_button[6] = button12; purchase_button[7] = button13;
            purchase_button[8] = button15; purchase_button[9] = button16; purchase_button[10] = button17; purchase_button[11] = button18;
            purchase_button[12] = button19; purchase_button[13] = button20; purchase_button[14] = button21; purchase_button[15] = button22;
            purchase_button[16] = button23; purchase_button[17] = button24; purchase_button[18] = button25; purchase_button[19] = button26;

            menu_name_label[0] = label2; menu_name_label[1] = label6; menu_name_label[2] = label8; menu_name_label[3] = label10;
            menu_name_label[4] = label12; menu_name_label[5] = label14; menu_name_label[6] = label16; menu_name_label[7] = label18;
            menu_name_label[8] = label20; menu_name_label[9] = label22; menu_name_label[10] = label24; menu_name_label[11] = label26;
            menu_name_label[12] = label28; menu_name_label[13] = label30; menu_name_label[14] = label32; menu_name_label[15] = label34;
            menu_name_label[16] = label36; menu_name_label[17] = label38; menu_name_label[18] = label40; menu_name_label[19] = label42;

            menu_price_label[0] = label3; menu_price_label[1] = label5; menu_price_label[2] = label7; menu_price_label[3] = label9;
            menu_price_label[4] = label11; menu_price_label[5] = label13; menu_price_label[6] = label15; menu_price_label[7] = label17;
            menu_price_label[8] = label19; menu_price_label[9] = label21; menu_price_label[10] = label23; menu_price_label[11] = label25;
            menu_price_label[12] = label27; menu_price_label[13] = label29; menu_price_label[14] = label31; menu_price_label[15] = label33;
            menu_price_label[16] = label35; menu_price_label[17] = label37; menu_price_label[18] = label39; menu_price_label[19] = label41;

            menu_panel[0] = panel1; menu_panel[1] = panel3; menu_panel[2] = panel2; menu_panel[3] = panel4;
            menu_panel[4] = panel8; menu_panel[5] = panel5; menu_panel[6] = panel6; menu_panel[7] = panel7;
            menu_panel[8] = panel12; menu_panel[9] = panel9; menu_panel[10] = panel10; menu_panel[11] = panel11;
            menu_panel[12] = panel16; menu_panel[13] = panel13; menu_panel[14] = panel14; menu_panel[15] = panel15;
            menu_panel[16] = panel20; menu_panel[17] = panel17; menu_panel[18] = panel18; menu_panel[19] = panel19;

            tab_button[0] = panel21; tab_button[1] = panel22; tab_button[2] = panel24; tab_button[3] = panel26; tab_button[4] = panel27;
            delete_button[0] = button49; delete_button[1] = button50; delete_button[2] = button51;
            delete_button[3] = button52; delete_button[4] = button53; delete_button[5] = button54;

            purchase_menu_panel[0] = panel31; purchase_menu_name_label[0] = label47; purchase_menu_num_label[0] = label48; purchase_menu_price_label[0] = label49;
            purchase_menu_panel[1] = panel32; purchase_menu_name_label[1] = label52; purchase_menu_num_label[1] = label51; purchase_menu_price_label[1] = label50;
            purchase_menu_panel[2] = panel33; purchase_menu_name_label[2] = label55; purchase_menu_num_label[2] = label54; purchase_menu_price_label[2] = label53;
            purchase_menu_panel[3] = panel34; purchase_menu_name_label[3] = label58; purchase_menu_num_label[3] = label57; purchase_menu_price_label[3] = label56;
            purchase_menu_panel[4] = panel35; purchase_menu_name_label[4] = label61; purchase_menu_num_label[4] = label60; purchase_menu_price_label[4] = label59;
            purchase_menu_panel[5] = panel37; purchase_menu_name_label[5] = label64; purchase_menu_num_label[5] = label63; purchase_menu_price_label[5] = label62;

            //初期に麺類の画面を表示
            this.invisibleAllMenu();
            for (int i = UDON_FLAG_ID; i <= 10; i++)
            {
                setNoodleMenu(i);
            }
            for (int i = RAMEN_FLAG_ID; i <= 25; i++)
            {
                setNoodleMenu(i);
            }
            setNoodleMenu(75);

            label44.Text = user_money.ToString() + "円"; //投入金額
            label46.Text = total_price.ToString() + "円";


        }

        private void button1_Click(object sender, EventArgs e) //麺類タブ
        {
            this.invisibleAllMenu();
            this.resetTabBorder();
            this.tab_button[0].BorderStyle = BorderStyle.Fixed3D;
            for (int i = UDON_FLAG_ID; i <= 10; i++)
            {
                setNoodleMenu(i);
            }
            for (int i = RAMEN_FLAG_ID; i <= 25; i++)
            {
                setNoodleMenu(i);
            }
            setNoodleMenu(75); //焼きそばのため
        }

        private void button2_Click(object sender, EventArgs e) //ご飯類タブ
        {
            this.log(this, sender, e);
            this.invisibleAllMenu();
            this.resetTabBorder();
            this.tab_button[1].BorderStyle = BorderStyle.Fixed3D;
            for (int i = RICE_FLAG_ID; i <= 54; i += 3)
            {
                setRiceMenu(i);
            }
            setRiceMenu(98); //ご飯のため
        }

        private void button3_Click(object sender, EventArgs e) //サイドメニュータブ
        {
            this.log(this, sender, e);
            this.invisibleAllMenu();
            this.resetTabBorder();
            this.tab_button[2].BorderStyle = BorderStyle.Fixed3D;
            for (int i = SIDE_DISH_FLAG_ID; i <= 74; i++) //56はから揚げ(中)のid
            {
                setSideDishMenu(i);
            }
        }

        private void button4_Click(object sender, EventArgs e) //小鉢料理/汁物タブ
        {
            this.log(this, sender, e);
            this.invisibleAllMenu();
            this.resetTabBorder();
            this.tab_button[3].BorderStyle = BorderStyle.Fixed3D;
            for (int i = SMALL_BOWL_FLAG_ID; i <= 90; i++)
            {
                setSmallBowlMenu(i);
            }
            for (int i = SOUP_FLAG_ID; i <= 96; i++)
            {
                setSmallBowlMenu(i);
            }
        }

        private void button5_Click(object sender, EventArgs e) //デザートタブ
        {
            this.log(this, sender, e);
            this.invisibleAllMenu();
            this.resetTabBorder();
            this.tab_button[4].BorderStyle = BorderStyle.Fixed3D;
            for (int i = DESSERT_FLAG_ID; i <= 94; i++)
            {
                setDessertMenu(i);
            }
        }

        private void invisibleAllMenu()
        {
            for (int i = 0; i < GRID_NUM; i++)
            {
                menu_panel[i].Visible = false;
            }
            for (int i = 0; i < 6; i++)
            {
                purchase_menu_panel[i].Visible = false;
            }
        }

        private void nextPage(object sender, EventArgs e)
        { //次へボタンに割当
            now_purchase_page++;
            appearInPurchaseDisplay();
        }

        private void previousPage(object sender, EventArgs e) //前へボタンに割当
        {
            now_purchase_page--;
            appearInPurchaseDisplay();
        }

        private void addToPurchaseDisplay(object sender, EventArgs e)
        {
            PuchaseItem item = new PuchaseItem();
            int tag = int.Parse(((Button)sender).Tag.ToString());
            item.name = menu_name_label[tag].Text;
            string temp_price = menu_price_label[tag].Text;
            temp_price = temp_price.Replace("円", "");
            item.price = int.Parse(temp_price);
            item.num = 1;
            item.total_price = item.price;
            total_price += item.total_price;
            purchase_list.Add(item);
            appearInPurchaseDisplay();
            //select_quantity_form = new SelectQuantityForm(item.name,this);
            //select_quantity_form.Show();

            //this.Hide();
            //    if (is_selected_item_num)
            //    {
            //        item.num = purchase_item_num;
            //        item.total_price = item.price * purchase_item_num;
            //        purchase_list.Add(item);
            //        Console.WriteLine("total price is " + item.total_price.ToString());
            //    }

        }

        private void appearInPurchaseDisplay()
        {
            int purchase_list_size = purchase_list.Count;
            int required_page_num = purchase_list_size / PURCHASE_LIST_NUM + 1;
            if (now_purchase_page > required_page_num) { return; }
            if (purchase_list_size > 6 && now_purchase_page == 1)
            {
                button14.Visible = true;
                button55.Visible = false;
            }
            else if (now_purchase_page > 1)
            {
                button14.Visible = true;
                button55.Visible = true;
            }
            else if (purchase_list_size <= 6)
            {
                button14.Visible = false;
                button55.Visible = false;
            }

            for (int i = 0; i < purchase_list_size % 6; i++)
            {
                int j = required_page_num <= 1 ? i : i + (now_purchase_page - 1) * PURCHASE_LIST_NUM;

                purchase_menu_panel[i].Visible = true;
                delete_button[i].Visible = true;
                purchase_menu_panel[i].BorderStyle = BorderStyle.FixedSingle;
                purchase_menu_name_label[i].Text = purchase_list[j].name;
                purchase_menu_num_label[i].Text = (purchase_list[j].num).ToString();
                purchase_menu_price_label[i].Text = (purchase_list[j].total_price).ToString();

            }
            label46.Text = total_price.ToString() + "円";
            highlightCanPurchaseMenu();
        }

        private void deleteItemInPurchaseDisplay(object sender, EventArgs e)
        {
            int tag = int.Parse(((Button)sender).Tag.ToString());
            total_price -= purchase_list[tag].price;
            purchase_list.RemoveAt(tag);
            for (int i = 0; i < 6; i++)
            {
                purchase_menu_name_label[i].Text = "";
                purchase_menu_num_label[i].Text = "";
                purchase_menu_price_label[i].Text = "";
                delete_button[i].Visible = false;
                purchase_menu_panel[i].BorderStyle = BorderStyle.None;
            }
            appearInPurchaseDisplay();
            updateDisplay();
        }

        private void highlightCanPurchaseMenu()
        {
            int i = 0;
            while (menu_panel[i].Visible)
            {
                int menu_price = int.Parse(menu_price_label[i].Text.Replace("円", ""));
                int diff = user_money - total_price;
                if (diff < 0) { diff = 0; }
                if (diff < menu_price)
                {
                    purchase_button[i].Enabled = false;
                    menu_panel[i].BackColor = Color.DarkGray;
                }
                i++;
            }
            //updateDisplay();
        }

        private void updateDisplay()
        {
            int i = 0;
            while (menu_panel[i].Visible)
            {
                menu_panel[i].Refresh();
                i++;
            }
            i = 0;
            while (purchase_menu_panel[i].Visible)
            {
                purchase_menu_panel[i].Refresh();
                i++;
            }
        }

        private void resetTabBorder()
        {
            for (int i = 0; i < TAB_NUM; i++)
            {
                tab_button[i].BorderStyle = BorderStyle.None;
            }
        }

        private void setNoodleMenu(int id)
        {
            if (id != 75)
            {
                int j = id <= 10 ? id - UDON_FLAG_ID : id - RAMEN_FLAG_ID + 10;
                string menu_name = menu_manager.getNameById(id);
                this.menu_panel[j].Visible = true;
                this.menu_name_label[j].Text = menu_name;
                this.menu_price_label[j].Text = (menu_manager.getPrice(menu_name)).ToString() + "円";
                if (this.menu_manager.canChangeSoba(id))
                {
                    this.change_button[j].Visible = true;
                    this.change_button[j].Text = "そばに変更";
                }
                else
                {
                    this.change_button[j].Visible = false;
                }
            }
            else
            { //焼きそばのため
                string menu_name = menu_manager.getNameById(75);
                this.menu_panel[15].Visible = true;
                this.menu_name_label[15].Text = menu_name;
                this.menu_price_label[15].Text = (menu_manager.getPrice(menu_name)).ToString() + "円";
                this.change_button[15].Visible = false;
            }
        }

        private void setRiceMenu(int id)
        {
            int j = id <= 54 ? (id - RICE_FLAG_ID) / 3 : 10;
            string menu_name = menu_manager.getNameById(id);
            this.menu_panel[j].Visible = true;
            this.menu_name_label[j].Text = menu_name;
            this.menu_price_label[j].Text = (menu_manager.getPrice(menu_name)).ToString() + "円";
            if (this.menu_manager.canChangeSize(id))
            {
                this.change_button[j].Visible = true;
                this.change_button[j].Text = "サイズを変更";
            }
            else
            {
                this.change_button[j].Visible = false;
            }
        }

        private void setSideDishMenu(int id)
        {
            if (id != 57 && id != 70 && id != 72 && id != 74)
            {

                string menu_name = menu_manager.getNameById(id);
                this.menu_panel[side_dish_cnt].Visible = true;
                this.menu_name_label[side_dish_cnt].Text = menu_name;
                this.menu_price_label[side_dish_cnt].Text = (menu_manager.getPrice(menu_name)).ToString() + "円";
                if (this.menu_manager.canChangeSize(id))
                {
                    this.change_button[side_dish_cnt].Visible = true;
                    this.change_button[side_dish_cnt].Text = "サイズを変更";
                }
                else
                {
                    this.change_button[side_dish_cnt].Visible = false;
                }
                side_dish_cnt++;
            }
        }

        private void setSmallBowlMenu(int id)
        {
            int j = id <= 90 ? id - SMALL_BOWL_FLAG_ID : id - SOUP_FLAG_ID + 15;
            string menu_name = menu_manager.getNameById(id);
            this.menu_panel[j].Visible = true;
            this.menu_name_label[j].Text = menu_name;
            this.menu_price_label[j].Text = (menu_manager.getPrice(menu_name)).ToString() + "円";
            if (this.menu_manager.canChangeSize(id))
            {
                this.change_button[j].Visible = true;
                this.change_button[j].Text = "サイズを変更";
            }
            else
            {
                this.change_button[j].Visible = false;
            }
        }

        private void setDessertMenu(int id)
        {
            int j = id - DESSERT_FLAG_ID;
            string menu_name = menu_manager.getNameById(id);
            this.menu_panel[j].Visible = true;
            this.menu_name_label[j].Text = menu_name;
            this.menu_price_label[j].Text = (menu_manager.getPrice(menu_name)).ToString() + "円";
            if (this.menu_manager.canChangeSize(id))
            {
                this.change_button[j].Visible = true;
                this.change_button[j].Text = "サイズを変更";
            }
            else
            {
                this.change_button[j].Visible = false;
            }
        }

        private void listBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel28_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button34_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button48_Click(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        public void label48_Click(object sender, EventArgs e)
        {

        }
    }
}