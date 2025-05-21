using DuckSimulatorImproved.Abstractions;
using DuckSimulatorImproved.Interfaces;

namespace DuckSimulatorImproved.Ducks
{
    public class GoldenDuck : Duck, IFlyable, IQuackable, IDanceable
    {
        public static string Variant => "Dourado";

        public GoldenDuck() : base(Variant) { }

        public override string Display() => "Pato Dourado";

        public void Fly() => MessageBox.Show(Display() + " voando alto!");

        public void Quack() => MessageBox.Show(Display() + " grasnando luxuosamente!");

        public void Dance() => MessageBox.Show(Display() + " está dançando majestosamente!");
    }
}
