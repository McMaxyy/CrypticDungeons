using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Newtonsoft.Json;

namespace STS
{
    //Player, armors, weapons, inventory and item data
    public class Podatki
    {
        [JsonIgnore] public bool defend, cleared, skipped, bossStage;
        [JsonIgnore] public int n = 1;
        [JsonIgnore] public int t = 1;
        [JsonIgnore] public double h;
        [JsonIgnore] public double y;
        [JsonIgnore] public double playerHP = 30;
        [JsonIgnore] public int enemyMaxHP;
        [JsonIgnore] public int enemyHP;
        [JsonIgnore] public int stageRank;
        [JsonIgnore] public string saveName = "";

        public int newCoins;
        public int coins = 0;
        public int points = 0;
        public int str = 0;
        public int def = 0;
        public int playerMaxHP = 30;
        public double shields;
        public int expAdd;
        public double exp = 0;
        public int maxExp = 10;
        public int level = 1;
        public int newLevel = 2;

        //Every piece of equipment, inventory is stored in these objects
        public Armors armors = new Armors();
        public Weapon weapons = new Weapon();
        [JsonIgnore] public Bosses bosses = new Bosses();
        [JsonIgnore] public Mobs mobs = new Mobs();
        [JsonIgnore] public Recipes recipes = new Recipes();
        public Inventory inventory = new Inventory();
        public Items items = new Items();
    }

    //Weapon class
    public abstract class Weapons
    {
        private string _weaponName;
        private int _weaponDmgMax;
        private int _weaponDmgMin;
        private bool _isUnlocked;
        private Bitmap _weaponImage;
        private int _coinValue;
        private bool _isObtained;

        [JsonIgnore]
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
        [JsonIgnore]
        public Bitmap weaponImage
        {
            get { return _weaponImage; }
            set { _weaponImage = value; }
        }
        [JsonIgnore]
        public int coinValue
        {
            get { return _coinValue; }
            set { _coinValue = value; }
        }
        public bool isUnlocked
        {
            get { return _isUnlocked; }
            set { _isUnlocked = value; }
        }
        public bool isObtained
        {
            get { return _isObtained; }
            set { _isObtained = value; }
        }
    }

    public class WoodenSword : Weapons
    {
        public WoodenSword()
        {
            weaponName = "Wooden Sword";
            weaponDmgMax = 3;
            weaponDmgMin = 2;
            isUnlocked = true;
            weaponImage = Properties.Resources.WoodenSword_Equip;
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
            weaponImage = Properties.Resources.IronSword_Equip;
            coinValue = 35;
            isObtained = false;
        }
    }
    public class PickleSword : Weapons
    {
        public PickleSword()
        {
            weaponName = "Pickle Sword";
            weaponDmgMax = 10;
            weaponDmgMin = 8;
            isUnlocked = false;
            weaponImage = Properties.Resources.PiklSword_Equip;
            isObtained = false;
        }
    }
    public class GoblinSword : Weapons
    {
        public GoblinSword()
        {
            weaponName = "Goblin Sword";
            weaponDmgMax = 17;
            weaponDmgMin = 13;
            isUnlocked = false;
            weaponImage = Properties.Resources.GoblinSwordNormal_Equip;
            isObtained = false;
        }
    }
    public class MonkeMallet : Weapons
    {
        public MonkeMallet()
        {
            weaponName = "Monke Mallet";
            weaponDmgMax = 25;
            weaponDmgMin = 20;
            isUnlocked = false;
            weaponImage = Properties.Resources.MonkeMallet_Equip;
            isObtained = false;
        }
    }
    public class DinoSword : Weapons
    {
        public DinoSword()
        {
            weaponName = "Dino Sword";
            weaponDmgMax = 30;
            weaponDmgMin = 28;
            isUnlocked = false;
            weaponImage = Properties.Resources.DinoSword_Equip;
            isObtained = false;
        }
    }

    //Armor class
    public class Armor
    {
        private string _armorName;
        private int _armorDefense;
        private bool _isUnlocked;
        private Bitmap _armorImage;
        private int _coinValue;
        private bool _isObtained;

