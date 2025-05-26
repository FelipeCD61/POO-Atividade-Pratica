using System;
using System.Collections.Generic;
using DuckSimulatorImproved.Abstractions;
using DuckSimulatorImproved.Interfaces;

namespace DuckSimulatorImproved.Services
{
    // Padrão Factory para criar patos
    public class DuckFactory
    {
        private static DuckFactory? _instance;
        private Dictionary<string, Func<Duck>> _duckCreators;

        private DuckFactory()
        {
            _duckCreators = new Dictionary<string, Func<Duck>>();
        }

        public static DuckFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DuckFactory();
                }
                return _instance;
            }
        }

        public void RegisterDuck(string duckType, Func<Duck> creator)
        {
            _duckCreators[duckType] = creator;
        }

        public Duck CreateDuck(string duckType)
        {
            if (_duckCreators.ContainsKey(duckType))
            {
                return _duckCreators[duckType]();
            }
            throw new ArgumentException($"Tipo de pato desconhecido: {duckType}");
        }

        public IEnumerable<string> GetAvailableDuckTypes()
        {
            return _duckCreators.Keys;
        }
    }
}
