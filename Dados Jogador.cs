using System;

class jogadorDeFutebol{
    public string nome = "Roger Guedes";
    public int dataDeNasc = 1996;
    public string posicao = "Atacante";
    public string nacionalidade = "Brasileiro";
    public double peso = 76;
    public double altura = 1.82;
    public Time clube;
    
    public void imprimirDados(string nome, string posicao, string nacionalidade, int dataDeNasc, double peso, double altura){
        Console.WriteLine("Nome: "+ this.nome);
        Console.WriteLine("ano de nascimento: "+ this.dataDeNasc);
        Console.WriteLine("posicao: "+ this.posicao);
        Console.WriteLine("nacionalidade: "+ this.nacionalidade);
        Console.WriteLine("peso: "+ this.peso);
        Console.WriteLine("altura: "+ this.altura);
    }
    public int idade(int dataDeNasc)
    {
        int anoAtual = 2023;
        return anoAtual - dataDeNasc;
    }
}

class Time{
    public string nomeTime = "corinthians";
}


class dadosJogador {
  static void Main() {
    jogadorDeFutebol jogador = new jogadorDeFutebol();
    jogador.imprimirDados(jogador.nome, jogador.posicao, jogador.nacionalidade, jogador.dataDeNasc, jogador.altura, jogador.peso);
    Console.WriteLine("A idade do jogador é: "+ jogador.idade(jogador.dataDeNasc)+ " anos.");
      
  }
}