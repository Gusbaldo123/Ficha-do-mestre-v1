namespace Ficha_do_Mestre_v1.Screens
{
    partial class ItemGen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemGen));
            this.bt_GenerateItem = new System.Windows.Forms.Button();
            this.cb_Quality = new System.Windows.Forms.ComboBox();
            this.lbl_QualityItem = new System.Windows.Forms.Label();
            this.lbl_PlayerLvl = new System.Windows.Forms.Label();
            this.txt_PlayerLvl = new System.Windows.Forms.TextBox();
            this.chb_Str = new System.Windows.Forms.CheckBox();
            this.chb_Dex = new System.Windows.Forms.CheckBox();
            this.chb_Int = new System.Windows.Forms.CheckBox();
            this.chb_Wis = new System.Windows.Forms.CheckBox();
            this.chb_Arm = new System.Windows.Forms.CheckBox();
            this.chb_Con = new System.Windows.Forms.CheckBox();
            this.chb_Luk = new System.Windows.Forms.CheckBox();
            this.chb_Fai = new System.Windows.Forms.CheckBox();
            this.bt_Head = new System.Windows.Forms.PictureBox();
            this.bt_Torso = new System.Windows.Forms.PictureBox();
            this.bt_HandSingle = new System.Windows.Forms.PictureBox();
            this.bt_Leggings = new System.Windows.Forms.PictureBox();
            this.bt_Feet = new System.Windows.Forms.PictureBox();
            this.bt_Collar = new System.Windows.Forms.PictureBox();
            this.lbl_GeneratedItemNameLbl = new System.Windows.Forms.Label();
            this.lbl_GeneratedItemTitle = new System.Windows.Forms.Label();
            this.pnl_GeneratedItem = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Slot = new System.Windows.Forms.Label();
            this.bt_GeneratedItemCopy = new System.Windows.Forms.Button();
            this.lbl_GeneratedItemStatusStr = new System.Windows.Forms.Label();
            this.lbl_GeneratedItemStatusTitle = new System.Windows.Forms.Label();
            this.txt_GeneratedItemEffect = new System.Windows.Forms.TextBox();
            this.lbl_GeneratedItemEffectLbl = new System.Windows.Forms.Label();
            this.lbl_GeneratedItemName = new System.Windows.Forms.Label();
            this.bt_StatusAll = new System.Windows.Forms.Button();
            this.bt_StatusNone = new System.Windows.Forms.Button();
            this.bt_HandDual = new System.Windows.Forms.PictureBox();
            this.ch_Head = new System.Windows.Forms.CheckBox();
            this.ch_Torso = new System.Windows.Forms.CheckBox();
            this.ch_Leggings = new System.Windows.Forms.CheckBox();
            this.ch_Feet = new System.Windows.Forms.CheckBox();
            this.ch_Collar = new System.Windows.Forms.CheckBox();
            this.ch_HandSingle = new System.Windows.Forms.CheckBox();
            this.ch_HandDual = new System.Windows.Forms.CheckBox();
            this.lb_SelectItem = new System.Windows.Forms.ListBox();
            this.lbl_ItemQnty = new System.Windows.Forms.Label();
            this.txtboxItemFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Head)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Torso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_HandSingle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Leggings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Feet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Collar)).BeginInit();
            this.pnl_GeneratedItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_HandDual)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_GenerateItem
            // 
            this.bt_GenerateItem.Location = new System.Drawing.Point(15, 323);
            this.bt_GenerateItem.Name = "bt_GenerateItem";
            this.bt_GenerateItem.Size = new System.Drawing.Size(79, 23);
            this.bt_GenerateItem.TabIndex = 8;
            this.bt_GenerateItem.Text = "Gerar";
            this.bt_GenerateItem.UseVisualStyleBackColor = true;
            this.bt_GenerateItem.Click += new System.EventHandler(this.bt_GenerateItem_Click);
            // 
            // cb_Quality
            // 
            this.cb_Quality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Quality.FormattingEnabled = true;
            this.cb_Quality.Items.AddRange(new object[] {
            "Aleatório",
            "Comum",
            "Raro",
            "Épico",
            "Lendário",
            "Divino"});
            this.cb_Quality.Location = new System.Drawing.Point(111, 6);
            this.cb_Quality.Name = "cb_Quality";
            this.cb_Quality.Size = new System.Drawing.Size(104, 21);
            this.cb_Quality.TabIndex = 9;
            // 
            // lbl_QualityItem
            // 
            this.lbl_QualityItem.AutoSize = true;
            this.lbl_QualityItem.Location = new System.Drawing.Point(12, 9);
            this.lbl_QualityItem.Name = "lbl_QualityItem";
            this.lbl_QualityItem.Size = new System.Drawing.Size(93, 13);
            this.lbl_QualityItem.TabIndex = 10;
            this.lbl_QualityItem.Text = "Qualidade do Item";
            // 
            // lbl_PlayerLvl
            // 
            this.lbl_PlayerLvl.AutoSize = true;
            this.lbl_PlayerLvl.Location = new System.Drawing.Point(12, 38);
            this.lbl_PlayerLvl.Name = "lbl_PlayerLvl";
            this.lbl_PlayerLvl.Size = new System.Drawing.Size(77, 13);
            this.lbl_PlayerLvl.TabIndex = 11;
            this.lbl_PlayerLvl.Text = "Lvl do Jogador";
            // 
            // txt_PlayerLvl
            // 
            this.txt_PlayerLvl.Location = new System.Drawing.Point(111, 35);
            this.txt_PlayerLvl.Name = "txt_PlayerLvl";
            this.txt_PlayerLvl.Size = new System.Drawing.Size(104, 20);
            this.txt_PlayerLvl.TabIndex = 12;
            this.txt_PlayerLvl.TextChanged += new System.EventHandler(this.txt_PlayerLvl_TextChanged);
            // 
            // chb_Str
            // 
            this.chb_Str.AutoSize = true;
            this.chb_Str.Location = new System.Drawing.Point(15, 65);
            this.chb_Str.Name = "chb_Str";
            this.chb_Str.Size = new System.Drawing.Size(39, 17);
            this.chb_Str.TabIndex = 13;
            this.chb_Str.Text = "Str";
            this.chb_Str.UseVisualStyleBackColor = true;
            // 
            // chb_Dex
            // 
            this.chb_Dex.AutoSize = true;
            this.chb_Dex.Location = new System.Drawing.Point(60, 65);
            this.chb_Dex.Name = "chb_Dex";
            this.chb_Dex.Size = new System.Drawing.Size(45, 17);
            this.chb_Dex.TabIndex = 14;
            this.chb_Dex.Text = "Dex";
            this.chb_Dex.UseVisualStyleBackColor = true;
            // 
            // chb_Int
            // 
            this.chb_Int.AutoSize = true;
            this.chb_Int.Location = new System.Drawing.Point(111, 65);
            this.chb_Int.Name = "chb_Int";
            this.chb_Int.Size = new System.Drawing.Size(38, 17);
            this.chb_Int.TabIndex = 15;
            this.chb_Int.Text = "Int";
            this.chb_Int.UseVisualStyleBackColor = true;
            // 
            // chb_Wis
            // 
            this.chb_Wis.AutoSize = true;
            this.chb_Wis.Location = new System.Drawing.Point(155, 65);
            this.chb_Wis.Name = "chb_Wis";
            this.chb_Wis.Size = new System.Drawing.Size(44, 17);
            this.chb_Wis.TabIndex = 16;
            this.chb_Wis.Text = "Wis";
            this.chb_Wis.UseVisualStyleBackColor = true;
            // 
            // chb_Arm
            // 
            this.chb_Arm.AutoSize = true;
            this.chb_Arm.Location = new System.Drawing.Point(15, 88);
            this.chb_Arm.Name = "chb_Arm";
            this.chb_Arm.Size = new System.Drawing.Size(44, 17);
            this.chb_Arm.TabIndex = 17;
            this.chb_Arm.Text = "Arm";
            this.chb_Arm.UseVisualStyleBackColor = true;
            // 
            // chb_Con
            // 
            this.chb_Con.AutoSize = true;
            this.chb_Con.Location = new System.Drawing.Point(60, 88);
            this.chb_Con.Name = "chb_Con";
            this.chb_Con.Size = new System.Drawing.Size(45, 17);
            this.chb_Con.TabIndex = 18;
            this.chb_Con.Text = "Con";
            this.chb_Con.UseVisualStyleBackColor = true;
            // 
            // chb_Luk
            // 
            this.chb_Luk.AutoSize = true;
            this.chb_Luk.Location = new System.Drawing.Point(111, 88);
            this.chb_Luk.Name = "chb_Luk";
            this.chb_Luk.Size = new System.Drawing.Size(44, 17);
            this.chb_Luk.TabIndex = 19;
            this.chb_Luk.Text = "Luk";
            this.chb_Luk.UseVisualStyleBackColor = true;
            // 
            // chb_Fai
            // 
            this.chb_Fai.AutoSize = true;
            this.chb_Fai.Location = new System.Drawing.Point(155, 88);
            this.chb_Fai.Name = "chb_Fai";
            this.chb_Fai.Size = new System.Drawing.Size(40, 17);
            this.chb_Fai.TabIndex = 20;
            this.chb_Fai.Text = "Fai";
            this.chb_Fai.UseVisualStyleBackColor = true;
            // 
            // bt_Head
            // 
            this.bt_Head.Image = ((System.Drawing.Image)(resources.GetObject("bt_Head.Image")));
            this.bt_Head.Location = new System.Drawing.Point(242, 6);
            this.bt_Head.Name = "bt_Head";
            this.bt_Head.Size = new System.Drawing.Size(25, 25);
            this.bt_Head.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bt_Head.TabIndex = 21;
            this.bt_Head.TabStop = false;
            // 
            // bt_Torso
            // 
            this.bt_Torso.Image = ((System.Drawing.Image)(resources.GetObject("bt_Torso.Image")));
            this.bt_Torso.Location = new System.Drawing.Point(242, 32);
            this.bt_Torso.Name = "bt_Torso";
            this.bt_Torso.Size = new System.Drawing.Size(25, 25);
            this.bt_Torso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bt_Torso.TabIndex = 22;
            this.bt_Torso.TabStop = false;
            // 
            // bt_HandSingle
            // 
            this.bt_HandSingle.Image = ((System.Drawing.Image)(resources.GetObject("bt_HandSingle.Image")));
            this.bt_HandSingle.Location = new System.Drawing.Point(273, 44);
            this.bt_HandSingle.Name = "bt_HandSingle";
            this.bt_HandSingle.Size = new System.Drawing.Size(25, 25);
            this.bt_HandSingle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bt_HandSingle.TabIndex = 24;
            this.bt_HandSingle.TabStop = false;
            // 
            // bt_Leggings
            // 
            this.bt_Leggings.Image = ((System.Drawing.Image)(resources.GetObject("bt_Leggings.Image")));
            this.bt_Leggings.Location = new System.Drawing.Point(242, 58);
            this.bt_Leggings.Name = "bt_Leggings";
            this.bt_Leggings.Size = new System.Drawing.Size(25, 25);
            this.bt_Leggings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bt_Leggings.TabIndex = 25;
            this.bt_Leggings.TabStop = false;
            // 
            // bt_Feet
            // 
            this.bt_Feet.Image = ((System.Drawing.Image)(resources.GetObject("bt_Feet.Image")));
            this.bt_Feet.Location = new System.Drawing.Point(242, 84);
            this.bt_Feet.Name = "bt_Feet";
            this.bt_Feet.Size = new System.Drawing.Size(25, 25);
            this.bt_Feet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bt_Feet.TabIndex = 26;
            this.bt_Feet.TabStop = false;
            // 
            // bt_Collar
            // 
            this.bt_Collar.Image = ((System.Drawing.Image)(resources.GetObject("bt_Collar.Image")));
            this.bt_Collar.Location = new System.Drawing.Point(273, 18);
            this.bt_Collar.Name = "bt_Collar";
            this.bt_Collar.Size = new System.Drawing.Size(25, 25);
            this.bt_Collar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bt_Collar.TabIndex = 27;
            this.bt_Collar.TabStop = false;
            // 
            // lbl_GeneratedItemNameLbl
            // 
            this.lbl_GeneratedItemNameLbl.AutoSize = true;
            this.lbl_GeneratedItemNameLbl.Location = new System.Drawing.Point(4, 28);
            this.lbl_GeneratedItemNameLbl.Name = "lbl_GeneratedItemNameLbl";
            this.lbl_GeneratedItemNameLbl.Size = new System.Drawing.Size(35, 13);
            this.lbl_GeneratedItemNameLbl.TabIndex = 28;
            this.lbl_GeneratedItemNameLbl.Text = "Nome";
            // 
            // lbl_GeneratedItemTitle
            // 
            this.lbl_GeneratedItemTitle.AutoSize = true;
            this.lbl_GeneratedItemTitle.Location = new System.Drawing.Point(60, 9);
            this.lbl_GeneratedItemTitle.Name = "lbl_GeneratedItemTitle";
            this.lbl_GeneratedItemTitle.Size = new System.Drawing.Size(65, 13);
            this.lbl_GeneratedItemTitle.TabIndex = 30;
            this.lbl_GeneratedItemTitle.Text = "Item Gerado";
            // 
            // pnl_GeneratedItem
            // 
            this.pnl_GeneratedItem.Controls.Add(this.label1);
            this.pnl_GeneratedItem.Controls.Add(this.lbl_Slot);
            this.pnl_GeneratedItem.Controls.Add(this.bt_GeneratedItemCopy);
            this.pnl_GeneratedItem.Controls.Add(this.lbl_GeneratedItemStatusStr);
            this.pnl_GeneratedItem.Controls.Add(this.lbl_GeneratedItemStatusTitle);
            this.pnl_GeneratedItem.Controls.Add(this.txt_GeneratedItemEffect);
            this.pnl_GeneratedItem.Controls.Add(this.lbl_GeneratedItemEffectLbl);
            this.pnl_GeneratedItem.Controls.Add(this.lbl_GeneratedItemName);
            this.pnl_GeneratedItem.Controls.Add(this.lbl_GeneratedItemNameLbl);
            this.pnl_GeneratedItem.Controls.Add(this.lbl_GeneratedItemTitle);
            this.pnl_GeneratedItem.Enabled = false;
            this.pnl_GeneratedItem.Location = new System.Drawing.Point(15, 111);
            this.pnl_GeneratedItem.Name = "pnl_GeneratedItem";
            this.pnl_GeneratedItem.Size = new System.Drawing.Size(304, 206);
            this.pnl_GeneratedItem.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Slot";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Slot
            // 
            this.lbl_Slot.AutoSize = true;
            this.lbl_Slot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Slot.Location = new System.Drawing.Point(42, 52);
            this.lbl_Slot.Name = "lbl_Slot";
            this.lbl_Slot.Size = new System.Drawing.Size(25, 13);
            this.lbl_Slot.TabIndex = 36;
            this.lbl_Slot.Text = "Slot";
            this.lbl_Slot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bt_GeneratedItemCopy
            // 
            this.bt_GeneratedItemCopy.Enabled = false;
            this.bt_GeneratedItemCopy.Location = new System.Drawing.Point(241, 180);
            this.bt_GeneratedItemCopy.Name = "bt_GeneratedItemCopy";
            this.bt_GeneratedItemCopy.Size = new System.Drawing.Size(60, 23);
            this.bt_GeneratedItemCopy.TabIndex = 34;
            this.bt_GeneratedItemCopy.Text = "Copiar";
            this.bt_GeneratedItemCopy.UseVisualStyleBackColor = true;
            this.bt_GeneratedItemCopy.Click += new System.EventHandler(this.bt_GeneratedItemCopy_Click);
            // 
            // lbl_GeneratedItemStatusStr
            // 
            this.lbl_GeneratedItemStatusStr.AutoSize = true;
            this.lbl_GeneratedItemStatusStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GeneratedItemStatusStr.Location = new System.Drawing.Point(5, 88);
            this.lbl_GeneratedItemStatusStr.Name = "lbl_GeneratedItemStatusStr";
            this.lbl_GeneratedItemStatusStr.Size = new System.Drawing.Size(32, 12);
            this.lbl_GeneratedItemStatusStr.TabIndex = 35;
            this.lbl_GeneratedItemStatusStr.Text = "Status";
            // 
            // lbl_GeneratedItemStatusTitle
            // 
            this.lbl_GeneratedItemStatusTitle.AutoSize = true;
            this.lbl_GeneratedItemStatusTitle.Location = new System.Drawing.Point(4, 73);
            this.lbl_GeneratedItemStatusTitle.Name = "lbl_GeneratedItemStatusTitle";
            this.lbl_GeneratedItemStatusTitle.Size = new System.Drawing.Size(37, 13);
            this.lbl_GeneratedItemStatusTitle.TabIndex = 34;
            this.lbl_GeneratedItemStatusTitle.Text = "Status";
            // 
            // txt_GeneratedItemEffect
            // 
            this.txt_GeneratedItemEffect.Location = new System.Drawing.Point(110, 61);
            this.txt_GeneratedItemEffect.Multiline = true;
            this.txt_GeneratedItemEffect.Name = "txt_GeneratedItemEffect";
            this.txt_GeneratedItemEffect.ReadOnly = true;
            this.txt_GeneratedItemEffect.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_GeneratedItemEffect.Size = new System.Drawing.Size(173, 113);
            this.txt_GeneratedItemEffect.TabIndex = 33;
            // 
            // lbl_GeneratedItemEffectLbl
            // 
            this.lbl_GeneratedItemEffectLbl.AutoSize = true;
            this.lbl_GeneratedItemEffectLbl.Location = new System.Drawing.Point(107, 45);
            this.lbl_GeneratedItemEffectLbl.Name = "lbl_GeneratedItemEffectLbl";
            this.lbl_GeneratedItemEffectLbl.Size = new System.Drawing.Size(34, 13);
            this.lbl_GeneratedItemEffectLbl.TabIndex = 32;
            this.lbl_GeneratedItemEffectLbl.Text = "Efeito";
            // 
            // lbl_GeneratedItemName
            // 
            this.lbl_GeneratedItemName.AutoSize = true;
            this.lbl_GeneratedItemName.Location = new System.Drawing.Point(39, 28);
            this.lbl_GeneratedItemName.Name = "lbl_GeneratedItemName";
            this.lbl_GeneratedItemName.Size = new System.Drawing.Size(35, 13);
            this.lbl_GeneratedItemName.TabIndex = 31;
            this.lbl_GeneratedItemName.Text = "Nome";
            // 
            // bt_StatusAll
            // 
            this.bt_StatusAll.Location = new System.Drawing.Point(196, 59);
            this.bt_StatusAll.Name = "bt_StatusAll";
            this.bt_StatusAll.Size = new System.Drawing.Size(19, 23);
            this.bt_StatusAll.TabIndex = 32;
            this.bt_StatusAll.UseVisualStyleBackColor = true;
            this.bt_StatusAll.Click += new System.EventHandler(this.bt_StatusAll_Click);
            // 
            // bt_StatusNone
            // 
            this.bt_StatusNone.Location = new System.Drawing.Point(196, 84);
            this.bt_StatusNone.Name = "bt_StatusNone";
            this.bt_StatusNone.Size = new System.Drawing.Size(19, 23);
            this.bt_StatusNone.TabIndex = 33;
            this.bt_StatusNone.UseVisualStyleBackColor = true;
            this.bt_StatusNone.Click += new System.EventHandler(this.bt_StatusNone_Click);
            // 
            // bt_HandDual
            // 
            this.bt_HandDual.Image = ((System.Drawing.Image)(resources.GetObject("bt_HandDual.Image")));
            this.bt_HandDual.Location = new System.Drawing.Point(273, 70);
            this.bt_HandDual.Name = "bt_HandDual";
            this.bt_HandDual.Size = new System.Drawing.Size(25, 25);
            this.bt_HandDual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bt_HandDual.TabIndex = 34;
            this.bt_HandDual.TabStop = false;
            // 
            // ch_Head
            // 
            this.ch_Head.AutoSize = true;
            this.ch_Head.Checked = true;
            this.ch_Head.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_Head.Location = new System.Drawing.Point(223, 12);
            this.ch_Head.Name = "ch_Head";
            this.ch_Head.Size = new System.Drawing.Size(15, 14);
            this.ch_Head.TabIndex = 35;
            this.ch_Head.UseVisualStyleBackColor = true;
            // 
            // ch_Torso
            // 
            this.ch_Torso.AutoSize = true;
            this.ch_Torso.Checked = true;
            this.ch_Torso.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_Torso.Location = new System.Drawing.Point(223, 37);
            this.ch_Torso.Name = "ch_Torso";
            this.ch_Torso.Size = new System.Drawing.Size(15, 14);
            this.ch_Torso.TabIndex = 36;
            this.ch_Torso.UseVisualStyleBackColor = true;
            // 
            // ch_Leggings
            // 
            this.ch_Leggings.AutoSize = true;
            this.ch_Leggings.Checked = true;
            this.ch_Leggings.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_Leggings.Location = new System.Drawing.Point(223, 64);
            this.ch_Leggings.Name = "ch_Leggings";
            this.ch_Leggings.Size = new System.Drawing.Size(15, 14);
            this.ch_Leggings.TabIndex = 37;
            this.ch_Leggings.UseVisualStyleBackColor = true;
            // 
            // ch_Feet
            // 
            this.ch_Feet.AutoSize = true;
            this.ch_Feet.Checked = true;
            this.ch_Feet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_Feet.Location = new System.Drawing.Point(223, 89);
            this.ch_Feet.Name = "ch_Feet";
            this.ch_Feet.Size = new System.Drawing.Size(15, 14);
            this.ch_Feet.TabIndex = 38;
            this.ch_Feet.UseVisualStyleBackColor = true;
            // 
            // ch_Collar
            // 
            this.ch_Collar.AutoSize = true;
            this.ch_Collar.Checked = true;
            this.ch_Collar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_Collar.Location = new System.Drawing.Point(304, 24);
            this.ch_Collar.Name = "ch_Collar";
            this.ch_Collar.Size = new System.Drawing.Size(15, 14);
            this.ch_Collar.TabIndex = 39;
            this.ch_Collar.UseVisualStyleBackColor = true;
            // 
            // ch_HandSingle
            // 
            this.ch_HandSingle.AutoSize = true;
            this.ch_HandSingle.Checked = true;
            this.ch_HandSingle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_HandSingle.Location = new System.Drawing.Point(304, 49);
            this.ch_HandSingle.Name = "ch_HandSingle";
            this.ch_HandSingle.Size = new System.Drawing.Size(15, 14);
            this.ch_HandSingle.TabIndex = 40;
            this.ch_HandSingle.UseVisualStyleBackColor = true;
            // 
            // ch_HandDual
            // 
            this.ch_HandDual.AutoSize = true;
            this.ch_HandDual.Checked = true;
            this.ch_HandDual.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_HandDual.Location = new System.Drawing.Point(304, 75);
            this.ch_HandDual.Name = "ch_HandDual";
            this.ch_HandDual.Size = new System.Drawing.Size(15, 14);
            this.ch_HandDual.TabIndex = 41;
            this.ch_HandDual.UseVisualStyleBackColor = true;
            // 
            // lb_SelectItem
            // 
            this.lb_SelectItem.FormattingEnabled = true;
            this.lb_SelectItem.Location = new System.Drawing.Point(325, 24);
            this.lb_SelectItem.Name = "lb_SelectItem";
            this.lb_SelectItem.Size = new System.Drawing.Size(134, 212);
            this.lb_SelectItem.TabIndex = 42;
            this.lb_SelectItem.SelectedIndexChanged += new System.EventHandler(this.lb_SelectItem_SelectedIndexChanged);
            // 
            // lbl_ItemQnty
            // 
            this.lbl_ItemQnty.AutoSize = true;
            this.lbl_ItemQnty.Location = new System.Drawing.Point(322, 9);
            this.lbl_ItemQnty.Name = "lbl_ItemQnty";
            this.lbl_ItemQnty.Size = new System.Drawing.Size(93, 13);
            this.lbl_ItemQnty.TabIndex = 43;
            this.lbl_ItemQnty.Text = "Qualidade do Item";
            // 
            // txtboxItemFilter
            // 
            this.txtboxItemFilter.Location = new System.Drawing.Point(511, 149);
            this.txtboxItemFilter.Name = "txtboxItemFilter";
            this.txtboxItemFilter.Size = new System.Drawing.Size(104, 20);
            this.txtboxItemFilter.TabIndex = 44;
            this.txtboxItemFilter.TextChanged += new System.EventHandler(this.txtboxItemFilter_TextChanged);
            // 
            // ItemGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 347);
            this.Controls.Add(this.txtboxItemFilter);
            this.Controls.Add(this.lbl_ItemQnty);
            this.Controls.Add(this.lb_SelectItem);
            this.Controls.Add(this.ch_HandDual);
            this.Controls.Add(this.ch_HandSingle);
            this.Controls.Add(this.ch_Collar);
            this.Controls.Add(this.ch_Feet);
            this.Controls.Add(this.ch_Leggings);
            this.Controls.Add(this.ch_Torso);
            this.Controls.Add(this.ch_Head);
            this.Controls.Add(this.bt_HandDual);
            this.Controls.Add(this.bt_StatusNone);
            this.Controls.Add(this.bt_StatusAll);
            this.Controls.Add(this.pnl_GeneratedItem);
            this.Controls.Add(this.bt_Collar);
            this.Controls.Add(this.bt_Feet);
            this.Controls.Add(this.bt_Leggings);
            this.Controls.Add(this.bt_HandSingle);
            this.Controls.Add(this.bt_Torso);
            this.Controls.Add(this.bt_Head);
            this.Controls.Add(this.chb_Fai);
            this.Controls.Add(this.chb_Luk);
            this.Controls.Add(this.chb_Con);
            this.Controls.Add(this.chb_Arm);
            this.Controls.Add(this.chb_Wis);
            this.Controls.Add(this.chb_Int);
            this.Controls.Add(this.chb_Dex);
            this.Controls.Add(this.chb_Str);
            this.Controls.Add(this.txt_PlayerLvl);
            this.Controls.Add(this.lbl_PlayerLvl);
            this.Controls.Add(this.lbl_QualityItem);
            this.Controls.Add(this.cb_Quality);
            this.Controls.Add(this.bt_GenerateItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemGen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ItemGen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bt_Head)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Torso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_HandSingle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Leggings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Feet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Collar)).EndInit();
            this.pnl_GeneratedItem.ResumeLayout(false);
            this.pnl_GeneratedItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_HandDual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_GenerateItem;
        private System.Windows.Forms.ComboBox cb_Quality;
        private System.Windows.Forms.Label lbl_QualityItem;
        private System.Windows.Forms.Label lbl_PlayerLvl;
        private System.Windows.Forms.TextBox txt_PlayerLvl;
        private System.Windows.Forms.CheckBox chb_Str;
        private System.Windows.Forms.CheckBox chb_Dex;
        private System.Windows.Forms.CheckBox chb_Int;
        private System.Windows.Forms.CheckBox chb_Wis;
        private System.Windows.Forms.CheckBox chb_Arm;
        private System.Windows.Forms.CheckBox chb_Con;
        private System.Windows.Forms.CheckBox chb_Luk;
        private System.Windows.Forms.CheckBox chb_Fai;
        private System.Windows.Forms.PictureBox bt_Head;
        private System.Windows.Forms.PictureBox bt_Torso;
        private System.Windows.Forms.PictureBox bt_HandSingle;
        private System.Windows.Forms.PictureBox bt_Leggings;
        private System.Windows.Forms.PictureBox bt_Feet;
        private System.Windows.Forms.PictureBox bt_Collar;
        private System.Windows.Forms.Label lbl_GeneratedItemNameLbl;
        private System.Windows.Forms.Label lbl_GeneratedItemTitle;
        private System.Windows.Forms.Panel pnl_GeneratedItem;
        private System.Windows.Forms.Label lbl_GeneratedItemName;
        private System.Windows.Forms.TextBox txt_GeneratedItemEffect;
        private System.Windows.Forms.Label lbl_GeneratedItemEffectLbl;
        private System.Windows.Forms.Label lbl_GeneratedItemStatusStr;
        private System.Windows.Forms.Label lbl_GeneratedItemStatusTitle;
        private System.Windows.Forms.Button bt_StatusAll;
        private System.Windows.Forms.Button bt_StatusNone;
        private System.Windows.Forms.Button bt_GeneratedItemCopy;
        private System.Windows.Forms.PictureBox bt_HandDual;
        private System.Windows.Forms.CheckBox ch_Head;
        private System.Windows.Forms.CheckBox ch_Torso;
        private System.Windows.Forms.CheckBox ch_Leggings;
        private System.Windows.Forms.CheckBox ch_Feet;
        private System.Windows.Forms.CheckBox ch_Collar;
        private System.Windows.Forms.CheckBox ch_HandSingle;
        private System.Windows.Forms.CheckBox ch_HandDual;
        private System.Windows.Forms.Label lbl_Slot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_SelectItem;
        private System.Windows.Forms.Label lbl_ItemQnty;
        private System.Windows.Forms.TextBox txtboxItemFilter;
    }
}