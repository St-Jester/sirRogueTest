using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPGClassLibrary;
using System.Threading;

namespace SirRogueTest1
{
   //need sort of observer when any button is clicked
    public partial class Form1 : Form
    {
        Player p;
        Quest q;
        Equipment t;
        Journal journal;
        public Form1()
        {
            InitializeComponent();
            p = new Player();
            HpLabel.Text = p.HP.CurrentValue.ToString();
            journal = new Journal();
            t = new Equipment("testitem",1, 12);
            q = new Quest("Give me 5 things and ill make u rich", "5 things", 200, 20, 20);
        }

        private void StartQuestButton_Click(object sender, EventArgs e)
        {
            if(p.Stamina.CurrentValue >= q.StaminaRequirement)
            {
                //record in journal

                //start it
                MessageBox.Show(q.Description, q.QuestName);
                p.Stamina.CurrentValue = p.Stamina.CurrentValue - q.StaminaRequirement;
                p.Money += q.QuestMoneyReward;
                p.lm.AddXp(q.QuestXp);
                StaminaLabel.Text = p.Stamina.CurrentValue.ToString();
                MoneyLabel.Text = p.Money.ToString();

                journal.AddRecord(q.QuestName, q.Description);
                foreach (var i in journal.JournalRecords)
                {
                    listView1.Items.Add(i.Key.ToString());

                }
            }
        }

        private void TestBonus_Click(object sender, EventArgs e)
        {
            p.HP.CurrentValue = p.HP.CurrentValue - 1.0;
            HpLabel.Text = p.HP.CurrentValue.ToString();
        }

        private void TavernButton_Click(object sender, EventArgs e)
        {
            if (TavernTimer.Enabled == true)
            {
                TavernTimer.Stop();
            }
            else
            {
                TavernTimer.Start();
            }
            
        }
        private void TavernTimer_Tick(object sender, EventArgs e)
        {
            StaminaLabel.Text = p.Stamina.CurrentValue.ToString();
            HpLabel.Text = p.HP.CurrentValue.ToString();
            if (p.HP.CurrentValue >= p.HP.BaseValue && p.Stamina.CurrentValue < p.Stamina.BaseValue)
            {
                p.Stamina.CurrentValue = p.Stamina.CurrentValue + 1.0;
               
                StaminaLabel.Text = p.Stamina.CurrentValue.ToString();
                HpLabel.Text = p.HP.CurrentValue.ToString();
            }
            if(p.HP.CurrentValue  < p.HP.BaseValue && p.Stamina.CurrentValue >= p.Stamina.BaseValue)
                {
                p.HP.CurrentValue = p.HP.CurrentValue + 1.0;
               
                StaminaLabel.Text = p.Stamina.CurrentValue.ToString();
                HpLabel.Text = p.HP.CurrentValue.ToString();
            }
            if (p.HP.CurrentValue < p.HP.BaseValue && p.Stamina.CurrentValue < p.Stamina.BaseValue)
            {
                p.HP.CurrentValue = p.HP.CurrentValue + 1.0;
                p.Stamina.CurrentValue = p.Stamina.CurrentValue + 1.0;
               
                StaminaLabel.Text = p.Stamina.CurrentValue.ToString();
                HpLabel.Text = p.HP.CurrentValue.ToString();

            }
            if (p.HP.CurrentValue >= p.HP.BaseValue && p.Stamina.CurrentValue >= p.Stamina.BaseValue)
            {
                TavernTimer.Stop();
              
                StaminaLabel.Text = p.Stamina.CurrentValue.ToString();
                HpLabel.Text = p.HP.CurrentValue.ToString();
            }
        }

        private void ItemButton_Click(object sender, EventArgs e)
        {
            p.eqman.Equip(t);
            //equipunique
            
            HpLabel.Text = p.HP.CurrentValue.ToString();
            ItemNameTEMPLabel.Text = t.ItemName;

            ItemButton.Enabled = false;
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            ItemButton.Enabled = true;

            //check if this item is equipped
            //multiply stats modifier
            //p.HP.RemoveModifier(t.HPModifier);
            //p.HP = p.HP - t.HPModifier;
            Equipment equip =  p.eqman.Unequip((int)t.equipmentSlot);
          
            HpLabel.Text = p.HP.CurrentValue.ToString();

            ItemNameTEMPLabel.Text = "No item";
            foreach (var item in p.HP.AllModifiers)
            {
                MessageBox.Show(item.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //load saving files
        }

        
    }
}
