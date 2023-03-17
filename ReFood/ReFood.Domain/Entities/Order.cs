using ReFood.Domain.Validation;

namespace ReFood.Domain.Entities
{
    public sealed class Order : Entity
    {
        public struct ProductOrder {
            public int amount;
            public Product product;
            public double price;
        }

        public int StoreId { get;  set; }
        public Store Store { get;  set; }

        public int ProtagonistId { get; set; }
        public Protagonist Protagonist { get; set; }

        public ICollection<ProductOrder> Products { get; private set; }

        public Order(Store store, Protagonist protagonist, ICollection<ProductOrder> products) {
            ValidateDomain(store, protagonist, products);
            Store = store;
            Protagonist = protagonist;
            Products = products;
        }

        void ValidateDomain(Store store, Protagonist protagonist, ICollection<ProductOrder> products) {
            DomainExceptionValidation.When(store == null || store.Id < 0,
                "A valid store must be provided!");

            DomainExceptionValidation.When(protagonist == null || protagonist.Id < 0,
                "A valid protagonist must be provided!");

            DomainExceptionValidation.When(products == null || products.Count == 0,
                "An order must have one product at least!");

            foreach(var product in products) {
                DomainExceptionValidation.When(product.amount <= 0,
                    "A product order must be one or more!");
            }
            
        }
    }
}
