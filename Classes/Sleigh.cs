namespace Classes
{
    public class Sleigh
    {
        private string sleighName;
        private double maxVolume;
        private double maxWeight; 
        private double weight = 0.0, volume = 0.0;
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

        public void ShowContent()
        {
            Console.WriteLine($"Ecco la lista dei regali nella lista \"{sleighName}\"");
            foreach(Gift gift in gifts)
            {
                Console.WriteLine($"Nome: {gift.name} - Colore: {gift.color} - Peso: {gift.weight} - Volume {gift.volume}");
            }
        }
    }
}