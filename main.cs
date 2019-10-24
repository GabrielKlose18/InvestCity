using System;
using System.IO;
using System.Text;

namespace Contratar{
  class MainClass {
  public static void Main (string[] args) {

    StreamReader Autenticador;
    StreamWriter DataEmpreendedores;
    StreamWriter DataCompradores;

    int opcao;

    Console.WriteLine ("Bem vindo ao InvestCity!");
    Console.WriteLine("Desenvolvendo relações!");
    Console.WriteLine("Possui cadastro conosco? ");
    Console.WriteLine("Digite: \n 1 - SIM \n 2 - NÃO");
    opcao = Console.ReadLine();

    if(opcao = 1){
      Autenticador = File.OpenText("usuarios.txt");
            Console.WriteLine("Confirme seu telefone cadastrado: \n");
            CadUser.Telefone = Console.ReadLine();

            while(Autenticador.EndOfStream != true){
              string linha = Autenticador.ReadLine();
              if(linha.Contains(CadUser.Telefone)){
                Console.WriteLine("Usuário encontrado");
              }
    else if(opcao = 2){

      int Cad;
      Console.WriteLine("Precisamos realizar seu cadastro: ");
      Console.WriteLine("Escolha: 1 - Empreendedor \n 2 - Comprador");
      Cad = Console.ReadLine();

      if(Cad = 1){

        string vetEmpreendedor[,] = new string[100,100];


        DataEmpreendedores = File.AppendText("servicos.txt");

        Console.WriteLine("Nome do Empreendedor: ");
        Empreendedor.Nome = Console.ReadLine();
        DataEmpreendedores.WriteLine(Empreendedor.Nome);
        Console.WriteLine("Telefone para Contato: ");
        Empreendedor.Telefone = Console.ReadLine();
        DataEmpreendedores.WriteLine(Empreendedor.Telefone);
        Console.WriteLine("Tipo de serviço: ");
        Empreendedor.tipoServico = Console.ReadLine();
        DataEmpreendedores.WriteLine(Empreendedor.tipoServico);
        Console.WriteLine("Cidade da prestação de serviços: ");
        Empreendedor.Cidade = Console.ReadLine();
        DataEmpreendedores.WriteLine(Empreendedor.Cidade);

        //falta fazer alguma coisa para armazenar o preco num vetor

        vetEmpreendedor[i] = DataEmpreendedores;
      }

      else if(Cad = 2){

        string vetCompradores[,] = new string[100,100];


        DataCompradores = File.AppendText("contratantes.txt");

        Console.WriteLine("Nome do Comprador: ");
        Comprador.Nome = Console.ReadLine();
        DataCompradores.WriteLine(Comprador.Nome);
        Console.WriteLine("Telefone para Contato: ");
        Comprador.Telefone = Console.ReadLine();
        DataCompradores.WriteLine(Comprador.Telefone);
        Console.WriteLine("Cidade do Comprador: ");
        DataCompradores.cidade = Console.ReadLine();
        DataCompradores.WriteLine(Comprador.cidade);
        

        //falta fazer alguma coisa para armazenar o preco num vetor

        vetCompradores[i] = DataCompradores;
      }

      else:
        while(Cad != 1 && Cad != 2){
          Console.WriteLine("Opção inválida! Digite um número válido: ");
          Cad = Console.ReadLine();
        }
        
    }          
    }
  }
}
}

