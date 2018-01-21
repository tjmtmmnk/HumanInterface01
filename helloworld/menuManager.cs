using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.IO;

namespace helloworld
{
	struct menu
	{
		public int id;
		public string name;
		public int price;
	}

	class menuManager
	{
        ArrayList menuList;
        public menuManager(string filename)
        {
            menuList = new ArrayList();
            StreamReader reader = new StreamReader(filename, Encoding.Default);
            string temp;
            while ((temp = reader.ReadLine()) != null)
            {
                menu tempMenu;
                string[] row = temp.Split(',');
                tempMenu.id = int.Parse(row[0]);
                tempMenu.name = row[1];
                tempMenu.price = int.Parse(row[2]);
                menuList.Add(tempMenu);
            }                
        }

		// nameが一致するmenuを返す
		private menu getMenu(string name)
		{
			menu tempMenu;
			tempMenu.id = 0;
			tempMenu.name = "";
			tempMenu.price = 0;

			for (int i = 0; i < menuList.Count; i++)
			{
                tempMenu = (menu)menuList[i];
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

		public int get_id(string name)
		{
			return getMenu(name).id;
		}

        public int get_price(string name)
        {
            return getMenu(name).price;
        }

        public int get_price(string name, int size)
        {
            string[] size_str = {"SS","小","中","大"};
            return getMenu(name+"（"+size_str[size]+"）").price;
        }
    }
}
