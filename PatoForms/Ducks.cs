using System;
using System.Windows.Forms;

namespace PatoForms
{
    public abstract class Duck
    {
        public string Name { get; }
        public Duck(string name) => Name = name;
        public void Swim() => MessageBox.Show(Name + " está nadando!");
        public abstract string Display();
    }

    public interface IFlyable { void Fly(); }
    public interface IQuackable { void Quack(); }
    public interface IDanceable { void Dance(); }
    public interface IInvisible { void Disappear(); }

    public class MallardDuck : Duck, IFlyable, IQuackable
    {
        public MallardDuck() : base("Mallard") { }
        public override string Display() => "Pato Mallard";
        public void Fly() => MessageBox.Show(Display() + " voando!");
        public void Quack() => MessageBox.Show(Display() + " grasnando!");
    }

    public class RedheadDuck : Duck, IFlyable, IQuackable
    {
        public RedheadDuck() : base("Redhead") { }
        public override string Display() => "Pato Redhead";
        public void Fly() => MessageBox.Show(Display() + " voando!");
        public void Quack() => MessageBox.Show(Display() + " grasnando!");
    }

    public class RubberDuck : Duck, IQuackable
    {
        public RubberDuck() : base("Rubber") { }
        public override string Display() => "Pato de Borracha";
        public void Quack() => MessageBox.Show(Display() + " faz squeak!");
    }

    public class DecoyDuck : Duck
    {
        public DecoyDuck() : base("Decoy") { }
        public override string Display() => "Pato de Madeira";
    }

    public class WoodenDuck : Duck, IQuackable, IDanceable
    {
        public WoodenDuck() : base("Wooden") { }
        public override string Display() => "Pato de Madeira Especial";
        public void Quack() => MessageBox.Show(Display() + " grasnando!");
        public void Dance() => MessageBox.Show(Display() + " está dançando!");
    }

    public class GoldenDuck : Duck, IFlyable, IQuackable, IDanceable
    {
        public GoldenDuck() : base("Golden") { }
        public override string Display() => "Pato Dourado";
        public void Fly() => MessageBox.Show(Display() + " voando alto!");
        public void Quack() => MessageBox.Show(Display() + " grasnando luxuosamente!");
        public void Dance() => MessageBox.Show(Display() + " está dançando majestosamente!");
    }

    public class GhostDuck : Duck, IInvisible
    {
        public GhostDuck() : base("Ghost") { }
        public override string Display() => "Pato Fantasma";
        public void Disappear() => MessageBox.Show(Display() + " desapareceu!");
    }
}
