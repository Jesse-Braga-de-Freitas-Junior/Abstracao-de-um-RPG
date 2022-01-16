namespace Projeto___Abstração_de_um_RPG.src.Entites
{
    public class Pupil : Hero
    {
        public Pupil(string Name, int Level, string HeroType) 
         {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType; 
         }
         public override string Attack() 
        {
            return this.Name + " Atacando com espada e magia";
        }
         public string Attack(int Bonus) 
        {
            if(Bonus > 6) 
            {
                return this.Name + " Ataque especial espada mágica acomanhada de adagas flamejantes " + Bonus + " de dano";
            }
            else 
            {
                return this.Name + " Ataque com adagas flamejantes de  " + Bonus + " de dano ";
            }
        }
    }
}