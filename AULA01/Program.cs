var numeros = new int[] { 1, 2, 3, 4, 5 };


//em arrowfunction, A FUNÇÃO É DECLARADA COMO UMA VARIÁVEL!!!!!!!!!!!!
Func<int, bool> SelecionarPar = x => { //arrowfunction, x é nome de um parametro qualquer
    return x % 2 == 0;
};
/* 
é o mesmo que o código abaixo
static bool SelecionarPar(int num)
{
    return num %2 == 0;
}*/


Func<int, bool> SelecionarImpar = x => x % 2 != 0; //tbm é arrowfunction
/* static bool SelecionarImpar(int num)
{
    return num %2 != 0;
}*/



var pares = numeros.Filtrar(SelecionarPar);
var impares = Funcoes.Filtrar(numeros, SelecionarImpar);
var maioresQue2 = Funcoes.Filtrar(numeros, x => x > 2); //outra tipo de representar arrowfunction !!!!!!!!!!!!!!!

Imprimir("Pares: ", pares);
Imprimir("Impares: ", impares);
Imprimir("Maiores que 2:  ", maioresQue2);

static void Imprimir(string mensagem, int[] vetor){
    Console.Write(mensagem);
    foreach (var item in vetor)
    {
        Console.Write($"{item}  ");
    }
    Console.WriteLine(";");
}

