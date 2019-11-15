using System;

namespace zajecia6
{
    public class Website
    {
        private Domain _domain;
        private Server _server;

        public Website(
            string domainName, DateTime expirationDate, int processorSpeed, double bandwidth, int ram,
            string technologyUsed
            )
        {
            _domain = new Domain(domainName, expirationDate);
            _server = new Server(processorSpeed, bandwidth, ram, technologyUsed);
        }

        public void SetNewExpirationDate(DateTime newDate)
        {
            _domain.ExpirationDate = newDate;
        }

        public void GetServerParams()
        {
            Console.Write(
                "Szybkosc procesora: " + _server.ProcessorSpeed + "\n" +
                "Przepustowosc lacza: " + _server.Bandwidth + "\n" +
                "Pojemnosc pamieci RAM: " + _server.Ram + "\n" +
                "Uzyta technologia: " + _server.TechnologyUsed
                );
        }
    }
}