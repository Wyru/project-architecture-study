
using ReFood.Domain.Validation;

namespace ReFood.Domain.Entities
{
    public enum Archetype
    {
        None,
        AlerEgo,
        Archer,
        Assassin,
        Avanger,
        Berserk,
        Caster,
        Foreigner,
        Lancer,
        MoonCancer,
        Pretender,
        Rider,
        Ruler,
        Saber,
        Shielder
    }


    public sealed class Protagonist : Entity
    {

        public string Name { get; private set; }
        public Archetype Archetype { get; private set; }
        public string VeryLongIsekaiTitle { get; private set; }

        public Protagonist(string name, Archetype archetype,string veryLongIsekaiTitle) {

            ValidateDomain(name, veryLongIsekaiTitle);

            Name = name;
            Archetype = archetype;
            VeryLongIsekaiTitle = veryLongIsekaiTitle;
        }

        void ValidateDomain(string name, string veryLongIsekaiTitle) {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name),
                "A name must be provided!");

            DomainExceptionValidation.When(veryLongIsekaiTitle.Length < 15,
                "The very long isekai title must be at least 15 characters long ");
        }
    }
}
