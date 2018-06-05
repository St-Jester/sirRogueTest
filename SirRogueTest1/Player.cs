using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGClassLibrary;

namespace SirRogueTest1
{
    public class Player
    {
        public Stat HP;
        public Stat Stamina;
        public Stat Damage;

        public LevelManager lm;
        public EquipmentManager eqman;

        public double Money { get; set; }

        public Player()
        {
            HP = new Stat(100.0);
            Stamina = new Stat(100.0);
            Damage = new Stat(10.0);
            lm = new LevelManager();
            eqman = new EquipmentManager();
            eqman.onEquipmentChanged += OnEquipmentChanged;
        }

        void OnEquipmentChanged(Equipment newItem, Equipment oldItem)
        {
            // Add new modifiers
            if (newItem != null)
            {
                HP.AddModifier(newItem.HPModifier);
                Damage.AddModifier(newItem.DamageModifier);
            }

            // Remove old modifiers
            if (oldItem != null)
            {
                HP.RemoveModifier(oldItem.HPModifier);
                Damage.RemoveModifier(oldItem.DamageModifier);
            }
        }
    }
    
    //needs connection to player;
    //singleton and observer
    public class LevelManager
    {
        public double CurrentXp { get; set; }
        public double MaxXp { get; set; }
        public int CurrentLevel { get; set; }
        public double LvlingCoef { get; set; }          //coeff to change maxxp after lvlup must be >1
        private double incrementalCoef;                 //coef to change LvlingCoeff

        public LevelManager(double _maxXP, double _lcoef, double _incrCoef)
        {
            MaxXp = _maxXP;
            LvlingCoef = _lcoef;
            incrementalCoef = _incrCoef;
        }
        public LevelManager()
        {
            CurrentXp = 0;
            MaxXp = 100;
            CurrentLevel = 1;
            LvlingCoef = 1.2;
        }

        public void LvlUp()                 //make this observing
        {
            CurrentLevel = (int)(CurrentXp / MaxXp);
            CurrentXp %= MaxXp;
            MaxXp *= LvlingCoef;
            LvlingCoef = LvlingCoef + MaxXp / 1000;
        }

        public bool IsLevelup()
        {
            return CurrentXp >= MaxXp;
        }

        public void AddXp(double _amount)
        {
            CurrentXp += _amount;
            if(IsLevelup())                 //make this observed
            {
                LvlUp();
            }
        }
    }

}
