class Comprador {
  public string nome;
  public string telefone;
  public string cidade;
  public double valor_investimento;

  public void setnome(string n){
    nome = n;
  }

  public string getnome(){
    return nome;
  }

  public void settelefone(string t){
    telefone = t;
  }

  public string getnome(){
    return nome;
  }

  public void setcidade(string ct){
    cidade = ct;
  }

  public string getcidade(){
    return cidade;
  }

  public void setvalor_investimento(double vl){
    valor_investimento = vl;
  }

  public double getvalor_investimento(){
    return valor_investimento;
  }

  public Comprador(string n, string t, string ct, double vl){
    nome = n;
    telefone = t;
    cidade = ct;
    valor_investimento = vl;
  }

}