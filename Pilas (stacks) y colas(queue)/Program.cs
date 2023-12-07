namespace Pilas__stacks__y_colas_queue_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*En la pila el orden es de abajo hacia arriba, en este caso seria 5, 4, 3... 
             * El ultimo numero en ingresar es el primero en salir*/
            Stack<int> pilaNumeros = new Stack<int>();
            /*Con push se agregan numeros a la pila (stack)*/
            pilaNumeros.Push(1);
            pilaNumeros.Push(2);
            pilaNumeros.Push(3);
            pilaNumeros.Push(4);
            pilaNumeros.Push(5);

            foreach(int i in pilaNumeros)
            {
                Console.WriteLine(i);
            }

            int elementoCima = pilaNumeros.Peek();

            Console.WriteLine($"El elemento de la cima es: {elementoCima}");
        }
    }
}