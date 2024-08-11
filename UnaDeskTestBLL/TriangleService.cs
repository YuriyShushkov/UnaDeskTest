using UnaDeskTest.Contracts;
using UnaDeskTest.Dto;

namespace UnaDeskTestBLL
{
    public class TriangleService : ITriangleService
    {
        public TriangleTypeEnum GetType(TriangleDto triangle)
        {
            var line1 = triangle.Line1 * triangle.Line1;
            var line2 = triangle.Line2 * triangle.Line2;
            var line3 = triangle.Line3 * triangle.Line3;

            if (line1 + line2 == line3 || line1 + line3 == line2 || line3 + line2 == line1)
            {
                return TriangleTypeEnum.Right;
            }

            if (line1 + line2 < line3 || line1 + line3 < line2 || line3 + line2 < line1)
            {
                return TriangleTypeEnum.Obtuse;
            }

            return TriangleTypeEnum.Acute;
        }

        
    }
}
