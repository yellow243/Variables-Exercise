namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string deviceName = "Xbox";
            int howOld = 2;
            char excited = '!';
            bool valid = true;
            double speed = 150;
            decimal badSpeed = 5.5m;
            Console.WriteLine($"I have a {deviceName} and I've had it for {howOld} years now{excited}. Its {valid}, sometimes it can lag but thats ONLY because my wifi gets like {speed} mbps and sometimes drops to like {badSpeed}.");
        }
    }
}
