using DuckSimulatorImproved.Abstractions;
using DuckSimulatorImproved.Ducks;
using DuckSimulatorImproved.Services;

namespace DuckSimulatorImproved
{
    public partial class MainForm : Form
    {
        private Duck currentDuck;
        private IDuckCommand currentCommand;
        private readonly DuckFactory duckFactory;
        private readonly DuckCommandManager commandManager;
        private readonly PictureBox duckImageBox;
        private readonly Panel actionPanel;
        private readonly Button executeButton;

        private readonly string resourcesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");

        // Display name to image filename mapping
        private readonly Dictionary<string, string> duckImages = new()
        {
            { "Pato-real", "mallard_duck.png" },
            { "Ruivo", "redhead_duck.png" },
            { "Borracha", "rubber_duck.png" },
            { "Madeira", "decoy_duck.png" },
            { "Dourado", "golden_duck.png" },
            { "Fantasma", "ghost_duck.png" }
        };

        // Display name to duck variant key mapping
        private readonly Dictionary<string, string> displayNameToVariant = new()
        {
            { "Pato-real", MallardDuck.Variant },
            { "Ruivo", RedheadDuck.Variant },
            { "Borracha", RubberDuck.Variant },
            { "Madeira", DecoyDuck.Variant },
            { "Dourado", GoldenDuck.Variant },
            { "Fantasma", GhostDuck.Variant }
        };

        public MainForm()
        {
            InitializeComponent();

            duckFactory = DuckFactory.Instance;
            RegisterDucks();

            commandManager = DuckCommandManager.Instance;

            ConfigureDuckMenu();

            this.BackColor = Color.FromArgb(240, 240, 240);
            this.Text = "Simulador de Patos";
            this.Size = new Size(800, 600);
            this.MinimumSize = new Size(640, 480);

            var mainPanel = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(20)
            };
            this.Controls.Add(mainPanel);

            var infoPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 60,
                Padding = new Padding(10)
            };
            mainPanel.Controls.Add(infoPanel);

            var displayPanel = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(10)
            };
            mainPanel.Controls.Add(displayPanel);

            duckImageBox = new PictureBox
            {
                Size = new Size(300, 300),
                Location = new Point(150, 150),
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.Transparent,
                BackgroundImage = Image.FromFile(Path.Combine(resourcesPath, "lake_background.png"))
            };
            displayPanel.Controls.Add(duckImageBox);

            actionPanel = new Panel
            {
                Dock = DockStyle.Right,
                Width = 200,
                Padding = new Padding(10),
                BackColor = Color.FromArgb(230, 230, 230)
            };
            displayPanel.Controls.Add(actionPanel);

            executeButton = new Button
            {
                Text = "Executar Ação",
                Dock = DockStyle.Bottom,
                Height = 40,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                BackColor = Color.FromArgb(0, 122, 204),
                ForeColor = Color.White,
                Enabled = false
            };
            executeButton.Click += ExecuteButton_Click;
            actionPanel.Controls.Add(executeButton);
        }

        private void RegisterDucks()
        {
            duckFactory.RegisterDuck(MallardDuck.Variant, () => new MallardDuck());
            duckFactory.RegisterDuck(RedheadDuck.Variant, () => new RedheadDuck());
            duckFactory.RegisterDuck(RubberDuck.Variant, () => new RubberDuck());
            duckFactory.RegisterDuck(DecoyDuck.Variant, () => new DecoyDuck());
            duckFactory.RegisterDuck(GoldenDuck.Variant, () => new GoldenDuck());
            duckFactory.RegisterDuck(GhostDuck.Variant, () => new GhostDuck());
        }

        private void ConfigureDuckMenu()
        {
            patosToolStripMenuItem.DropDownItems.Clear();

            foreach (var displayName in displayNameToVariant.Keys)
            {
                var menuItem = new ToolStripMenuItem(displayName);
                menuItem.Click += (s, e) => SelectDuck(displayName);
                patosToolStripMenuItem.DropDownItems.Add(menuItem);
            }
        }

        private void SelectDuck(string displayName)
        {
            try
            {
                if (!displayNameToVariant.TryGetValue(displayName, out var variantKey))
                {
                    MessageBox.Show("Tipo de pato desconhecido: " + displayName);
                    return;
                }

                currentDuck = duckFactory.CreateDuck(variantKey);
                UpdateDuckImage(displayName);
                UpdateCommandMenu();

                lblStatus.Text = "Pato selecionado: " + currentDuck.Display();
                lblAbility.Text = "Nenhuma habilidade selecionada";
                currentCommand = null;
                executeButton.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao selecionar pato: {ex.Message}");
            }
        }

        private void UpdateDuckImage(string displayName)
        {
            try
            {
                if (duckImages.TryGetValue(displayName, out var imageName))
                {
                    string imagePath = Path.Combine(resourcesPath, imageName);
                    if (File.Exists(imagePath))
                    {
                        using var stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
                        duckImageBox.Image = Image.FromStream(stream);
                    }
                    else
                    {
                        duckImageBox.Image = null;
                    }
                }
                else
                {
                    duckImageBox.Image = null;
                }
            }
            catch
            {
                duckImageBox.Image = null;
            }
        }

        private void UpdateCommandMenu()
        {
            // Remove everything and re-add only the executeButton
            actionPanel.Controls.Clear();

            // Re-add the execute button to the bottom
            actionPanel.Controls.Add(executeButton);
            executeButton.Dock = DockStyle.Bottom;
            executeButton.Enabled = false;

            // Get available commands
            var commands = commandManager.GetAvailableCommands(currentDuck);

            // Add radio buttons for each command
            int yPos = 20;
            foreach (var command in commands)
            {
                var current = command; // Fix closure issue

                var radioButton = new RadioButton
                {
                    Text = current.Name,
                    Location = new Point(10, yPos),
                    Width = 150,
                    Font = new Font("Segoe UI", 9)
                };

                radioButton.CheckedChanged += (s, e) =>
                {
                    if (radioButton.Checked)
                    {
                        SelectCommand(current);
                    }
                };

                actionPanel.Controls.Add(radioButton);
                yPos += 30;
            }
        }

        private void SelectCommand(IDuckCommand command)
        {
            currentCommand = command;
            lblAbility.Text = "Habilidade selecionada: " + command.Name;
            executeButton.Enabled = true;
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            ExecuteCurrentAction();
        }

        private void executarAçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecuteCurrentAction();
        }

        private void ExecuteCurrentAction()
        {
            if (currentDuck == null)
            {
                MessageBox.Show("Selecione um pato primeiro!");
            }
            else if (currentCommand == null)
            {
                MessageBox.Show("Selecione uma habilidade!");
            }
            else
            {
                currentCommand.Execute();
            }
        }
    }
}
