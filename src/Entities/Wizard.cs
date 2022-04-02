namespace AbstraindoUmjogoDeRPG.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType) : base(name, level, heroType)
        {
        }

        public  override string Attack(){
            return Name +" Lançou MAGIA ...";
        }

          public   string Attack(int bonus){
              if (bonus>6) {
                return Name +" Lançou  muita MAGIA ..." + bonus;
              }  else{
                 return Name +" Lançou  pouca MAGIA ..." + bonus;
              }
        }
    }
}