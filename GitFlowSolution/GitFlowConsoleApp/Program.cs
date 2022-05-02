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
                Console.WriteLine(taskItem.Name);
            }
        }
    }
}
