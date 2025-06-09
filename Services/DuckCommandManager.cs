using DuckSimulatorImproved.Abstractions;
using DuckSimulatorImproved.Interfaces;

namespace DuckSimulatorImproved.Services
{
    // Serviço para gerenciar comandos disponíveis para cada pato
    public class DuckCommandManager
    {
        private static DuckCommandManager? _instance;

        public static DuckCommandManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DuckCommandManager();
                }
                return _instance;
            }
        }

        public List<IDuckCommand> GetAvailableCommands(Duck duck)
        {
            // Lista de todos os comandos possíveis
            var allCommands = new List<IDuckCommand>
            {
                new FlyCommand(duck as IFlyable),
                new QuackCommand(duck as IQuackable),
                new DanceCommand(duck as IDanceable),
                new DisappearCommand(duck as IInvisible)
            };

            // Retorna somente os comandos aplicáveis ao pato
            return [..allCommands
                .Where(cmd => cmd.CanExecute(duck))
                .ToList(),new SwimCommand(duck)];
        }
    }
}
