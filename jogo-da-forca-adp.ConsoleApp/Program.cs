using System.ComponentModel;
using System.Security.Cryptography;

class Program

/*

v1 
1 - Nosso jogo deve aceitar o input do jogador e exibir o valor digitado [x]
2 - Nosso jogo deve gerar um número secreto aleatório [x]
3 - Nosso jogo deve validar a tentativa do jogador e exibir uma mensagem [x]

v2


*/

{
    static void Main(string[] args)
    {
        //gerando número aleatório
        int numeroAleatorio = GerarNumeroAleatorio();
        Console.WriteLine($"Valor aleatório gerado: {numeroAleatorio}");

        bool userErrou = true;

        while (userErrou)
        {
            //chamando, conferindo e armazenando caso o valor digitado seja válido
            int chuteDoUser = SolicitarValor();

            //retorno vai para a variável de controle da repetição
            userErrou = VerificarAcerto(chuteDoUser, numeroAleatorio);
        }

    }

    static int GerarNumeroAleatorio()
    {
        int numeroAleatorio = RandomNumberGenerator.GetInt32(1, 11);
        return numeroAleatorio;
    }

    static int SolicitarValor()
    {
        Console.Write("Digite um valor: ");
        string valorDigitado = Console.ReadLine()!;

        if (int.TryParse(valorDigitado, out int valorDigitadoValido))
        {
            if (valorDigitadoValido <= 0)
                Console.WriteLine("TENTATIVA INVÁLIDA! Insira valores maiores que 0.");

            else if (valorDigitadoValido > 0)
            {
                Console.WriteLine("TENTATIVA VÁLIDA! O valor inserido é aceitado pelo programa.");
                return valorDigitadoValido;
            }
        }

        else
            Console.WriteLine("TENTATIVA INVÁLIDA! Apenas NÚMEROS serão aceitos pelo programa");

        return 0;
    }

    static bool VerificarAcerto(int chuteDoUser, int numeroAleatorio)
    {
        if (chuteDoUser == numeroAleatorio)
        {
            Console.WriteLine("PARABÉNS! Você acertou em cheio o número secreto!");
            return false;
        }

        else if (chuteDoUser > numeroAleatorio)
            Console.WriteLine("ERROU! O número secreto é MENOR que o seu chute!");

        else
            Console.WriteLine("ERROU! O número secreto é MAIOR que o seu chute!");

        return true;

    }
}