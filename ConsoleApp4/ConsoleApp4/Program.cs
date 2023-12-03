using System;
using System.Collections.Generic;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


class ЖивийОрганізм
{
    public double Енергія { get; set; }
    public int Вік { get; set; }
    public double Розмір { get; set; }
}

interface IReproducible
{
    void Розмножитися();
}

interface IPredator
{
    void Полювати();
}

class Тварина : ЖивийОрганізм, IReproducible, IPredator
{
    public string Тип { get; set; }

    public void Розмножитися()
    {
        Console.WriteLine($"Тварина розмножується.");
    }

    public void Полювати()
    {
        Console.WriteLine($"Тварина полює.");
    }
}

class Рослина : ЖивийОрганізм, IReproducible
{
    public string Тип { get; set; }

    public void Розмножитися()
    {
        Console.WriteLine($"Рослина розмножується.");
    }
}

class Мікроорганізм : ЖивийОрганізм, IReproducible
{
    public string Тип { get; set; }

    public void Розмножитися()
    {
        Console.WriteLine($"Мікроорганізм розмножується.");
    }
}

class Екосистема
{
    public List<ЖивийОрганізм> Організми { get; set; }

    public void Харчування()
    {
        // Логіка харчування між організмами
    }

    public void Розмноження()
    {
        // Логіка розмноження організмів
    }

    public void Конкуренція()
    {
        // Логіка конкуренції за ресурси
    }
}