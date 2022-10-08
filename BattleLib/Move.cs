namespace BattleLib
{
    public class Move
    {
        public Move()
        {
            this.Type = ElementalType.NULL;
            this.StatType = StatType.NULL;
            this.Strength = 1;
        }

        public Move(ElementalType type, StatType statType, int strength)
        {
            this.Type = type;
            this.StatType = statType;
            this.Strength = strength;
        }

        public ElementalType Type;
        public StatType StatType;
        public int Strength;

        public void PreDamageCalc()
        {
        }

        public void PostDamageCalc()
        {
        }
    }
}