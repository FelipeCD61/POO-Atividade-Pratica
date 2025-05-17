using System;
using System.Windows.Forms;

namespace PatoForms
{
    public partial class MainForm : Form
    {
        private Duck currentDuck;
        private Action currentAction;

        public MainForm()
        {
            InitializeComponent();
        }

        private void SelectDuck(Duck duck)
        {
            currentDuck = duck;
            habilidadesToolStripMenuItem.DropDownItems.Clear();
            if (duck is IFlyable) habilidadesToolStripMenuItem.DropDownItems.Add("Voo", null, (s, e) => OnAbilitySelected("Voo"));
            if (duck is IQuackable) habilidadesToolStripMenuItem.DropDownItems.Add("Grasnar", null, (s, e) => OnAbilitySelected("Grasnar"));
            if (duck is IDanceable) habilidadesToolStripMenuItem.DropDownItems.Add("Dancar", null, (s, e) => OnAbilitySelected("Dancar"));
            if (duck is IInvisible) habilidadesToolStripMenuItem.DropDownItems.Add("Desaparecer", null, (s, e) => OnAbilitySelected("Desaparecer"));
            lblStatus.Text = "Pato selecionado: " + duck.Display();
            lblAbility.Text = "Nenhuma habilidade selecionada";
        }

        private void OnAbilitySelected(string ability)
        {
            lblAbility.Text = "Habilidade selecionada: " + ability;
            switch (ability)
            {
                case "Voo": currentAction = () => ((IFlyable)currentDuck).Fly(); break;
                case "Grasnar": currentAction = () => ((IQuackable)currentDuck).Quack(); break;
                case "Dancar": currentAction = () => ((IDanceable)currentDuck).Dance(); break;
                case "Desaparecer": currentAction = () => ((IInvisible)currentDuck).Disappear(); break;
                default: currentAction = null; break;
            }
        }

        private void executarAçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentDuck == null)
                MessageBox.Show("Selecione um pato primeiro!");
            else if (currentAction == null)
                MessageBox.Show("Selecione uma habilidade!");
            else
                currentAction();
        }
    }
}
