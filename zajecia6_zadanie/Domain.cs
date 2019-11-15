using System;

namespace zajecia6
{
    class Domain
    {
        public readonly string Name;

        private DateTime _expirationDate;

        public DateTime ExpirationDate
        {
            get => _expirationDate;
            set => _expirationDate = (value.Date > _expirationDate.Date) ? value.Date : _expirationDate;
        }

        public Domain(string name, DateTime expirationDate)
        {
            Name = name;
            ExpirationDate = expirationDate;
        }
    }
}