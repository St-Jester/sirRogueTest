using System;
using System.Collections.Generic;
using System.Text;

namespace RPGClassLibrary
{
    public class Equipment:Item
    {
        public EquipmentSlot equipmentSlot = new EquipmentSlot();


        public Modifier HPModifier { get; set; }
        public Modifier DamageModifier { get; set; }

        public Equipment(string _eqname, int _eqslot, double _hpValue = 0, double _damageValue = 0) : base(_eqname)
        {
            HPModifier = new Modifier(_hpValue, ItemName, this);
            DamageModifier = new Modifier(_damageValue, ItemName, this);
            equipmentSlot = (EquipmentSlot)_eqslot;
        }
    }

    public enum EquipmentSlot
    {
        Torso,
        Arms,
        Legs,
        Weapon
    }
}
