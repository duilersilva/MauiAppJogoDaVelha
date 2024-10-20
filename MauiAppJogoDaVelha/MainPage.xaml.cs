
namespace MauiAppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        String vez = "X";

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.IsEnabled = false;

            if (vez == "X")
            {
                btn.Text = "X";
                vez = "O";
            }
            else
            {
                btn.Text = "O";
                vez = "X";
            }
            /*VERIFICANDO X */
            /*verificando se x ganhou na primeira linha */
            if ((btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X") ||
                /*verificando se x ganhou na segunda linha */
                (btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X") ||
                /*verificando se x ganhou na terceira linha */
                (btn30.Text == "X" && btn31.Text == "X" && btn32.Text == "X") ||
                /*verificando se x ganhou na primeira coluna*/
                (btn10.Text == "X" && btn20.Text == "X" && btn30.Text == "X") ||
                /*verificando se x ganhou na segunda coluna*/
                (btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X") ||
                /*verificando se x ganhou na terceira coluna*/
                (btn12.Text == "X" && btn22.Text == "X" && btn32.Text == "X") ||
                /*verificando se x ganhou na diaginal coluna*/
                (btn10.Text == "X" && btn21.Text == "X" && btn32.Text == "X") ||
                /*verificando se x ganhou na segunda digonal coluna*/
                (btn30.Text == "X" && btn21.Text == "X" && btn12.Text == "X"))       
                
            {
                DisplayAlert("Parabéns !", "O vencedor foi o X !", "OK");
                Zerar();
            }
            /*VERIFICANDO O */
            /*verificando se O ganhou na primeira linha */
            else if ((btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O") ||
                /*verificando se O ganhou na segunda linha */
                    (btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O") ||
                    /*verificando se O ganhou na terceira linha */
                    (btn30.Text == "O" && btn31.Text == "O" && btn32.Text == "O") ||
                    /*verificando se O ganhou na primeira coluna*/
                    (btn10.Text == "O" && btn20.Text == "O" && btn30.Text == "O") ||
                    /*verificando se O ganhou na segunda coluna*/
                    (btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O") ||
                    /*verificando se O ganhou na terceira coluna*/
                    (btn12.Text == "O" && btn22.Text == "O" && btn32.Text == "O") ||
                    /*verificando se O ganhou na diaginal coluna*/
                    (btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O") ||
                    /*verificando se O ganhou na segunda digonal coluna*/
                    (btn30.Text == "O" && btn21.Text == "O" && btn12.Text == "O"))

            {
                DisplayAlert("Parabéns !", "O vencedor foi o O !", "OK");
                Zerar();
            }
            /*VERIFICANDO EMPATE */
            else if (btn10.Text != "" && btn11.Text != "" && btn12.Text != "" &&
                     btn20.Text != "" && btn21.Text != "" && btn22.Text != "" &&
                     btn30.Text != "" && btn31.Text != "" && btn32.Text != "")
            {
                DisplayAlert("Deu Velha", "Não houve vencedor !", "OK");
                Zerar();
            }
        }

        void Zerar()
        {
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = "";
            btn30.Text = "";
            btn31.Text = "";
            btn32.Text = "";

            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;
            btn20.IsEnabled = true;
            btn21.IsEnabled = true;
            btn22.IsEnabled = true;
            btn30.IsEnabled = true;
            btn31.IsEnabled = true;
            btn32.IsEnabled = true;
        }
    }
}
