using System;
using System.Globalization;
using FINAL;
class Program
{
    private static void Main(string[] args)
    {  int cont =1;int op=0;  Usuario[] usuarios = new Usuario[0]; bool valido = false; Biblioteca objbiblioteca = new Biblioteca(usuarios);
    do{
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Examen Final. Jose Rodrigo Peñate - 1134324");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Ingrese la opción que desee:\n------------------------------------------ \n [1] Ingreso de datos \n [2] Mostrar datos \n [3] Prestar libro \n [4] Devolver libro  \n [5] Salir del programa");
         op = int.Parse(Console.ReadLine());
      
      
    ////Se hce el menu y un switch para cada caso
        switch(op){
            case 1: /// En el primer caso 
           
            Console.WriteLine("Cuantos usuarios necesita agregar? ");
            int cuantos =0;
            cuantos = int.Parse(Console.ReadLine());
            usuarios = new Usuario[cuantos];
            
            for(int i = 0; i<usuarios.Length; i++){
                int contador = i+1;
                Console.WriteLine("Ingrese el nombre del usuario "+contador+": ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el apellido del usuario "+contador+": ");
                string apellido = Console.ReadLine();
                Console.WriteLine("Ingrese el carné del usuario "+contador+": ");
                string carne = Console.ReadLine();
                Console.WriteLine("Ingrese el telefono del usuario "+contador+": ");
                string telefono = Console.ReadLine();
                usuarios[i] = new Usuario(nombre, apellido, carne, telefono);
            }
             objbiblioteca = new Biblioteca(usuarios);
            ///////////////////////////////////// Pedimos todos los datos necesarios para ingresar un estudiante
            
            break;


            case 2:
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("                Qué desea que se muestre? ");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine(" [1] Listado de libros prestados por usuario \n [2] Consultar catálogo de libros \n [3] Listado de usuarios activos");
            int opcion = int.Parse(Console.ReadLine());
            switch(opcion){
                case 1:
                objbiblioteca.mostrarLibrosPrestados();
                break;
                case 2:
                objbiblioteca.mostrarLibros();
                break;
                case 3:
                objbiblioteca.mostrarusuarios();
                break;
            }


            break;


            case 3: // Caso para prestar
            Console.WriteLine("Ingrese [nombre] del usuario a validar: ");
            string nombreus = Console.ReadLine();
            Console.WriteLine("Ingrese [carné] del usuario a validar: ");
            string carneus = Console.ReadLine(); /// Valida si el usuario existe con una especie de "LOGIN"
            
            for(int i = 0; i<usuarios.Length; i++){
                if(usuarios[i].nombre == nombreus && usuarios[i].carne == carneus){
                    valido = true;
                    Console.WriteLine("El usuario existe");
                    objbiblioteca.prestar(usuarios[i].nombre);

                }
            }
            if(valido == false){Console.WriteLine("El usuario no es valido, no existe");}

            break;

            case 4: // Caso para devolver 
            Console.WriteLine("Ingrese [nombre] del usuario a validar: ");
            string nombreus1 = Console.ReadLine();
            Console.WriteLine("Ingrese [carné] del usuario a validar: ");
            string carneus1 = Console.ReadLine();/// Valida si el usuario existe con una especie de "LOGIN"
            
            for(int i = 0; i<usuarios.Length; i++){
                if(usuarios[i].nombre == nombreus1 && usuarios[i].carne == carneus1){
                    valido = true;
                    Console.WriteLine("El usuario existe");
                    objbiblioteca.devolver(usuarios[i].nombre);

                }
            }
            if(valido == false){Console.WriteLine("El usuario no es valido, no existe");}

            break;
        }}while(op != 5);


    }
}