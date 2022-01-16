namespace Projeto___Abstração_de_um_RPG.src.Entites
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType)
         {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType; 
         }

        public override string Attack() 
        {
            return this.Name + " Atacando com Espada";
        }
         public string Attack(int Bonus) 
        {
            if(Bonus > 6) 
            {
                return this.Name + " Ataque especial sete espadas do poder com bonus de  " + Bonus + " de dano";
            }
            else 
            {
                return this.Name + " Ataque frontal de espada simples " + Bonus + " de dano";
            }
        }
    }
}