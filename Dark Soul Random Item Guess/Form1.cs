using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dark_Soul_Random_Item_Guess
{
    public partial class Form1 : Form
    {
        private Random RNG;
        private List<Item> RollItems;
        private List<Item> Weapons;
        private List<Item> Armors;
        private List<Item> Magics;
        private List<Item> Rings;
        private List<Item> Consumable;
        private List<Item> Gestures;
        private Item SelectedItem;


        public Form1()
        {
            RNG = new Random();
            CreateLists();
            InitializeComponent();
        }

        private void CreateLists()
        {
            Weapons = new List<Item>();
            LoadData(ItemType.Weapon, Weapons);
            Armors = new List<Item>();
            LoadData(ItemType.Armor, Armors);
            Magics = new List<Item>();
            LoadData(ItemType.Magic, Magics);
            Rings = new List<Item>();
            LoadData(ItemType.Ring, Rings);
            Consumable = new List<Item>();
            LoadData(ItemType.Consumable, Consumable);
            Gestures = new List<Item>();
            LoadData(ItemType.Gesture, Gestures);


        }

        private void LoadData(ItemType itemType, List<Item> items)
        {
            string Filelocation = "";
            switch (itemType)
            {
                case ItemType.Weapon:
                    Filelocation = "Weapon";
                    break;

                case ItemType.Armor:
                    Filelocation = "Armor";
                    break;

                case ItemType.Magic:
                    Filelocation = "Magic";
                    break;

                case ItemType.Ring:
                    Filelocation = "Ring";
                    break;

                case ItemType.Consumable:
                    Filelocation = "Consumable";
                    break;

                case ItemType.Gesture:
                    Filelocation = "Gesture";
                    break;
            }

            string location = Application.StartupPath + "\\Data\\"+Filelocation+"\\";
            if (!File.Exists(location + Filelocation+"Names.txt"))
            {
                MessageBox.Show("MISSING_DATA::"+Filelocation.ToUpper()+"::AT_PATH::" + location);
                return;
            }
            using (StreamReader reader = new StreamReader(location + Filelocation + "Names.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    items.Add(new Item { name = line });
                }
            }
            for (int i = 0; i < items.Count; i++)
            {
                if (File.Exists(location + items[i].name + ".png"))
                {
                    items[i].image = Image.FromFile(location + items[i].name + ".png");
                }
                else
                {
                    MessageBox.Show(location + items[i].name + ".png" + "\nCouldn't be found");
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            LaItemName.Text = "";
            RTBHowToGetText.Text = "";
            RollItems = new List<Item>();
            if (CBWeapons.Checked)
            {
                RollItems.AddRange(Weapons);
            }

            if (CBArmors.Checked)
            {
                RollItems.AddRange(Armors);
            }

            if (CBMagics.Checked)
            {
                RollItems.AddRange(Magics);
            }

            if (CBRings.Checked)
            {
                RollItems.AddRange(Rings);
            }

            if (CBConsumables.Checked)
            {
                RollItems.AddRange(Consumable);
            }

            if (CBGestures.Checked)
            {
                RollItems.AddRange(Gestures);
            }

            if (RollItems.Count != 0)
            {
                SelectedItem = RollItems[RNG.Next(0, RollItems.Count)];
                PBItemDisplay.Image = SelectedItem.image;
                if (CBShowData.Checked)
                {
                    LaItemName.Text = SelectedItem.name;
                    RTBHowToGetText.Text = SelectedItem.howToGet;
                }

            }
        }

        class Item
        {
            public Image image;
            public string name;
            public string howToGet;
        }

        private void BuShowData_Click(object sender, EventArgs e)
        {
            if (SelectedItem.image != null)
            {
                LaItemName.Text = SelectedItem.name;
                RTBHowToGetText.Text = SelectedItem.howToGet;
            }
        }

        enum ItemType
        {
            Weapon, Armor, Magic, Consumable, Ring, Gesture
        }
    }
}
