namespace zajecia6
{
    class Server
    {
        public int ProcessorSpeed { get; private set; }
        public double Bandwidth { get; private set; }
        public int Ram { get; private set; }
        public string TechnologyUsed { get; private set; }

        public Server(int processorSpeed, double bandwidth, int ram, string technologyUsed)
        {
            ProcessorSpeed = processorSpeed;
            Bandwidth = bandwidth;
            Ram = ram;
            TechnologyUsed = technologyUsed;
        }
    }
}