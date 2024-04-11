// See https://aka.ms/new-console-template for more information

bool fin = false;
List<Cliente> listaDeCliente = new List<Cliente>(); //crea mi lista de cliente

while(fin == false){

    Console.WriteLine("Qué acción desea realizar: 1 - Crear Cliente \n 2 - Realizar transacción \n 3 - Listar Clientes");
    int accion = Convert.ToInt32(Console.ReadLine());

    switch(accion)
    {
        case 1:
        //logica
        //me creo un cliente cualquiera
        Cliente cliente = new Cliente();
        Console.WriteLine("Ingrese el nombre del cliente");
        cliente.Nombre = Console.ReadLine();
        Console.WriteLine("Ingrese el CI del cliente");
        cliente.NumeroCedula = Console.ReadLine();
        cliente.SaldoTotal = 0;
        cliente.NroCuenta = 100 + cliente.NumeroCedula;
        listaDeCliente.Add(cliente); //añado al cliente a la lista
        Console.WriteLine($"El nombre de la persona es: {cliente.Nombre}");
        Console.WriteLine($"El CI de la persona es: {cliente.NumeroCedula}");
        Console.WriteLine($"El Saldo Incial es: {cliente.SaldoTotal}");
        Console.WriteLine($"El Nro cuenta es: {cliente.NroCuenta}");
        break;

        case 2:
        //logica
        Console.WriteLine("Ingrese el CI a buscar");
        string cedulaABuscar = Console.ReadLine();
        Cliente clienteEncontrado = listaDeCliente.Find(cliente => cliente.NumeroCedula == cedulaABuscar);
        
        break;

        case 3:
            foreach (var uncliente in listaDeCliente)
            {
                Console.WriteLine("Detalle del cliente:");
                Console.WriteLine($"El nombre de la persona es: {uncliente.Nombre}");
                Console.WriteLine($"El CI de la persona es: {uncliente.NumeroCedula}");
                Console.WriteLine($"El Saldo Incial es: {uncliente.SaldoTotal}");
                Console.WriteLine($"El Nro cuenta es: {uncliente.NroCuenta}");
                Console.WriteLine("---------------------\n");
            }
            break;
            
        default:
        break;
    }

    Console.WriteLine("Desea registrar otra persona?: Si = 1, No = 2");

   // int continuar = Convert.ToInt32(Console.ReadLine());
    //if(continuar == 2){
    //    fin = true;
   // }
} //Fin del while

//Console.WriteLine("Lista de clientes registrados:");
 //       foreach (var cliente in listaClientes)
   //     {
  //          Console.WriteLine($"Nombre: {cliente.Nombre}, CI: {cliente.NumeroCedula}, Saldo Total: {cliente.SaldoTotal}, Nro Cuenta: {cliente.NroCuenta}");
   //     }
//
struct Cliente {
    public string Nombre;
    public string NumeroCedula;
    public decimal SaldoTotal;
    public string NroCuenta;
}
