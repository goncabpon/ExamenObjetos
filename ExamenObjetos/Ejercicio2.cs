using System;



public enum Color {Rojo, Verde, Azul }
public class Shape
{
    Color Color { get; set; }
    public virtual void Draw()
    {

    }

}

public class Rectangulo : Shape
{
    public Rectangulo (Color color)
    {
        Color = color;
    }
    public override void Draw()
    {
        
    }

}

public class Circulo : Shape
{
    public Circulo (Color color)
    {
        Color = color;
    }
    public override void Draw()
    {

    }
}

public class Flecha : Shape
{
    public Triangulo (Color color)
    {
        Color = color;
    }
    public override void Draw() 
    {

    }
}



