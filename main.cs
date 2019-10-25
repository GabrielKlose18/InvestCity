using System;
using System.IO;
using System.Text;

namespace Contratar{
  class MainClass {
    public static void Main (string[] args) {
     string opcaoPerfil;
     string opcaoUsuario;

      Console.WriteLine ("Bem vindo ao InvestCity!");
      Console.WriteLine("Desenvolvendo relações!");
      Console.WriteLine("Qual o seu Perfil? ");
      Console.WriteLine("Digite: \n 1 - Empreendedor \n 2 - Comprador");
      opcaoPerfil = Console.ReadLine();

      if(opcaoPerfil = "1"){
        Autenticador = File.OpenText("./BD/empreendedor.txt");
        Console.WriteLine("Possui cadastro conosco? ");
        Console.WriteLine("Digite: \n 1 - SIM \n 2 - NÃO");
        opcaoUsuario = Console.ReadLine();
        if(opcaoUsuario = "1"){
          while(Autenticador.EndOfStream != true){
            string linha = Autenticador.ReadLine();
            if(linha.Contains(CadUser.Telefone)){
              Console.WriteLine("Usuário encontrado");
            }
          }
        }
      }
      
    }
  }
}

