using School_System;
var studentRepo = new StudentRepo();
Var insRepo = new InstructorRepo(); 
Var subjectRepo = nee SubjectRepo ();
Var depRepo = new DepartmentRepo ();
var admin = new Admin(studentRepo,ins,
 subjectRepo,depRepo)
{
    Id = 1,
    Age = 24,
    Name = "ahmed samir",
    OfficeHours = 5,
    Salary = 25_0000
};
var adminRoom = new AdminRoom() { OurAdmin = admin };
void StartSystem() {
    Console.WriteLine("Hello our remarkable admin ");
    do
    {
        Console.WriteLine("1- work with Studnet data ");
        Console.WriteLine("2- work with Department data ");
        Console.WriteLine("3- work with Studnet data ");
        Console.WriteLine("4- work with Studnet data ");

    }

}
