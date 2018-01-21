using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.IO;

namespace helloworld
{
    class Menu
    {
        public int id;
        public string name;
        public int price;
        public bool can_change_soba = false;
        public bool can_change_size = false;
    }

    class myMenuManager
    {

        private ArrayList menuList;

        public void makeMenuList(string filename)
        {
            menuList = new ArrayList();
            StreamReader reader = new StreamReader(filename, Encoding.Default);
            string temp;
            while ((temp = reader.ReadLine()) != null)
            {
                Menu tempMenu = new Menu();
                string[] row = temp.Split(',');
                tempMenu.id = int.Parse(row[0]);
                tempMenu.name = row[1];
                tempMenu.price = int.Parse(row[2]);
                if (1 <= tempMenu.id && tempMenu.id <= 10)
                {
                    tempMenu.can_change_soba = true;
                }
                if (tempMenu.id >= 27 && tempMenu.id % 3 == 0 && tempMenu.id <= 54)
                { //3の倍数であるという規則性
                    tempMenu.can_change_size = true;
                }
                if (tempMenu.id == 61 || tempMenu.id == 69 || tempMenu.id == 71 || tempMenu.id == 73 || tempMenu.id == 98)
                {
                    tempMenu.can_change_size = true;
                }
                menuList.Add(tempMenu);
            }
        }
        private Menu getMenu(string name)
        {
            Menu tempMenu = new Menu();
            tempMenu.id = 0;
            tempMenu.name = "";
            tempMenu.price = 0;

            for (int i = 0; i < menuList.Count; i++)
            {
                tempMenu = (Menu)menuList[i];
                if (name == tempMenu.name) break;
                else if (i == menuList.Count - 1)
                {
                    tempMenu.id = 0;
                    tempMenu.name = "";
                    tempMenu.price = 0;
                }
            }
            return tempMenu;
        }
        private Menu getMenuById(int id)
        {
            Menu tempMenu = new Menu();
            tempMenu.id = 0;
            tempMenu.name = "";
            tempMenu.price = 0;

            for (int i = 0; i < menuList.Count; i++)
            {
                tempMenu = (Menu)menuList[i];
                if (id == tempMenu.id) break;
                else if (i == menuList.Count - 1)
                {
                    tempMenu.id = 0;
                    tempMenu.name = "";
                    tempMenu.price = 0;
                }
            }
            return tempMenu;
        }
        public ArrayList getMenuList()
        {
            if (menuList.Count != 0)
            {
                return menuList;
            }
            else
            {
                Console.WriteLine("menu is empty");
                return null;
            }
        }

        public string getNameById(int id)
        {
            Menu temp_menu = new Menu();
            for (int i = 0; i < menuList.Count; i++)
            {
                if (id == temp_menu.id) break;
                else if (i == menuList.Count - 1)
                {
                    temp_menu.id = 0;
                    temp_menu.name = "";
                    temp_menu.price = 0;
                }
            }
            return temp_menu.name;
        }

        public int getId(string name)
        {
            return getMenu(name).id;
        }

        public int getPrice(string name)
        {
            return getMenu(name).price;
        }

        public int getPrice(string name, int size)
        {
            string[] size_str = { "SS", "小", "中", "大" };
            return getMenu(name + "（" + size_str[size] + "）").price;
        }

        public bool canChangeSoba(string name)
        {
            return getMenu(name).can_change_soba;
        }
        public bool canChangeSize(string name)
        {
            return getMenu(name).can_change_size;
        }
        public bool canChangeSoba(int id)
        {
            return getMenuById(id).can_change_soba;
        }
        public bool canChangeSize(int id)
        {
            return getMenuById(id).can_change_size;
        }

    }
}
