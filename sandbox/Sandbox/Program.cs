using System;

class Program
{
    public double Function(List<double> values)
    {

        double smallest = values[0];
        
        foreach(double num in values)
        {
            if (num < smallest)
            {
                smallest = num;
            }
        }
        return smallest;
    }
   
    static void Main(string[] args)
    {
        
    }
}