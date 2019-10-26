using System;
using System.IO;
using System.Text;

namespace Contratar{
  class MainClass {
    public static void Main (string[] args) {
     string opcaoPerfil;
     string opcaoUsuario;
     string opcaoCpf;
     bool finded = false;
     StreamReader Autenticador;

     Empreendedor empreendedor = new Empreendedor();
     Comprador comprador = new Comprador();

      Console.WriteLine ("Bem vindo ao InvestCity!");
      Console.WriteLine("Desenvolvendo relações!");
      Console.WriteLine("Qual o seu Perfil? ");
      Console.WriteLine("Digite: \n 1 - Empreendedor \n 2 - Comprador");
      opcaoPerfil = Console.ReadLine();

      if(opcaoPerfil == "1"){
        Autenticador = File.OpenText("./BD/empreendedor.txt");
        Console.WriteLine("Possui cadastro conosco? ");
        Console.WriteLine("Digite: \n 1 - SIM \n 2 - NÃO");
        opcaoUsuario = Console.ReadLine();
        if(opcaoUsuario == "1"){
          Console.WriteLine("Digite seu CPF (Sem pontos) ");
          opcaoCpf = Console.ReadLine();
          while(Autenticador.EndOfStream != true){
            string linha = Autenticador.ReadLine();
            if(linha.Contains(opcaoCpf)){
              finded = true;
              Console.WriteLine("Usuário encontrado");
              Console.WriteLine("Compradores disponiveis:");
              comprador.listar();
              
            }
          }
          if(!finded){
            Console.WriteLine("Usuário não encontrado!");
          }
        }else{
          Console.WriteLine("Nome do Empreendedor: ");
          empreendedor.setNome(Console.ReadLine());
          Console.WriteLine("Cpf do Empreendedor: ");
          empreendedor.setCpf(Console.ReadLine());
          Console.WriteLine("Telefone para Contato: ");
          empreendedor.setTelefone(Console.ReadLine());
          Console.WriteLine("Tipo de serviço: ");
          empreendedor.setTipoServico(Console.ReadLine());
          Console.WriteLine("Cidade da prestação de serviço: ");
          empreendedor.setCidade(Console.ReadLine());
          Console.WriteLine("Valor do serviço: ");
          empreendedor.setPreco(Double.Parse(Console.ReadLine()));

          empreendedor.insert();
          Console.WriteLine("Empreendedor cadastrado com sucesso!");
        }
      }else{
        Autenticador = File.OpenText("./BD/comprador.txt");
        Console.WriteLine("Possui cadastro conosco? ");
        Console.WriteLine("Digite: \n 1 - SIM \n 2 - NÃO");
        opcaoUsuario = Console.ReadLine();
        if(opcaoUsuario == "1"){
          Console.WriteLine("Digite seu CPF (Sem pontos) ");
          opcaoCpf = Console.ReadLine();
          while(Autenticador.EndOfStream != true){
            string linha = Autenticador.ReadLine();
            if(linha.Contains(opcaoCpf)){
              finded = true;
              Console.WriteLine("Usuário encontrado!");
              Console.WriteLine("Serviços disponiveis:");
              empreendedor.listar();
            }
          }
          if(!finded){
            Console.WriteLine("Usuário não encontrado!");
          }
        }else{
          Console.WriteLine("Nome do comprador: ");
          comprador.setNome(Console.ReadLine());
          Console.WriteLine("Cpf do comprador: ");
          comprador.setCpf(Console.ReadLine());
          Console.WriteLine("Telefone para Contato: ");
          comprador.setTelefone(Console.ReadLine());
          Console.WriteLine("Cidade que deseja o serviço: ");
          comprador.setCidade(Console.ReadLine());
          Console.WriteLine("Valor do Investimento: ");
          comprador.setValorInvestido(Double.Parse(Console.ReadLine()));

          comprador.insert();
          Console.WriteLine("Comprador cadastrado com sucesso!");
        }
      }
      
    }
  }
}

