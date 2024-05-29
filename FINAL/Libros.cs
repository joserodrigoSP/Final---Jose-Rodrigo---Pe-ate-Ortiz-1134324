using System;
using System.Globalization;
namespace FINAL;

public class Libro
{

    public string titulo; 
    public string autor;
    public string genero;

    public bool prestado=false;
    public int numlibro;


    public Libro(string titulo, string autor, string genero, int numlibro){
        this.titulo = titulo;
        this.autor = autor;
        this.genero = genero;
        this.numlibro = numlibro;
    }


}
