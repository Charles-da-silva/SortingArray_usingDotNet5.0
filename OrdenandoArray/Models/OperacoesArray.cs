namespace OrdenandoArray.Models
{
    public class OperacoesArray
    {
        public void OrdenarBubbleSort(ref int[] array)
        {

            //////////  Início do algoritmo Bubble sort

            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j +1])
                    {
                        temp = array[j+1];
                        array[j+1] = array[j];
                        array[j] = temp;
                    }
                }
            }

            //////////  final do algoritmo
        }

        public void ImprimirArray(int[] array)
        {
            var linha = string.Join(" -> ", array);
            System.Console.WriteLine(linha);
        }
    }
}