using System;


interface IPriceable
{
    void SetPrice(double price);
}

interface IDiscountable
{
    void ApplyDiscount(string discount);
}

interface IPromocodable
{
    void ApplyPromocode(string promocode);
}

interface IColorable
{
    void SetColor(byte color);
}

interface ISizable
{
    void SetSize(byte size);
}

class Book : IPriceable, IDiscountable
{
    public double Price { get; private set; }
    public string Discount { get; private set; }

    public void SetPrice(double price) => Price = price;
    public void ApplyDiscount(string discount) => Discount = discount;
}


class Outerwear : IPriceable, IDiscountable, IColorable, ISizable
{
    public double Price { get; private set; }
    public string Discount { get; private set; }
    public byte Color { get; private set; }
    public byte Size { get; private set; }

    public void SetPrice(double price) => Price = price;
    public void ApplyDiscount(string discount) => Discount = discount;
    public void SetColor(byte color) => Color = color;
    public void SetSize(byte size) => Size = size;
}
class Program
{
    static void Main(string[] args)
    {
       
        Console.ReadKey();
    }
}