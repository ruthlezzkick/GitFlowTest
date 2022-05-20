using Domain.DTO;

namespace Domain.DAO.Task
{
    public static class TaskListFakeFactory
    {
        public static IList<TaskItem> GetTaskItems()
        {
            return new List<TaskItem>
            {
                new TaskItem 
                {
                    Id = 1,
                    Name = "Task1",
                    Created = new DateTime(2020,4,20),
                    Updated = new DateTime(2020,4,20),
                    Status = 1,
                    Description = "Pierwszy task",
                    Group = 1
                },
                new TaskItem
                {
                    Id = 2,
                    Name = "Task2",
                    Created = new DateTime(2020,4,21),
                    Updated = new DateTime(2020,4,23),
                    Status = 2,
                    Description = "Drugi task",
                    Group = 1
                },
                new TaskItem
                {
                    Id = 3,
                    Name = "Task3",
                    Created = new DateTime(2020,4,22),
                    Updated = new DateTime(2020,4,22),
                    Status = 1,
                    Description = "Trzeci task",
                    Group = 2
                },
				new TaskItem
                {
                    Id = 4,
                    Name = "Task4",
                    Created = new DateTime(2020,5,20),
<<<<<<< HEAD
                    Updated = new DateTime(2020,5,26),
=======
                    Updated = new DateTime(2020,5,24),
>>>>>>> a380c85395a0063154fcc81a1ef557cb64e5d6e7
                    Status = 2,
                    Description = "Czwarty task",
                    Group = 2
                },
            };
        }
    }
}
