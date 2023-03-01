namespace OrderGenerator.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client(string name, string email, DateTime birthdate)
        {
            Name = name;
            Email = email;
            BirthDate = birthdate;
        }

        public override string ToString()
        {
            return $"{Name}, {BirthDate.ToString("MM/dd/yyyy")} - {Email}";
        }
    }
}
