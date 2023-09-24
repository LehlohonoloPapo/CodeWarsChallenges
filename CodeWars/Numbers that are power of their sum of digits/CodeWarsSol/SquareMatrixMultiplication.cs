namespace CodeWarsSol;
public class SquareMatrixMultiplication
{
    
    public static int[,] MatrixMultiplication(int[,] a, int[,] b)
    {
        var sum = 0;
        int product=0;
        
        var dynamicArray = CreateTwoDimensionalArray(a.GetLength(0),a.GetLength(1));
        for (var i = 0; i < a.GetLength(0); i++)
        {
            var gee = 0;
            for (var j = 0; j < a.GetLength(1); j++)
            {
                var fi = a[i, i];
                var sec = b[i, j];
                product = a[i, i] * b[i, j];
                sum += product;
                Console.WriteLine(sum);
                 gee= j;
            } 
            
            dynamicArray[i,i] = sum;
      
            sum = 0;
            

           
            
           
            
        }
        return dynamicArray;
    }
    static int[,] CreateTwoDimensionalArray(int rows, int cols)
    {
        int[,] dynamicArray = new int[rows, cols];
        int value = 1;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                dynamicArray[i, j] = value++;
            }
        }
        return dynamicArray;
    }
}