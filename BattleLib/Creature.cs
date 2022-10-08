namespace BattleLib
{
    public class Creature
    {
        public Creature()
        {
            this.Name = "Missing";
            this.stats = new Stats();
        }

        public Creature(string Name, Stats stats, Move[] moves)
        {
            this.Name = Name;
            this.stats = stats;
            this.moves = moves;
        }

        public string Name;
        public Stats stats;
        public Move[] moves;
    }

    public class Stats
    {
        public Stats()
        {
            this.HealthPoints = 1;
            this.Attack = 1;
            this.Defense = 1;
            this.Speed = 1;
            this.AttackMagic = 1;
            this.DefenseMagic = 1;
            this.Type = ElementalType.NULL;
        }

        public Stats(int hp, int atk, int def, int spd, int atk_m, int def_m, ElementalType type)
        {
            this.HealthPoints = hp;
            this.Attack = atk;
            this.Defense = def;
            this.Speed = spd;
            this.AttackMagic = atk_m;
            this.DefenseMagic = def_m;
            this.Type = type;
        }

        public int HealthPoints;
        public int Attack;
        public int Defense;
        public ElementalType Type;
        public int AttackMagic;
        public int DefenseMagic;
        public int Speed;
    }
}