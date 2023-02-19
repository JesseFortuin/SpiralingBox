using System.Diagnostics.Metrics;

namespace SpiralingBox.BL
{
    public class TwoDimensionalSpiralArray
    {
        public int[,] BoxCreator(int width, int length)
        {
            var box = new int[length, width];

            int row = 0;

            int col = 0;

            int lastCol = length - 1;

            int lastRow = width - 1;

            int value = 1;

            while (row <= lastRow && col <= lastCol)
            {
                for(int i = col; i <= lastCol; i++)
                {
                    box[i, col] = value;
                }//wai

                for(int j = row; j <= lastRow; j++)
                {
                    box[lastCol, j] = value;
                }//wai

                for (int k = lastCol; k >= col; k--)
                {
                    box[k, lastRow] = value;
                }//wai

                
                for (int l = lastRow; l > row; l--)
                {
                    box[col, l] = value;
                }
                
                value++;

                row++;

                col++;

                lastCol--;

                lastRow--;
            }
            return box;
        }
    }
}