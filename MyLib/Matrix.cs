namespace MyLib
{
    public class Matrix
    {
        public static int SumMaxMin(int[,] mas)
        {
            int max = mas[0, 0];
            int iMax, jMax;
            iMax = jMax = 0;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if( mas[i, j] > max ) 
                    { 
                        max = mas[i, j];
                        iMax = i;
                        jMax = j;
                    }
                }
            }
            return iMax+jMax;
        }
        public static double[] vectorSum(double[,] mas)
        {
            double[] temp = new double[8];
            for (int i = 0;i < mas.GetLength(0);i++)
            {
                double s = 0;
                for(int j = 0;j < mas.GetLength(1);j++)
                {
                    s += mas[i, j];
                }
                temp[i]= s;
            }
            return temp;
        }
        public static double diffMas(double[] mas)
        {
            double max= mas[0];
            double min= mas[0];
            int indexMin = 0;
            for (int i = 1; i < mas.Length; i++)
            {
                if (mas[i] > max) max = mas[i];
                if (mas[i] < min)
                {
                    min = mas[i];
                    indexMin = i;
                }
            }
            return max-indexMin;
        }
    }
}
