using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROBLEMA_SENHA_FIXA {
    internal class Program {
        static void Main(string[] args) {

            int senha;

            Console.Write("Digite a senha: ");
            senha = int.Parse(Console.ReadLine());

            while (senha != 2002) {
                Console.Write("Senha Invalida! Tente novamente: ");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido!");
        }
    }
}
