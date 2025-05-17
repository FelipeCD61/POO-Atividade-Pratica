using System;
using System.Windows.Forms;
namespace PatoForms
{
    partial class MainForm : Form
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem patosToolStripMenuItem;
        private ToolStripMenuItem selecionarToolStripMenuItem;
        private ToolStripMenuItem mallardToolStripMenuItem;
        private ToolStripMenuItem redheadToolStripMenuItem;
        private ToolStripMenuItem rubberToolStripMenuItem;
        private ToolStripMenuItem decoyToolStripMenuItem;
        private ToolStripMenuItem woodenToolStripMenuItem;
        private ToolStripMenuItem goldenToolStripMenuItem;
        private ToolStripMenuItem ghostToolStripMenuItem;
        private ToolStripMenuItem habilidadesToolStripMenuItem;
        private ToolStripMenuItem executarAçãoToolStripMenuItem;
        private Label lblStatus;
        private Label lblAbility;

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
            this.selecionarToolStripMenuItem = new ToolStripMenuItem();
            this.mallardToolStripMenuItem = new ToolStripMenuItem();
            this.redheadToolStripMenuItem = new ToolStripMenuItem();
            this.rubberToolStripMenuItem = new ToolStripMenuItem();
            this.decoyToolStripMenuItem = new ToolStripMenuItem();
            this.woodenToolStripMenuItem = new ToolStripMenuItem();
            this.goldenToolStripMenuItem = new ToolStripMenuItem();
            this.ghostToolStripMenuItem = new ToolStripMenuItem();
            this.habilidadesToolStripMenuItem = new ToolStripMenuItem();
            this.executarAçãoToolStripMenuItem = new ToolStripMenuItem();
            this.lblStatus = new Label();
            this.lblAbility = new Label();
            this.SuspendLayout();
            // menuStrip1
            this.menuStrip1.Items.AddRange(new ToolStripItem[] { this.patosToolStripMenuItem, this.habilidadesToolStripMenuItem, this.executarAçãoToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            // patosToolStripMenuItem
            this.patosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.selecionarToolStripMenuItem });
            this.patosToolStripMenuItem.Name = "patosToolStripMenuItem";
            this.patosToolStripMenuItem.Text = "Patos";
            // selecionarToolStripMenuItem
            this.selecionarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.mallardToolStripMenuItem, this.redheadToolStripMenuItem, this.rubberToolStripMenuItem, this.decoyToolStripMenuItem, this.woodenToolStripMenuItem, this.goldenToolStripMenuItem, this.ghostToolStripMenuItem });
            this.selecionarToolStripMenuItem.Name = "selecionarToolStripMenuItem";
            this.selecionarToolStripMenuItem.Text = "Selecionar";
            // mallardToolStripMenuItem
            //this.mallardToolStripMenuItem.Name = "mallardToolStripMenuItem";
            //this.mallardToolStripMenuItem.Text = "Mallard";
            //this.mallardToolStripMenuItem.Click += (s, e) => SelectDuck(new MallardDuck());
            //// redheadToolStripMenuItem
            //this.redheadToolStripMenuItem.Name = "redheadToolStripMenuItem";
            //this.redheadToolStripMenuItem.Text = "Redhead";
            //this.redheadToolStripMenuItem.Click += (s, e) => SelectDuck(new RedheadDuck());
            //// rubberToolStripMenuItem
            //this.rubberToolStripMenuItem.Name = "rubberToolStripMenuItem";
            //this.rubberToolStripMenuItem.Text = "Rubber";
            //this.rubberToolStripMenuItem.Click += (s, e) => SelectDuck(new RubberDuck());
            //// decoyToolStripMenuItem
            //this.decoyToolStripMenuItem.Name = "decoyToolStripMenuItem";
            //this.decoyToolStripMenuItem.Text = "Decoy";
            //this.decoyToolStripMenuItem.Click += (s, e) => SelectDuck(new DecoyDuck());
            //// woodenToolStripMenuItem
            //this.woodenToolStripMenuItem.Name = "woodenToolStripMenuItem";
            //this.woodenToolStripMenuItem.Text = "Wooden";
            //this.woodenToolStripMenuItem.Click += (s, e) => SelectDuck(new WoodenDuck());
            //// goldenToolStripMenuItem
            //this.goldenToolStripMenuItem.Name = "goldenToolStripMenuItem";
            //this.goldenToolStripMenuItem.Text = "Golden";
            //this.goldenToolStripMenuItem.Click += (s, e) => SelectDuck(new GoldenDuck());
            //// ghostToolStripMenuItem
            //this.ghostToolStripMenuItem.Name = "ghostToolStripMenuItem";
            //this.ghostToolStripMenuItem.Text = "Ghost";
            //this.ghostToolStripMenuItem.Click += (s, e) => SelectDuck(new GhostDuck());
            //// habilidadesToolStripMenuItem
            //this.habilidadesToolStripMenuItem.Name = "habilidadesToolStripMenuItem";
            //this.habilidadesToolStripMenuItem.Text = "Habilidades";
            //// executarAçãoToolStripMenuItem
            this.executarAçãoToolStripMenuItem.Name = "executarAçãoToolStripMenuItem";
            this.executarAçãoToolStripMenuItem.Text = "Executar Ação";
            this.executarAçãoToolStripMenuItem.Click += new System.EventHandler(this.executarAçãoToolStripMenuItem_Click);
            // lblStatus
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 40);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(200, 23);
            this.lblStatus.Text = "Nenhum pato selecionado";
            // lblAbility
            this.lblAbility.AutoSize = true;
            this.lblAbility.Location = new System.Drawing.Point(12, 70);
            this.lblAbility.Name = "lblAbility";
            this.lblAbility.Size = new System.Drawing.Size(250, 23);
            this.lblAbility.Text = "Nenhuma habilidade selecionada";
            // MainForm
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAbility);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Simulador de Patos";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void SuspendLayout()
        {
            throw new NotImplementedException();
        }
    }
}
