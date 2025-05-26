using DuckSimulatorImproved.Abstractions;
using DuckSimulatorImproved.Interfaces;

namespace DuckSimulatorImproved.Ducks
{
    public class RedheadDuck : Duck, IFlyable, IQuackable
    {
        public static string Variant => "Ruivo";

        public RedheadDuck() : base(Variant) { }

        public override string Display() => "Pato Ruivo";

        public string Fly() => Display() + " voando!";

        public string Quack() => Display() + " grasnando!";
    }
}
