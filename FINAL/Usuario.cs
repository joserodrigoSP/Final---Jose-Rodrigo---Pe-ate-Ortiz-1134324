using System;
using System.Globalization;
namespace FINAL;

public class Usuario
{
    public string nombre;
    public string apellido;
    public string carne;
    public string telefono;
    public string libroprestado ="";

    public Usuario(string nombre, string apellido, string carne, string telefono){
        this.nombre = nombre;
        this.apellido=apellido;
        this.carne=carne;
        this.telefono=telefono;
    }
    public string getnombre(){
        return nombre;
    }
    public string getapllido(){
        return apellido;
    }
    public string getcarne(){
        return carne;
    }

    public string gettelfono(){
        return telefono;
    }
}
