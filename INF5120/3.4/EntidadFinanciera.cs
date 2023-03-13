using System;

public class EntidadFinanciera {
    // Atributos
    private string nombre;
    private string telefono;
    private string direccion;
    private int contratos;
    private int comisiones;

    // Operaciones
    public void setNombre(string nombre) {
        this.nombre = nombre;
    }
    public string getNombre() {
        return nombre;
    }

    public void setDireccion(string direccion) {
        this.direccion = direccion;
    }
    public string getDireccion() {
        return direccion;
    }

    public void setTelefono(string telefono) {
        this.telefono = telefono;
    }
    public string getTelefono() {
        return telefono;
    }

    public void setContratos(int contratos) {
        this.contratos = contratos;
    }
    public int getContratos() {
        return contratos;
    }

    public void setComisiones(int comisiones) {
        this.comisiones = comisiones;
    }
    public int getComisiones() {
        return comisiones;
    }

    public void CapturarInformacion() {
        Console.WriteLine("Cual es el nombre de la entidad financiera?");
        setNombre(Console.ReadLine());

        Console.WriteLine("Cual es la direccion?");
        setDireccion(Console.ReadLine());

        Console.WriteLine("Cual es el numero telefonico?");
        setTelefono(Console.ReadLine());

        Console.WriteLine("Cuantos contratos tiene?");
        int numContratos = int.Parse(Console.ReadLine());
        setContratos(numContratos);

        Console.WriteLine("Que porcentaje ganan de comisiones?");
        int porcentajeComisiones = int.Parse(Console.ReadLine());
        setComisiones(porcentajeComisiones);
    }

    public void DosplayScreen() {
        Console.WriteLine("\n\n------------------------------------------------\n\n");
        Console.WriteLine("La entidad financiera " + getNombre() + " ubicado en:\n" + getDireccion() + "\ncon el numero telefonico: " + getTelefono() + " ha aprobado la suma de " + getContratos() + " contratos por la cual cobra una comision del " + getComisiones() + " %.");
    }
}

class PRUEBATESTER {
    static void Main() {
        EntidadFinanciera banco1 = new EntidadFinanciera();

        banco1.CapturarInformacion();

        banco1.DosplayScreen();
    }
}
