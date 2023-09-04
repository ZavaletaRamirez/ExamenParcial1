using System;

class Program
{
    static string[] artistas = new string[2];
    static string[] titulos = new string[2];
    static int[] duraciones = new int[2];
    static int[] tamanos = new int[2];
    static int cantidadCanciones = 0;

    static int[] codigos = new int[100];
    static string[] nombres = new string[100];
    static DateTime[] fechasNacimiento = new DateTime[100];
    static int[] grados = new int[100];
    static int[] aniosRegistro = new int[100];
    static int cantidadAlumnos = 0;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("********* Menú *********");
            Console.WriteLine("1. Ejercicio de Canciones");
            Console.WriteLine("2. Ejercicio de Alumnos");
            Console.WriteLine("3. Salir");
            Console.Write("\nElija una opción: ");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    MenuCanciones();
                    break;
                case 2:
                    MenuAlumnos();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, elija una opción válida.");
                    break;
            }
        }
    }

    static void MenuCanciones()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("********* Ejercicio de Canciones *********");
            Console.WriteLine("1. Agregar una canción");
            Console.WriteLine("2. Mostrar lista de canciones");
            Console.WriteLine("3. Volver al menú principal");
            Console.Write("\nElija una opción: ");

            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (opcion)
            {
                case 1:
                    AgregarCancion();
                    break;
                case 2:
                    MostrarCanciones();
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("\nOpción no válida. Por favor, elija una opción válida.");
                    break;
            }
        }
    }

    static void MenuAlumnos()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("********* Ejercicio de Alumnos *********");
            Console.WriteLine("1. Agregar un alumno");
            Console.WriteLine("2. Mostrar lista de alumnos");
            Console.WriteLine("3. Buscar alumno por código");
            Console.WriteLine("4. Editar información de un alumno por código");
            Console.WriteLine("\n5. Volver al menú principal");
            Console.Write("\nElija una opción: ");

            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (opcion)
            {
                case 1:
                    AgregarAlumno();
                    break;
                case 2:
                    MostrarListadoAlumnos();
                    break;
                case 3:
                    BuscarAlumnoPorCodigo();
                    break;
                case 4:
                    EditarAlumnoPorCodigo();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Opción no válida. Por favor, elija una opción válida.");
                    break;
            }
        }
    }

    static void AgregarCancion()
    {
        // solicitamos informacion al usuario
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("****** Ingrese los datos de la canción " + (i + 1) + " ****** :");
            Console.Write("Artista: ");
            artistas[i] = Console.ReadLine();

            Console.Write("\nTítulo: ");
            titulos[i] = Console.ReadLine();

            Console.Write("\nDuración (en segundos): ");
            duraciones[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nTamaño del fichero (en KB): ");
            tamanos[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nCanciones agregadas con exito...");
            
        }
        Console.WriteLine("\nPresione cualquier tecla para volver al menú de canciones...");
        Console.ReadKey();


    }

    static void MostrarCanciones()
    {
        Console.WriteLine("******Datos de las canciones******:\n");

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("Cancion #" + (i + 1) + ":");
            Console.WriteLine("Artista: " + artistas[i]);
            Console.WriteLine("Titulo: " + titulos[i]);
            Console.WriteLine("Duración (segundos): " + duraciones[i] + " segundos");
            Console.WriteLine("Tamaño del fichero (KB): " + tamanos[i] + "KB");
        }
        Console.WriteLine("\nPresione cualquier tecla para volver al menú de canciones...");
        Console.ReadKey();


    }

    static void AgregarAlumno()
    {
        // Código para agregar un alumno

        Console.WriteLine("Agregar un alumno");

        Console.Write("\nCódigo: ");
        int codigo = int.Parse(Console.ReadLine());
        codigos[cantidadAlumnos] = codigo;

        Console.Write("Nombre completo: ");
        string nombre = Console.ReadLine();
        nombres[cantidadAlumnos] = nombre;

        Console.Write("Fecha de nacimiento (yyyy-MM-dd): ");
        DateTime fechaNacimiento = DateTime.Parse(Console.ReadLine());
        fechasNacimiento[cantidadAlumnos] = fechaNacimiento;

        Console.Write("Grado: ");
        int grado = int.Parse(Console.ReadLine());
        grados[cantidadAlumnos] = grado;

        Console.Write("Año de registro: ");
        int anioRegistro = int.Parse(Console.ReadLine());
        aniosRegistro[cantidadAlumnos] = anioRegistro;

        cantidadAlumnos++;
        Console.WriteLine("\nAlumno agregado con éxito.");
        Console.WriteLine("Presione cualquier tecla para volver al menú...");
        Console.ReadKey();
        Console.Clear();
    }

    static void MostrarListadoAlumnos()
    {
        // Código para mostrar el listado de alumnos
        Console.WriteLine("Listado de Alumnos");
        Console.WriteLine("\nCódigo\tNombre\t\tFecha Nacimiento\tGrado\tAño de Registro");
        for (int i = 0; i < cantidadAlumnos; i++)
        {
            Console.WriteLine($"{codigos[i]}\t{nombres[i]}\t{fechasNacimiento[i]:yyyy-MM-dd}\t\t{grados[i]}\t{aniosRegistro[i]}");
        }
        Console.WriteLine("\n\nPresione la tecla ENTER para regresar al menú...");
        Console.ReadKey();
        Console.Clear();
    }

    static void BuscarAlumnoPorCodigo()
    {
        // Código para buscar un alumno por código
        Console.Write("Ingrese el código del alumno a buscar: ");
        int codigoBuscar = int.Parse(Console.ReadLine());

        bool encontrado = false;

        for (int i = 0; i < cantidadAlumnos; i++)
        {
            if (codigos[i] == codigoBuscar)
            {
                Console.WriteLine("Alumno encontrado:");
                Console.WriteLine("\nCódigo\tNombre\t\tFecha Nacimiento\tGrado\tAño de Registro");
                Console.WriteLine($"{codigos[i]}\t{nombres[i]}\t{fechasNacimiento[i]:yyyy-MM-dd}\t\t{grados[i]}\t{aniosRegistro[i]}");
                encontrado = true;
                break;
            }
            Console.WriteLine("\n\nPresione la tecla ENTER para regresar al menú...");
            Console.ReadKey();
            Console.Clear();
        }

        if (!encontrado)
        {
            Console.WriteLine("\nAlumno no encontrado.");
        }
        Console.WriteLine("Presione cualquier tecla para volver al menú...");
        Console.ReadKey();
        Console.Clear();
    }

    static void EditarAlumnoPorCodigo()
    {
        // Código para editar la información de un alumno por código
        Console.Write("\nIngrese el código del alumno a editar: ");
        int codigoEditar = int.Parse(Console.ReadLine());

        bool encontrado = false;
        //aca recorremos entre los codigos de alumnos agregados para ir a la posicion correcta
        for (int i = 0; i < cantidadAlumnos; i++)
        {
            if (codigos[i] == codigoEditar)
            {
                Console.WriteLine("\nEditar información del alumno:");

                Console.Write("Nuevo nombre completo: ");
                string nuevoNombre = Console.ReadLine();
                nombres[i] = nuevoNombre;

                Console.Write("Nueva fecha de nacimiento (yyyy-MM-dd): ");
                DateTime nuevaFechaNacimiento = DateTime.Parse(Console.ReadLine());
                fechasNacimiento[i] = nuevaFechaNacimiento;

                Console.Write("Nuevo grado: ");
                int nuevoGrado = int.Parse(Console.ReadLine());
                grados[i] = nuevoGrado;

                Console.Write("Nuevo año de registro: ");
                int nuevoAnioRegistro = int.Parse(Console.ReadLine());
                aniosRegistro[i] = nuevoAnioRegistro;

                Console.WriteLine("Información del alumno actualizada con éxito.");
                encontrado = true;
                break;

            }
        }

        if (!encontrado)
        {
            Console.WriteLine("\nAlumno no encontrado.");
            Console.WriteLine("Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
