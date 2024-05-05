namespace Soild.I
{
    public class Manager
    {

        public void AssginTask()
        {
            //Code to assign a task.
        }

        public void CreateTask()
        {
            //Code to create a task.  
        }

        public void WorkOnTask()
        {
            throw new Exception("Manager can't work on Task");
        }
    }
}
