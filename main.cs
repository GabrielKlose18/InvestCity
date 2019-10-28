using System;
using System.IO;
using System.Text;

namespace Contratar{
  class MainClass {
    public static void Main (string[] args) {
      string cpf;
      string opcaoPerfil;
      string opcaoUsuario;
      string opcaoCpf;
      string empreendedorString;
      bool finded = false;
      StreamReader Autenticador;

      Empreendedor empreendedor = new Empreendedor();
      Comprador comprador = new Comprador();
      BaseSombra basesombra = new BaseSombra();
      EmpreendedorComprador empreendedorComprador = new EmpreendedorComprador();


      Console.WriteLine ("Bem vindo ao InvestCity!");
      Console.WriteLine("Desenvolvendo relações!");
      Console.WriteLine("Qual o seu Perfil? ");
      Console.WriteLine("Digite: \n 1 - Empreendedor \n 2 - Comprador");
      opcaoPerfil = Console.ReadLine();

      if(opcaoPerfil == "1"){
        Console.WriteLine("Possui cadastro conosco? ");
        Console.WriteLine("Digite: \n 1 - SIM \n 2 - NÃO");
        opcaoUsuario = Console.ReadLine();
        if(opcaoUsuario == "1"){
          Autenticador = File.OpenText("./BD/empreendedor.txt");
          Console.WriteLine("Digite seu CPF (Sem pontos) ");
          opcaoCpf = Console.ReadLine();
          if(basesombra.ValidaCPF(opcaoCpf)){
            while(Autenticador.EndOfStream != true){
              string linha = Autenticador.ReadLine();
              if(linha.Contains(opcaoCpf)){
                finded = true;
                Console.WriteLine("Usuário encontrado!");
                
                Console.WriteLine("Seus Servicos:");
                empreendedorComprador.listar(opcaoCpf);                
              }
            }
            Autenticador.Close();
            if(!finded){
              Console.WriteLine("Usuário não encontrado!");
            }
          }else{
            Console.WriteLine("CPF inválido!");
          }
        }else{
          Console.WriteLine("Nome do Empreendedor: ");
          empreendedor.setNome(Console.ReadLine());
          Console.WriteLine("Cpf do Empreendedor: ");          
          cpf = Console.ReadLine();
          while(!basesombra.ValidaCPF(cpf)){
            Console.WriteLine("Cpf inválido, digite novamente: ");          
            cpf = Console.ReadLine();
          }
          empreendedor.setCpf(cpf);
          
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
        Console.WriteLine("Possui cadastro conosco? ");
        Console.WriteLine("Digite: \n 1 - SIM \n 2 - NÃO");
        opcaoUsuario = Console.ReadLine();
        if(opcaoUsuario == "1"){
          Autenticador = File.OpenText("./BD/comprador.txt");
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
          Autenticador.Close();
          if(finded){
            Console.WriteLine("Selecione um serviço (Digite o cpf):");
            cpf = Console.ReadLine();
            while(empreendedor.selecionar(cpf) == "false"){
              Console.WriteLine("Cpf inválido, digite novamente: ");          
              cpf = Console.ReadLine();
            }
            empreendedorString = empreendedor.selecionar(cpf);
            string[] empreendedorArray = empreendedorString.Split(";".ToCharArray());

            empreendedorComprador.setCpfEmpreendedor(empreendedorArray[1]);
            empreendedorComprador.setCpfComprador(opcaoCpf);
            empreendedorComprador.setServico(empreendedorArray[4]);
            empreendedorComprador.setValor(Double.Parse(empreendedorArray[6]));

            empreendedorComprador.insert();

          }else{
            Console.WriteLine("Usuário não encontrado!");
          }
        }else{
          Console.WriteLine("Nome do comprador: ");
          comprador.setNome(Console.ReadLine());
          Console.WriteLine("Cpf do comprador: ");
          cpf = Console.ReadLine();
          while(!basesombra.ValidaCPF(cpf)){
            Console.WriteLine("Cpf inválido, digite novamente: ");          
            cpf = Console.ReadLine();
          }
          comprador.setCpf(cpf);
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

