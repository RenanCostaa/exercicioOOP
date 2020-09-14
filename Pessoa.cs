using System;

/*Crie uma classe que modele uma pessoa:

Atributos: nome, idade, peso e altura
Métodos: Envelhercer, engordar, emagrecer, crescer. Obs: Por padrão, a cada ano que nossa pessoa envelhece, sendo a idade dela menor que 21 anos, ela deve crescer 0,5 cm.
*/

public class Pessoa{
  //atributos
  private string nome;
  private int idade;
  private double peso;
  private double altura;

  //getters
  public string retornaNome(){
    return nome;
  }
  public int retornaIdade(){
    return idade;
  }
  public double retornaPeso(){
    return peso;
  }
  public double retornaAltura(){
    return altura;
  }

  //setters
  public void alteraNome(string n){
    nome=n;
  }
  public void alteraIdade(int i){
    idade=i;
  }
  public void alteraPeso(double p){
    peso=p;
  }
  public void alteraAltura(double a){
    altura=a;
  }


  public void envelhecer(){
  }
  public void engordar(){
  }
  public void emagrecer(){
  }
  public void crescer(){
  }
}