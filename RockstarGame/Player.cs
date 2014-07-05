namespace Rockstar.Components
{
    public class Player
    {
        public Player()
        {
            this.Health = new PlayerAttribute(0, 100, 75);
            this.Creativity = new PlayerAttribute(0, 100, 75);
            this.Happiness = new PlayerAttribute(0, 100, 75);
            this.Alertness = new PlayerAttribute(0, 100, 75);
        }

        public bool NotDead()
        {
            return Health.CurrentValue > 0;
        }

        public PlayerAttribute Health { get; set; }
        public PlayerAttribute Creativity { get; set; }
        public PlayerAttribute Happiness { get; set; }
        public PlayerAttribute Alertness { get; set; }

        public string Name { get; set; }

        public void Laze()
        {
            //Decrement Creativity
            Creativity.DecrementValue();
            Happiness.IncrementValue(3);
            
        }
    }
}
