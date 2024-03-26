namespace SerializationLab
{
    class Event
    {
        public int eventNumber { get; set; }
        public string location { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var evnt = new Event();
            string[] toSave = [evnt.eventNumber.ToString(), evnt.location];
            File.WriteAllText("./events.txt", string.Join(",", toSave));
            var data = File.ReadAllLines("./events.txt");
            foreach (var line in data)
            {
                var raw = line.Split(",");
                var evt = new Event {
                    eventNumber = int.Parse(raw[0]),
                    location = raw[1] };
                Console.WriteLine(evt.eventNumber);
                Console.WriteLine(evt.location);
            }
            ReadFromFile();
        }

        static void ReadFromFile()
        {
            Console.WriteLine("Tech Competition");
            Console.WriteLine("In Word: Hackathon");
            File.WriteAllText("./data.txt", "Hackathon");
            var data = File.ReadAllText("./data.txt");
            Console.WriteLine(data[0]);
            Console.WriteLine(data[(data.Length-1)/2]);
            Console.WriteLine(data[data.Length-1]);
        }
    }
}
