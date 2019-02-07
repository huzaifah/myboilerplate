using System;
using MyFirstBoilerPlate.EntityFrameworkCore;
using MyFirstBoilerPlate.Tasks;

namespace MyFirstBoilerPlate.Tests.InitialData
{
    public class TestDataBuilder
    {
        private readonly MyFirstBoilerPlateDbContext _context;

        public TestDataBuilder(MyFirstBoilerPlateDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            _context.Tasks.AddRange(
                new Task("Follow the white rabbit", "Follow the white rabbit in order to know the reality."),
                new Task("Clean your room") { State = TaskState.Completed }
                );
        }
    }
}
