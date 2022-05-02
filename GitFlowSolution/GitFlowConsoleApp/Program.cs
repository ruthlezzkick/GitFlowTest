using Domain.DAO.Task;

namespace GitFlowConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            var taskItemList = TaskListFakeFactory.GetTaskItems();
            foreach (var taskItem in taskItemList)
            {
                Console.WriteLine($"TASK ID: {taskItem.Id} TASK NAME: {taskItem.Name} DESCRIPTION: {taskItem.Description}");
            }
        }
    }
}
