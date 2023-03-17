using ReFood.Domain.Validation;

namespace ReFood.Domain.Entities
{
    public sealed class Store : Entity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Specialty { get; private set; }
        public string City { get; private set; }

        public ICollection<Product>? Products { get; private set; }

        public Store(string name, string description, string specialty, string city) {
            
            ValidateDomain(name, description, specialty, city);

            Name = name;
            Description = description;
            Specialty = specialty;
            City = city;
        }


        void ValidateDomain(string name, string description, string specialty, string city) {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name),
                "A name must be provided!");

            DomainExceptionValidation.When(string.IsNullOrEmpty(description),
                "A desciption must be provided!");

            DomainExceptionValidation.When(string.IsNullOrEmpty(specialty),
                "A city must be provided!");

            DomainExceptionValidation.When(string.IsNullOrEmpty(city),
                "A specialty must be provided!");

            DomainExceptionValidation.When(name.Length < 5,
                "The name must be at least 5 characters long ");

            DomainExceptionValidation.When(description.Length > 144,
                "No one will read more than 144 characters");

        }
    }
}
