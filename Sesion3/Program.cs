/*
 Ejercicio 1 - Sesion 3
 Crea una estructura de datos para un cliente con estos campos:
    
    - Nombre completo
    - Teléfono
    - Dirección
    - Email
    - Si es nuevo cliente

Bonus: escribe un método para presentar estos datos desde la estructura al hacer Console.WriteLine(...)
*/

Cliente nuevoCliente = new Cliente("Alejandro Villaflor", "55550000", "Ciudad de Guatemala", "ale2020@email.com", true);

nuevoCliente.imprimir();

struct Cliente
{
    public string nombre;
    public string telefono;
    public string direccion;
    public string email;
    public bool nuevoCliente;

    public Cliente(string nombre, string telefono, string direccion, string email, bool nuevoCliente)
    {
        this.nombre = nombre;
        this.telefono = telefono;
        this.direccion = direccion;
        this.email = email;
        this.nuevoCliente = nuevoCliente;
    }
    public void imprimir()
    {
        Console.WriteLine("Nombre:\t\t" + this.nombre);
        Console.WriteLine("Telefono:\t" + this.telefono);
        Console.WriteLine("Direccion:\t" + this.direccion);
        Console.WriteLine("Email:\t\t" + this.email);
        Console.WriteLine("Nuevo cliente:\t" + (this.nuevoCliente ? "Si" : "No"));
    }
}


