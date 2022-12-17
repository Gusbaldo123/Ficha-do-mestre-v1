using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha_do_Mestre_v1
{
    public partial class XpCalc : Form
    {
        public XpCalc()
        {
            InitializeComponent();
        }

        private void bt_Calculate_Click(object sender, EventArgs e)
        {
            if (txt_CurrentLvl.Text == "" || txt_CurrentXP.Text == "" || txt_EarnedXP.Text == "") return;
            int lvl = 0, loot = 0, xp = 0;

            try {   lvl = Convert.ToInt32(txt_CurrentLvl.Text);
            } catch { return; }

            try {   loot = Convert.ToInt32(txt_CurrentXP.Text);
            } catch { return; }

            try {   xp = Convert.ToInt32(txt_EarnedXP.Text);
            }
            catch { return; }

            int nec, totalxp, points = 0;

            totalxp = loot + xp;
            nec = (lvl + 1) * 25;
            while (totalxp >= nec)
            {
                points += (lvl + 5) / 5;
                lvl++;
                totalxp -= nec;
                nec = (lvl + 1) * 25;
            }
            lbl_CalcXp.Text = "Calculadora de XP"+ Environment.NewLine;
            lbl_CalcXp.Text += Environment.NewLine + " Lvl: " + lvl;
            lbl_CalcXp.Text += Environment.NewLine + totalxp + "/" + nec + "Xp";
            lbl_CalcXp.Text += Environment.NewLine+" +" + points + " pontos";
        }

        private void XpCalc_Load(object sender, EventArgs e)
        {
            int xp = 0;
            for (int i = 0; i <= 40; i++)
            {
                xp += (i + 1) * 100;
            }
            for (int i = 41; i <= 80; i++)
            {
                xp += (i + 1) * 400;
            }
            //MessageBox.Show($"Seu xp total é {xp}");
        }
    }
}
