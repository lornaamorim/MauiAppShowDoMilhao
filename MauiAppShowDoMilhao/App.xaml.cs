﻿using MauiAppShowDoMilhao.Models;

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
                Enunciado = "Quem foi o grande amor de Julieta?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "ROMEU" },
                    new Alternativa { Correta = false, Descricao = "ORFEU" },
                    new Alternativa { Correta = false, Descricao = "HAMLET" },
                    new Alternativa { Correta = false, Descricao = "IAGO" },
                }
            },
            new Pergunta
            {
                Id = 3,
                Enunciado = "De acordo com a Bíblia, qual era o fruto proibido?",
                 Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "MAMÃO" },
                    new Alternativa { Correta = false, Descricao = "UVA" },
                    new Alternativa { Correta = true, Descricao = "MAÇÃ" },
                    new Alternativa { Correta = false, Descricao = "ABACAXI" },
                }
            },
             new Pergunta
            {
                Id = 4,
                Enunciado = "Quem foi o criador dos personagens Pedrinho, Narizinho e Emília?",
                 Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "MAURÍCIO DE SOUSA" },
                    new Alternativa { Correta = false, Descricao = "ZIRALDO" },
                    new Alternativa { Correta = true, Descricao = "MONTEIRO LOBATO" },
                    new Alternativa { Correta = false, Descricao = "MACHADO DE ASSIS" },
                }
             },
              new Pergunta
            {
                Id = 5,
                Enunciado = "Como se chama o lugar onde se guardam vinhos?",
                 Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "ADEGA" },
                    new Alternativa { Correta = false, Descricao = "BIBLIOTECA" },
                    new Alternativa { Correta = false, Descricao = "SOTÃO" },
                    new Alternativa { Correta = false, Descricao = "SALA" },
                }
             },
                new Pergunta
            {
                Id = 6,
                Enunciado = "Qual é o réptil que muda de cor conforme o lugar em que está?",
                 Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "SAPO" },
                    new Alternativa { Correta = true, Descricao = "CAMALEÃO" },
                    new Alternativa { Correta = false, Descricao = "LAGARTO" },
                    new Alternativa { Correta = false, Descricao = "JACARÉ" },
                }
             },
                new Pergunta
            {
                Id = 7,
                Enunciado = "Qual é a duração de cada tempo de uma partida de futebol?",
                 Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "45 MINUTOS" },
                    new Alternativa { Correta = false, Descricao = "60 MINUTOS" },
                    new Alternativa { Correta = false, Descricao = "90 MINUTOS" },
                    new Alternativa { Correta = false, Descricao = "120 MINUTOS" },
                }
             },
                 new Pergunta
            {
                Id = 8,
                Enunciado = "Quantas folhas tem um trevo da sorte?",
                 Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "TRÊS" },
                    new Alternativa { Correta = true, Descricao = "QUATRO" },
                    new Alternativa { Correta = false, Descricao = "CINCO" },
                    new Alternativa { Correta = false, Descricao = "SEIS" },
                }
             },
                 new Pergunta
            {
                Id = 9,
                Enunciado = "Com que fruta a Branca de Neve foi envenenada?",
                 Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "MAÇÃ" },
                    new Alternativa { Correta = false, Descricao = "PERA" },
                    new Alternativa { Correta = false, Descricao = "MELÃO" },
                    new Alternativa { Correta = false, Descricao = "LARANJA" },
                }
             },
                  new Pergunta
            {
                Id = 10,
                Enunciado = "Qual é a área da medicina que trata de crianças?",
                 Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "GERIATRIA" },
                    new Alternativa { Correta = false, Descricao = "PEDIATRIA" },
                    new Alternativa { Correta = false, Descricao = "INFANTOLOGIA" },
                    new Alternativa { Correta = false, Descricao = "BIOLOGIA" },
                }
             },
                  new Pergunta
            {
                Id = 11,
                Enunciado = "Cavalo, rainha e torre são peças de qual jogo?",
                 Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "DAMAS" },
                    new Alternativa { Correta = true, Descricao = "XADREZ" },
                    new Alternativa { Correta = false, Descricao = "LUDO" },
                    new Alternativa { Correta = false, Descricao = "DOMINÓ" },
                }
             },
                  new Pergunta
            {
                Id = 12,
                Enunciado = "Qual é o santo casamenteiro?",
                 Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "SÃO PEDRO" },
                    new Alternativa { Correta = false, Descricao = "SÃO PAULO" },
                    new Alternativa { Correta = false, Descricao = "SÃO JOÃO" },
                    new Alternativa { Correta = true, Descricao = "SANTO ANTÔNIO" },
                }
             },
                   new Pergunta
            {
                Id = 13,
                Enunciado = "Qual ser mitológico possui o corpo metade mulher e metade peixe?",
                 Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "SEREIA" },
                    new Alternativa { Correta = false, Descricao = "MEDUSA" },
                    new Alternativa { Correta = false, Descricao = "CLEÓPATRA" },
                    new Alternativa { Correta = false, Descricao = "SERENA" },
                }
             },
                   new Pergunta
            {
                Id = 14,
                Enunciado = "Qual destes elementos se forma dentro das ostras?",
                 Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "DIAMANTE" },
                    new Alternativa { Correta = true, Descricao = "PÉROLA" },
                    new Alternativa { Correta = false, Descricao = "RUBI" },
                    new Alternativa { Correta = false, Descricao = "ESMERALDA" },
                }
             },
                    new Pergunta
            {
                Id = 15,
                Enunciado = "Quando é comemorado o dia da mentira no Brasil?",
                 Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "26 DE DEZEMBRO" },
                    new Alternativa { Correta = false, Descricao = "27 DE SETEMBRO" },
                    new Alternativa { Correta = true, Descricao = "1 DE ABRIL" },
                    new Alternativa { Correta = false, Descricao = "15 DE NOVEMBRO" },
                }
             },
                    new Pergunta
            {
                Id = 16,
                Enunciado = "Quem é a mulher do Tarzan?",
                 Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "DIANA" },
                    new Alternativa { Correta = false, Descricao = "LOUIS LAINE" },
                    new Alternativa { Correta = true, Descricao = "JANE" },
                    new Alternativa { Correta = false, Descricao = "CHITA" },
                }
             },
                    new Pergunta
            {
                Id = 17,
                Enunciado = "Qual é o animal que puxa o trenó do Papai Noel?",
                 Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "CAVALO" },
                    new Alternativa { Correta = true, Descricao = "RENA" },
                    new Alternativa { Correta = false, Descricao = "TOURO" },
                    new Alternativa { Correta = false, Descricao = "JUMENTO" },
                }
             },
                    new Pergunta
            {
                Id = 18,
                Enunciado = "Como Joana d‘Arc foi morta?",
                 Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "ENFORCADA" },
                    new Alternativa { Correta = false, Descricao = "AFOGADA" },
                    new Alternativa { Correta = true, Descricao = "QUEIMADA" },
                    new Alternativa { Correta = false, Descricao = "ASFIXIADA" },
                }
             },
                    new Pergunta
            {
                Id = 19,
                Enunciado = "Qual é o significado da frase inglesa “I love you”?",
                 Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "BOM-DIA" },
                    new Alternativa { Correta = false, Descricao = "ATÉ LOGO" },
                    new Alternativa { Correta = true, Descricao = "EU AMO VOCÊ" },
                    new Alternativa { Correta = false, Descricao = "ESTOU COM FOME" },
                }
             },
                    new Pergunta
            {
                Id = 20,
                Enunciado = "Qual é a cor da pedra rubi?",
                 Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "AZUL" },
                    new Alternativa { Correta = false, Descricao = "VERDE" },
                    new Alternativa { Correta = false, Descricao = "AMARELA" },
                    new Alternativa { Correta = true, Descricao = "VERMELHA" },
                }
             },
        };
        List<Pergunta> perguntas_medias = new()
        {
             new Pergunta
            {
                Id = 1,
                Enunciado = "No filme, quem era parceiro de crimes da Bonnie?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "BILL" },
                    new Alternativa { Correta = true, Descricao = "CLYDE" },
                    new Alternativa { Correta = false, Descricao = "JAMES" },
                    new Alternativa { Correta = false, Descricao = "BUTCH" },
                }

            },
             new Pergunta
            {
                Id = 2,
                Enunciado = "Quando começou e terminou a Primeira Guerra Mundial?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "1914-1919" },
                    new Alternativa { Correta = false, Descricao = "1939-1945" },
                    new Alternativa { Correta = false, Descricao = "1921-1932" },
                    new Alternativa { Correta = false, Descricao = "1912-1915" },
                }

            },
             new Pergunta
            {
                Id = 3,
                Enunciado = "Qual é a letra do alfabeto que simboliza o número dez em algarismo romano?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "V" },
                    new Alternativa { Correta = false, Descricao = "D" },
                    new Alternativa { Correta = false, Descricao = "L" },
                    new Alternativa { Correta = true, Descricao = "X" },
                }

            },
              new Pergunta
            {
                Id = 4,
                Enunciado = "O que leva o sangue do coração para o corpo?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "VEIAS" },
                    new Alternativa { Correta = false, Descricao = "MÚSCULOS" },
                    new Alternativa { Correta = true, Descricao = "ARTÉRIAS" },
                    new Alternativa { Correta = false, Descricao = "OSSOS" },
                }

            },
               new Pergunta
            {
                Id = 5,
                Enunciado = "O “super bowl” faz parte de qual esporte?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "BASEBALL" },
                    new Alternativa { Correta = false, Descricao = "BASQUETE" },
                    new Alternativa { Correta = true, Descricao = "FUTEBOL AMERICANO" },
                    new Alternativa { Correta = false, Descricao = "GOLF" },
                }

            },
               new Pergunta
            {
                Id = 6,
                Enunciado = "A que categoria pertence o cavalo-marinho?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "MOLUSCO" },
                    new Alternativa { Correta = false, Descricao = "CRUSTÁCEO" },
                    new Alternativa { Correta = true, Descricao = "PEIXE" },
                    new Alternativa { Correta = false, Descricao = "MAMÍFERO" },
                }

            },
               new Pergunta
            {
                Id = 7,
                Enunciado = "O FBI é a polícia federal de qual país?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "INGLATERRA" },
                    new Alternativa { Correta = true, Descricao = "ESTADOS UNIDOS" },
                    new Alternativa { Correta = false, Descricao = "CANADÁ" },
                    new Alternativa { Correta = false, Descricao = "FRANÇA" },
                }

            },
               new Pergunta
            {
                Id = 8,
                Enunciado = "Qual dessas cobras não é venenosa?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "URUTU" },
                    new Alternativa { Correta = false, Descricao = "CASCAVEL" },
                    new Alternativa { Correta = false, Descricao = "JARARACA" },
                    new Alternativa { Correta = true, Descricao = "PÍTON" },
                }

            },
               new Pergunta
            {
                Id = 9,
                Enunciado = "Qual é o dia da Padroeira do Brasil?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "12 DE OUTUBRO" },
                    new Alternativa { Correta = false, Descricao = "12 DE NOVEMBRO" },
                    new Alternativa { Correta = false, Descricao = "11 DE DEZEMBRO" },
                    new Alternativa { Correta = false, Descricao = "1 DE JANEIRO" },
                }

            },
               new Pergunta
            {
                Id = 10,
                Enunciado = "A cidade de Pompéia, que foi soterrada por um vulcão fica em qual desses países?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "JAPÃO" },
                    new Alternativa { Correta = false, Descricao = "MÉXICO" },
                    new Alternativa { Correta = true, Descricao = "ITÁLIA" },
                    new Alternativa { Correta = false, Descricao = "ESTADOS UNIDOS" },
                }

            },
               new Pergunta
            {
                Id = 11,
                Enunciado = "Como eram chamados os pilotos suicidas da Segunda Guerra?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "CAMICASES" },
                    new Alternativa { Correta = false, Descricao = "SASHIMIS" },
                    new Alternativa { Correta = false, Descricao = "HARAQUIRIS" },
                    new Alternativa { Correta = false, Descricao = "SUMÔS" },
                }

            },
               new Pergunta
            {
                Id = 12,
                Enunciado = "Como é chamada a cantora que representa o papel principal em uma ópera?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "PRIMEIRA DAMA" },
                    new Alternativa { Correta = false, Descricao = "DONA-PRIMA" },
                    new Alternativa { Correta = true, Descricao = "PRIMA-DONA" },
                    new Alternativa { Correta = false, Descricao = "OBRA-PRIMA" },
                }

            },
               new Pergunta
            {
                Id = 13,
                Enunciado = "Quantos quilates tem o ouro puro?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "18" },
                    new Alternativa { Correta = false, Descricao = "20" },
                    new Alternativa { Correta = true, Descricao = "24" },
                    new Alternativa { Correta = false, Descricao = "30" },
                }

            },
               new Pergunta
            {
                Id = 14,
                Enunciado = "Como é chamada a doença que causa perda desigual da melanina?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "ASTIGMATISMO" },
                    new Alternativa { Correta = false, Descricao = "TENDINITE" },
                    new Alternativa { Correta = true, Descricao = "VITILIGO" },
                    new Alternativa { Correta = false, Descricao = "VITINGA" },
                }

            },
               new Pergunta
            {
                Id = 15,
                Enunciado = "Que planta era usada para fabricação de papel no antigo Egito?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "PAPIRO" },
                    new Alternativa { Correta = false, Descricao = "EUCALIPTO" },
                    new Alternativa { Correta = false, Descricao = "OLIVEIRA" },
                    new Alternativa { Correta = false, Descricao = "MILHO" },
                }

            },
               new Pergunta
            {
                Id = 16,
                Enunciado = "Que país europeu tem como atração a tourada?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "ESPANHA" },
                    new Alternativa { Correta = false, Descricao = "ITÁLIA" },
                    new Alternativa { Correta = false, Descricao = "FRANÇA" },
                    new Alternativa { Correta = false, Descricao = "ALEMANHA" },
                }

            },
               new Pergunta
            {
                Id = 17,
                Enunciado = "O que os filatelistas colecionam?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "QUADROS" },
                    new Alternativa { Correta = false, Descricao = "MOEDAS" },
                    new Alternativa { Correta = true, Descricao = "SELOS" },
                    new Alternativa { Correta = false, Descricao = "FIGURINHAS" },
                }

            },
               new Pergunta
            {
                Id = 18,
                Enunciado = "Em que cidade está situada a famosa Praça Vermelha?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "MOSCOU" },
                    new Alternativa { Correta = false, Descricao = "BERLIM" },
                    new Alternativa { Correta = false, Descricao = "PARIS" },
                    new Alternativa { Correta = false, Descricao = "ROMA" },
                }

            },
               new Pergunta
            {
                Id = 19,
                Enunciado = "Que animais são criados nas pocilgas?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "CAMELOS" },
                    new Alternativa { Correta = false, Descricao = "BÚFALOS" },
                    new Alternativa { Correta = false, Descricao = "CARNEIROS" },
                    new Alternativa { Correta = true, Descricao = "PORCOS" },
                }

            },
               new Pergunta
            {
                Id = 20,
                Enunciado = "Quem introduziu o futebol no Brasil?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "PELÉ" },
                    new Alternativa { Correta = false, Descricao = "JOÃO HAVELANGE" },
                    new Alternativa { Correta = true, Descricao = "CHARLES MILLER" },
                    new Alternativa { Correta = false, Descricao = "PAULO MACHADO" },
                }

            },
        };
        List<Pergunta> perguntas_dificeis = new()
        {
             new Pergunta
            {
                Id = 1,
                Enunciado = "",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                }

            },
             new Pergunta
            {
                Id = 2,
                Enunciado = "",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                }

            },
             new Pergunta
            {
                Id = 3,
                Enunciado = "",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                }

            },
             new Pergunta
            {
                Id = 4,
                Enunciado = "",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                }

            },
             new Pergunta
            {
                Id = 5,
                Enunciado = "",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                }

            },
             new Pergunta
            {
                Id = 6,
                Enunciado = "",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                }

            },
             new Pergunta
            {
                Id = 7,
                Enunciado = "",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                }

            },
             new Pergunta
            {
                Id = 8,
                Enunciado = "",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                }

            },
             new Pergunta
            {
                Id = 9,
                Enunciado = "",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                }

            },
             new Pergunta
            {
                Id = 10,
                Enunciado = "",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                }

            },
             new Pergunta
            {
                Id = 11,
                Enunciado = "",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                }

            },
             new Pergunta
            {
                Id = 12,
                Enunciado = "",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                }

            },
             new Pergunta
            {
                Id = 13,
                Enunciado = "",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                }

            },
             new Pergunta
            {
                Id = 14,
                Enunciado = "",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                }

            },
             new Pergunta
            {
                Id = 15,
                Enunciado = "",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                }

            },
             new Pergunta
            {
                Id = 16,
                Enunciado = "",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                }

            },
             new Pergunta
            {
                Id = 17,
                Enunciado = "",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                }

            },
             new Pergunta
            {
                Id = 18,
                Enunciado = "",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                }

            },
             new Pergunta
            {
                Id = 19,
                Enunciado = "",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                }

            },
             new Pergunta
            {
                Id = 20,
                Enunciado = "",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                    new Alternativa { Correta = false, Descricao = "" },
                }

            },
        };



        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
