namespace csharpractice.Matrixes;

public class main
{
    static void Main(string[] args)
    {
        string[,] products = productsToFill();

        for (int i = 0; i < products.GetLength(0); i++)
        {
            for (int j = 0; j < products.GetLength(1); j++)
            {
                if (j==1)
                {
                    Console.WriteLine(products[i, j]);
                }
                else
                {
                Console.Write(products[i, j]+ " ");
                }
            }
            Console.WriteLine(" ");
        }


    }

    public static string[,] productsToFill()
    {
        string[,] products = new string[10, 3];

        products[0, 0] = "001";
        products[0, 1] = "Manzana";
        products[0, 2] = "1.00";

        products[1, 0] = "002";
        products[1, 1] = "Banana";
        products[1, 2] = "0.50";

        products[2, 0] = "003";
        products[2, 1] = "Naranja";
        products[2, 2] = "0.75";

        products[3, 0] = "004";
        products[3, 1] = "Pera";
        products[3, 2] = "1.25";

        products[4, 0] = "005";
        products[4, 1] = "Melocotón";
        products[4, 2] = "1.50";

        products[5, 0] = "006";
        products[5, 1] = "Uva";
        products[5, 2] = "2.00";

        products[6, 0] = "007";
        products[6, 1] = "Kiwi";
        products[6, 2] = "1.75";

        products[7, 0] = "008";
        products[7, 1] = "Piña";
        products[7, 2] = "3.00";

        products[8, 0] = "009";
        products[8, 1] = "Mango";
        products[8, 2] = "2.50";

        products[9, 0] = "010";
        products[9, 1] = "Fresa";
        products[9, 2] = "2.25";
        return products;
    }
}