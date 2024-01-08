
namespace FORCA
{
    partial class FORCA
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtLetra = new System.Windows.Forms.TextBox();
            this.LblPalavraForca = new System.Windows.Forms.Label();
            this.BtnJogar = new System.Windows.Forms.Button();
            this.BtnLetra = new System.Windows.Forms.Button();
            this.LblDica = new System.Windows.Forms.Label();
            this.LblLetras = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblPernaEsquerda = new System.Windows.Forms.Label();
            this.LblPernaDireita = new System.Windows.Forms.Label();
            this.LblTronco = new System.Windows.Forms.Label();
            this.LblCabeca = new System.Windows.Forms.Label();
            this.LblBracoDireito = new System.Windows.Forms.Label();
            this.LblBracoEsquerdo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnDica = new System.Windows.Forms.Button();
            this.LblDica2 = new System.Windows.Forms.Label();
            this.BtnChutarPalavra = new System.Windows.Forms.Button();
            this.TxtPalavra = new System.Windows.Forms.TextBox();
            this.LblContador = new System.Windows.Forms.Label();
            this.BtnModoFacil = new System.Windows.Forms.Button();
            this.BtnModoMedio = new System.Windows.Forms.Button();
            this.BtnModoDificil = new System.Windows.Forms.Button();
            this.LblArrayPalavrasForca = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtLetra
            // 
            this.TxtLetra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtLetra.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtLetra.Location = new System.Drawing.Point(526, 244);
            this.TxtLetra.MaxLength = 1;
            this.TxtLetra.Name = "TxtLetra";
            this.TxtLetra.Size = new System.Drawing.Size(32, 27);
            this.TxtLetra.TabIndex = 1;
            this.TxtLetra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtLetra.Visible = false;
            this.TxtLetra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtLetra_KeyDown);
            // 
            // LblPalavraForca
            // 
            this.LblPalavraForca.AutoSize = true;
            this.LblPalavraForca.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPalavraForca.Location = new System.Drawing.Point(21, 25);
            this.LblPalavraForca.Name = "LblPalavraForca";
            this.LblPalavraForca.Size = new System.Drawing.Size(0, 58);
            this.LblPalavraForca.TabIndex = 1;
            this.LblPalavraForca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnJogar
            // 
            this.BtnJogar.BackColor = System.Drawing.Color.Olive;
            this.BtnJogar.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnJogar.ForeColor = System.Drawing.Color.White;
            this.BtnJogar.Location = new System.Drawing.Point(56, 271);
            this.BtnJogar.Name = "BtnJogar";
            this.BtnJogar.Size = new System.Drawing.Size(119, 27);
            this.BtnJogar.TabIndex = 0;
            this.BtnJogar.Text = "&NOVA PALAVRA";
            this.BtnJogar.UseVisualStyleBackColor = false;
            this.BtnJogar.Click += new System.EventHandler(this.BtnJogar_Click);
            // 
            // BtnLetra
            // 
            this.BtnLetra.BackColor = System.Drawing.Color.Olive;
            this.BtnLetra.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnLetra.ForeColor = System.Drawing.Color.White;
            this.BtnLetra.Location = new System.Drawing.Point(395, 244);
            this.BtnLetra.Name = "BtnLetra";
            this.BtnLetra.Size = new System.Drawing.Size(125, 27);
            this.BtnLetra.TabIndex = 2;
            this.BtnLetra.Text = "CHUTAR LETRA";
            this.BtnLetra.UseVisualStyleBackColor = false;
            this.BtnLetra.Visible = false;
            this.BtnLetra.Click += new System.EventHandler(this.BtnLetra_Click);
            // 
            // LblDica
            // 
            this.LblDica.AutoSize = true;
            this.LblDica.BackColor = System.Drawing.Color.Transparent;
            this.LblDica.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblDica.ForeColor = System.Drawing.Color.Transparent;
            this.LblDica.Location = new System.Drawing.Point(1, 308);
            this.LblDica.Name = "LblDica";
            this.LblDica.Size = new System.Drawing.Size(10, 13);
            this.LblDica.TabIndex = 4;
            this.LblDica.Text = " ";
            this.LblDica.Visible = false;
            // 
            // LblLetras
            // 
            this.LblLetras.AutoSize = true;
            this.LblLetras.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblLetras.Location = new System.Drawing.Point(410, 63);
            this.LblLetras.Name = "LblLetras";
            this.LblLetras.Size = new System.Drawing.Size(18, 29);
            this.LblLetras.TabIndex = 5;
            this.LblLetras.Text = " ";
            this.LblLetras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.LblPalavraForca);
            this.groupBox1.Location = new System.Drawing.Point(261, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(107, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "|";
            // 
            // LblPernaEsquerda
            // 
            this.LblPernaEsquerda.BackColor = System.Drawing.Color.Transparent;
            this.LblPernaEsquerda.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPernaEsquerda.ForeColor = System.Drawing.Color.Maroon;
            this.LblPernaEsquerda.Location = new System.Drawing.Point(76, 132);
            this.LblPernaEsquerda.Name = "LblPernaEsquerda";
            this.LblPernaEsquerda.Size = new System.Drawing.Size(37, 65);
            this.LblPernaEsquerda.TabIndex = 13;
            this.LblPernaEsquerda.Text = "/";
            this.LblPernaEsquerda.Visible = false;
            // 
            // LblPernaDireita
            // 
            this.LblPernaDireita.BackColor = System.Drawing.Color.Transparent;
            this.LblPernaDireita.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPernaDireita.ForeColor = System.Drawing.Color.Maroon;
            this.LblPernaDireita.Location = new System.Drawing.Point(110, 132);
            this.LblPernaDireita.Name = "LblPernaDireita";
            this.LblPernaDireita.Size = new System.Drawing.Size(37, 65);
            this.LblPernaDireita.TabIndex = 14;
            this.LblPernaDireita.Text = "\\";
            this.LblPernaDireita.Visible = false;
            // 
            // LblTronco
            // 
            this.LblTronco.BackColor = System.Drawing.Color.Maroon;
            this.LblTronco.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTronco.ForeColor = System.Drawing.Color.Maroon;
            this.LblTronco.Location = new System.Drawing.Point(112, 76);
            this.LblTronco.Name = "LblTronco";
            this.LblTronco.Size = new System.Drawing.Size(6, 69);
            this.LblTronco.TabIndex = 15;
            this.LblTronco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblTronco.Visible = false;
            // 
            // LblCabeca
            // 
            this.LblCabeca.BackColor = System.Drawing.Color.Transparent;
            this.LblCabeca.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblCabeca.ForeColor = System.Drawing.Color.Maroon;
            this.LblCabeca.Location = new System.Drawing.Point(78, 26);
            this.LblCabeca.Name = "LblCabeca";
            this.LblCabeca.Size = new System.Drawing.Size(77, 62);
            this.LblCabeca.TabIndex = 19;
            this.LblCabeca.Text = "O";
            this.LblCabeca.Visible = false;
            // 
            // LblBracoDireito
            // 
            this.LblBracoDireito.BackColor = System.Drawing.Color.Transparent;
            this.LblBracoDireito.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblBracoDireito.ForeColor = System.Drawing.Color.Maroon;
            this.LblBracoDireito.Location = new System.Drawing.Point(121, 87);
            this.LblBracoDireito.Name = "LblBracoDireito";
            this.LblBracoDireito.Size = new System.Drawing.Size(34, 63);
            this.LblBracoDireito.TabIndex = 22;
            this.LblBracoDireito.Text = "\\";
            this.LblBracoDireito.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LblBracoDireito.Visible = false;
            // 
            // LblBracoEsquerdo
            // 
            this.LblBracoEsquerdo.BackColor = System.Drawing.Color.Transparent;
            this.LblBracoEsquerdo.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblBracoEsquerdo.ForeColor = System.Drawing.Color.Maroon;
            this.LblBracoEsquerdo.Location = new System.Drawing.Point(74, 87);
            this.LblBracoEsquerdo.Name = "LblBracoEsquerdo";
            this.LblBracoEsquerdo.Size = new System.Drawing.Size(37, 63);
            this.LblBracoEsquerdo.TabIndex = 23;
            this.LblBracoEsquerdo.Text = "/";
            this.LblBracoEsquerdo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblBracoEsquerdo.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(261, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "LETRAS ERRADAS: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnDica
            // 
            this.BtnDica.BackColor = System.Drawing.Color.Olive;
            this.BtnDica.Font = new System.Drawing.Font("Bahnschrift Condensed", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDica.ForeColor = System.Drawing.Color.White;
            this.BtnDica.Location = new System.Drawing.Point(261, 201);
            this.BtnDica.Name = "BtnDica";
            this.BtnDica.Size = new System.Drawing.Size(35, 23);
            this.BtnDica.TabIndex = 25;
            this.BtnDica.Text = "&DICA";
            this.BtnDica.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnDica.UseVisualStyleBackColor = false;
            this.BtnDica.Visible = false;
            this.BtnDica.Click += new System.EventHandler(this.BtnDica_Click);
            // 
            // LblDica2
            // 
            this.LblDica2.AutoSize = true;
            this.LblDica2.BackColor = System.Drawing.Color.Transparent;
            this.LblDica2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblDica2.Location = new System.Drawing.Point(297, 207);
            this.LblDica2.Name = "LblDica2";
            this.LblDica2.Size = new System.Drawing.Size(61, 13);
            this.LblDica2.TabIndex = 26;
            this.LblDica2.Text = " É uma fruta.";
            this.LblDica2.Visible = false;
            // 
            // BtnChutarPalavra
            // 
            this.BtnChutarPalavra.BackColor = System.Drawing.Color.Olive;
            this.BtnChutarPalavra.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnChutarPalavra.ForeColor = System.Drawing.Color.White;
            this.BtnChutarPalavra.Location = new System.Drawing.Point(395, 271);
            this.BtnChutarPalavra.Name = "BtnChutarPalavra";
            this.BtnChutarPalavra.Size = new System.Drawing.Size(125, 27);
            this.BtnChutarPalavra.TabIndex = 4;
            this.BtnChutarPalavra.Text = "CHUTAR PALAVRA";
            this.BtnChutarPalavra.UseVisualStyleBackColor = false;
            this.BtnChutarPalavra.Visible = false;
            this.BtnChutarPalavra.Click += new System.EventHandler(this.BtnChutarPalavra_Click);
            // 
            // TxtPalavra
            // 
            this.TxtPalavra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPalavra.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPalavra.Location = new System.Drawing.Point(526, 271);
            this.TxtPalavra.MaxLength = 9;
            this.TxtPalavra.Name = "TxtPalavra";
            this.TxtPalavra.Size = new System.Drawing.Size(113, 27);
            this.TxtPalavra.TabIndex = 3;
            this.TxtPalavra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPalavra.Visible = false;
            this.TxtPalavra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPalavra_KeyDown);
            // 
            // LblContador
            // 
            this.LblContador.AutoSize = true;
            this.LblContador.ForeColor = System.Drawing.Color.Transparent;
            this.LblContador.Location = new System.Drawing.Point(230, 26);
            this.LblContador.Name = "LblContador";
            this.LblContador.Size = new System.Drawing.Size(13, 15);
            this.LblContador.TabIndex = 27;
            this.LblContador.Text = "0";
            // 
            // BtnModoFacil
            // 
            this.BtnModoFacil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnModoFacil.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnModoFacil.ForeColor = System.Drawing.Color.White;
            this.BtnModoFacil.Location = new System.Drawing.Point(445, 6);
            this.BtnModoFacil.Name = "BtnModoFacil";
            this.BtnModoFacil.Size = new System.Drawing.Size(75, 23);
            this.BtnModoFacil.TabIndex = 28;
            this.BtnModoFacil.Text = "FÁCIL";
            this.BtnModoFacil.UseVisualStyleBackColor = false;
            this.BtnModoFacil.Click += new System.EventHandler(this.BtnModoFacil_Click);
            // 
            // BtnModoMedio
            // 
            this.BtnModoMedio.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnModoMedio.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnModoMedio.ForeColor = System.Drawing.Color.White;
            this.BtnModoMedio.Location = new System.Drawing.Point(525, 6);
            this.BtnModoMedio.Name = "BtnModoMedio";
            this.BtnModoMedio.Size = new System.Drawing.Size(75, 23);
            this.BtnModoMedio.TabIndex = 29;
            this.BtnModoMedio.Text = "MÉDIO";
            this.BtnModoMedio.UseVisualStyleBackColor = false;
            this.BtnModoMedio.Click += new System.EventHandler(this.BtnModoMedio_Click);
            // 
            // BtnModoDificil
            // 
            this.BtnModoDificil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnModoDificil.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnModoDificil.ForeColor = System.Drawing.Color.White;
            this.BtnModoDificil.Location = new System.Drawing.Point(605, 6);
            this.BtnModoDificil.Name = "BtnModoDificil";
            this.BtnModoDificil.Size = new System.Drawing.Size(75, 23);
            this.BtnModoDificil.TabIndex = 30;
            this.BtnModoDificil.Text = "DIFÍCIL";
            this.BtnModoDificil.UseVisualStyleBackColor = false;
            this.BtnModoDificil.Click += new System.EventHandler(this.BtnModoDificil_Click);
            // 
            // LblArrayPalavrasForca
            // 
            this.LblArrayPalavrasForca.AutoSize = true;
            this.LblArrayPalavrasForca.ForeColor = System.Drawing.Color.Transparent;
            this.LblArrayPalavrasForca.Location = new System.Drawing.Point(78, 305);
            this.LblArrayPalavrasForca.Name = "LblArrayPalavrasForca";
            this.LblArrayPalavrasForca.Size = new System.Drawing.Size(10, 15);
            this.LblArrayPalavrasForca.TabIndex = 31;
            this.LblArrayPalavrasForca.Text = " ";
            // 
            // FORCA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(700, 320);
            this.Controls.Add(this.LblArrayPalavrasForca);
            this.Controls.Add(this.BtnModoDificil);
            this.Controls.Add(this.BtnModoMedio);
            this.Controls.Add(this.BtnModoFacil);
            this.Controls.Add(this.LblContador);
            this.Controls.Add(this.TxtPalavra);
            this.Controls.Add(this.BtnChutarPalavra);
            this.Controls.Add(this.LblDica2);
            this.Controls.Add(this.BtnDica);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblBracoEsquerdo);
            this.Controls.Add(this.LblBracoDireito);
            this.Controls.Add(this.LblCabeca);
            this.Controls.Add(this.LblTronco);
            this.Controls.Add(this.LblPernaDireita);
            this.Controls.Add(this.LblPernaEsquerda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblLetras);
            this.Controls.Add(this.LblDica);
            this.Controls.Add(this.BtnLetra);
            this.Controls.Add(this.BtnJogar);
            this.Controls.Add(this.TxtLetra);
            this.Name = "FORCA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forca";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtLetra;
        private System.Windows.Forms.Label LblPalavraForca;
        private System.Windows.Forms.Button BtnJogar;
        private System.Windows.Forms.Button BtnLetra;
        private System.Windows.Forms.Label LblDica;
        private System.Windows.Forms.Label LblLetras;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblPernaEsquerda;
        private System.Windows.Forms.Label LblPernaDireita;
        private System.Windows.Forms.Label LblTronco;
        private System.Windows.Forms.Label LblCabeca;
        private System.Windows.Forms.Label LblBracoDireito;
        private System.Windows.Forms.Label LblBracoEsquerdo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnDica;
        private System.Windows.Forms.Label LblDica2;
        private System.Windows.Forms.Button BtnChutarPalavra;
        private System.Windows.Forms.TextBox TxtPalavra;
        private System.Windows.Forms.Label LblContador;
        private System.Windows.Forms.Button BtnModoFacil;
        private System.Windows.Forms.Button BtnModoMedio;
        private System.Windows.Forms.Button BtnModoDificil;
        private System.Windows.Forms.Label LblArrayPalavrasForca;
    }
}

