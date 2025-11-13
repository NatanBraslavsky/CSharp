List<int> lista = new List<int> { 1, 5, 3, 2, 6, 8 };

//List<int> listaPares = lista.FindAll(Par);

//Assim

//bool Par(int numero)
//{
//    return numero % 2 == 0;
//}

//foreach(int numeros in listaPares)
//{
//    Console.WriteLine(numeros);
//}


//Ou assim

List<int> listaPar = lista.FindAll(numero => numero % 2 == 0);
foreach(int numero in listaPar)
{
    Console.WriteLine(numero);
}