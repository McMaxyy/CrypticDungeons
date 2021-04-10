using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace STS
{
    public class Podatki
    {
        public bool defend, cleared;
        public int n = 1;
        public int sumfin = 1;
        public int t = 1;
        public int y;
        public int playerHP = 30;
        public int enemyMaxHP = 15;
        public int enemyHP = 15;

        public int str = 0;
        public int def = 0;
        public int playerMaxHP = 30;
        public int exp = 0;
        public int maxExp = 10;
        public int level = 1;

        public Armors armors = new Armors();
        public Weapon weapons = new Weapon();
    }

    public class Weapons
    {
        private string _weaponName;
        private int _weaponDmgMax;
        private int _weaponDmgMin;
        public bool isUnlocked;

        public string weaponName
        {
            get { return _weaponName; }
            set { _weaponName = value; }
        }
        public int weaponDmgMax
        {
            get { return _weaponDmgMax; }
            set { _weaponDmgMax = value; }
        }
        public int weaponDmgMin
        {
            get { return _weaponDmgMin; }
            set { _weaponDmgMin = value; }
        }

        public Weapons()
        {
            weaponName = "N/A";
            weaponDmgMin = 0;
            weaponDmgMax = 0;
            isUnlocked = false;
        }
        public Weapons(string _weaponName, int _weaponDmgMin, int _weaponDmgMax)
        {
            weaponName = _weaponName;
            weaponDmgMin = _weaponDmgMin;
            weaponDmgMax = _weaponDmgMax;
        }
    }

    public class WoodenSword : Weapons
    {
        public WoodenSword()
        {
            weaponName = "Wooden Sword";
            weaponDmgMax = 30;
            weaponDmgMin = 10; 
            isUnlocked = true;
        }
    }
    public class IronSword : Weapons
    {
        public IronSword()
        {
            weaponName = "Iron Sword";
            weaponDmgMax = 5;
            weaponDmgMin = 3;
            isUnlocked = false;
        }
    }

    public class Armor
    {
        private string _armorName;
        private int _armorDefense;
        public bool isUnlocked;

        public string armorName
        {
            get { return _armorName; }
            set { _armorName = value; }
        }

        public int armorDefense
        {
            get { return _armorDefense; }
            set { _armorDefense = value; }
        }

        public Armor()
        {
            armorName = "N/A";
            armorDefense = 1;
            isUnlocked = false;
        }
    }

    public class BronzeArmor : Armor
    {
        public BronzeArmor()
        {
            armorName = "Bronze Armor";
            armorDefense = 3;
            isUnlocked = true;
        }
    }
    public class IronArmor : Armor
    {
        public IronArmor()
        {
            armorName = "Iron Armor";
            armorDefense = 6;
            isUnlocked = false;
        }
    }

    public class Armors
    {
        public IronArmor ironA = new IronArmor();
        public BronzeArmor bronzeA = new BronzeArmor();
    }

    public class Weapon
    {
        public WoodenSword woodenS = new WoodenSword();
        public IronSword ironS = new IronSword();
    }
}
