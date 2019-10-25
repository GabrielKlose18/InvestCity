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

  public void listar(string caminho){
    //declarando a variavel do tipo StreamWriter 
    StreamReader x;

    //abrindo um arquivo texto
    x = File.OpenText(caminho);

                                  //enquanto nao retornar valor booleano true 
    while (x.EndOfStream != true){//quer dizer que não chegou no fim do  arquivo
        //le conteúdo da linha
        string linha = x.ReadLine();
        //escreve na tela o conteúdo da linha
        Console.WriteLine(linha);
    }
    //após sair do while, é porque leu todo o conteúdo, então
    //temos que fechar o arquivo texto que está aberto
    x.Close();

    
  }
}