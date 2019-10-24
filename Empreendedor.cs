class Empreendedor{
  private string Nome;
  private string Telefone;
  private string tipoServico;
  private string Cidade;
  private double Preco;

  public void setNome(string Name){
    Nome = Name;
  }

  public getNome(){
    return Nome;
  }

  public void setTelefone(string Tel){
    Telefone = Tel;
  }

  public getTelefone(){
    return Telefone;
  }

  public void settipoServico(string Serv){
    tipoServico = Serv;
  }

  public gettipoServico(){
    return tipoServico;
  }

  public void setCidade(string City){
    Cidade = City;
  }

  public getCidade(){
    return City;
  }

  public void setPreco(double Price){
    Preco = Price;
  }

  public getPreco(){
    return Preco;
  }

  public Empreendedor (string Name, string Tel, string Serv, string City, double Price){
    Nome = Name;
    Telefone = Tel;
    tipoServico = Serv;
    Cidade = City;
    Preco = Price;
  }

}