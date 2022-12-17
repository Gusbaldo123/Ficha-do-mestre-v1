using System;
using System.Windows.Forms;

namespace Ficha_do_Mestre_v1
{
    public partial class Ficha : Form
    {
        public Ficha()
        {
            InitializeComponent();
        }

        private void Ficha_Load(object sender, EventArgs e)
        {
            ShowForm(new NPCGen());
        }

        private void bt_NPC_Click(object sender, EventArgs e)
        {
            ShowForm(new NPCGen());
        }
        private void bt_XpCalc_Click(object sender, EventArgs e)
        {
            ShowForm(new XpCalc());
        }
        private void bt_Itens_Click(object sender, EventArgs e)
        {
            ShowForm(new Screens.ItemGen());
        }
        void ShowForm(Form myForm)
        {
            pnl_Ficha.Controls.Clear();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            pnl_Ficha.Controls.Add(myForm);
            myForm.Show();
        }
    }
}
