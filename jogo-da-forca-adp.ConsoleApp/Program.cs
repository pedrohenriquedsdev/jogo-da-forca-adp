using System.Security.Cryptography;

namespace jogo_da_forca_adp.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=================");
            Console.WriteLine("Jogo da forca");
            Console.WriteLine("=================");

            //LÓGICA DO JOGO DA FORCA 

            // 1. Ao iniciar o jogo, deve ser selecionada uma palavra aleatória à partir de uma lista.
            //Escolher uma palavra aleatória
            string palavraAleatoria = GerarPalavraAleatoria(); //OBTÉM O RETORNO DO MÉTODO

            Console.WriteLine(palavraAleatoria);



            // 2. O jogador poderá chutar a palavra secreta letra por letra, cada letra certa deverá ser apresentada, assim como as letras erradas.
            char[] letrasAcertadas = new char[palavraAleatoria.Length]; //RECEBE O TAMANHO DA PALAVRA ALEATÓRIA QUE POR SUA VEZ POSSUI ÍNDICES MESMO SENDO UM ARRAY

            for (int caractere = 0; caractere < letrasAcertadas.Length; caractere++) //GERAR "_" RESPEITANDO O TAMANHO DA PALAVRA ALEATÓRIA GERADA (lembra que indice e length entregam valores diferentes)
            {
                letrasAcertadas[caractere] = '_';
            }

            bool jogadorAcertouPalavra = false;
            bool jogadorPerdeu = false;

            int quantidadeDeErros = 0;

            while (!jogadorAcertouPalavra && !jogadorPerdeu)
            {
                Console.WriteLine(letrasAcertadas);
                Console.WriteLine($"Quantidade de erros: {quantidadeDeErros}");

                Console.Write("Digite uma letra: ");
                string? strLetra = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(strLetra))
                {
                    Console.WriteLine("Digite uma letra ou um caractere válido!");
                    Console.ReadLine();
                    continue;
                }

                char letraChute = Convert.ToChar(strLetra.ToUpper()); //ARMAZENA EM MAIÚSCULA A LETRA DIGITADA PELO USER 

                bool letraFoiEncontrada = false;

                for (int contador = 0; contador < palavraAleatoria.Length; contador++) //PERCORRE INDICE por INDICE A "palavraAleatoria"
                {
                    char letraAtual = palavraAleatoria[contador]; //ARMAZENA O CARACTERE DA "palavraAleatoria" EM "letraAtual" A CADA VOLTA

                    if (letraChute == letraAtual) //SE NAQUELA RODADA FOR IGUAL, O ARRAY "letrasAcertadas" RECEBE O VALOR NA POSIÇÃO CORRETA.
                    {
                        letrasAcertadas[contador] = letraAtual;
                        letraFoiEncontrada = true;
                    }
                }

                if (letraFoiEncontrada == false) //CONTROLA OS ERROS POR RODADA, SE EU CONTABILIZAR POR LETRA AO MENOS UMA ESTARÁ ERRADA.
                    quantidadeDeErros++;

                jogadorAcertouPalavra = palavraAleatoria == string.Join("", letrasAcertadas); //ESSA COMPARAÇÃO SE CERTA, RETORNA TRUE E A VARAIVEL RECEBE TRUE.
                jogadorPerdeu = quantidadeDeErros > 5; //MESMSA COISA AQUI, UMA COMPARAÇÃO RETORNA VALORES BOOL.

                if (jogadorAcertouPalavra)
                {
                    Console.WriteLine("=================");
                    Console.WriteLine($"Você acertou a palavra secreta {palavraAleatoria}");
                    Console.WriteLine("=================");
                }
                else if (jogadorPerdeu)
                {
                    Console.WriteLine("=================");
                    Console.WriteLine($"Que azar! A palavra secreta era {palavraAleatoria}");
                    Console.WriteLine("=================");
                }

                Console.ReadLine();
            }

            Console.WriteLine("Deseja continuar o jogo? (S/N): ");
            string? opcaoContinuar = Console.ReadLine()?.ToUpper();

            if (opcaoContinuar != "S")
                break; //caimos fora do loop e do programa
        }
    }

    static string GerarPalavraAleatoria()
    {
        Console.WriteLine("Escolhendo palavra aleátoria");

        string[] palavras = [
           "ABACATE",
            "ABACAXI",
            "ACEROLA",
            "AÇAÍ",
            "ARAÇÁ",
            "ABACATE",
            "BACABA",
            "BACURI",
            "BANANA",
            "CAJÁ",
            "CAJU",
            "CARAMBOLA",
            "CUPUAÇU",
            "GRAVIOLA",
            "GOIABA",
            "JABUTICABA",
            "JENIPAPO",
            "MAÇÃ",
            "MANGABA",
            "MANGA",
            "MARACUJÁ",
            "MURICI",
            "PEQUI",
            "PITANGA",
            "PITAYA",
            "SAPOTI",
            "TANGERINA",
            "UMBU",
            "UVA",
            "UVAIA"
       ];

        int indiceAleatorio = RandomNumberGenerator.GetInt32(palavras.Length); //PEGA O TOTAL DE ÍNDICES NO ARRAY E A PARTIR DELE GERA UM NÚMERO ALEATÓRIO QUE É ARMAZENADO NO "indiceAleatorio"

        string palavraAleatoria = palavras[indiceAleatorio]; //PEGA UMA PALAVRA ALEATÓRIA E ARMAZENA NA "palavraAleatoria"

        return palavraAleatoria;
    }
}
