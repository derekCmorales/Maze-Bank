/* sistema bancario hecho por
    José Javier Rodríguez Alvarado 1535524
    Derek Adolfo Calderón Moraes 1567624
 */
Random rnd = new Random();
List<int> numcheque_ls = new List<int>();

int numcheque;

string nombres = "N/A";
string apellidos = "N/A";
int saldoCuenta = 0;
int opcion;
int nuevoDeposito = 0;
int cantidadDepositos = 0;
int nuevoRetiro = 0;
int cantidadRetiros = 0;
int penalizaciones = 0;

//numero decuenta que ingresa el usuario
int cuenta;
//numero de cuenta creado por el sistema
int numCuenta = rnd.Next(10000, 15000);


do
{
    MenuPrincipal();
    Console.Write("Ingrese una opcion: ");
    Console.ForegroundColor = ConsoleColor.White;
    while (!int.TryParse(Console.ReadLine(), out opcion))
    {
        Console.Clear();
        MenuPrincipal();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Opción inválida. Intente nuevamente: ");
        Console.ForegroundColor = ConsoleColor.White;
    }

    switch (opcion)
    {
        //--------------------------------Crear Cuenta--------------------------------//
        
        case 1:
    
//Solicita nombre del titular
    do
    {
        Console.Clear();
        encabezadoApertura();
        Console.Write("Nombre del titular de la cuenta: ");
        Console.ForegroundColor = ConsoleColor.White;
        nombres = Console.ReadLine();
        
    } while (string.IsNullOrEmpty(nombres) || !nombres.All(char.IsLetter) || nombres.Any(char.IsDigit));
    

//Solicita apellidos del titular
    do
    {
        Console.Clear();
        encabezadoApertura();
        Console.Write("Apellido del titular de la cuenta: ");
        Console.ForegroundColor = ConsoleColor.White;
        apellidos = Console.ReadLine();
        
    } while (string.IsNullOrEmpty(apellidos) || !apellidos.All(char.IsLetter) || apellidos.Any(char.IsDigit));
    
    
    // Balance para crear cuenta
    int Balance;
    
    Console.Clear();
    encabezadoApertura();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("Saldo inicial para crear la cuenta. (Mínimo Q200): ");
    Console.ForegroundColor = ConsoleColor.White;
    while (!int.TryParse(Console.ReadLine(), out Balance) || Balance < 200)
    {
        encabezadoApertura();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Monto ingresado no entero o insuficiente.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Saldo inicial para crear la cuenta. (Mínimo Q200): ");
        Console.ForegroundColor = ConsoleColor.White;
    }
    Console.Clear();
    encabezadoApertura();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Creando cuenta bancaria...");
    Thread.Sleep(2000); Console.Clear();
    encabezadoApertura();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Cuenta creada con éxito!");
    
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("\nDatos de la cuenta: \n");
    
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("Número de cuenta: ");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(numCuenta);
    
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("Nombre del titular de la cuenta: ");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(nombres);
    
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("Apellido del titular de la cuenta: ");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(apellidos);
    
    saldoCuenta += Balance;
    
    
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("\nPulsa cualquier tecla para regresar al menu.");
    Console.ForegroundColor = ConsoleColor.White;
    Console.ReadKey();
            break;
        
        //--------------------------------------Depositos---------------------------------------------//
        
        case 2:

            //codigo de depsitos
            encabezadoDepositos();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\nIngrese el número de la cuenta: ");
            Console.ForegroundColor = ConsoleColor.White;
            while (!int.TryParse(Console.ReadLine(), out cuenta) || cuenta != numCuenta)
            {
                encabezadoDepositos();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Buscando cuenta en la base de datos...");
                Thread.Sleep(1000);
                Console.Clear();
                encabezadoDepositos();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Número de cuenta inválido o inexistente.");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Ingrese el número de la cuenta: ");
                Console.ForegroundColor = ConsoleColor.White;
        
            }

            if (cuenta == numCuenta)
            {
                encabezadoDepositos();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Buscando cuenta en la base de datos...");
                Thread.Sleep(1200);
                Console.Clear();
                encabezadoDepositos();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Cuenta encontrada!");
                
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nDatos de la cuenta: \n");
    
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Número de cuenta: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(numCuenta);
    
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Nombre del titular de la cuenta: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(nombres);
    
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Apellido del titular de la cuenta: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(apellidos);
            }
    
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nPulsa cualquier tecla si quieres continuar con el depósito.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            
            Console.Clear();
            encabezadoDepositos();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Depósito al número de cuenta: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(numCuenta);
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            Console.Write("\nIngrese la cantidad que desea depósitar: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Q.");
            while (!int.TryParse(Console.ReadLine(), out nuevoDeposito))
            {
                encabezadoDepositos();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ingrese un monto válido.");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Ingrese la cantidad que desea depósitar: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Q.");
        
            }
            Console.Clear();
            encabezadoDepositos();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Realizando Depósito...");
            Thread.Sleep(1200);
            Console.Clear();
            encabezadoDepositos();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Depósito de Q." + nuevoDeposito + " Realizado con éxito.");

            saldoCuenta += nuevoDeposito;
            cantidadDepositos++;
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Presione cualquier tecla para regresar al menú.");
            Console.ReadKey();
            break;
        
        
        //----------------------------------RETIROS----------------------------------//
        
        
        case 3:
            
                        //codigo de retiros
            encabezadoRetiros();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\nIngrese el número de la cuenta: ");
            Console.ForegroundColor = ConsoleColor.White;
            while (!int.TryParse(Console.ReadLine(), out cuenta) || cuenta != numCuenta)
            {
                encabezadoRetiros();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Buscando cuenta en la base de datos...");
                Thread.Sleep(1000);
                Console.Clear();
                encabezadoRetiros();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Número de cuenta válido o inexistente.");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Ingrese el número de la cuenta: ");
                Console.ForegroundColor = ConsoleColor.White;
        
            }

            if (cuenta == numCuenta)
            {
                encabezadoRetiros();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Buscando cuenta en la base de datos...");
                Thread.Sleep(1200);
                Console.Clear();
                encabezadoRetiros();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Cuenta encontrada!");
                
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nDatos de la cuenta: \n");
    
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Número de cuenta: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(numCuenta);
    
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Nombre del titular de la cuenta: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(nombres);
    
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Apellido del titular de la cuenta: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(apellidos);
            }
    
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nPulsa cualquier tecla si quieres continuar con el retiro.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            Console.Clear();
            encabezadoRetiros();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Depósito al número de cuenta: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(numCuenta);
            Console.ForegroundColor = ConsoleColor.Yellow;
                        
            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\nIngrese el número de cheque para el retiro: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("N.");
    
                while (!int.TryParse(Console.ReadLine(), out numcheque))
                {
                    Console.Clear();
                    encabezadoRetiros();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Número de cheque inválido.");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Ingrese el número de cheque para el retiro: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("N.");
                }
                

                if (numcheque_ls.Contains(numcheque))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Número de cheque ya usado.");
                }
                else
                {
                    numcheque_ls.Add(numcheque);
                    break;
                }
            } while (true);
            
                        
            Console.Clear();
            encabezadoRetiros();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\nIngrese la cantidad del cheque a retirar: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Q.");
            while (!int.TryParse(Console.ReadLine(), out nuevoRetiro))
            {
                encabezadoRetiros();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ingrese un monto válido.");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Ingrese la cantidad del cheque a retirar: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Q.");

            }
                        
            if (nuevoRetiro > saldoCuenta)
            {
                Console.Clear();
                encabezadoRetiros();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error. El monto del cheque es mayor al saldo de la cuenta.");
                Console.Write("Se le ha penalizado con Q.150\n");
                Console.ForegroundColor = ConsoleColor.White;
                saldoCuenta -= 150;
                penalizaciones++;

                
            }
            else if (nuevoRetiro <= saldoCuenta)
            {
                Console.Clear();
                encabezadoRetiros();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Realizando retiro...");
                Thread.Sleep(1200);
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Retiro de Q." + nuevoRetiro + " Realizado con éxito.");
                saldoCuenta -= nuevoRetiro;
                cantidadRetiros++;
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nPresione cualquier tecla para regresar al menú.");
            Console.ReadKey();
            break;
        case 4:
            //-----------------------------------ESTADISTICAS-----------------------------------//
            
            encabezadoEstadisticas();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\nIngrese el número de la cuenta: ");
            Console.ForegroundColor = ConsoleColor.White;
            while (!int.TryParse(Console.ReadLine(), out cuenta) || cuenta != numCuenta)
            {
                encabezadoEstadisticas();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Buscando cuenta en la base de datos...");
                Thread.Sleep(1000);
                Console.Clear();
                encabezadoEstadisticas();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Número de cuenta válido o inexistente.");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Ingrese el número de la cuenta: ");
                Console.ForegroundColor = ConsoleColor.White;
        
            }

            if (cuenta == numCuenta)
            {
                encabezadoEstadisticas();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Buscando cuenta en la base de datos...");
                Thread.Sleep(1200);
                Console.Clear();
                encabezadoEstadisticas();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Cuenta encontrada!");
                
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nDatos de la cuenta: \n");
    
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Número de cuenta: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(numCuenta);
    
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Nombre del titular de la cuenta: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(nombres);
    
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Apellido del titular de la cuenta: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(apellidos);
            }
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nPresione cualquier tecla para acceder a las estadísticas.");
            Console.ReadKey();
            
            Console.Clear();
            encabezadoEstadisticas();
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Saldo actual de la cuenta: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(saldoCuenta);
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("");
            Console.Write("Cantidad de depósitos realizados: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(cantidadDepositos);
            string barra = "\u2588";

            for (int i = 1; i <= cantidadDepositos; i++)
            {
                Console.Write(barra);
            }
            
            
            
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("");
            Console.Write("\nCantidad de retiros realizados: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(cantidadRetiros);

            for (int i = 1; i <= cantidadRetiros; i++)
            {
                Console.Write(barra);
            }
            
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("");
            Console.Write("\nCantidad de penalizaciones:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(penalizaciones);
            barra = "\u2588";

            for (int i = 1; i <= penalizaciones; i++)
            {
                Console.Write(barra);
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("");
            Console.Write("\nPresione cualquier tecla para regresar al menú.");
            Console.ReadKey();
            break;
        case 5:
            Salida();
            break;
    }
} while (opcion != 5);



static void MenuPrincipal()
{
    // Título e interfaz inicial
    Console.Clear();
    Console.Write(new string(' ', (Console.WindowWidth - "Bienvenido a Maze Bank Los Santos".Length) / 2));
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Bienvenido a Maze Bank Los Santos");
    Console.ForegroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Menú Principal\n");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("1. Abrir una Cuenta Monetaria");
    Console.WriteLine("2. Depositar");
    Console.WriteLine("3. Retirar");
    Console.WriteLine("4. Estadísticas");
    Console.WriteLine("5. Salir\n");
    Console.ForegroundColor = ConsoleColor.Blue;
}


static void Salida()
{
    
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("     \u2588\u2588\u2557 \u2588\u2588\u2588\u2588\u2588\u2557 \u2588\u2588\u2557   \u2588\u2588\u2557\u2588\u2588\u2557\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2557\u2588\u2588\u2588\u2588\u2588\u2588\u2557                             \u2588\u2588\u2588\u2588\u2588\u2588\u2557  \u2588\u2588\u2588\u2588\u2588\u2588\u2557 \u2588\u2588\u2588\u2588\u2588\u2588\u2557 \u2588\u2588\u2588\u2588\u2588\u2588\u2557 \u2588\u2588\u2557 \u2588\u2588\u2588\u2588\u2588\u2588\u2557 \u2588\u2588\u2557   \u2588\u2588\u2557\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2557\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2557\n     \u2588\u2588\u2551\u2588\u2588\u2554\u2550\u2550\u2588\u2588\u2557\u2588\u2588\u2551   \u2588\u2588\u2551\u2588\u2588\u2551\u2588\u2588\u2554\u2550\u2550\u2550\u2550\u255d\u2588\u2588\u2554\u2550\u2550\u2588\u2588\u2557                            \u2588\u2588\u2554\u2550\u2550\u2588\u2588\u2557\u2588\u2588\u2554\u2550\u2550\u2550\u2588\u2588\u2557\u2588\u2588\u2554\u2550\u2550\u2588\u2588\u2557\u2588\u2588\u2554\u2550\u2550\u2588\u2588\u2557\u2588\u2588\u2551\u2588\u2588\u2554\u2550\u2550\u2550\u2550\u255d \u2588\u2588\u2551   \u2588\u2588\u2551\u2588\u2588\u2554\u2550\u2550\u2550\u2550\u255d\u255a\u2550\u2550\u2588\u2588\u2588\u2554\u255d\n     \u2588\u2588\u2551\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2551\u2588\u2588\u2551   \u2588\u2588\u2551\u2588\u2588\u2551\u2588\u2588\u2588\u2588\u2588\u2557  \u2588\u2588\u2588\u2588\u2588\u2588\u2554\u255d                            \u2588\u2588\u2588\u2588\u2588\u2588\u2554\u255d\u2588\u2588\u2551   \u2588\u2588\u2551\u2588\u2588\u2551  \u2588\u2588\u2551\u2588\u2588\u2588\u2588\u2588\u2588\u2554\u255d\u2588\u2588\u2551\u2588\u2588\u2551  \u2588\u2588\u2588\u2557\u2588\u2588\u2551   \u2588\u2588\u2551\u2588\u2588\u2588\u2588\u2588\u2557    \u2588\u2588\u2588\u2554\u255d \n\u2588\u2588   \u2588\u2588\u2551\u2588\u2588\u2554\u2550\u2550\u2588\u2588\u2551\u255a\u2588\u2588\u2557 \u2588\u2588\u2554\u255d\u2588\u2588\u2551\u2588\u2588\u2554\u2550\u2550\u255d  \u2588\u2588\u2554\u2550\u2550\u2588\u2588\u2557                            \u2588\u2588\u2554\u2550\u2550\u2588\u2588\u2557\u2588\u2588\u2551   \u2588\u2588\u2551\u2588\u2588\u2551  \u2588\u2588\u2551\u2588\u2588\u2554\u2550\u2550\u2588\u2588\u2557\u2588\u2588\u2551\u2588\u2588\u2551   \u2588\u2588\u2551\u2588\u2588\u2551   \u2588\u2588\u2551\u2588\u2588\u2554\u2550\u2550\u255d   \u2588\u2588\u2588\u2554\u255d  \n\u255a\u2588\u2588\u2588\u2588\u2588\u2554\u255d\u2588\u2588\u2551  \u2588\u2588\u2551 \u255a\u2588\u2588\u2588\u2588\u2554\u255d \u2588\u2588\u2551\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2557\u2588\u2588\u2551  \u2588\u2588\u2551                            \u2588\u2588\u2551  \u2588\u2588\u2551\u255a\u2588\u2588\u2588\u2588\u2588\u2588\u2554\u255d\u2588\u2588\u2588\u2588\u2588\u2588\u2554\u255d\u2588\u2588\u2551  \u2588\u2588\u2551\u2588\u2588\u2551\u255a\u2588\u2588\u2588\u2588\u2588\u2588\u2554\u255d\u255a\u2588\u2588\u2588\u2588\u2588\u2588\u2554\u255d\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2557\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2557\n \u255a\u2550\u2550\u2550\u2550\u255d \u255a\u2550\u255d  \u255a\u2550\u255d  \u255a\u2550\u2550\u2550\u255d  \u255a\u2550\u255d\u255a\u2550\u2550\u2550\u2550\u2550\u2550\u255d\u255a\u2550\u255d  \u255a\u2550\u255d                            \u255a\u2550\u255d  \u255a\u2550\u255d \u255a\u2550\u2550\u2550\u2550\u2550\u255d \u255a\u2550\u2550\u2550\u2550\u2550\u255d \u255a\u2550\u255d  \u255a\u2550\u255d\u255a\u2550\u255d \u255a\u2550\u2550\u2550\u2550\u2550\u255d  \u255a\u2550\u2550\u2550\u2550\u2550\u255d \u255a\u2550\u2550\u2550\u2550\u2550\u2550\u255d\u255a\u2550\u2550\u2550\u2550\u2550\u2550\u255d\n\u2588\u2588\u2588\u2588\u2588\u2588\u2557 \u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2557\u2588\u2588\u2588\u2588\u2588\u2588\u2557 \u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2557\u2588\u2588\u2557  \u2588\u2588\u2557                                 \u2588\u2588\u2588\u2588\u2588\u2588\u2557 \u2588\u2588\u2588\u2588\u2588\u2557 \u2588\u2588\u2557     \u2588\u2588\u2588\u2588\u2588\u2588\u2557 \u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2557\u2588\u2588\u2588\u2588\u2588\u2588\u2557  \u2588\u2588\u2588\u2588\u2588\u2588\u2557 \u2588\u2588\u2588\u2557   \u2588\u2588\u2557   \n\u2588\u2588\u2554\u2550\u2550\u2588\u2588\u2557\u2588\u2588\u2554\u2550\u2550\u2550\u2550\u255d\u2588\u2588\u2554\u2550\u2550\u2588\u2588\u2557\u2588\u2588\u2554\u2550\u2550\u2550\u2550\u255d\u2588\u2588\u2551 \u2588\u2588\u2554\u255d                                \u2588\u2588\u2554\u2550\u2550\u2550\u2550\u255d\u2588\u2588\u2554\u2550\u2550\u2588\u2588\u2557\u2588\u2588\u2551     \u2588\u2588\u2554\u2550\u2550\u2588\u2588\u2557\u2588\u2588\u2554\u2550\u2550\u2550\u2550\u255d\u2588\u2588\u2554\u2550\u2550\u2588\u2588\u2557\u2588\u2588\u2554\u2550\u2550\u2550\u2588\u2588\u2557\u2588\u2588\u2588\u2588\u2557  \u2588\u2588\u2551   \n\u2588\u2588\u2551  \u2588\u2588\u2551\u2588\u2588\u2588\u2588\u2588\u2557  \u2588\u2588\u2588\u2588\u2588\u2588\u2554\u255d\u2588\u2588\u2588\u2588\u2588\u2557  \u2588\u2588\u2588\u2588\u2588\u2554\u255d                                 \u2588\u2588\u2551     \u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2551\u2588\u2588\u2551     \u2588\u2588\u2551  \u2588\u2588\u2551\u2588\u2588\u2588\u2588\u2588\u2557  \u2588\u2588\u2588\u2588\u2588\u2588\u2554\u255d\u2588\u2588\u2551   \u2588\u2588\u2551\u2588\u2588\u2554\u2588\u2588\u2557 \u2588\u2588\u2551   \n\u2588\u2588\u2551  \u2588\u2588\u2551\u2588\u2588\u2554\u2550\u2550\u255d  \u2588\u2588\u2554\u2550\u2550\u2588\u2588\u2557\u2588\u2588\u2554\u2550\u2550\u255d  \u2588\u2588\u2554\u2550\u2588\u2588\u2557                                 \u2588\u2588\u2551     \u2588\u2588\u2554\u2550\u2550\u2588\u2588\u2551\u2588\u2588\u2551     \u2588\u2588\u2551  \u2588\u2588\u2551\u2588\u2588\u2554\u2550\u2550\u255d  \u2588\u2588\u2554\u2550\u2550\u2588\u2588\u2557\u2588\u2588\u2551   \u2588\u2588\u2551\u2588\u2588\u2551\u255a\u2588\u2588\u2557\u2588\u2588\u2551   \n\u2588\u2588\u2588\u2588\u2588\u2588\u2554\u255d\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2557\u2588\u2588\u2551  \u2588\u2588\u2551\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2557\u2588\u2588\u2551  \u2588\u2588\u2557                                \u255a\u2588\u2588\u2588\u2588\u2588\u2588\u2557\u2588\u2588\u2551  \u2588\u2588\u2551\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2557\u2588\u2588\u2588\u2588\u2588\u2588\u2554\u255d\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2557\u2588\u2588\u2551  \u2588\u2588\u2551\u255a\u2588\u2588\u2588\u2588\u2588\u2588\u2554\u255d\u2588\u2588\u2551 \u255a\u2588\u2588\u2588\u2588\u2551   \n\u255a\u2550\u2550\u2550\u2550\u2550\u255d \u255a\u2550\u2550\u2550\u2550\u2550\u2550\u255d\u255a\u2550\u255d  \u255a\u2550\u255d\u255a\u2550\u2550\u2550\u2550\u2550\u2550\u255d\u255a\u2550\u255d  \u255a\u2550\u255d                                 \u255a\u2550\u2550\u2550\u2550\u2550\u255d\u255a\u2550\u255d  \u255a\u2550\u255d\u255a\u2550\u2550\u2550\u2550\u2550\u2550\u255d\u255a\u2550\u2550\u2550\u2550\u2550\u255d \u255a\u2550\u2550\u2550\u2550\u2550\u2550\u255d\u255a\u2550\u255d  \u255a\u2550\u255d \u255a\u2550\u2550\u2550\u2550\u2550\u255d \u255a\u2550\u255d  \u255a\u2550\u2550\u2550\u255d   \n                                                                                                                                              \n");
    Console.ForegroundColor = ConsoleColor.White;
}

//Funcion de encabezado de apertrura cuenta
static void encabezadoApertura()
{
    Console.Clear();
    Console.Write(new string(' ', (Console.WindowWidth - "Apertura de Cuenta Monetaria".Length) / 2));
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Apertura de Cuenta Monetaria\n");
    Console.ForegroundColor = ConsoleColor.Blue;
}


//Funcion de encabezado de despositos
static void encabezadoDepositos()
{
    Console.Clear();
    Console.Write(new string(' ', (Console.WindowWidth - "Depósitos".Length) / 2));
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Depósitos\n");
    Console.ForegroundColor = ConsoleColor.Blue;
}


//Funcion de encabezado de retiros
static void encabezadoRetiros()
{
    Console.Clear();
    Console.Write(new string(' ', (Console.WindowWidth - "Retiros".Length) / 2));
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Retiros\n");
    Console.ForegroundColor = ConsoleColor.Blue;
}


//Funcion de encabezado de estadistias
static void encabezadoEstadisticas()
{
    Console.Clear();
    Console.Write(new string(' ', (Console.WindowWidth - "Estadísticas".Length) / 2));
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Estadísticas\n");
    Console.ForegroundColor = ConsoleColor.Blue;
}
