namespace BattleLib
{
    public class Creature
    {
        public string Name;
        public Stats stats;
        public Move[] moves;
    }

    public struct Stats
    {
        public int HealthPoints;
        public int Attack;
        public int Defense;
        public Type Type;
        public int AttackMagic;
        public int DefenseMagic;
        public int Speed;
    }
}