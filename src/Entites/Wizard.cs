namespace Projeto___Abstração_de_um_RPG.src.Entites
{
    public class Wizard : Hero
    {
                 public Wizard(string Name, int Level, string HeroType)
         {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType; 
         }

        public override string Attack() 
        {
            return this.Name + " Atacando com magia";
        }
        public string Attack(int Bonus) 
        {
            if(Bonus > 6) 
            {
                return this.Name + " Ataque especial de magia com bonus de " + Bonus + " de dano ";
            }
            else 
            {
                return this.Name + " Ataque de magia leve de " + Bonus + " de dano";
            }
        }
    }
}