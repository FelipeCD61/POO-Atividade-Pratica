using DuckSimulatorImproved.Abstractions;
using DuckSimulatorImproved.Interfaces;

namespace DuckSimulatorImproved.Ducks
{
    public class GhostDuck : Duck, IInvisible
    {
        public static string Variant => "Fantasma";

        public GhostDuck() : base(Variant) { }
        public override string Display() => "Pato Fantasma";

        public void Disappear() => MessageBox.Show(Display() + " desapareceu!");
    }
}
