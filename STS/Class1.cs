using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace STS
{
    public class Podatki
    {
        public bool defend, cleared, skipped, bossStage;
        public int n = 1;
        public int t = 1;
        public double h;
        public double y;
        public double playerHP = 30;
        public int enemyMaxHP;
        public int enemyHP;

        public int points = 0;
        public int str = 0;
        public int def = 0;
        public int playerMaxHP = 30;
        public double exp = 0;
        public int maxExp = 10;
        public int level = 1;
        public int newLevel = 2;

        public Armors armors = new Armors();
        public Weapon weapons = new Weapon();
        public Bosses bosses = new Bosses();
        public Mobs mobs = new Mobs();
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
    public class MythrilArmor : Armor
    {
        public MythrilArmor()
        {
            armorName = "Mythril Armor";
            armorDefense = 9;
            isUnlocked = false;
        }
    }

    public class Armors
    {
        public IronArmor ironA = new IronArmor();
        public BronzeArmor bronzeA = new BronzeArmor();
        public MythrilArmor mythrilA = new MythrilArmor();
    }

    public class Weapon
    {
        public WoodenSword woodenS = new WoodenSword();
        public IronSword ironS = new IronSword();
    }

    public class Boss
    {
        private string _bossName;
        private int _bossID;
        private int _minDmgBoss;
        private int _maxDmgBoss;
        private int _bossMaxHP;
        private Bitmap _bossImage;

        public string bossName
        {
            get { return _bossName; }
            set { _bossName = value; }
        }
        public int bossID
        {
            get { return _bossID; }
            set { _bossID = value; }
        }
        public int minDmgBoss
        {
            get { return _minDmgBoss; }
            set { _minDmgBoss = value; }
        }
        public int maxDmgBoss
        {
            get { return _maxDmgBoss; }
            set { _maxDmgBoss = value; }
        }
        public int bossMaxHP
        {
            get { return _bossMaxHP; }
            set { _bossMaxHP = value; }
        }
        public Bitmap bossImage
        {
            get { return _bossImage; }
            set { _bossImage = value; }
        }
    }
    public class MenacingPikl : Boss
    {
        public MenacingPikl()
        {
            bossName = "Menacing Pickle";
            bossID = 1;
            minDmgBoss = 5;
            maxDmgBoss = 8;
            bossMaxHP = 45;
            bossImage = Properties.Resources.MenacingPikl;
        }
    }
    public class Pikl : Boss
    {
        public Pikl()
        {
            bossName = "Pickle";
            bossID = 2;
            minDmgBoss = 10;
            maxDmgBoss = 13;
            bossMaxHP = 60;
            bossImage = Properties.Resources.Pikl;
        }
    }

    public class Bosses
    {
        public MenacingPikl menacingPikl = new MenacingPikl();
        public Pikl pikl = new Pikl();
    }

    public class Mob
    {
        private string _mobName;
        private int _maxMobHP;
        private int _minMobDmg;
        private int _maxMobDmg;
        private int _stageID;
        private Bitmap _mobImage;

        public string mobName
        {
            get { return _mobName; }
            set { _mobName = value; }
        }
        public int maxMobHP
        {
            get { return _maxMobHP; }
            set { _maxMobHP = value; }
        }
        public int maxMobDmg
        {
            get { return _maxMobDmg; }
            set { _maxMobDmg = value; }
        }
        public int minMobDmg
        {
            get { return _minMobDmg; }
            set { _minMobDmg = value; }
        }
        public int stageID
        {
            get { return _stageID; }
            set { _stageID = value; }
        }
        public Bitmap mobImage
        {
            get { return _mobImage; }
            set { _mobImage = value; }
        }
    }
    public class Pikle : Mob
    {
        public Pikle()
        {
            mobName = "Pikl";
            stageID = 1;
            maxMobHP = 15;
            minMobDmg = 3;
            maxMobDmg = 5;
            mobImage = Properties.Resources.Pikl;
        }
    }
    public class Jerry : Mob
    {
        public Jerry()
        {
            mobName = "Swrd";
            stageID = 2;
            maxMobHP = 30;
            minMobDmg = 6;
            maxMobDmg = 8;
            mobImage = Properties.Resources.Jerry;
        }
    }

    public class Mobs
    {
        public Pikle pikle = new Pikle();
        public Jerry jerry = new Jerry();
    }
}
