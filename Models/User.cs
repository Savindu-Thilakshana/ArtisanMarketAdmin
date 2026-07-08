using System;

namespace ArtisanMarketAdmin.Models
{
    public class User
    {
        private string _name;
        private string _email;
        private string _contact;
        private string _status;

        public User(string name, string email, string contact, string status)
        {
            Name = name;
            Email = email;
            Contact = contact;
            _status = status;
        }

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty.");
                _name = value;
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || !value.Contains("@"))
                    throw new ArgumentException("A valid email is required.");
                _email = value;
            }
        }

        public string Contact
        {
            get => _contact;
            set => _contact = value;
        }

        public string Status
        {
            get => _status;
            protected set => _status = value;
        }

        public override string ToString()
        {
            return $"{_name} ({_email}) - {_status}";
        }
    }
}