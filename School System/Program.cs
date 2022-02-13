using School_System;
var studentRepo = new StudentRepo();
var admin = new Admin(studentRepo)
{
    Id = 1,
    Age = 24,
    Name = "ahmed samir",
    OfficeHours = 5,
    Salary = 25_0000
};
var adminRoom = new AdminRoom() { OurAdmin = admin };
admin.getStudent();
admin.updateStudent(new Student()
            {
                Name = "ali"
                , Age = 13
                ,GPA = 2, 
                Id = 1
            });
admin.removeStudentById(2);
admin.getStudent();