namespace Dependency_Injection_Pratik.Data
{
    public class ClassRoom 
    {
        private readonly ITeacher _teacher;
        public ClassRoom(ITeacher teacher)
        {
            _teacher = teacher;
        }

        public void TeacherGetInfo()
        {
            _teacher.GetInfo();
        }
    }
}
