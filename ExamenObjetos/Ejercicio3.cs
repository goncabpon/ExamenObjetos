﻿using System;


public class Ejercicio3
{
	public Class1()
	{
        var shapes = new List<IShape>()
            {
                new Rectangulo(Color.Rojo),
                new Circulo(Color.Azul),
                new Rectangulo(Color.Verde),
                new Flecha(Color.Azul)
            };
        foreach (var shape in shapes)
        {
            shape.Draw(Console.WriteLine);
        }
        Console.ReadLine();

    }
}

public interface IShape
{
    Color Color { get; set; }
    void Draw(Action<String> action);
}

public enum Color { Rojo, Verde, Azul }
public class Shape : IShape
{
    Color Color { get; set; }
    public virtual void Draw()
    {

    }

}

public class Rectangulo : Shape
{
    public Rectangulo(Color color)
    {
        Color = color;
    }
    public override void Draw()
    {

    }

}

public class Circulo : Shape
{
    public Circulo(Color color)
    {
        Color = color;
    }
    public override void Draw()
    {

    }
}

public class Flecha : Shape
{
    public Triangulo(Color color)
    {
        Color = color;
    }
    public override void Draw()
    {

    }
}

