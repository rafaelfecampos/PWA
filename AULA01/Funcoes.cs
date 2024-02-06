static class Funcoes
{
    public static int[] Filtrar(this int[] vetor, Func<int, bool> selecionar) //o "this" faz com que o método apareça para todo vetor de inteiros na função principal --- Extension Methods
    {
        var resultado = new List<int>();
        foreach (var num in vetor)
        {
            if (selecionar(num))
                resultado.Add(num);
        }
        return resultado.ToArray();
    }
}