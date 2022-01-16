namespace Projeto___Abstração_de_um_RPG.src.Entites
{
    public class Archer : Hero
    {
        public Archer(string Name, int Level, string HeroType)
         {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType; 
         }

        public override string Attack() 
        {
            return this.Name + " Atacando com Arcos";
        }
        public string Attack(int Bonus) 
        {
            if(Bonus > 6) 
            {
                return this.Name + " Ataque especial flechas envenenadas " + Bonus + " de dano";
            }
            else 
            {
                return this.Name + " Ataque com flechas simples " + Bonus +  " de dano";
            }
        }
    }
}