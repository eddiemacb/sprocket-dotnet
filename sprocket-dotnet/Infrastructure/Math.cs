using System;

public class Math
{
    private int number_one;
    private int number_two;

    public Math(int number_one, int number_two)
    {
        this.number_one = number_one;
        this.number_two = number_two;
    }

    public int Sum()
    {
        return this.number_one + this.number_two;
    }

    public int Product()
    {
        return this.number_one / this.number_two;
    }
}