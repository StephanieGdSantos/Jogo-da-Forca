using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORCA
{
    public partial class FORCA : Form
    {
        public FORCA()
        {
            InitializeComponent();
        }

        private void BtnJogar_Click(object sender, EventArgs e)
        {
            LblContador.Text = "";
            string[] palavras = LblArrayPalavrasForca.Text.Split(", ");
            if (palavras[0] == " ")
            {
                MessageBox.Show("É necessário selecionar um modo fácil, médio " +
                    "ou difícil antes de começar o jogo.", "Selecione um modo de jogo");
                BtnModoFacil.Focus();
            }
            else
            {
                BtnDica.Visible = false;
                LblDica2.Visible = false;
                Random numeroAleatorio = new Random();
                int posicao = numeroAleatorio.Next(palavras.Length);
                string palavraEscolhida = palavras[posicao];
                LblPalavraForca.Text = "_";
                LblDica.Text = palavraEscolhida;
                for (int i = 0; i < palavraEscolhida.Length - 1; i++)
                {
                    if (palavraEscolhida[i] == char.Parse(" "))
                    {
                        LblPalavraForca.Text += " ";
                    }
                    else
                    {
                        LblPalavraForca.Text += "_";
                    }
                }
                TornarInvisivel(LblCabeca, LblTronco, LblBracoEsquerdo, LblBracoDireito,
                    LblPernaEsquerda, LblPernaDireita);
                TornarVisivel(TxtLetra, TxtPalavra, BtnLetra, BtnChutarPalavra);
                LblLetras.Text = " ";
                TxtLetra.ReadOnly = false;
                TxtPalavra.ReadOnly = false;
            }

        }

        static void TornarInvisivel(Label LblCabeca, Label LblTronco, Label LblBracoEsquerdo,
            Label LblBracoDireito, Label LblPernaEsquerda, Label LblPernaDireita)
        {
            LblCabeca.Visible = false;
            LblTronco.Visible = false;
            LblBracoEsquerdo.Visible = false;
            LblBracoDireito.Visible = false;
            LblPernaEsquerda.Visible = false;
            LblPernaDireita.Visible = false;
        }

        static void TornarVisivel(TextBox TxtLetra, TextBox TxtPalavra,
            Button BtnChutarLetra, Button btnChutarPalavra)
        {
            BtnChutarLetra.Visible = true;
            TxtPalavra.Visible = true;
            btnChutarPalavra.Visible = true;
            TxtLetra.Visible = true;
            TxtLetra.Focus();
        }

        private void BtnLetra_Click(object sender, EventArgs e)
        {
            string forca = LblPalavraForca.Text;
            string palavraCerta = LblDica.Text;
            string letra = TxtLetra.Text.ToUpper();
            string[] arrayForca = new string[forca.Length];
            string[] arrayPalavra = new string[palavraCerta.Length];
            string palavraForca = "";
            LblPalavraForca.Text = ProcurarLetra(arrayPalavra, arrayForca, letra, palavraForca,
                palavraCerta, forca);
            LblContador.Text += ",0";
            if (LblContador.Text.Split(",").Length == 4)
            {
                BtnDica.Visible = true;
            }
            TxtLetra.Clear();
            TxtLetra.Focus();
            MostrarMessageBox(LblPalavraForca.Text, palavraCerta, BtnJogar,
                LblLetras.Text.Split(", ").Length, TxtLetra, TxtPalavra);
            LblLetras.Text = MostrarLetrasErradas(LblPalavraForca.Text, forca, LblLetras.Text,
                letra);
            MostrarBonequinho(LblLetras.Text, LblCabeca, LblTronco, LblBracoEsquerdo,
                LblBracoDireito, LblPernaEsquerda, LblPernaDireita);
        }

        static string ProcurarLetra(string[] arrayPalavra, string[] arrayForca, string letra,
            string palavraForca, string palavraCerta, string forca)
        {
            for (int i = 0; i < arrayPalavra.Length; i++)
            {
                arrayPalavra[i] = palavraCerta[i].ToString();
                arrayForca[i] = forca[i].ToString();

            }
            for (int i = 0; i < arrayForca.Length; i++)
            {
                if (arrayPalavra[i] == letra)
                {
                    arrayForca[i] = arrayPalavra[i];
                }
                palavraForca += arrayForca[i];
            }
            return palavraForca;
        }

        static string MostrarLetrasErradas(string lblForca, string stringForca,
            string letrasErradas, string letra)
        {
            if (letra == "" || JaFoiChutado(letra, letrasErradas))
            {
                return letrasErradas;
            }
            if (lblForca == stringForca)
            {
                if (letrasErradas == " ")
                {
                    letrasErradas = letra;
                    return letrasErradas;
                }
                letrasErradas += ", " + letra;
            }
            return letrasErradas;
        }
        static bool JaFoiChutado(string letraEscolhida, string letrasChutadas)
        {
            string[] arrayLetras = letrasChutadas.Split(", ");
            foreach (string letras in arrayLetras)
            {
                if (letras == letraEscolhida)
                {
                    return true;
                }
            }
            return false;
        }

        static void MostrarBonequinho(string letrasErradas, Label cabeca, Label tronco,
            Label bracoEsquerdo, Label bracoDireito, Label pernaEsquerda,
            Label pernaDireita)
        {
            if (letrasErradas != " ")
            {
                switch (letrasErradas.Split(", ").Length)
                {
                    case 1:
                        cabeca.Visible = true;
                        break;
                    case 2:
                        tronco.Visible = true;
                        break;
                    case 3:
                        bracoEsquerdo.Visible = true;
                        break;
                    case 4:
                        bracoDireito.Visible = true;
                        break;
                    case 5:
                        pernaEsquerda.Visible = true;
                        break;
                    case 6:
                        pernaDireita.Visible = true;
                        break;
                }
            }
        }

        static void MostrarMessageBox(string forca, string palavraCerta, Button BtnJogar,
            int quantidadeLetrasErradas, TextBox TxtLetra, TextBox TxtPalavra)
        {
            MostrarVitoria(forca, palavraCerta, TxtLetra, TxtPalavra, BtnJogar);
            MostrarDerrota(quantidadeLetrasErradas, TxtLetra, TxtPalavra, BtnJogar);
        }

        static void MostrarVitoria(string forca, string palavraCerta, TextBox TxtChuteLetra,
            TextBox TxtChutePalavra, Button BtnJogar)
        {
            if (forca == palavraCerta)
            {
                MessageBox.Show("Parabéns! Você venceu :D \nSe quiser jogar novamente, pressione 'Nova palavra'.");
                TxtChuteLetra.ReadOnly = true;
                TxtChutePalavra.ReadOnly = true;
                BtnJogar.Focus();
            }
        }

        static void MostrarDerrota(int quantidadeLetrasErradas, TextBox TxtChuteLetra,
            TextBox TxtChutePalavra, Button BtnJogar)
        {
            if (quantidadeLetrasErradas == 6)
            {
                MessageBox.Show("Infelizmente, você perdeu :( \nMas não desista," +
                    " tente uma nova palavra.");
                TxtChuteLetra.ReadOnly = true;
                TxtChutePalavra.ReadOnly = true;
                BtnJogar.Focus();
            }
        }

        private void TxtLetra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLetra.PerformClick();
            }
        }

        private void BtnDica_Click(object sender, EventArgs e)
        {
            LblDica2.Visible = true;
            TxtLetra.Focus();
        }

        private void BtnChutarPalavra_Click(object sender, EventArgs e)
        {
            if (TxtPalavra.Text == LblDica.Text)
            {
                MostrarVitoria(TxtPalavra.Text, LblDica.Text, TxtLetra, TxtPalavra, BtnJogar);
            }
            else
            {
                MostrarDerrota(6, TxtLetra, TxtPalavra, BtnJogar);
            }
            TxtPalavra.Clear();
        }

        private void TxtPalavra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnChutarPalavra.PerformClick();
            }
        }

        private void BtnModoFacil_Click(object sender, EventArgs e)
        {
            LblArrayPalavrasForca.Text = "UVA, LARANJA, PERA, AMORA, MIRTILO, GRUMIXAMA, " +
                "TORANJA, BANANA, MELANCIA, FRAMBOESA, ABACAXI, AMEIXA, CARAMBOLA, " +
                "ACEROLA, MANGA, CACAU, ABACATE";
            LblDica2.Visible = false;
            LblDica2.Text = "É uma fruta.";
            BtnJogar.PerformClick();
        }

        private void BtnModoMedio_Click(object sender, EventArgs e)
        {
            LblArrayPalavrasForca.Text = "VIOLETA, BORDO, FUCHSIA, BRONZE, CARMESIM, CIANO, " +
                "COBRE, DOURADO, HERBAL, INDIGO, MALVA, MAGENTA, OLIVA, PARDO, PURPURA, " +
                "TERRACOTA";
            LblDica2.Visible = false;
            LblDica2.Text = "É uma cor.";
            BtnJogar.PerformClick();
        }

        private void BtnModoDificil_Click(object sender, EventArgs e)
        {
            LblArrayPalavrasForca.Text = "BED, MORNING, CONGRATULATIONS, FRIEND, DIED, " +
                "MURDERED, FATHER, PLACE, THURSDAY, HAMSTER, PURPLE, LIBRARY, BLUEBERRY, " +
                "BODY, HEADER, FORK";
            LblDica2.Visible = false;
            LblDica2.Text = "É uma palavra em inglês.";
            BtnJogar.PerformClick();
        }
    }
}