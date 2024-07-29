using MauiAppShowDoMilhao.Models;

namespace MauiAppShowDoMilhao
{
    public partial class App : Application
    {
        List<Pergunta> perguntas_faceis = new()
        {
            new Pergunta
            {
                Id = 1,
                Enunciado = "Qual é o nome do estado da água em forma de gelo?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "LÍQUIDO" },
                    new Alternativa { Correta = true, Descricao = "SÓLIDO" },
                    new Alternativa { Correta = false, Descricao = "GASOSO" },
                    new Alternativa { Correta = false, Descricao = "VAPOROSO" },
                }

            },
            new Pergunta
            {
                Id = 2,
                Enunciado = "Como se chama o lugar onde são armazenadas as balas",
                Alternativas = new()
                {

                }
            }
        };


        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
