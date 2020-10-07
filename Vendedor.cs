using System;

//ATRIBUTO NOME (GET E SET)
//INSERIR CONSTRUTOR NÃO VAZIO (COMPLETO)
class vendedor{
  double salario,comissao;
  string nome;

  public vendedor(string n,double s,double c) {
    nome = n;
    salario = s;
    comissao = c;
  }

  public double receber_relatorio(double valor_vendas){
    return (salario + comissao*valor_vendas);
  }

}