        [JsonIgnore] public string armorName
        {
            get { return _armorName; }
            set { _armorName = value; }
        }
        [JsonIgnore] public int armorDefense
        {
            get { return _armorDefense; }
            set { _armorDefense = value; }
        }
        [JsonIgnore] public Bitmap armorImage
        {
            get { return _armorImage; }
            set { _armorImage = value; }
        }
        [JsonIgnore] public int coinValue
        {
            get { return _coinValue; }
            set { _coinValue = value; }
        }
        public bool isUnlocked
        {
            get { return _isUnlocked; }
            set { _isUnlocked = value; }
        }
        public bool isObtained
        {
            get { return _isObtained; }
            set { _isObtained = value; }
        }
    }

    public class BronzeArmor : Armor
    {
        public BronzeArmor()
        {
            armorName = "Bronze Armor";
            armorDefense = 3;
            isUnlocked = true;
            armorImage = Properties.Resources.BronzeArmor_Equip;
        }
    }
    public class IronArmor : Armor
    {
        public IronArmor()
        {
            armorName = "Iron Armor";
            armorDefense = 6;
            isUnlocked = false;
            armorImage = Properties.Resources.IronArmor_Equip;
            coinValue = 60;
            isObtained = false;
        }
    }
    public class PickleArmor : Armor
    {
        public PickleArmor()
        {
            armorName = "Pickle Armor";
            armorDefense = 12;
            isUnlocked = false;
            armorImage = Properties.Resources.PiklArmor_Equip;
            isObtained = false;
        }
    }
    public class GoblinArmor : Armor
    {
        public GoblinArmor()
        {
            armorName = "Goblin Armor";
            armorDefense = 18;
            isUnlocked = false;
            armorImage = Properties.Resources.GoblinArmor;
            isObtained = false;
        }
    }
    public class MonkeArmor : Armor
    {
        public MonkeArmor()
        {
            armorName = "Monke Armor";
            armorDefense = 24;
            isUnlocked = false;
            armorImage = Properties.Resources.MonkeArmor;
            isObtained = false;
        }
    }
    public class DinoArmor : Armor
    {
        public DinoArmor()
        {
            armorName = "Dino Armor";
            armorDefense = 30;
            isUnlocked = false;
            armorImage = Properties.Resources.DinoArmor;
            isObtained = false;
        }
    }

    //Create armors & weapons with primary constructor attributes
    public class Armors
    {
        public IronArmor ironA = new IronArmor();
        public BronzeArmor bronzeA = new BronzeArmor();
        public PickleArmor pickleA = new PickleArmor();
        public GoblinArmor goblinA = new GoblinArmor();
        public MonkeArmor monkeA = new MonkeArmor();
        public DinoArmor dinoA = new DinoArmor();
    }
    public class Weapon
    {
        public WoodenSword woodenS = new WoodenSword();
        public IronSword ironS = new IronSword();
        public PickleSword pickleS = new PickleSword();
        public GoblinSword goblinS = new GoblinSword();
        public MonkeMallet monkeM = new MonkeMallet();
        public DinoSword dinoS = new DinoSword();
    }

