class Empreendedor{
  private string cpf;
  private string nome;
  private string telefone;
  private string tipoServico;
  private string cidade;
  private double preco;

  public void setCpf(string Cpf){
    cpf = Cpf;
  }

  public string getCpf(){
    return cpf;
  }

  public void setNome(string Name){
    nome = Name;
  }

  public string getNome(){
    return nome;
  }

  public void setTelefone(string Tel){
    telefone = Tel;
  }

  public string getTelefone(){
    return telefone;
  }

  public void setTipoServico(string Serv){
    tipoServico = Serv;
  }

  public string getTipoServico(){
    return tipoServico;
  }

  public void setCidade(string City){
    cidade = City;
  }

  public string getCidade(){
    return cidade;
  }

  public void setPreco(double Price){
    preco = Price;
  }

  public double getPreco(){
    return preco;
  }

  public Empreendedor (string Cpf, string Name, string Tel, string Serv, string City, double Price){
    cpf = Cpf;
    nome = Name;
    telefone = Tel;
    tipoServico = Serv;
    cidade = City;
    preco = Price;
  }

  public void insert(){
    BaseSombra db = new BaseSombra();

    string query = $"{this.cpf};{this.nome};{this.telefone};{this.tipoServico};{this.cidade};{this.preco}";

    db.insert("./BD/empreendedor_comprador.txt",query);

  }
  public void listar(){
    BaseSombra db = new BaseSombra();
    db.listar("./BD/empreendedor_comprador.txt");

  }

}