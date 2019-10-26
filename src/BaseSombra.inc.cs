using System;
using System.IO;
using System.Text;

class BaseSombra { 
  public void insert(string caminho, string conteudo){
    
      var lineCount = (File.ReadAllLines(caminho).Length)+1;
      var text = lineCount.ToString()+";"+conteudo;
      using (StreamWriter sw = File.AppendText(caminho)) {
        sw.WriteLine(text);
      }	
    
  }

  public void listar(string tp,string caminho){
    //declarando a variavel do tipo StreamWriter 
    StreamReader x;

    //abrindo um arquivo texto
    x = File.OpenText(caminho);

                                  //enquanto nao retornar valor booleano true 
    while (x.EndOfStream != true){//quer dizer que não chegou no fim do  arquivo
        string linha = x.ReadLine();

        string[] array = linha.Split(";".ToCharArray());
        //escreve na tela o conteúdo da linha
        if(tp == "empreendedor"){
          Console.WriteLine($"
            Cpf: {array[1]} \n
            Nome: {array[2]} \n
            Telefone: {array[3]} \n
            Servico: {array[4]} \n
            Cidade: {array[5]} \n
            Preco: {array[6]}
          ");
        }else{
          Console.WriteLine($"
            Cpf: {array[1]} \n
            Nome: {array[2]} \n
            Telefone: {array[3]} \n
            Cidade: {array[4]} \n
            Valor investido: {array[5]}
          ");
        }
    }
    //após sair do while, é porque leu todo o conteúdo, então
    //temos que fechar o arquivo texto que está aberto
    x.Close();

    
  }
}