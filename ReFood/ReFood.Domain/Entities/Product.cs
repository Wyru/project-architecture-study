using ReFood.Domain.Validation;

namespace ReFood.Domain.Entities
{
    public sealed class Product : Entity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public double Price { get; private set; }
        public int StoreId { get; set; }
        public Store Store { get; set; }

        public Product(string name, string description, double price, Store store) {

            ValidateDomain(name, description, price, store);

            Name = name;
            Description = description;
            Price = price;
            Store = store;

        }


        void ValidateDomain(string name, string description, double price, Store store) {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name),
                "A name must be provided!");

            DomainExceptionValidation.When(string.IsNullOrEmpty(description),
                "A desciption must be provided!");

            DomainExceptionValidation.When(price < 0,
                "The price cannot be negative!");

            DomainExceptionValidation.When(name.Length < 5,
                "The name must be at least 5 characters long ");

            DomainExceptionValidation.When(description.Length > 144,
                "No one will read more than 144 characters");

            DomainExceptionValidation.When(store == null || store.Id < 0,
                "A valid store must be provided!");
        }
    }
}
