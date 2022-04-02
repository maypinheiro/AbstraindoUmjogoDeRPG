namespace AbstraindoUmjogoDeRPG.src.Entities
{
    public abstract class Hero {
     public string Name { get; set; }   
     public int Level { get; set; }
     public string HeroType;

      
        public Hero(string name, int level, string heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
        }
        public  virtual string Attack(){
            return Name +" Atacou ...";
        }

        public override string ToString()
        {
            return Name + " " + Level +" "+ HeroType;
        }

    }
}