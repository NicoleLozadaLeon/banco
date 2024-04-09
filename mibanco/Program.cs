// See https://aka.ms/new-console-template for more information
bool fin = false;

while(fin == false){
    Cliente cliente = new Cliente();
    /*
    string Nombre;
    string NumeroCedula;
    decimal SaldoTotal;
    string NroCuenta;
    */

    Console.WriteLine("Ingrese el nombre del cliente");
    cliente.Nombre = Console.ReadLine();

    Console.WriteLine("Ingrese el CI del cliente");
    cliente.NumeroCedula = Console.ReadLine();

    cliente.SaldoTotal = 0;

    cliente.NroCuenta = 100 + cliente.NumeroCedula;
    Console.WriteLine($"El nombre de la persona es: {cliente.Nombre}");
    Console.WriteLine($"El CI de la persona es: {cliente.NumeroCedula}");
    Console.WriteLine($"El Saldo Incial es: {cliente.SaldoTotal}");
    Console.WriteLine($"El Nro cuenta es: {cliente.NroCuenta}");

    Console.WriteLine("Desea registrar otra persona?: Si = 1, No = 2");

    int continuar = Convert.ToInt32(Console.ReadLine());
    if(continuar == 2){
        fin = true;
    }

} //Fin del while

struct Cliente {
    public string Nombre;
    public string NumeroCedula;
    public decimal SaldoTotal;
    public string NroCuenta;
}
