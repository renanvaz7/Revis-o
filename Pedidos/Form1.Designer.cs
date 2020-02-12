namespace Pedidos
{
    partial class frmPedidos
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
            this.groupBoxSuco = new System.Windows.Forms.GroupBox();
            this.labelSucoDetox = new System.Windows.Forms.Label();
            this.labelPreçoSucoDeLaranja = new System.Windows.Forms.Label();
            this.rbnSucoDetox = new System.Windows.Forms.RadioButton();
            this.rbnSucoDeLaranja = new System.Windows.Forms.RadioButton();
            this.groupBoxSanduiche = new System.Windows.Forms.GroupBox();
            this.labelPreçoBauru = new System.Windows.Forms.Label();
            this.labelPreçoMisto = new System.Windows.Forms.Label();
            this.labelPreçoXEggFrango = new System.Windows.Forms.Label();
            this.labelXEggBurguer = new System.Windows.Forms.Label();
            this.labelXSalada = new System.Windows.Forms.Label();
            this.labelXTudo = new System.Windows.Forms.Label();
            this.rbnBauru = new System.Windows.Forms.RadioButton();
            this.rbnMisto = new System.Windows.Forms.RadioButton();
            this.rbnXEggFrango = new System.Windows.Forms.RadioButton();
            this.rbnXEggBurguer = new System.Windows.Forms.RadioButton();
            this.rbnXSalada = new System.Windows.Forms.RadioButton();
            this.rbnXTudo = new System.Windows.Forms.RadioButton();
            this.groupBoxRefrigerante = new System.Windows.Forms.GroupBox();
            this.labelGuarana = new System.Windows.Forms.Label();
            this.labelCocaCola = new System.Windows.Forms.Label();
            this.rbnGuarana = new System.Windows.Forms.RadioButton();
            this.rbnCocaCola = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.groupBoxSuco.SuspendLayout();
            this.groupBoxSanduiche.SuspendLayout();
            this.groupBoxRefrigerante.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSuco
            // 
            this.groupBoxSuco.Controls.Add(this.labelSucoDetox);
            this.groupBoxSuco.Controls.Add(this.labelPreçoSucoDeLaranja);
            this.groupBoxSuco.Controls.Add(this.rbnSucoDetox);
            this.groupBoxSuco.Controls.Add(this.rbnSucoDeLaranja);
            this.groupBoxSuco.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSuco.Name = "groupBoxSuco";
            this.groupBoxSuco.Size = new System.Drawing.Size(371, 111);
            this.groupBoxSuco.TabIndex = 0;
            this.groupBoxSuco.TabStop = false;
            this.groupBoxSuco.Text = "Suco";
            // 
            // labelSucoDetox
            // 
            this.labelSucoDetox.AutoSize = true;
            this.labelSucoDetox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSucoDetox.Location = new System.Drawing.Point(283, 76);
            this.labelSucoDetox.Name = "labelSucoDetox";
            this.labelSucoDetox.Size = new System.Drawing.Size(65, 15);
            this.labelSucoDetox.TabIndex = 3;
            this.labelSucoDetox.Text = "R$ 12.50";
            // 
            // labelPreçoSucoDeLaranja
            // 
            this.labelPreçoSucoDeLaranja.AutoSize = true;
            this.labelPreçoSucoDeLaranja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreçoSucoDeLaranja.Location = new System.Drawing.Point(284, 30);
            this.labelPreçoSucoDeLaranja.Name = "labelPreçoSucoDeLaranja";
            this.labelPreçoSucoDeLaranja.Size = new System.Drawing.Size(57, 15);
            this.labelPreçoSucoDeLaranja.TabIndex = 2;
            this.labelPreçoSucoDeLaranja.Text = "R$ 5.70";
            // 
            // rbnSucoDetox
            // 
            this.rbnSucoDetox.AutoSize = true;
            this.rbnSucoDetox.Location = new System.Drawing.Point(13, 72);
            this.rbnSucoDetox.Name = "rbnSucoDetox";
            this.rbnSucoDetox.Size = new System.Drawing.Size(81, 17);
            this.rbnSucoDetox.TabIndex = 1;
            this.rbnSucoDetox.TabStop = true;
            this.rbnSucoDetox.Text = "Suco Detox";
            this.rbnSucoDetox.UseVisualStyleBackColor = true;
            this.rbnSucoDetox.CheckedChanged += new System.EventHandler(this.rbnSucoDeLaranja_CheckedChanged_1);
            // 
            // rbnSucoDeLaranja
            // 
            this.rbnSucoDeLaranja.AutoSize = true;
            this.rbnSucoDeLaranja.Location = new System.Drawing.Point(13, 30);
            this.rbnSucoDeLaranja.Name = "rbnSucoDeLaranja";
            this.rbnSucoDeLaranja.Size = new System.Drawing.Size(103, 17);
            this.rbnSucoDeLaranja.TabIndex = 0;
            this.rbnSucoDeLaranja.TabStop = true;
            this.rbnSucoDeLaranja.Text = "Suco de Laranja";
            this.rbnSucoDeLaranja.UseVisualStyleBackColor = true;
            this.rbnSucoDeLaranja.CheckedChanged += new System.EventHandler(this.rbnSucoDeLaranja_CheckedChanged_1);
            // 
            // groupBoxSanduiche
            // 
            this.groupBoxSanduiche.Controls.Add(this.labelPreçoBauru);
            this.groupBoxSanduiche.Controls.Add(this.labelPreçoMisto);
            this.groupBoxSanduiche.Controls.Add(this.labelPreçoXEggFrango);
            this.groupBoxSanduiche.Controls.Add(this.labelXEggBurguer);
            this.groupBoxSanduiche.Controls.Add(this.labelXSalada);
            this.groupBoxSanduiche.Controls.Add(this.labelXTudo);
            this.groupBoxSanduiche.Controls.Add(this.rbnBauru);
            this.groupBoxSanduiche.Controls.Add(this.rbnMisto);
            this.groupBoxSanduiche.Controls.Add(this.rbnXEggFrango);
            this.groupBoxSanduiche.Controls.Add(this.rbnXEggBurguer);
            this.groupBoxSanduiche.Controls.Add(this.rbnXSalada);
            this.groupBoxSanduiche.Controls.Add(this.rbnXTudo);
            this.groupBoxSanduiche.Location = new System.Drawing.Point(524, 12);
            this.groupBoxSanduiche.Name = "groupBoxSanduiche";
            this.groupBoxSanduiche.Size = new System.Drawing.Size(264, 272);
            this.groupBoxSanduiche.TabIndex = 1;
            this.groupBoxSanduiche.TabStop = false;
            this.groupBoxSanduiche.Text = "Sanduíche";
            // 
            // labelPreçoBauru
            // 
            this.labelPreçoBauru.AutoSize = true;
            this.labelPreçoBauru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreçoBauru.Location = new System.Drawing.Point(186, 238);
            this.labelPreçoBauru.Name = "labelPreçoBauru";
            this.labelPreçoBauru.Size = new System.Drawing.Size(65, 15);
            this.labelPreçoBauru.TabIndex = 11;
            this.labelPreçoBauru.Text = "R$ 11.50";
            // 
            // labelPreçoMisto
            // 
            this.labelPreçoMisto.AutoSize = true;
            this.labelPreçoMisto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreçoMisto.Location = new System.Drawing.Point(186, 198);
            this.labelPreçoMisto.Name = "labelPreçoMisto";
            this.labelPreçoMisto.Size = new System.Drawing.Size(57, 15);
            this.labelPreçoMisto.TabIndex = 10;
            this.labelPreçoMisto.Text = "R$ 9.50";
            // 
            // labelPreçoXEggFrango
            // 
            this.labelPreçoXEggFrango.AutoSize = true;
            this.labelPreçoXEggFrango.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreçoXEggFrango.Location = new System.Drawing.Point(186, 156);
            this.labelPreçoXEggFrango.Name = "labelPreçoXEggFrango";
            this.labelPreçoXEggFrango.Size = new System.Drawing.Size(65, 15);
            this.labelPreçoXEggFrango.TabIndex = 9;
            this.labelPreçoXEggFrango.Text = "R$ 18.50";
            // 
            // labelXEggBurguer
            // 
            this.labelXEggBurguer.AutoSize = true;
            this.labelXEggBurguer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXEggBurguer.Location = new System.Drawing.Point(186, 116);
            this.labelXEggBurguer.Name = "labelXEggBurguer";
            this.labelXEggBurguer.Size = new System.Drawing.Size(65, 15);
            this.labelXEggBurguer.TabIndex = 8;
            this.labelXEggBurguer.Text = "R$ 16.50";
            // 
            // labelXSalada
            // 
            this.labelXSalada.AutoSize = true;
            this.labelXSalada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXSalada.Location = new System.Drawing.Point(186, 76);
            this.labelXSalada.Name = "labelXSalada";
            this.labelXSalada.Size = new System.Drawing.Size(65, 15);
            this.labelXSalada.TabIndex = 7;
            this.labelXSalada.Text = "R$ 12.50";
            // 
            // labelXTudo
            // 
            this.labelXTudo.AutoSize = true;
            this.labelXTudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXTudo.Location = new System.Drawing.Point(186, 34);
            this.labelXTudo.Name = "labelXTudo";
            this.labelXTudo.Size = new System.Drawing.Size(65, 15);
            this.labelXTudo.TabIndex = 6;
            this.labelXTudo.Text = "R$ 16.50";
            // 
            // rbnBauru
            // 
            this.rbnBauru.AutoSize = true;
            this.rbnBauru.Location = new System.Drawing.Point(12, 238);
            this.rbnBauru.Name = "rbnBauru";
            this.rbnBauru.Size = new System.Drawing.Size(53, 17);
            this.rbnBauru.TabIndex = 5;
            this.rbnBauru.Text = "Bauru";
            this.rbnBauru.UseVisualStyleBackColor = true;
            this.rbnBauru.CheckedChanged += new System.EventHandler(this.rbnXTudo_CheckedChanged);
            // 
            // rbnMisto
            // 
            this.rbnMisto.AutoSize = true;
            this.rbnMisto.Location = new System.Drawing.Point(12, 194);
            this.rbnMisto.Name = "rbnMisto";
            this.rbnMisto.Size = new System.Drawing.Size(50, 17);
            this.rbnMisto.TabIndex = 4;
            this.rbnMisto.Text = "Misto";
            this.rbnMisto.UseVisualStyleBackColor = true;
            this.rbnMisto.CheckedChanged += new System.EventHandler(this.rbnXTudo_CheckedChanged);
            // 
            // rbnXEggFrango
            // 
            this.rbnXEggFrango.AutoSize = true;
            this.rbnXEggFrango.Location = new System.Drawing.Point(12, 154);
            this.rbnXEggFrango.Name = "rbnXEggFrango";
            this.rbnXEggFrango.Size = new System.Drawing.Size(96, 17);
            this.rbnXEggFrango.TabIndex = 3;
            this.rbnXEggFrango.Text = "X - Egg Frango";
            this.rbnXEggFrango.UseVisualStyleBackColor = true;
            this.rbnXEggFrango.CheckedChanged += new System.EventHandler(this.rbnXTudo_CheckedChanged);
            // 
            // rbnXEggBurguer
            // 
            this.rbnXEggBurguer.AutoSize = true;
            this.rbnXEggBurguer.Location = new System.Drawing.Point(12, 112);
            this.rbnXEggBurguer.Name = "rbnXEggBurguer";
            this.rbnXEggBurguer.Size = new System.Drawing.Size(100, 17);
            this.rbnXEggBurguer.TabIndex = 2;
            this.rbnXEggBurguer.Text = "X - Egg Burguer";
            this.rbnXEggBurguer.UseVisualStyleBackColor = true;
            this.rbnXEggBurguer.CheckedChanged += new System.EventHandler(this.rbnXTudo_CheckedChanged);
            // 
            // rbnXSalada
            // 
            this.rbnXSalada.AutoSize = true;
            this.rbnXSalada.Location = new System.Drawing.Point(12, 72);
            this.rbnXSalada.Name = "rbnXSalada";
            this.rbnXSalada.Size = new System.Drawing.Size(74, 17);
            this.rbnXSalada.TabIndex = 1;
            this.rbnXSalada.Text = "X - Salada";
            this.rbnXSalada.UseVisualStyleBackColor = true;
            this.rbnXSalada.CheckedChanged += new System.EventHandler(this.rbnXTudo_CheckedChanged);
            // 
            // rbnXTudo
            // 
            this.rbnXTudo.AutoSize = true;
            this.rbnXTudo.Location = new System.Drawing.Point(12, 30);
            this.rbnXTudo.Name = "rbnXTudo";
            this.rbnXTudo.Size = new System.Drawing.Size(66, 17);
            this.rbnXTudo.TabIndex = 0;
            this.rbnXTudo.Text = "X - Tudo";
            this.rbnXTudo.UseVisualStyleBackColor = true;
            this.rbnXTudo.CheckedChanged += new System.EventHandler(this.rbnXTudo_CheckedChanged);
            // 
            // groupBoxRefrigerante
            // 
            this.groupBoxRefrigerante.Controls.Add(this.labelGuarana);
            this.groupBoxRefrigerante.Controls.Add(this.labelCocaCola);
            this.groupBoxRefrigerante.Controls.Add(this.rbnGuarana);
            this.groupBoxRefrigerante.Controls.Add(this.rbnCocaCola);
            this.groupBoxRefrigerante.Location = new System.Drawing.Point(12, 173);
            this.groupBoxRefrigerante.Name = "groupBoxRefrigerante";
            this.groupBoxRefrigerante.Size = new System.Drawing.Size(371, 111);
            this.groupBoxRefrigerante.TabIndex = 2;
            this.groupBoxRefrigerante.TabStop = false;
            this.groupBoxRefrigerante.Text = "Refrigerante";
            // 
            // labelGuarana
            // 
            this.labelGuarana.AutoSize = true;
            this.labelGuarana.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGuarana.Location = new System.Drawing.Point(283, 79);
            this.labelGuarana.Name = "labelGuarana";
            this.labelGuarana.Size = new System.Drawing.Size(57, 15);
            this.labelGuarana.TabIndex = 3;
            this.labelGuarana.Text = "R$ 5.00";
            // 
            // labelCocaCola
            // 
            this.labelCocaCola.AutoSize = true;
            this.labelCocaCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCocaCola.Location = new System.Drawing.Point(283, 37);
            this.labelCocaCola.Name = "labelCocaCola";
            this.labelCocaCola.Size = new System.Drawing.Size(57, 15);
            this.labelCocaCola.TabIndex = 2;
            this.labelCocaCola.Text = "R$ 6.50";
            // 
            // rbnGuarana
            // 
            this.rbnGuarana.AutoSize = true;
            this.rbnGuarana.Location = new System.Drawing.Point(13, 77);
            this.rbnGuarana.Name = "rbnGuarana";
            this.rbnGuarana.Size = new System.Drawing.Size(97, 17);
            this.rbnGuarana.TabIndex = 1;
            this.rbnGuarana.TabStop = true;
            this.rbnGuarana.Text = "Guaraná 600ml";
            this.rbnGuarana.UseVisualStyleBackColor = true;
            this.rbnGuarana.CheckedChanged += new System.EventHandler(this.rbnCocaCola_CheckedChanged);
            // 
            // rbnCocaCola
            // 
            this.rbnCocaCola.AutoSize = true;
            this.rbnCocaCola.Location = new System.Drawing.Point(13, 33);
            this.rbnCocaCola.Name = "rbnCocaCola";
            this.rbnCocaCola.Size = new System.Drawing.Size(98, 17);
            this.rbnCocaCola.TabIndex = 0;
            this.rbnCocaCola.TabStop = true;
            this.rbnCocaCola.Text = "Coca Cola 1,5L";
            this.rbnCocaCola.UseVisualStyleBackColor = true;
            this.rbnCocaCola.CheckedChanged += new System.EventHandler(this.rbnCocaCola_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total a pagar R$";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.Red;
            this.labelTotal.Location = new System.Drawing.Point(486, 344);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTotal.Size = new System.Drawing.Size(0, 25);
            this.labelTotal.TabIndex = 4;
            // 
            // frmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxRefrigerante);
            this.Controls.Add(this.groupBoxSanduiche);
            this.Controls.Add(this.groupBoxSuco);
            this.Name = "frmPedidos";
            this.Text = "Pedidos";
            this.groupBoxSuco.ResumeLayout(false);
            this.groupBoxSuco.PerformLayout();
            this.groupBoxSanduiche.ResumeLayout(false);
            this.groupBoxSanduiche.PerformLayout();
            this.groupBoxRefrigerante.ResumeLayout(false);
            this.groupBoxRefrigerante.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSuco;
        private System.Windows.Forms.GroupBox groupBoxSanduiche;
        private System.Windows.Forms.GroupBox groupBoxRefrigerante;
        private System.Windows.Forms.RadioButton rbnSucoDetox;
        private System.Windows.Forms.RadioButton rbnSucoDeLaranja;
        private System.Windows.Forms.RadioButton rbnGuarana;
        private System.Windows.Forms.RadioButton rbnCocaCola;
        private System.Windows.Forms.Label labelSucoDetox;
        private System.Windows.Forms.Label labelPreçoSucoDeLaranja;
        private System.Windows.Forms.RadioButton rbnBauru;
        private System.Windows.Forms.RadioButton rbnMisto;
        private System.Windows.Forms.RadioButton rbnXEggFrango;
        private System.Windows.Forms.RadioButton rbnXEggBurguer;
        private System.Windows.Forms.RadioButton rbnXSalada;
        private System.Windows.Forms.RadioButton rbnXTudo;
        private System.Windows.Forms.Label labelGuarana;
        private System.Windows.Forms.Label labelCocaCola;
        private System.Windows.Forms.Label labelPreçoBauru;
        private System.Windows.Forms.Label labelPreçoMisto;
        private System.Windows.Forms.Label labelPreçoXEggFrango;
        private System.Windows.Forms.Label labelXEggBurguer;
        private System.Windows.Forms.Label labelXSalada;
        private System.Windows.Forms.Label labelXTudo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotal;
    }
}

