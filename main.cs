using System;

class MainClass {
  public static void Main () {
    Pessoa p = new Pessoa();
    p.alteraNome("Tiririca");
    p.alteraIdade(55);
    p.alteraPeso(82.5);
    p.alteraAltura(1.68);

    Console.WriteLine(p.retornaNome());
    Console.WriteLine(p.retornaIdade());
    Console.WriteLine(p.retornaPeso());
    Console.WriteLine(p.retornaAltura());

  }
}
