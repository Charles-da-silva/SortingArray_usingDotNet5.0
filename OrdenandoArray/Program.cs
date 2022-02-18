using System;
using OrdenandoArray.Models;

namespace OrdenandoArray
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacoesArray op = new OperacoesArray();
            int[] array = new int[5] {6,3,8,1,9};

            System.Console.WriteLine("Array original");
            op.ImprimirArray(array);

            op.OrdenarBubbleSort(ref array);

            System.Console.WriteLine("Array ordenado");
            op.ImprimirArray(array);


        }
    }
}
