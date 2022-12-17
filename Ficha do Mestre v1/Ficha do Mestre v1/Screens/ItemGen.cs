using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ficha_do_Mestre_v1.Informations;

namespace Ficha_do_Mestre_v1.Screens
{
    public partial class ItemGen : Form
    {
        bool[] listStatuses = new bool[8];

        MaterialList MaterialList = new MaterialList();
        Material generatedItem;

        int ExtraDir = 4;

        public ItemGen()
        {
            InitializeComponent();
        }
        private void ItemGen_Load(object sender, EventArgs e)
        {
            cb_Quality.SelectedIndex = (int)ItemQuality.Common;

            chb_Str.Checked = true;
            chb_Dex.Checked = true;
            chb_Int.Checked = true;
            chb_Wis.Checked = true;
            chb_Arm.Checked = true;
            chb_Con.Checked = true;
            chb_Luk.Checked = true;
            chb_Fai.Checked = true;

            ch_Head.Checked = true;
            ch_Torso.Checked = true;
            ch_Leggings.Checked = true;
            ch_Feet.Checked = true;
            ch_Collar.Checked = true;
            ch_HandSingle.Checked = true;
            ch_HandDual.Checked = true;

            lbl_ItemQnty.Text = $"{MaterialList.materialList.Count} itens registrados";
            lb_SelectItem.Enabled = false;
            foreach (var item in MaterialList.materialList)
            {
                lb_SelectItem.Items.Add(item.itemName);
            }
        }
        private void bt_StatusAll_Click(object sender, EventArgs e)
        {
            chb_Str.Checked = true;
            chb_Dex.Checked = true;
            chb_Int.Checked = true;
            chb_Wis.Checked = true;
            chb_Arm.Checked = true;
            chb_Con.Checked = true;
            chb_Luk.Checked = true;
            chb_Fai.Checked = true;

            ch_Head.Checked = true;
            ch_Torso.Checked = true;
            ch_Leggings.Checked = true;
            ch_Feet.Checked = true;
            ch_Collar.Checked = true;
            ch_HandSingle.Checked = true;
            ch_HandDual.Checked = true;
        }
        private void bt_StatusNone_Click(object sender, EventArgs e)
        {
            chb_Str.Checked = false;
            chb_Dex.Checked = false;
            chb_Int.Checked = false;
            chb_Wis.Checked = false;
            chb_Arm.Checked = false;
            chb_Con.Checked = false;
            chb_Luk.Checked = false;
            chb_Fai.Checked = false;

            ch_Head.Checked = false;
            ch_Torso.Checked = false;
            ch_Leggings.Checked = false;
            ch_Feet.Checked = false;
            ch_Collar.Checked = false;
            ch_HandSingle.Checked = false;
            ch_HandDual.Checked = false;
        }
        private void bt_GeneratedItemCopy_Click(object sender, EventArgs e)
        {
            string copyText = "";
            string Slot = " [";
            switch (generatedItem.itemSlot)
            {
                case ItemSlot.Head:
                    Slot += "Cabeça";
                    break;
                case ItemSlot.Torso:
                    Slot += "Tronco";
                    break;
                case ItemSlot.Leggings:
                    Slot += "Pernas";
                    break;
                case ItemSlot.Feet:
                    Slot += "Pés";
                    break;
                case ItemSlot.Collar:
                    Slot += "Acessório";
                    break;
                case ItemSlot.HandSingle:
                    Slot += "Mão Única";
                    break;
                case ItemSlot.HandDual:
                    Slot += "Duas Mãos";
                    break;
            }
            Slot += "] ";

            copyText += ((generatedItem.itemQuality).ToString()) + " " + generatedItem.itemName+ Slot + " (";
            if (generatedItem.itemEffect != "")
            {
                copyText += generatedItem.effectName + (generatedItem.isEffectPassive ? "{ Passivo }" : " ( " + generatedItem.effectCost + " )");
                copyText += ": ( ";
                copyText += generatedItem.itemEffect;
                copyText += " ), ";
            }

            string txtStatuses = "";

            for (int i = 0; i < generatedItem.statuses.Count; i++)
            {
                if (generatedItem.statuses[i].percentageGain != 0)
                {
                    txtStatuses += (txtStatuses != "" ? "," : "")+" "+(generatedItem.statuses[i].percentageGain>0?"+":"") + generatedItem.statuses[i].percentageGain + " " + (ItemStatus)(generatedItem.statuses[i].itemStatus);
                }
            }
            copyText += txtStatuses;
            copyText += " )";

            Clipboard.SetText(copyText);
            //MessageBox.Show("Mensagem Copiada com Sucesso","Copiado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void bt_GenerateItem_Click(object sender, EventArgs e)
        {
            FillItem();
        }
        
        void FillItem()
        {
            ItemQuality quality = (ItemQuality)(cb_Quality.SelectedIndex-1);
            int PlayerLvl = 0;

            try { PlayerLvl = Convert.ToInt32(txt_PlayerLvl.Text); } catch 
            {
                MessageBox.Show("Nível inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            listStatuses[0] = chb_Str.Checked;
            listStatuses[1] = chb_Dex.Checked;
            listStatuses[2] = chb_Int.Checked;
            listStatuses[3] = chb_Wis.Checked;
            listStatuses[4] = chb_Arm.Checked;
            listStatuses[5] = chb_Con.Checked;
            listStatuses[6] = chb_Luk.Checked;
            listStatuses[7] = chb_Fai.Checked;

            List<int> selc = new List<int>();
            if (ch_Head.Checked) selc.Add(0);
            if (ch_Torso.Checked) selc.Add(1);
            if (ch_Leggings.Checked) selc.Add(2);
            if (ch_Feet.Checked) selc.Add(3);
            if (ch_Collar.Checked) selc.Add(4);
            if (ch_HandSingle.Checked) selc.Add(5);
            if (ch_HandDual.Checked) selc.Add(6);

            if (selc.Count <= 0)
            {
                MessageBox.Show("Slots Inválidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            generatedItem = GenerateItem(PlayerLvl, quality, selc.ToArray(), listStatuses);
            if (generatedItem == null)
            {
                MessageBox.Show("Não há um item cadastrado com estes filtros", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FillPanels();
        }
        void FillPanels()
        {
            pnl_GeneratedItem.Enabled = true;
            string txt = generatedItem.itemName;
            switch (generatedItem.itemQuality)
            {
                case ItemQuality.Common:
                    lbl_GeneratedItemName.ForeColor = Color.FromArgb(100, 100, 100);
                    break;
                case ItemQuality.Rare:
                    lbl_GeneratedItemName.ForeColor = Color.FromArgb(31, 66, 120);
                    break;
                case ItemQuality.Epic:
                    lbl_GeneratedItemName.ForeColor = Color.FromArgb(100, 43, 173);
                    break;
                case ItemQuality.Legendary:
                    lbl_GeneratedItemName.ForeColor = Color.FromArgb(245, 125, 56);
                    break;
                case ItemQuality.Divine:
                    lbl_GeneratedItemName.ForeColor = Color.FromArgb(255, 56, 73);
                    break;
            }
            lbl_Slot.Text = "";
            switch (generatedItem.itemSlot)
            {
                case ItemSlot.Head:
                    lbl_Slot.Text += "Cabeça";
                    break;
                case ItemSlot.Torso:
                    lbl_Slot.Text += "Tronco";
                    break;
                case ItemSlot.Leggings:
                    lbl_Slot.Text += "Pernas";
                    break;
                case ItemSlot.Feet:
                    lbl_Slot.Text += "Pés";
                    break;
                case ItemSlot.Collar:
                    lbl_Slot.Text += "Acessório";
                    break;
                case ItemSlot.HandSingle:
                    lbl_Slot.Text += "Mão Única";
                    break;
                case ItemSlot.HandDual:
                    lbl_Slot.Text += "Duas Mãos";
                    break;
            }

            lbl_GeneratedItemName.Text = ((generatedItem.itemQuality).ToString()) + " " + txt;

            string txtEffect = "";
            txtEffect += ((generatedItem.itemQuality).ToString()) + " " + generatedItem.itemName + "(";
            if (generatedItem.itemEffect != "")
            {
                txtEffect += generatedItem.effectName + (generatedItem.isEffectPassive ? " { Passivo }" : "( " + generatedItem.effectCost + " )");
                txtEffect += ": ( ";
                txtEffect += generatedItem.itemEffect;
                txtEffect += " )";
            }

            txt_GeneratedItemEffect.Text = generatedItem.itemEffect == "" ? "Nenhum" : txtEffect;
            bt_GeneratedItemCopy.Enabled = true;

            string txtC = "";

            for (int i = 0; i < Enum.GetNames(typeof(ItemStatus)).Length; i++)
            {
                txtC += ((ItemStatus)i).ToString() + ": " + Math.Ceiling(generatedItem.statuses[i].percentageGain).ToString() + Environment.NewLine;
            }

            lbl_GeneratedItemStatusStr.Text = txtC;

            foreach (Status status in generatedItem.statuses)
            {
                txt += Environment.NewLine + (Math.Ceiling(status.percentageGain)) + " " + status.itemStatus.ToString();
            }

            //MessageBox.Show(txt);
        }
        Material GenerateItem(int playerLvl, ItemQuality itemQuality,int[] enabledSlots, bool[] enabledStatuses)
        {
            int numExtra = playerLvl - ExtraDir;

            for (int i = 0; i < ExtraDir; i++)
            {
                if (playerLvl - i < 0)
                {
                    numExtra = playerLvl - i + 1;
                    break;
                }
            }
            int randomLvl = playerLvl + ExtraDir + 1;
            try
            { randomLvl = new Random().Next(numExtra, playerLvl + ExtraDir + 1); }
            catch
            { }
            if (randomLvl <= 0) randomLvl = 1;
            float gainStatus = (float)Math.Ceiling((randomLvl + 1) * (2 + (0.55f * numExtra)));

            bool continueIterations = true;

            int tries = 1000000;

            while (continueIterations && tries>0)
            {
                tries--;
                var list = (int)itemQuality == -1 ? MaterialList.materialList : MaterialList.materialList.Where(Mat => (Mat.itemQuality == itemQuality && enabledSlots.Contains((int)Mat.itemSlot))).ToList();

                if (list.Count <= 0) return null;

                Material item = list[new Random().Next(0, list.Count)];

                bool canProceed = true;

                foreach (Status selStatus in item.statuses)
                {
                    if (selStatus.percentageGain <= 0) continue;
                    if (selStatus.itemStatus == (ItemStatus)0 && !enabledStatuses[0]) canProceed = false;
                    if (selStatus.itemStatus == (ItemStatus)1 && !enabledStatuses[1]) canProceed = false;
                    if (selStatus.itemStatus == (ItemStatus)2 && !enabledStatuses[2]) canProceed = false;
                    if (selStatus.itemStatus == (ItemStatus)3 && !enabledStatuses[3]) canProceed = false;
                    if (selStatus.itemStatus == (ItemStatus)4 && !enabledStatuses[4]) canProceed = false;
                    if (selStatus.itemStatus == (ItemStatus)5 && !enabledStatuses[5]) canProceed = false;
                    if (selStatus.itemStatus == (ItemStatus)6 && !enabledStatuses[6]) canProceed = false;
                    if (selStatus.itemStatus == (ItemStatus)7 && !enabledStatuses[7]) canProceed = false;
                }
                if(!enabledSlots.Contains((int)item.itemSlot)) canProceed = false;
                if (!canProceed) continue;

                List<Status> statuses = new List<Status>();

                foreach (Status status in item.statuses)
                    statuses.Add(new Status((int)(gainStatus * status.percentageGain), status.itemStatus));

                continueIterations = false;
                return new Material($"{item.itemName} Lvl" + randomLvl, item.isEffectPassive, item.effectCost, item.effectName, item.itemEffect, statuses, item.itemSlot, item.itemQuality);
            }
            return null;
        }

        private void lb_SelectItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            Material item = MaterialList.materialList[lb_SelectItem.SelectedIndex];
            int playerLvl = Convert.ToInt32(txt_PlayerLvl.Text);
            int numExtra = playerLvl - ExtraDir;

            for (int i = 0; i < ExtraDir; i++)
            {
                if (playerLvl - i < 0)
                {
                    numExtra = playerLvl - i + 1;
                    break;
                }
            }


            int randomLvl = playerLvl + ExtraDir + 1;
            if (randomLvl <= 0) randomLvl = 1;
            float gainStatus = (float)Math.Ceiling((randomLvl + 1) * (2 + (0.55f * numExtra)));

            List<Status> statuses = new List<Status>();

            foreach (Status status in item.statuses)
                statuses.Add(new Status((int)(gainStatus * status.percentageGain), status.itemStatus));

            generatedItem = new Material($"{item.itemName} Lvl" + playerLvl, item.isEffectPassive, item.effectCost, item.effectName, item.itemEffect, statuses, item.itemSlot, item.itemQuality);
            FillPanels();
        }

        private void txt_PlayerLvl_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int playerLvl = Convert.ToInt32(txt_PlayerLvl.Text);
                lb_SelectItem.Enabled = true;
                bt_GenerateItem.Enabled = true;
            }
            catch
            {
                lb_SelectItem.Enabled = false;
                bt_GenerateItem.Enabled = false;
            }
        }
    }
}