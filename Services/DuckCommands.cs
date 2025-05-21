using System;
using System.Collections.Generic;
using DuckSimulatorImproved.Abstractions;
using DuckSimulatorImproved.Interfaces;

namespace DuckSimulatorImproved.Services
{
    // Padrão Command para encapsular ações dos patos
    public interface IDuckCommand
    {
        string Name { get; }
        void Execute();
        bool CanExecute(Duck duck);
    }

    public class FlyCommand : IDuckCommand
    {
        private readonly IFlyable _flyable;

        public FlyCommand(IFlyable flyable)
        {
            _flyable = flyable;
        }

        public string Name => "Voo";

        public bool CanExecute(Duck duck)
        {
            return duck is IFlyable;
        }

        public void Execute()
        {
            _flyable.Fly();
        }
    }

    public class QuackCommand : IDuckCommand
    {
        private readonly IQuackable _quackable;

        public QuackCommand(IQuackable quackable)
        {
            _quackable = quackable;
        }

        public string Name => "Grasnar";

        public bool CanExecute(Duck duck)
        {
            return duck is IQuackable;
        }

        public void Execute()
        {
            _quackable.Quack();
        }
    }

    public class DanceCommand : IDuckCommand
    {
        private readonly IDanceable _danceable;

        public DanceCommand(IDanceable danceable)
        {
            _danceable = danceable;
        }

        public string Name => "Dancar";

        public bool CanExecute(Duck duck)
        {
            return duck is IDanceable;
        }

        public void Execute()
        {
            _danceable.Dance();
        }
    }

    public class DisappearCommand : IDuckCommand
    {
        private readonly IInvisible _invisible;

        public DisappearCommand(IInvisible invisible)
        {
            _invisible = invisible;
        }

        public string Name => "Desaparecer";

        public bool CanExecute(Duck duck)
        {
            return duck is IInvisible;
        }

        public void Execute()
        {
            _invisible.Disappear();
        }
    }

    public class SwimCommand : IDuckCommand
    {
        private readonly Duck _duck;

        public SwimCommand(Duck duck)
        {
            _duck = duck;
        }

        public string Name => "Nadar";

        public bool CanExecute(Duck duck)
        {
            return true; // Todos os patos podem nadar
        }

        public void Execute()
        {
            _duck.Swim();
        }
    }
}
