using System;
using MyFirstBoilerPlate.Tasks;
using MyFirstBoilerPlate.Tasks.Dto;
using MyFirstBoilerPlate.Tests.InitialData;
using Shouldly;
using Xunit;

namespace MyFirstBoilerPlate.Tests.Tasks
{
    public class TaskAppService_Tests : MyFirstBoilerPlateTestBase
    {
        private readonly ITaskAppService _taskAppService;

        public TaskAppService_Tests()
        {
            _taskAppService = Resolve<ITaskAppService>();
        }

        [Fact]
        public async System.Threading.Tasks.Task Should_Get_All_Task()
        {
            var output = await _taskAppService.GetAll(new GetAllTasksInput());
            output.Items.Count.ShouldBe(2);
        }

        [Fact]
        public async System.Threading.Tasks.Task Should_Get_Filtered_Tasks()
        {
            var output = await _taskAppService.GetAll(new GetAllTasksInput { State = TaskState.Open });

            output.Items.ShouldAllBe(t => t.State == TaskState.Open);
        }

    }
}
