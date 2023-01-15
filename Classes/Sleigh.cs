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

        public double weight = 0.0, volume = 0.0;
        List<Gift> gifts = new List<Gift>();
        public Sleigh() {}

        public Sleigh(string sleighName, double maxVolume, double maxWeight)
        {
            this.sleighName = sleighName;
            this.maxVolume = maxVolume;
            this.maxWeight = maxWeight;
        }

        public bool AddGift(Gift gift)
        {
            if (volume + gift.volume > maxVolume || weight + gift.weight > maxWeight)
            {
                Console.WriteLine("Il regalo non può stare nella slitta");
                return false;
            }
            else
            {
                gifts.Add(gift);
                volume += gift.volume;
                weight += gift.weight;
                return true;
            }
            
        }
    }
}