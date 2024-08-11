using UnaDeskTest.Dto;

namespace UnaDeskTest.Contracts
{
    public interface ITriangleService
    {
        public TriangleTypeEnum GetType(TriangleDto triangle);
    }
}
