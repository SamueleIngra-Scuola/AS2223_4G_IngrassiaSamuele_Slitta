namespace Classes
{
    public class Sleigh
    {
        public string sleighName
        {
            get
            {
                return sleighName;
            }
            set
            {
                sleighName = value;
            }
        }
        public double maxVolume
        {
            get
            {
                return maxVolume;
            }
            set
            {
                maxVolume = value;
            }
        }
        public double maxWeight
        {
            get
            {
                return maxWeight;
            }
            set
            {
                maxWeight = value;
            }
        }
        List<Gift> gifts = new List<Gift>();
        public Sleigh() {}

        public Sleigh(string sleighName, double maxVolume, double maxWeight)
        {
            this.sleighName = sleighName;
            this.maxVolume = maxVolume;
            this.maxWeight = maxWeight;
        }
    }
}