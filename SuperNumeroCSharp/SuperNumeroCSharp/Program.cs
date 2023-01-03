using System.Runtime.CompilerServices;




/*
 * El supernumero de x (donde x es un entero mayor o igual a cero) se define como:
 * -> x, si x es inferior a 10.
 * -> x más el supernumero de la suma de los dígitos de x, si x es igual o superior a 10.
 */
static int superNumero(int nn)
{
    if (nn < 10)
    {
        return nn;
    }
    else
    {
        //Console.WriteLine("ELSE PARA {0}", nn);
        int digitos = 0; //suma de los digitos
        string nnString = nn.ToString();
        int ress = nn; // resultado

        foreach (char item in nnString)
        {
            digitos += int.Parse(item.ToString());
            //Console.WriteLine("ITEM: {0}, DIGITOS: {1}", item, digitos);
        }

        ress += superNumero(digitos);
        //Console.WriteLine("RES: {0}, DIGITOS SUPER: {1}", ress, digitos);


        return ress;
    }
}



static void Main(string[] args)
{
    int superN = 317;
    Console.WriteLine("resultado:" + superNumero(superN));

}


int superN = 317;
Console.WriteLine(superNumero(superN));