    //Boss class
    public class Boss
    {
        private string _bossName;
        private int _bossID;
        private int _minDmgBoss;
        private int _maxDmgBoss;
        private int _bossMaxHP;
        private Bitmap _bossImage;
        private int[] _dropTable;
        private int _coinValue;

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
        public int coinValue
        {
            get { return _coinValue; }
            set { _coinValue = value; }
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
        public int[] dropTable
        {
            get { return _dropTable; }
            set { _dropTable = value; }
        }
    }
    public class MenacingPikl : Boss
    {
        public MenacingPikl()
        {
            bossName = "Menacing Pickle";
            bossID = 0;
            coinValue = 6;
            minDmgBoss = 6;
            maxDmgBoss = 8;
            bossMaxHP = 45;
            bossImage = Properties.Resources.MenacingPikl;
            dropTable = new int[] { PickleJuice.ID, PickleSkin.ID };
        }
    }
    public class GoblinKing : Boss
    {
        public GoblinKing()
        {
            bossName = "Goblin King";
            bossID = 1;
            coinValue = 15;
            minDmgBoss = 11;
            maxDmgBoss = 14;
            bossMaxHP = 80;
            bossImage = Properties.Resources.GoblinKing;
            dropTable = new int[] { GoblinSkull.ID, GoblinHide.ID };
        }
    }
    public class SmolMonkeBoss : Boss
    {
        public SmolMonkeBoss()
        {
            bossName = "Smol Hanging Monke";
            bossID = 2;
            coinValue = 25;
            minDmgBoss = 21;
            maxDmgBoss = 23;
            bossMaxHP = 100;
            bossImage = Properties.Resources.SmolBossMonke;
            dropTable = new int[] { MonkeCarapace.ID, MonkeBones.ID };
        }
    }
    public class Zavr : Boss
    {
        public Zavr()
        {
            bossName = "Zavr";
            bossID = 3;
            coinValue = 50;
            minDmgBoss = 28;
            maxDmgBoss = 32;
            bossMaxHP = 200;
            bossImage = Properties.Resources.ZavrRed;
            dropTable = new int[] { DinoTeeth.ID, DinoClaws.ID, DinoTail.ID };
        }
    }

    //Create bosses with primary attributes
    public class Bosses
    {
        public MenacingPikl menacingPikl = new MenacingPikl();
        public GoblinKing goblinKing = new GoblinKing();
        public SmolMonkeBoss smolMonkeBoss = new SmolMonkeBoss();
        public Zavr zavr = new Zavr();
    }

    //Interfaces, allowing me to add another subclass/label to the Mob subclasses
    interface MobLowRank
    {

    }
    interface MobMidRank
    {

    }
    interface MobHighRank
    {

    }

    //Mob class (enemies)
    public abstract class Mob
    {
        private string _mobName;
        private int _maxMobHP;
        private int _minMobDmg;
        private int _maxMobDmg;
        private int _coinValue;
        private Bitmap _mobImage;
        private int _mobID;

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
        public int coinValue
        {
            get { return _coinValue; }
            set { _coinValue = value; }
        }
        public Bitmap mobImage
        {
            get { return _mobImage; }
            set { _mobImage = value; }
        }
        public int mobID
        {
            get { return _mobID; }
            set { _mobID = value; }
        }
    }

    public class Pikle : Mob, MobLowRank
    {
        public Pikle()
        {
            mobName = "Pikl";
            coinValue = 2;
            maxMobHP = 15;
            minMobDmg = 3;
            maxMobDmg = 5;
            mobImage = Properties.Resources.Pikl;
            mobID = 0;
        }
    }
    public class Jerry : Mob, MobLowRank
    {
        public Jerry()
        {
            mobName = "Jerry";
            coinValue = 3;
            maxMobHP = 10;
            minMobDmg = 3;
            maxMobDmg = 7;
            mobImage = Properties.Resources.Jerry; 
            mobID = 1;
        }
    }
    public class SmolGoblin : Mob, MobMidRank
    {
        public SmolGoblin()
        {
            mobName = "Smol Goblin";
            coinValue = 4;
            maxMobHP = 25;
            minMobDmg = 5;
            maxMobDmg = 7;
            mobImage = Properties.Resources.Nejc;
            mobID = 2;
        }
    }
    public class SpearGoblin : Mob, MobMidRank
    {
        public SpearGoblin()
        {
            mobName = "Spear Goblin";
            coinValue = 5;
            maxMobHP = 35;
            minMobDmg = 6;
            maxMobDmg = 8;
            mobImage = Properties.Resources.SpearGoblin;
            mobID = 3;
        }
    }
    public class SpaceGoblin : Mob, MobMidRank
    {
        public SpaceGoblin()
        {
            mobName = "Space Goblin";
            coinValue = 6;
            maxMobHP = 40;
            minMobDmg = 7;
            maxMobDmg = 9;
            mobImage = Properties.Resources.SpaceGoblin;
            mobID = 4;
        }
    }
    public class Cyclops : Mob
    {
        public Cyclops()
        {
            mobName = "Cyclops";
            coinValue = 20;
            maxMobHP = 90;
            minMobDmg = 14;
            maxMobDmg = 17;
            mobImage = Properties.Resources.Cyclops;
            mobID = 5;
        }
    }

