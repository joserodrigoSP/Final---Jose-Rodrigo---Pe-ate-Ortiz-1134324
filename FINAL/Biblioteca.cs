using System;
using System.Globalization;
using System.Security.Cryptography;
namespace FINAL;

public class Biblioteca
{
    public Libro[] objlibro= new Libro[5];
    public int numusuarios =0;
    Usuario[] objus = new Usuario[0]; 

    public Biblioteca(Usuario[] usuarioss){
            objlibro[0] = new Libro("Harry Potter y la piedra filosofal", "J.K. Rowling", "Fantasía juvenil",0);
            //////////////////////
            objlibro[1] = new Libro("Cien años de soledad", "Gabriel García Márquez", "Realismo mágico",1);
            //////////////////////
            objlibro[2] = new Libro("Orgullo y prejuicio", "Jane Austen", "Novela romántica",2);
            //////////////////////
            objlibro[3] = new Libro("Matar a un ruiseñor", "Harper Lee", "Ficción literaria",3);
            //////////////////////
            objlibro[4] = new Libro("Don Quijote de la Mancha", "Miguel de Cervantes", "Novela de caballerías",4);
            this.objus = usuarioss;
    }

    // SE ASIGNAN LOS LIBROS QUE EXISTEN EN LA BIBLIOTECA

    public void mostrarLibros(){
        string alg = "";
        for(int i=0; i<objlibro.Length; i++){
            if(objlibro[i].prestado==false){
                alg="disponible";
            }else{
                alg="Prestado, no disponible";   /////////// despliega todos los libros, el if es para imprimir si está disponible o no
            }
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("No. Libro: "+ objlibro[i].numlibro);
            Console.WriteLine("Titulo del libro: "+ objlibro[i].titulo);
            Console.WriteLine("Autor del libro: "+ objlibro[i].titulo);
            Console.WriteLine("Género del libro: "+ objlibro[i].titulo);
            Console.WriteLine("Disponibilidad: "+alg);
            if(objlibro[i].prestado==true){
                for(int j=0; j<objus.Length; j++){
                    if(objlibro[i].titulo==objus[j].libroprestado){
                Console.WriteLine("Prestado por: "+objus[j].nombre+" "+objus[j].apellido);}}
                }
            Console.WriteLine("----------------------------------------------");
        }
    }

    public void prestar(string usuario){
        mostrarLibros();
        Console.WriteLine("Ingrese el numero del libro a prestar: ");
        int op = int.Parse(Console.ReadLine());
        switch(op){
            case 0:
            if(objlibro[0].prestado==false){
                objlibro[0].prestado=true;
                Console.WriteLine("El libro se le ha asignado al usuario");
                for(int i=0; i<objus.Length; i++){
                    if(objus[i].nombre==usuario)
                objus[i].libroprestado="Harry Potter y la piedra filosofal";
                }
                
            }else{
                Console.WriteLine("💥💥💥💥 El libro ya esta prestado 💥💥💥💥");
                Console.WriteLine("No se puede prestar");
            }
            break;
            case 1:
            if(objlibro[1].prestado==false){
                objlibro[1].prestado=true;
                Console.WriteLine("El libro se le ha asignado al usuario");
                for(int i=0; i<objus.Length; i++){
                    if(objus[i].nombre==usuario)
                objus[i].libroprestado="Cien años de soledad";
                }
                
            }else{
               Console.WriteLine("💥💥💥💥 El libro ya esta prestado 💥💥💥💥");
                Console.WriteLine("No se puede prestar");
            }
            break;
            case 2:
             if(objlibro[2].prestado==false){
                objlibro[2].prestado=true;
                Console.WriteLine("El libro se le ha asignado al usuario");
                for(int i=0; i<objus.Length; i++){
                    if(objus[i].nombre==usuario)
                objus[i].libroprestado="Orgullo y prejuicio";
                }
                
            }else{
                Console.WriteLine("💥💥💥💥 El libro ya esta prestado 💥💥💥💥");
                Console.WriteLine("No se puede prestar");
            }
            break;
            case 3:
            if(objlibro[3].prestado==false){
                objlibro[3].prestado=true;
                Console.WriteLine("El libro se le ha asignado al usuario");
                for(int i=0; i<objus.Length; i++){
                    if(objus[i].nombre==usuario)
                objus[i].libroprestado="Matar a un ruiseñor";
                }
                
            }else{
                Console.WriteLine("💥💥💥💥 El libro ya esta prestado 💥💥💥💥");
                Console.WriteLine("No se puede prestar");
            }
            break;
            case 4:
            if(objlibro[4].prestado==false){
                objlibro[4].prestado=true;/// Le cambia el estado al libro y el usuario tendra como libro prestado el titulo 
                Console.WriteLine("El libro se le ha asignado al usuario");
                for(int i=0; i<objus.Length; i++){
                    if(objus[i].nombre==usuario)
                objus[i].libroprestado="Don Quijote de la Mancha";
                }
                
            }else{
              Console.WriteLine("💥💥💥💥 El libro ya esta prestado 💥💥💥💥");
                Console.WriteLine("No se puede prestar");
            }
            break;
        } ///////////////////////////////////// EN ESTE APARTADO SOLAMENTE SE VALIDA SI EL LIBRO NO ESTA PRESTADO, SI NO ESTA PRESTADO SE LE CAMBIA DE FALSE A TRUE 
    }
    public void devolver(string usuario){

        for(int i=0; i<objus.Length; i++){
            if(objus[i].nombre==usuario){

                if(objus[i].libroprestado==""){/// Valida si el usuario prestó un libro o no
                    Console.WriteLine("Usted no tiene libros prestados");
                }else{
                    Console.WriteLine("Devolviendo "+objus[i].libroprestado+". ");
                    for(int j =0; j<objlibro.Length;j++){
                        if(objlibro[j].titulo==objus[i].libroprestado){
                            objlibro[j].prestado=false; /////////// Solamente se cambia el estado del libro prestado
                        }
                    }


                }

            }
        }
        

    }

    public void mostrarLibrosPrestados(){
        string alg = "";
        for(int i=0; i<objlibro.Length; i++){
            if(objlibro[i].prestado==false){ // si es falso es porque no está disponible
                alg="disponible";
            }else{
            for(int j=0; j<objus.Length; j++){
            if(objlibro[i].titulo==objus[j].libroprestado){
            alg="Prestado por: "+objus[j].nombre+" "+objus[j].apellido;}}
            
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("No. Libro: "+ objlibro[i].numlibro);
            Console.WriteLine("Titulo del libro: "+ objlibro[i].titulo);
            Console.WriteLine("Autor del libro: "+ objlibro[i].titulo);
            Console.WriteLine("Género del libro: "+ objlibro[i].titulo);
            Console.WriteLine("Disponibilidad: "+alg);
       
            Console.WriteLine("----------------------------------------------");
            }
           
        }
    }

    public void mostrarusuarios(){
        for(int i=0; i<objus.Length; i++){
            Console.WriteLine("Nombre usuario: "+ objus[i].nombre);
            Console.WriteLine("Apellido usuario: "+ objus[i].apellido);
            Console.WriteLine("carnet usuario: "+ objus[i].carne);
            string presto="";
            if(objus[i].libroprestado==""){
                presto="No tiene libros prestados";
            }else{presto=objus[i].libroprestado;}
            Console.WriteLine("Libro prestado: "+ presto);
        }
    }


     

}
