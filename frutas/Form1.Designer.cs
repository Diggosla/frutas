namespace frutas
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.boxmaca = new System.Windows.Forms.CheckBox();
            this.Boxpera = new System.Windows.Forms.CheckBox();
            this.Boxuva = new System.Windows.Forms.CheckBox();
            this.Boxabacaxi = new System.Windows.Forms.CheckBox();
            this.Boxmorango = new System.Windows.Forms.CheckBox();
            this.Boxbanana = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Boxmamao = new System.Windows.Forms.CheckBox();
            this.bntfruta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boxmaca
            // 
            this.boxmaca.AutoSize = true;
            this.boxmaca.Location = new System.Drawing.Point(17, 56);
            this.boxmaca.Name = "boxmaca";
            this.boxmaca.Size = new System.Drawing.Size(56, 17);
            this.boxmaca.TabIndex = 0;
            this.boxmaca.Text = "MAÇA";
            this.boxmaca.UseVisualStyleBackColor = true;
            // 
            // Boxpera
            // 
            this.Boxpera.AutoSize = true;
            this.Boxpera.Location = new System.Drawing.Point(17, 79);
            this.Boxpera.Name = "Boxpera";
            this.Boxpera.Size = new System.Drawing.Size(55, 17);
            this.Boxpera.TabIndex = 1;
            this.Boxpera.Text = "PÈRA";
            this.Boxpera.UseVisualStyleBackColor = true;
            this.Boxpera.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Boxuva
            // 
            this.Boxuva.AutoSize = true;
            this.Boxuva.Location = new System.Drawing.Point(17, 102);
            this.Boxuva.Name = "Boxuva";
            this.Boxuva.Size = new System.Drawing.Size(48, 17);
            this.Boxuva.TabIndex = 2;
            this.Boxuva.Text = "UVA";
            this.Boxuva.UseVisualStyleBackColor = true;
            // 
            // Boxabacaxi
            // 
            this.Boxabacaxi.AutoSize = true;
            this.Boxabacaxi.Location = new System.Drawing.Point(16, 125);
            this.Boxabacaxi.Name = "Boxabacaxi";
            this.Boxabacaxi.Size = new System.Drawing.Size(71, 17);
            this.Boxabacaxi.TabIndex = 3;
            this.Boxabacaxi.Text = "ABACAXI";
            this.Boxabacaxi.UseVisualStyleBackColor = true;
            // 
            // Boxmorango
            // 
            this.Boxmorango.AutoSize = true;
            this.Boxmorango.Location = new System.Drawing.Point(17, 148);
            this.Boxmorango.Name = "Boxmorango";
            this.Boxmorango.Size = new System.Drawing.Size(82, 17);
            this.Boxmorango.TabIndex = 4;
            this.Boxmorango.Text = "MORANGO";
            this.Boxmorango.UseVisualStyleBackColor = true;
            // 
            // Boxbanana
            // 
            this.Boxbanana.AutoSize = true;
            this.Boxbanana.Location = new System.Drawing.Point(17, 171);
            this.Boxbanana.Name = "Boxbanana";
            this.Boxbanana.Size = new System.Drawing.Size(70, 17);
            this.Boxbanana.TabIndex = 6;
            this.Boxbanana.Text = "BANANA";
            this.Boxbanana.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Escolha sua frita:";
            // 
            // Boxmamao
            // 
            this.Boxmamao.AutoSize = true;
            this.Boxmamao.Location = new System.Drawing.Point(17, 194);
            this.Boxmamao.Name = "Boxmamao";
            this.Boxmamao.Size = new System.Drawing.Size(66, 17);
            this.Boxmamao.TabIndex = 8;
            this.Boxmamao.Text = "MAMÂO";
            this.Boxmamao.UseVisualStyleBackColor = true;
            // 
            // bntfruta
            // 
            this.bntfruta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntfruta.Location = new System.Drawing.Point(260, 9);
            this.bntfruta.Name = "bntfruta";
            this.bntfruta.Size = new System.Drawing.Size(339, 23);
            this.bntfruta.TabIndex = 9;
            this.bntfruta.Text = "Escolha a Fruta ao lado e clique aqui!";
            this.bntfruta.UseVisualStyleBackColor = true;
            this.bntfruta.Click += new System.EventHandler(this.bntfruta_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 248);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bntfruta);
            this.Controls.Add(this.Boxmamao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Boxbanana);
            this.Controls.Add(this.Boxmorango);
            this.Controls.Add(this.Boxabacaxi);
            this.Controls.Add(this.Boxuva);
            this.Controls.Add(this.Boxpera);
            this.Controls.Add(this.boxmaca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Frutas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox boxmaca;
        private System.Windows.Forms.CheckBox Boxpera;
        private System.Windows.Forms.CheckBox Boxuva;
        private System.Windows.Forms.CheckBox Boxabacaxi;
        private System.Windows.Forms.CheckBox Boxmorango;
        private System.Windows.Forms.CheckBox Boxbanana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Boxmamao;
        private System.Windows.Forms.Button bntfruta;
        private System.Windows.Forms.Button button1;
    }
}