    public class CoolMonke : Mob, MobHighRank
    {
        public CoolMonke()
        {
            mobName = "Cool Monke";
            coinValue = 10;
            maxMobHP = 40;
            minMobDmg = 10;
            maxMobDmg = 12;
            mobImage = Properties.Resources.CoolMonke;
            mobID = 6;
        }
    }
    public class StrongMonke : Mob, MobHighRank
    {
        public StrongMonke()
        {
            mobName = "Strong Monke";
            coinValue = 13;
            maxMobHP = 65;
            minMobDmg = 9;
            maxMobDmg = 13;
            mobImage = Properties.Resources.StrongMonke;
            mobID = 7;
        }
    }
    public class CrossbowMonke : Mob, MobHighRank
    {
        public CrossbowMonke()
        {
            mobName = "Crossbow Monke";
            coinValue = 15;
            maxMobHP = 50;
            minMobDmg = 13;
            maxMobDmg = 15;
            mobImage = Properties.Resources.CrossbowMonke;
            mobID = 8;
        }
    }
    public class Gorilla : Mob
    {
        public Gorilla()
        {
            mobName = "Gorilla";
            coinValue = 35;
            maxMobHP = 140;
            minMobDmg = 22;
            maxMobDmg = 25;
            mobImage = Properties.Resources.Gorillaz;
            mobID = 9;
        }
    }

    //Creating enemies with primary constructor attributes
    public class Mobs
    {
        public Pikle pikle = new Pikle();
        public Jerry jerry = new Jerry();
        public SmolGoblin smolGoblin = new SmolGoblin();
        public SpearGoblin spearGoblin = new SpearGoblin();
        public SpaceGoblin spaceGoblin = new SpaceGoblin();
        public Cyclops cyclops = new Cyclops();
        public CoolMonke coolMonke = new CoolMonke();
        public StrongMonke strongMonke = new StrongMonke();
        public CrossbowMonke crossbowMonke = new CrossbowMonke();
        public Gorilla gorilla = new Gorilla();
    }

    //Inventory class, where materials are stored in, with functions such as "showItem (used for showing what the boss dropped)", "addItem", "useItem", "toString (used for listing materials the player has)"
    //and "requiredMaterials (used for crafting recipes)"
    public class Inventory
    {
        public Item[] items = { new PickleJuice(), new PickleSkin(), new GoblinHide(), new GoblinSkull(), new MonkeBones(), new MonkeCarapace(),
            new DinoTeeth(), new DinoClaws(), new DinoTail(),
            new IronOre(), new MythrilOre(),
            new HealthPotion(), new Sword(), new Shield(), new Bomb() };
        public string itemShow;
        public int reqMat;

        public void showItem(int ItemID)
        {
            itemShow = items[ItemID].itemName;
        }
        public void addItem(int itemID, int numberOfItemsToAdd)
        {
            items[itemID].incrementQuantity(numberOfItemsToAdd);
        }
        public void useItem(int itemID, int numberOfItemsToRemove)
        {
            items[itemID].decrementQuantity(numberOfItemsToRemove);
        }

