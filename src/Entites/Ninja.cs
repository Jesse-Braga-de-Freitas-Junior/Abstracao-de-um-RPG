namespace Projeto___Abstração_de_um_RPG.src.Entites
{
    public class Ninja : Hero
    {
          public Ninja(string Name, int Level, string HeroType)
         {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType; 
         }

        public override string Attack() 
        {
            return this.Name + " Atacando com churiquens";
        }
        public string Attack(int Bonus) 
        {
            if(Bonus > 6) 
            {
                return this.Name + " Ataque especial com super churiken  " + Bonus + " de dano";
            }
            else 
            {
                return this.Name + " Ataque com adagas  " + Bonus + " de dano";
            }
        }
    }
}