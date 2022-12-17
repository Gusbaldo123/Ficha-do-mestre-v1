namespace Ficha_do_Mestre_v1
{
    partial class XpCalc
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
            this.txt_CurrentLvl = new System.Windows.Forms.TextBox();
            this.lbl_CurrentLvl = new System.Windows.Forms.Label();
            this.txt_CurrentXP = new System.Windows.Forms.TextBox();
            this.lbl_CurrentXP = new System.Windows.Forms.Label();
            this.txt_EarnedXP = new System.Windows.Forms.TextBox();
            this.lbl_EarnedXP = new System.Windows.Forms.Label();
            this.bt_Calculate = new System.Windows.Forms.Button();
            this.lbl_CalcXp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_CurrentLvl
            // 
            this.txt_CurrentLvl.Location = new System.Drawing.Point(65, 6);
            this.txt_CurrentLvl.Name = "txt_CurrentLvl";
            this.txt_CurrentLvl.Size = new System.Drawing.Size(101, 20);
            this.txt_CurrentLvl.TabIndex = 4;
            // 
            // lbl_CurrentLvl
            // 
            this.lbl_CurrentLvl.AutoSize = true;
            this.lbl_CurrentLvl.Location = new System.Drawing.Point(12, 9);
            this.lbl_CurrentLvl.Name = "lbl_CurrentLvl";
            this.lbl_CurrentLvl.Size = new System.Drawing.Size(48, 13);
            this.lbl_CurrentLvl.TabIndex = 3;
            this.lbl_CurrentLvl.Text = "Lvl Atual";
            // 
            // txt_CurrentXP
            // 
            this.txt_CurrentXP.Location = new System.Drawing.Point(65, 32);
            this.txt_CurrentXP.Name = "txt_CurrentXP";
            this.txt_CurrentXP.Size = new System.Drawing.Size(101, 20);
            this.txt_CurrentXP.TabIndex = 6;
            // 
            // lbl_CurrentXP
            // 
            this.lbl_CurrentXP.AutoSize = true;
            this.lbl_CurrentXP.Location = new System.Drawing.Point(12, 35);
            this.lbl_CurrentXP.Name = "lbl_CurrentXP";
            this.lbl_CurrentXP.Size = new System.Drawing.Size(47, 13);
            this.lbl_CurrentXP.TabIndex = 5;
            this.lbl_CurrentXP.Text = "Xp Atual";
            // 
            // txt_EarnedXP
            // 
            this.txt_EarnedXP.Location = new System.Drawing.Point(73, 58);
            this.txt_EarnedXP.Name = "txt_EarnedXP";
            this.txt_EarnedXP.Size = new System.Drawing.Size(93, 20);
            this.txt_EarnedXP.TabIndex = 8;
            // 
            // lbl_EarnedXP
            // 
            this.lbl_EarnedXP.AutoSize = true;
            this.lbl_EarnedXP.Location = new System.Drawing.Point(12, 61);
            this.lbl_EarnedXP.Name = "lbl_EarnedXP";
            this.lbl_EarnedXP.Size = new System.Drawing.Size(55, 13);
            this.lbl_EarnedXP.TabIndex = 7;
            this.lbl_EarnedXP.Text = "Xp Ganho";
            // 
            // bt_Calculate
            // 
            this.bt_Calculate.Location = new System.Drawing.Point(91, 84);
            this.bt_Calculate.Name = "bt_Calculate";
            this.bt_Calculate.Size = new System.Drawing.Size(75, 23);
            this.bt_Calculate.TabIndex = 9;
            this.bt_Calculate.Text = "Calcular";
            this.bt_Calculate.UseVisualStyleBackColor = true;
            this.bt_Calculate.Click += new System.EventHandler(this.bt_Calculate_Click);
            // 
            // lbl_CalcXp
            // 
            this.lbl_CalcXp.AutoSize = true;
            this.lbl_CalcXp.Location = new System.Drawing.Point(12, 110);
            this.lbl_CalcXp.Name = "lbl_CalcXp";
            this.lbl_CalcXp.Size = new System.Drawing.Size(95, 13);
            this.lbl_CalcXp.TabIndex = 10;
            this.lbl_CalcXp.Text = "Calculadora de XP";
            // 
            // XpCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 347);
            this.Controls.Add(this.lbl_CalcXp);
            this.Controls.Add(this.bt_Calculate);
            this.Controls.Add(this.txt_EarnedXP);
            this.Controls.Add(this.lbl_EarnedXP);
            this.Controls.Add(this.txt_CurrentXP);
            this.Controls.Add(this.lbl_CurrentXP);
            this.Controls.Add(this.txt_CurrentLvl);
            this.Controls.Add(this.lbl_CurrentLvl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "XpCalc";
            this.Text = "XpCalc";
            this.Load += new System.EventHandler(this.XpCalc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_CurrentLvl;
        private System.Windows.Forms.Label lbl_CurrentLvl;
        private System.Windows.Forms.TextBox txt_CurrentXP;
        private System.Windows.Forms.Label lbl_CurrentXP;
        private System.Windows.Forms.TextBox txt_EarnedXP;
        private System.Windows.Forms.Label lbl_EarnedXP;
        private System.Windows.Forms.Button bt_Calculate;
        private System.Windows.Forms.Label lbl_CalcXp;
    }
}