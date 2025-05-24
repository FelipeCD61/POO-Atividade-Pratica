using DuckSimulatorImproved.Abstractions;
using DuckSimulatorImproved.Interfaces;

namespace DuckSimulatorImproved.Ducks
{
    public class GoldenDuck : Duck, IFlyable, IQuackable, IDanceable
    {
        public static string Variant => "Dourado";

        public GoldenDuck() : base(Variant) { }

        public override string Display() => "Pato Dourado";

        public string Fly() => Display() + " voando alto!";

        public string Quack() => Display() + " grasnando luxuosamente!";

        public string Dance() => Display() + " está dançando majestosamente!";
    }
}
