
namespace criptografar
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCritpo = new System.Windows.Forms.Button();
            this.lblCripto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTxtMsg = new System.Windows.Forms.RichTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.richTxtCript = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.decriptografarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCritpo
            // 
            this.btnCritpo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCritpo.Location = new System.Drawing.Point(88, 338);
            this.btnCritpo.Name = "btnCritpo";
            this.btnCritpo.Size = new System.Drawing.Size(208, 35);
            this.btnCritpo.TabIndex = 0;
            this.btnCritpo.Text = "Criptografar Texto";
            this.btnCritpo.UseVisualStyleBackColor = true;
            this.btnCritpo.Click += new System.EventHandler(this.btnCritpo_Click);
            // 
            // lblCripto
            // 
            this.lblCripto.AutoSize = true;
            this.lblCripto.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCripto.Location = new System.Drawing.Point(526, 48);
            this.lblCripto.Name = "lblCripto";
            this.lblCripto.Size = new System.Drawing.Size(412, 20);
            this.lblCripto.TabIndex = 1;
            this.lblCripto.Text = "Texto criptografado (Cópie o texto criptografado na caixa de texto abaixo)";
            this.lblCripto.Click += new System.EventHandler(this.lblCripto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite o texto que você quer criptografar";
            // 
            // richTxtMsg
            // 
            this.richTxtMsg.Location = new System.Drawing.Point(88, 71);
            this.richTxtMsg.Name = "richTxtMsg";
            this.richTxtMsg.Size = new System.Drawing.Size(415, 261);
            this.richTxtMsg.TabIndex = 4;
            this.richTxtMsg.Text = "";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(330, 338);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 35);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // richTxtCript
            // 
            this.richTxtCript.Location = new System.Drawing.Point(530, 71);
            this.richTxtCript.Name = "richTxtCript";
            this.richTxtCript.Size = new System.Drawing.Size(424, 261);
            this.richTxtCript.TabIndex = 6;
            this.richTxtCript.Text = "";
            this.richTxtCript.EnabledChanged += new System.EventHandler(this.richTextBox1_EnabledChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.decriptografarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1095, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // decriptografarToolStripMenuItem
            // 
            this.decriptografarToolStripMenuItem.Name = "decriptografarToolStripMenuItem";
            this.decriptografarToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.decriptografarToolStripMenuItem.Text = "Decriptografar";
            this.decriptografarToolStripMenuItem.Click += new System.EventHandler(this.decriptografarToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(536, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 472);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTxtCript);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.richTxtMsg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCripto);
            this.Controls.Add(this.btnCritpo);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Criptografar";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCritpo;
        private System.Windows.Forms.Label lblCripto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTxtMsg;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RichTextBox richTxtCript;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem decriptografarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label label2;
    }
}

