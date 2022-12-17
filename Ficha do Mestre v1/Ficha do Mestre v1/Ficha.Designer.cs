namespace Ficha_do_Mestre_v1
{
    partial class Ficha
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ficha));
            this.pnl_Ficha = new System.Windows.Forms.Panel();
            this.bt_NPCGen = new System.Windows.Forms.Button();
            this.bt_XpCalc = new System.Windows.Forms.Button();
            this.bt_Itens = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnl_Ficha
            // 
            this.pnl_Ficha.Location = new System.Drawing.Point(12, 42);
            this.pnl_Ficha.Name = "pnl_Ficha";
            this.pnl_Ficha.Size = new System.Drawing.Size(776, 396);
            this.pnl_Ficha.TabIndex = 0;
            // 
            // bt_NPCGen
            // 
            this.bt_NPCGen.Location = new System.Drawing.Point(13, 13);
            this.bt_NPCGen.Name = "bt_NPCGen";
            this.bt_NPCGen.Size = new System.Drawing.Size(75, 23);
            this.bt_NPCGen.TabIndex = 1;
            this.bt_NPCGen.Text = "NPC";
            this.bt_NPCGen.UseVisualStyleBackColor = true;
            this.bt_NPCGen.Click += new System.EventHandler(this.bt_NPC_Click);
            // 
            // bt_XpCalc
            // 
            this.bt_XpCalc.Location = new System.Drawing.Point(94, 13);
            this.bt_XpCalc.Name = "bt_XpCalc";
            this.bt_XpCalc.Size = new System.Drawing.Size(75, 23);
            this.bt_XpCalc.TabIndex = 2;
            this.bt_XpCalc.Text = "Xp Calc";
            this.bt_XpCalc.UseVisualStyleBackColor = true;
            this.bt_XpCalc.Click += new System.EventHandler(this.bt_XpCalc_Click);
            // 
            // bt_Itens
            // 
            this.bt_Itens.Location = new System.Drawing.Point(175, 13);
            this.bt_Itens.Name = "bt_Itens";
            this.bt_Itens.Size = new System.Drawing.Size(75, 23);
            this.bt_Itens.TabIndex = 3;
            this.bt_Itens.Text = "Itens";
            this.bt_Itens.UseVisualStyleBackColor = true;
            this.bt_Itens.Click += new System.EventHandler(this.bt_Itens_Click);
            // 
            // Ficha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_Itens);
            this.Controls.Add(this.bt_XpCalc);
            this.Controls.Add(this.bt_NPCGen);
            this.Controls.Add(this.pnl_Ficha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Ficha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ficha do Mestre";
            this.Load += new System.EventHandler(this.Ficha_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Ficha;
        private System.Windows.Forms.Button bt_NPCGen;
        private System.Windows.Forms.Button bt_XpCalc;
        private System.Windows.Forms.Button bt_Itens;
    }
}

