
using DuckSimulatorImproved.Ducks;

namespace DuckSimulatorImproved
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem patosToolStripMenuItem;
        private ToolStripMenuItem mallardToolStripMenuItem;
        private ToolStripMenuItem redheadToolStripMenuItem;
        private ToolStripMenuItem rubberToolStripMenuItem;
        private ToolStripMenuItem decoyToolStripMenuItem;
        private ToolStripMenuItem woodenToolStripMenuItem;
        private ToolStripMenuItem goldenToolStripMenuItem;
        private ToolStripMenuItem ghostToolStripMenuItem;

        private Label lblStatus;
        private Label lblAbility;
        private Label lblAction;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new MenuStrip();
            this.patosToolStripMenuItem = new ToolStripMenuItem();
            this.mallardToolStripMenuItem = new ToolStripMenuItem();
            this.redheadToolStripMenuItem = new ToolStripMenuItem();
            this.rubberToolStripMenuItem = new ToolStripMenuItem();
            this.decoyToolStripMenuItem = new ToolStripMenuItem();
            this.woodenToolStripMenuItem = new ToolStripMenuItem();
            this.goldenToolStripMenuItem = new ToolStripMenuItem();
            this.ghostToolStripMenuItem = new ToolStripMenuItem();
            this.lblStatus = new Label();
            this.lblAbility = new Label();
            this.lblAction = new Label();
            this.SuspendLayout();
            // menuStrip1
            this.menuStrip1.Items.AddRange(new ToolStripItem[] { this.patosToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.BackColor = Color.FromArgb(0, 122, 204);

            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            // patosToolStripMenuItem
            this.patosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.mallardToolStripMenuItem, this.redheadToolStripMenuItem, this.rubberToolStripMenuItem, this.decoyToolStripMenuItem, this.woodenToolStripMenuItem, this.goldenToolStripMenuItem, this.ghostToolStripMenuItem });
            this.patosToolStripMenuItem.Name = "patosToolStripMenuItem";
            this.patosToolStripMenuItem.Text = "Patos";
            // mallardToolStripMenuItem
            this.mallardToolStripMenuItem.Name = "mallardToolStripMenuItem";
            this.mallardToolStripMenuItem.Text = MallardDuck.Variant;
            this.mallardToolStripMenuItem.Click += (s, e) => SelectDuck(MallardDuck.Variant);
            // redheadToolStripMenuItem
            this.redheadToolStripMenuItem.Name = "redheadToolStripMenuItem";
            this.redheadToolStripMenuItem.Text = RedheadDuck.Variant;
            this.redheadToolStripMenuItem.Click += (s, e) => SelectDuck(RedheadDuck.Variant);
            // rubberToolStripMenuItem
            this.rubberToolStripMenuItem.Name = "rubberToolStripMenuItem";
            this.rubberToolStripMenuItem.Text = RubberDuck.Variant;
            this.rubberToolStripMenuItem.Click += (s, e) => SelectDuck(RubberDuck.Variant);
            // decoyToolStripMenuItem
            this.decoyToolStripMenuItem.Name = "decoyToolStripMenuItem";
            this.decoyToolStripMenuItem.Text = DecoyDuck.Variant;
            this.decoyToolStripMenuItem.Click += (s, e) => SelectDuck(DecoyDuck.Variant);
            // goldenToolStripMenuItem
            this.goldenToolStripMenuItem.Name = "goldenToolStripMenuItem";
            this.goldenToolStripMenuItem.Text = GoldenDuck.Variant;
            this.goldenToolStripMenuItem.Click += (s, e) => SelectDuck(GoldenDuck.Variant);
            // ghostToolStripMenuItem
            this.ghostToolStripMenuItem.Name = "ghostToolStripMenuItem";
            this.ghostToolStripMenuItem.Text = GhostDuck.Variant;
            this.ghostToolStripMenuItem.Click += (s, e) => SelectDuck(GhostDuck.Variant);

            // lblStatus
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            this.lblStatus.Location = new Point(12, 40);
            this.lblStatus.Text = "Nenhum pato selecionado";
            // lblAbility
            this.lblAbility.AutoSize = true;
            this.lblAbility.Font = new Font("Segoe UI", 10);
            this.lblAbility.Location = new Point(12, 70);
            this.lblAbility.Text = "Nenhuma habilidade selecionada";
            // lblAction
            this.lblAction.AutoSize = true;
            this.lblAction.Font = new Font("Segoe UI", 10);
            this.lblAction.Location = new Point(12, 90);
            this.lblAction.Text = "O pato está paradinho";
            // MainForm
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAbility);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblAction);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Simulador de Patos";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
