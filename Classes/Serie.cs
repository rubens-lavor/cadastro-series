using System;

namespace ProjetoDIO.Series
{
  public class Serie : EntidadeBase
  {

    private Genero Genero { get; set; }
    private string Titulo { get; set; }
    private string Descricao { get; set; }
    private int Ano { get; set; }
    private bool Excluido {get; set;}


    public Serie(int id, Genero genero, string titulo, string descricao, int ano)
  {
    this.Id = id;
    this.Genero = genero;
    this.Titulo = titulo;
    this.Descricao = descricao;
    this.Ano = ano;
    this.Excluido = false;
  }


    public override string ToString()
    {
      string retorno = " ";
      retorno += "Genero: " + this.Genero + Environment.NewLine;
      retorno += "Título: " + this.Titulo + Environment.NewLine;
      retorno += "Descricao: " + this.Descricao + Environment.NewLine;
      retorno += "Ano de Início: " + this.Ano + Environment.NewLine;

      return retorno;
    }

    public string retornarTitulo(){
      return this.Titulo;
    }

    internal int retornarId(){
      return this.Id;
    }

    public void excluirRegistro() {
      this.Excluido = true;
    }
  }
}