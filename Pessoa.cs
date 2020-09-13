using System;

/*Crie uma classe que modele uma pessoa:

Atributos: nome, idade, peso e altura
Métodos: Envelhercer, engordar, emagrecer, crescer. Obs: Por padrão, a cada ano que nossa pessoa envelhece, sendo a idade dela menor que 21 anos, ela deve crescer 0,5 cm.
*/

public class Pessoa{
  //atributos
  private string nome;
  private int idade;
  private float peso;
  private float altura;

  //getters
  public string retornaNome(){
    return nome;
  }
  public int retornaIdade(){
    return idade;
  }
  public float retornaPeso(){
    return peso;
  }
  public float retornaAltura(){
    return altura;
  }

  //setters
  public void alteraNome(){
  }
  public void alteraIdade(){
  }
  public void alteraPeso(){
  }
  public void alteraAltura(){
  }


  public envelhecer(){
  }
  public engordar(){
  }
  public emagrecer(){
  }
  public crescer(){
  }
}