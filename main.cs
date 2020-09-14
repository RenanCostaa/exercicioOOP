using System;

/*Crie uma classe que modele uma pessoa:

Atributos: nome, idade, peso e altura
Métodos: Envelhercer, engordar, emagrecer, crescer. Obs: Por padrão, a cada ano que nossa pessoa envelhece, sendo a idade dela menor que 21 anos, ela deve crescer 0,5 cm.
*/

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
