using System;

class MainClass {
  public static void Main (string[] args) {
    vendedor joao = new vendedor("João",20.3,1.2);
    veiculo uno = new veiculo("fiat",10,50,122864000.01);
    mostruario secaoA = new mostruario();
    exibirMenu menu = new exibirMenu();
    secaoA.setRepresentante(joao);
    secaoA.carros.Add(uno);
    secaoA.carros.Add(uno);
    secaoA.carros.Add(uno);
    secaoA.carros.Add(uno);
    secaoA.carros.Add(uno);
    secaoA.carros.Add(uno);
    double total = 0;

   /* While (true) {
      string resposta = "";
      menu.menu();
      Console.ReadLine("Escolha uma opção ou outra tecla para sair:")
      resposta = Console.ReadLine();

      if (resposta == "1") {
        string modelo;
        string marca;
        int ano;
        int km;
        int valor;

        veiculo modelo = new veiculo(marca,ano,km,valor);

      }

    };*/
    total = secaoA.calculaValor(total);
    Console.WriteLine("Valor total: {0}",total);
  }
}