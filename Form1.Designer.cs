namespace CodiceFiscale
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.calc = new System.Windows.Forms.Button();
            this.cog = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.esciMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.puntodomMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.nome = new System.Windows.Forms.TextBox();
            this.giorno = new System.Windows.Forms.TextBox();
            this.mese = new System.Windows.Forms.TextBox();
            this.anno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.provinciaa = new System.Windows.Forms.TextBox();
            this.comunee = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelCodice = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.codiLabel = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.random = new System.Windows.Forms.ToolStripMenuItem();
            this.randomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calc
            // 
            this.calc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calc.BackColor = System.Drawing.Color.Transparent;
            this.calc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calc.ForeColor = System.Drawing.Color.Red;
            this.calc.Location = new System.Drawing.Point(236, 338);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(119, 36);
            this.calc.TabIndex = 0;
            this.calc.Text = "Calcola";
            this.calc.UseVisualStyleBackColor = false;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // cog
            // 
            this.cog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cog.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cog.ForeColor = System.Drawing.Color.Black;
            this.cog.Location = new System.Drawing.Point(131, 70);
            this.cog.MaxLength = 40;
            this.cog.Name = "cog";
            this.cog.Size = new System.Drawing.Size(224, 32);
            this.cog.TabIndex = 1;
            this.cog.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cog_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Aqua;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.random,
            this.aboutMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(706, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvaMenu,
            this.esciMenu});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "File";
            // 
            // salvaMenu
            // 
            this.salvaMenu.Name = "salvaMenu";
            this.salvaMenu.Size = new System.Drawing.Size(180, 22);
            this.salvaMenu.Text = "Salva";
            this.salvaMenu.Click += new System.EventHandler(this.salvaMenu_Click);
            // 
            // esciMenu
            // 
            this.esciMenu.Name = "esciMenu";
            this.esciMenu.Size = new System.Drawing.Size(180, 22);
            this.esciMenu.Text = "Esci";
            this.esciMenu.Click += new System.EventHandler(this.esciMenu_Click);
            // 
            // aboutMenu
            // 
            this.aboutMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.puntodomMenu});
            this.aboutMenu.Name = "aboutMenu";
            this.aboutMenu.Size = new System.Drawing.Size(52, 20);
            this.aboutMenu.Text = "About";
            // 
            // puntodomMenu
            // 
            this.puntodomMenu.Name = "puntodomMenu";
            this.puntodomMenu.Size = new System.Drawing.Size(180, 22);
            this.puntodomMenu.Text = "?";
            this.puntodomMenu.Click += new System.EventHandler(this.puntodomMenu_Click);
            // 
            // male
            // 
            this.male.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.male.AutoSize = true;
            this.male.Checked = true;
            this.male.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male.Location = new System.Drawing.Point(417, 70);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(86, 24);
            this.male.TabIndex = 5;
            this.male.TabStop = true;
            this.male.Text = "Maschio";
            this.male.UseVisualStyleBackColor = true;
            this.male.CheckedChanged += new System.EventHandler(this.male_CheckedChanged);
            // 
            // female
            // 
            this.female.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.female.AutoSize = true;
            this.female.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female.Location = new System.Drawing.Point(526, 70);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(93, 24);
            this.female.TabIndex = 6;
            this.female.TabStop = true;
            this.female.Text = "Femmina";
            this.female.UseVisualStyleBackColor = true;
            this.female.CheckedChanged += new System.EventHandler(this.female_CheckedChanged);
            // 
            // nome
            // 
            this.nome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.ForeColor = System.Drawing.Color.Black;
            this.nome.Location = new System.Drawing.Point(131, 149);
            this.nome.MaxLength = 40;
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(224, 32);
            this.nome.TabIndex = 7;
            this.nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nome_KeyPress);
            // 
            // giorno
            // 
            this.giorno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.giorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giorno.Location = new System.Drawing.Point(417, 152);
            this.giorno.MaxLength = 2;
            this.giorno.Name = "giorno";
            this.giorno.Size = new System.Drawing.Size(51, 30);
            this.giorno.TabIndex = 8;
            this.giorno.Text = "1";
            this.giorno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.giorno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.giorno_KeyPress);
            // 
            // mese
            // 
            this.mese.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mese.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mese.Location = new System.Drawing.Point(498, 152);
            this.mese.MaxLength = 2;
            this.mese.Name = "mese";
            this.mese.Size = new System.Drawing.Size(51, 30);
            this.mese.TabIndex = 9;
            this.mese.Text = "1";
            this.mese.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mese.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mese_KeyPress);
            // 
            // anno
            // 
            this.anno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.anno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anno.Location = new System.Drawing.Point(579, 151);
            this.anno.MaxLength = 4;
            this.anno.Name = "anno";
            this.anno.Size = new System.Drawing.Size(61, 30);
            this.anno.TabIndex = 10;
            this.anno.Text = "1970";
            this.anno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.anno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.anno_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(474, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(555, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "/";
            // 
            // provinciaa
            // 
            this.provinciaa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.provinciaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provinciaa.ForeColor = System.Drawing.Color.Black;
            this.provinciaa.Location = new System.Drawing.Point(526, 236);
            this.provinciaa.MaxLength = 2;
            this.provinciaa.Name = "provinciaa";
            this.provinciaa.Size = new System.Drawing.Size(70, 32);
            this.provinciaa.TabIndex = 13;
            this.provinciaa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.provinciaa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.provinciaa_KeyPress);
            // 
            // comunee
            // 
            this.comunee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comunee.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comunee.ForeColor = System.Drawing.Color.Black;
            this.comunee.Location = new System.Drawing.Point(131, 236);
            this.comunee.MaxLength = 25;
            this.comunee.Name = "comunee";
            this.comunee.Size = new System.Drawing.Size(224, 32);
            this.comunee.TabIndex = 14;
            this.comunee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comunee_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(355, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 26);
            this.label3.TabIndex = 15;
            // 
            // LabelCodice
            // 
            this.LabelCodice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelCodice.AutoSize = true;
            this.LabelCodice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelCodice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCodice.Location = new System.Drawing.Point(250, 407);
            this.LabelCodice.Name = "LabelCodice";
            this.LabelCodice.Padding = new System.Windows.Forms.Padding(1);
            this.LabelCodice.Size = new System.Drawing.Size(147, 28);
            this.LabelCodice.TabIndex = 16;
            this.LabelCodice.Text = "Codice Finale";
            this.LabelCodice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelCodice.Visible = false;
            this.LabelCodice.Click += new System.EventHandler(this.LabelCodice_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Name";
            this.openFileDialog1.Title = "Solo file .codd";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 26);
            this.label4.TabIndex = 17;
            this.label4.Text = "Cognome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 26);
            this.label5.TabIndex = 18;
            this.label5.Text = "Nome:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 26);
            this.label6.TabIndex = 19;
            this.label6.Text = "Comune:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(412, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 26);
            this.label7.TabIndex = 20;
            this.label7.Text = "Provincia:";
            // 
            // codiLabel
            // 
            this.codiLabel.AutoSize = true;
            this.codiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codiLabel.Location = new System.Drawing.Point(143, 407);
            this.codiLabel.Name = "codiLabel";
            this.codiLabel.Size = new System.Drawing.Size(86, 26);
            this.codiLabel.TabIndex = 21;
            this.codiLabel.Text = "Codice:";
            this.codiLabel.Visible = false;
            // 
            // clear
            // 
            this.clear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clear.BackColor = System.Drawing.Color.Transparent;
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.Color.Blue;
            this.clear.Location = new System.Drawing.Point(365, 338);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 36);
            this.clear.TabIndex = 22;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Title = "Salva codice";
            // 
            // random
            // 
            this.random.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randomToolStripMenuItem});
            this.random.Name = "random";
            this.random.Size = new System.Drawing.Size(52, 20);
            this.random.Text = "Azioni";
            // 
            // randomToolStripMenuItem
            // 
            this.randomToolStripMenuItem.Name = "randomToolStripMenuItem";
            this.randomToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.randomToolStripMenuItem.Text = "Random";
            this.randomToolStripMenuItem.Click += new System.EventHandler(this.random_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(706, 478);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.codiLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LabelCodice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comunee);
            this.Controls.Add(this.provinciaa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.anno);
            this.Controls.Add(this.mese);
            this.Controls.Add(this.giorno);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.cog);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Codice Fiscale";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.TextBox cog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem salvaMenu;
        private System.Windows.Forms.ToolStripMenuItem esciMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutMenu;
        private System.Windows.Forms.ToolStripMenuItem puntodomMenu;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox giorno;
        private System.Windows.Forms.TextBox mese;
        private System.Windows.Forms.TextBox anno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox provinciaa;
        private System.Windows.Forms.TextBox comunee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelCodice;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label codiLabel;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem random;
        private System.Windows.Forms.ToolStripMenuItem randomToolStripMenuItem;
    }
}

