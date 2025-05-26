using DuckSimulatorImproved.Abstractions;

namespace DuckSimulatorImproved.Ducks
{
    public class DecoyDuck : Duck
    {
        public static string Variant => "Madeira";

        public DecoyDuck() : base(Variant) { }
        public override string Display() => "Pato de Madeira";
    }
}
