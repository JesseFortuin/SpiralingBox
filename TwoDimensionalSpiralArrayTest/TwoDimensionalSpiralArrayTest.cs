using SpiralingBox.BL;
using Xunit;

namespace TwoDimensionalSpiralArrayTest
{
    public class TwoDimensionalSpiralArrayTest
    {
        [Fact]
        public void BoxCreatorTest()
        {
            //arrange
            TwoDimensionalSpiralArray box = new TwoDimensionalSpiralArray();

            var width = 5;

            var height = 8;

            var spiralBox = new int[,] 
            {
                { 1, 1, 1, 1, 1 },
                { 1, 2, 2, 2, 1 },
                { 1, 2, 3, 2, 1 },
                { 1, 2, 3, 2, 1 },
                { 1, 2, 3, 2, 1 },
                { 1, 2, 3, 2, 1 },
                { 1, 2, 2, 2, 1 },
                { 1, 1, 1, 1, 1 }
            };

            //act
            int[,] actual = box.BoxCreator(width, height);

            //assert

            Assert.Equal(spiralBox, actual);
        }
    }
}