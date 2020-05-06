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
            Armors = new List<Item>();
            Magics = new List<Item>();
            Rings = new List<Item>();
            Consumable = new List<Item>();
            Gestures = new List<Item>();

        }

        private void LoadData(ItemType itemType, List<Item> items)
        {
            switch (itemType)
            {
                case ItemType.Weapon:
                    string location = Application.StartupPath + "\\Data\\Weapons\\";
                    if (!File.Exists(location+ "WeaponNames.txt"))
                    {
                        MessageBox.Show("MISSING_DATA::WEAPONS::AT_PATH::" + location);
                        return;
                    }
                    using (StreamReader reader = new StreamReader(location+ "WeaponNames.txt"))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            items.Add(new Item { name = line });
                        }
                    }
                    string nameHolder;
                    for (int i = 0; i < items.Count; i++)
                    {
                        nameHolder = items[i].name;
                        nameHolder.Replace(' ', '_');
                        items[i].image = Image.FromFile(location + nameHolder + ".png");
                    }
                    break;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            RollItems = new List<Item>();
            if (RBWeapons.Checked)
            {
                RollItems.AddRange(Weapons);
            }

            if (RBArmor.Checked)
            {
                RollItems.AddRange(Armors);
            }

            if (RBMagic.Checked)
            {
                RollItems.AddRange(Magics);
            }

            if (RBRings.Checked)
            {
                RollItems.AddRange(Rings);
            }

            if (RBConsumeable.Checked)
            {
                RollItems.AddRange(Consumable);
            }

            if (RBGestures.Checked)
            {
                RollItems.AddRange(Gestures);
            }

            if (RollItems.Count != 0)
            {
                SelectedItem = RollItems[RNG.Next(0, RollItems.Count)];
                PBItemDisplay.Image = SelectedItem.image;
                if (RBViewName.Checked)
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
