using DuckSimulatorImproved.Abstractions;
using DuckSimulatorImproved.Interfaces;

namespace DuckSimulatorImproved.Ducks
{
    public class RubberDuck : Duck, IQuackable
    {
        public static string Variant => "Borracha";

        public RubberDuck() : base(Variant) { }

        public override string Display() => "Pato de Borracha";

        public string Quack() => Display() + " faz squeak!";
    }
}
