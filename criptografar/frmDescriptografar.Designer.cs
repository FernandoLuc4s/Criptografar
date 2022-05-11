
namespace criptografar
{
    partial class frmDescriptografar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDescriptografar));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.criptografarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTxtDescript = new System.Windows.Forms.RichTextBox();
            this.btnClearDescitpto = new System.Windows.Forms.Button();
            this.richTxtMsg = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCripto = new System.Windows.Forms.Label();
            this.btnDescritpo = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criptografarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1095, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // criptografarToolStripMenuItem
            // 
            this.criptografarToolStripMenuItem.Name = "criptografarToolStripMenuItem";
            this.criptografarToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.criptografarToolStripMenuItem.Text = "Criptografar";
            this.criptografarToolStripMenuItem.Click += new System.EventHandler(this.criptografarToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // richTxtDescript
            // 
            this.richTxtDescript.Location = new System.Drawing.Point(536, 85);
            this.richTxtDescript.Name = "richTxtDescript";
            this.richTxtDescript.Size = new System.Drawing.Size(394, 261);
            this.richTxtDescript.TabIndex = 14;
            this.richTxtDescript.Text = "";
            // 
            // btnClearDescitpto
            // 
            this.btnClearDescitpto.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearDescitpto.Location = new System.Drawing.Point(336, 352);
            this.btnClearDescitpto.Name = "btnClearDescitpto";
            this.btnClearDescitpto.Size = new System.Drawing.Size(94, 35);
            this.btnClearDescitpto.TabIndex = 13;
            this.btnClearDescitpto.Text = "Limpar";
            this.btnClearDescitpto.UseVisualStyleBackColor = true;
            this.btnClearDescitpto.Click += new System.EventHandler(this.btnClearDescitpto_Click);
            // 
            // richTxtMsg
            // 
            this.richTxtMsg.Location = new System.Drawing.Point(94, 85);
            this.richTxtMsg.Name = "richTxtMsg";
            this.richTxtMsg.Size = new System.Drawing.Size(415, 261);
            this.richTxtMsg.TabIndex = 12;
            this.richTxtMsg.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cole aqui ou digite o texto que você quer descriptografar";
            // 
            // lblCripto
            // 
            this.lblCripto.AutoSize = true;
            this.lblCripto.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCripto.Location = new System.Drawing.Point(532, 62);
            this.lblCripto.Name = "lblCripto";
            this.lblCripto.Size = new System.Drawing.Size(139, 20);
            this.lblCripto.TabIndex = 10;
            this.lblCripto.Text = "Texto Descriptografado";
            // 
            // btnDescritpo
            // 
            this.btnDescritpo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescritpo.Location = new System.Drawing.Point(94, 352);
            this.btnDescritpo.Name = "btnDescritpo";
            this.btnDescritpo.Size = new System.Drawing.Size(208, 35);
            this.btnDescritpo.TabIndex = 9;
            this.btnDescritpo.Text = "Descriptografar Texto";
            this.btnDescritpo.UseVisualStyleBackColor = true;
            this.btnDescritpo.Click += new System.EventHandler(this.btnDescritpo_Click);
            // 
            // frmDescriptografar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 472);
            this.ControlBox = false;
            this.Controls.Add(this.richTxtDescript);
            this.Controls.Add(this.btnClearDescitpto);
            this.Controls.Add(this.richTxtMsg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCripto);
            this.Controls.Add(this.btnDescritpo);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDescriptografar";
            this.Text = "Descriptografar";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem criptografarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTxtDescript;
        private System.Windows.Forms.Button btnClearDescitpto;
        private System.Windows.Forms.RichTextBox richTxtMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCripto;
        private System.Windows.Forms.Button btnDescritpo;
    }
}