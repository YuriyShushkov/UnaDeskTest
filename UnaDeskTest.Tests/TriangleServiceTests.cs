using UnaDeskTest.Dto;
using UnaDeskTestBLL;

namespace UnaDeskTest.Tests
{
    public class TriangleServiceTests
    {
        [Theory]
        [InlineData(1.1, 1.2, 1.3, TriangleTypeEnum.Acute)]
        [InlineData(1.2, 1.1, 1.3, TriangleTypeEnum.Acute)]
        [InlineData(1.2, 1.3, 1.1, TriangleTypeEnum.Acute)]
        [InlineData(3, 4, 5, TriangleTypeEnum.Right)]
        [InlineData(4, 5, 3, TriangleTypeEnum.Right)]
        [InlineData(5, 3, 4, TriangleTypeEnum.Right)]
        [InlineData(3, 4, 15, TriangleTypeEnum.Obtuse)]
        [InlineData(4, 15, 3, TriangleTypeEnum.Obtuse)]
        [InlineData(15, 3, 4, TriangleTypeEnum.Obtuse)]
        public void ShoulBeAcuteTriangle(double line1, double line2, double line3, TriangleTypeEnum expected)
        {
            var service = new TriangleService();
            var type = service.GetType(new Dto.TriangleDto(line1, line2, line3));
            Assert.Equal(expected, type);
        }
    }
}