        public string toString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Item item in items)
            {
                if(item.itemQuantity > 0)
                {
                    sb.AppendLine(item.itemName + ": " + item.itemQuantity);
                }
            }
            return sb.ToString();
        }
        public int requiredMaterials(int ItemID)
        {
            reqMat = items[ItemID].itemQuantity;
            return reqMat;
        }
    }

    //Item class, where every material's primary constructor is located
    public class Item
    {
        private int _itemID;
        private string _itemName;
        private int _itemQuantity;

        public int itemID
        {
            get { return _itemID; }
            set { _itemID = value; }
        }
        public string itemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }
        public int itemQuantity
        {
            get { return _itemQuantity; }
            set { _itemQuantity = value; }
        }

        public void incrementQuantity(int i)
        {
            itemQuantity += i;
        }
        public void decrementQuantity(int i)
        {
            itemQuantity -= i;
        }
    }

    public class PickleJuice : Item
    {
        readonly public static int ID = 0;
        public PickleJuice()
        {
            itemName = "Pickle Juice";
            itemID = ID;
            itemQuantity = 0;
        }
    }
    public class PickleSkin : Item
    {
        readonly public static int ID = 1;
        public PickleSkin()
        {
            itemName = "Pickle Skin";
            itemID = ID;
            itemQuantity = 0;
        }
    }
    public class GoblinSkull : Item
    {
        readonly public static int ID = 2;
        public GoblinSkull()
        {
            itemName = "Goblin Skull";
            itemID = ID;
            itemQuantity = 0;
        }
    }
    public class GoblinHide : Item
    {
        readonly public static int ID = 3;
        public GoblinHide()
        {
            itemName = "Goblin Hide";
            itemID = ID;
            itemQuantity = 0;
        }
    }
    public class MonkeBones : Item
    {
        readonly public static int ID = 4;
        public MonkeBones()
        {
            itemName = "Monke Bones";
            itemID = ID;
            itemQuantity = 0;
        }
    }
    public class MonkeCarapace : Item
    {
        readonly public static int ID = 5;
        public MonkeCarapace()
        {
            itemName = "Monke Skull";
            itemID = ID;
            itemQuantity = 0;
        }
    }
    public class DinoTeeth : Item
    {
        readonly public static int ID = 6;
        public DinoTeeth()
        {
            itemName = "Dino Teeth";
            itemID = ID;
            itemQuantity = 0;
        }
    }
    public class DinoClaws : Item
    {
        readonly public static int ID = 7;
        public DinoClaws()
        {
            itemName = "Dino Claws";
            itemID = ID;
            itemQuantity = 0;
        }
    }
    public class DinoTail : Item
    {
        readonly public static int ID = 8;
        public DinoTail()
        {
            itemName = "Dino Tail";
            itemID = ID;
            itemQuantity = 0;
        }
    }

    public class HealthPotion : Item
    {
        public HealthPotion()
        {
            itemName = "Health Potion";
            itemQuantity = 0;
        }
    }
    public class Shield : Item
    {
        public Shield()
        {
            itemName = "Shield";
            itemQuantity = 0;
        }
    }
    public class Sword : Item
    {
        public Sword()
        {
            itemName = "Sword";
            itemQuantity = 0;
        }
    }
    public class Bomb : Item
    {
        public Bomb()
        {
            itemName = "Bomb";
            itemQuantity = 0;
        }
    }
    public class IronOre : Item
    {
        public IronOre()
        {
            itemName = "Iron Ore";
            itemQuantity = 0;
        }
    }
    public class MythrilOre : Item
    {
        public MythrilOre()
        {
            itemName = "Mythril Ore";
            itemQuantity = 0;
        }
    }

    public class Items
    {
        public HealthPotion healthPot = new HealthPotion();
        public Sword sword = new Sword();
        public Shield shield = new Shield();
        public Bomb bomb = new Bomb();
    }

    //Recipe class, with every crafting recipe and function for checking the availability and crafting said item, along with unlocking them
    abstract public class Recipe
    {
        private Dictionary<int, int> _recipe;

        public Dictionary<int, int> recipe
        {
            get { return _recipe; }
            set { _recipe = value; }
        }

        public bool isCraftable(ref Podatki p)
        {
            foreach (KeyValuePair<int, int> pair in recipe)
            {
                if (p.inventory.items[pair.Key].itemQuantity < pair.Value)
                {
                    return false;
                }
            }
            return true;
        }

        public void craftItem(ref Podatki p)
        {
            foreach (KeyValuePair<int, int> pair in recipe)
            {
                p.inventory.useItem(pair.Key, pair.Value);
            }

            this.unlock(ref p);
        }

        abstract public void unlock(ref Podatki p);
    }
    
    public class PickleSwordRecipe : Recipe
    {
        public PickleSwordRecipe() 
        {
            recipe = new Dictionary<int, int>()
            {
                { PickleSkin.ID, 2},
                { PickleJuice.ID, 2}
            };
        }

        override public void unlock(ref Podatki p)
        {
            p.weapons.pickleS.isUnlocked = true;
        }
    }
    public class PickleArmorRecipe : Recipe
    {
        public PickleArmorRecipe()
        {
            recipe = new Dictionary<int, int>()
            {
                { PickleSkin.ID, 4},
                { PickleJuice.ID, 1}
            };
        }

        override public void unlock(ref Podatki p)
        {
            p.armors.pickleA.isUnlocked = true;
        }
    }
    public class GoblinSwordRecipe : Recipe
    {
        public GoblinSwordRecipe()
        {
            recipe = new Dictionary<int, int>()
            {
                { GoblinSkull.ID, 3},
                { GoblinHide.ID, 3}
            };
        }

        override public void unlock(ref Podatki p)
        {
            p.weapons.goblinS.isUnlocked = true;
        }
    }
    public class GoblinArmorRecipe : Recipe
    {
        public GoblinArmorRecipe()
        {
            recipe = new Dictionary<int, int>()
            {
                { GoblinSkull.ID, 2},
                { GoblinHide.ID, 5}
            };
        }

        override public void unlock(ref Podatki p)
        {
            p.armors.goblinA.isUnlocked = true;
        }
    }
    public class MonkeArmorRecipe : Recipe
    {
        public MonkeArmorRecipe()
        {
            recipe = new Dictionary<int, int>()
            {
                { MonkeBones.ID, 4},
                { MonkeCarapace.ID, 5}
            };
        }

        override public void unlock(ref Podatki p)
        {
            p.armors.monkeA.isUnlocked = true;
        }
    }
    public class MonkeMalletRecipe : Recipe
    {
        public MonkeMalletRecipe()
        {
            recipe = new Dictionary<int, int>()
            {
                { MonkeBones.ID, 4},
                { MonkeCarapace.ID, 3}
            };
        }

        override public void unlock(ref Podatki p)
        {
            p.weapons.monkeM.isUnlocked = true;
        }
    }
    public class DinoSwordRecipe : Recipe
    {
        public DinoSwordRecipe()
        {
            recipe = new Dictionary<int, int>()
            {
                { DinoTeeth.ID, 3},
                { DinoClaws.ID, 4}
            };
        }

        override public void unlock(ref Podatki p)
        {
            p.weapons.dinoS.isUnlocked = true;
        }
    }
    public class DinoArmorRecipe : Recipe
    {
        public DinoArmorRecipe()
        {
            recipe = new Dictionary<int, int>()
            {
                { DinoTeeth.ID, 4},
                { DinoClaws.ID, 6},
                { DinoTail.ID, 1 }
            };
        }

        override public void unlock(ref Podatki p)
        {
            p.armors.dinoA.isUnlocked = true;
        }
    }

    //Creating the recipes and putting them in Podatki
    public class Recipes
    {
        public PickleSwordRecipe pickleS = new PickleSwordRecipe();
        public PickleArmorRecipe pickleA = new PickleArmorRecipe();
        public GoblinSwordRecipe goblinS = new GoblinSwordRecipe();
        public GoblinArmorRecipe goblinA = new GoblinArmorRecipe();
        public MonkeArmorRecipe monkeA = new MonkeArmorRecipe();
        public MonkeMalletRecipe monkeM = new MonkeMalletRecipe();
        public DinoSwordRecipe dinoS = new DinoSwordRecipe();
        public DinoArmorRecipe dinoA = new DinoArmorRecipe();
    }
}
