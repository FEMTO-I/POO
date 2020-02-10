class Persona{
    private string Nombre;
    public int Edad;
    public string Correo;
    public string getNombre](){
        return Nombre;
    }
    public void setNombre(string n){
        Nombre=n;
    }
    public int getEdad(){
        return edad;
    }

}
Class Program{
    static void Main(string []args){
        Persona p=new Persona(),
        p.setNombre("Ana");
        Console.Writeline(p.getNombre());
        
        Persona p2=new Persona();
        p.SetNombre("Tom");
        Console.Writeline(p.getNombre());
    }
}