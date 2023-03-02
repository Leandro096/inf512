using System;

public class Mouse{
    public string marca;
    public string modelo;
    public string tipo;
    private string color; //Colores permitidos: Rojo, Verde, Azul.
    public bool ergonomico;
    private float precio;

    public string getMarca() {
        return this.marca.ToLower();
    }

    public void setMarca(string marca){
        marca = marca.ToUpper();
        if (marca.Equals("DELL") || marca.Equals("GENIUS") || marca.Equals("LOGITEC")){
            this.marca = marca;
        } else {
            this.marca = "Generic Device";
        }
    }
    public bool seleccionar(string bloqueTexto){
        return true;
    }

    public bool clickDerecho(){
        Console.WriteLine("El usuario ha hecho un click derecho");
        return true;
    }

    public bool clickIzquierdo(){
        Console.WriteLine("El usuario ha hecho un click izquierdo");
        return true;
    }

    public bool getErgonomico() {
        return ergonomico;
    }

    public void setErgonomico(string tipo) {
        this.tipo = tipo;
        if (tipo.ToUpper().Equals("ERGONOMICO")) {
            ergonomico = true;
        } else {
            ergonomico = false;
        }
    }

    public string arrastrar(string bloqueTexto){
        return "";
    }

    public void setPrecio(float precio){
        if (precio >= 0.0 && precio <=50.0){
            this.precio = precio;
        } else {
            this.precio = 0.0f;
            Console.WriteLine("Error 1. Precio Invalido.");
        }
    }

    public float getPrecio(){
        return this.precio;
    }

    public string getColor(){
        return this.color.ToLower();
    }

    public void setColor(string color){
        color = color.ToUpper();
        if (color.Equals("ROJO") || color.Equals("VERDE") || color.Equals("AZUL")){
            this.color = color;
        } else {
            Console.WriteLine("Error 2. Color Invalido.");
            Console.WriteLine("Colores permitidos: ROJO, VERDE, AZUL.");
            Console.WriteLine("Debe corregir color: " + color);
            this.color = null;
        }
    }

    public void desplegarInformacion(){
        Console.WriteLine("Marca: " + getMarca());
        Console.WriteLine("Modelo: " + this.modelo);
        Console.WriteLine("Tipo: " + this.tipo);
        Console.WriteLine("Color: " + getColor());
        clickDerecho();
    }
}

public class MouseTest{
    static void Main(){
        Mouse raton1 = new Mouse(); 

        raton1.setMarca("Dell");
        raton1.modelo = "WM126";
        raton1.setPrecio(18.99f);
        raton1.setErgonomico("Ergonomico");
        raton1.setColor("rojo");

        raton1.desplegarInformacion();
    }
}