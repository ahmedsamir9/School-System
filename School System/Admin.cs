
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using School_System;
public class Admin : Staff
{
    
    public Admin(StudentRepo _studentRepo)
    {
        this.StudentRepo = _studentRepo;
    }
    private StudentRepo StudentRepo;
    private InstructorRepo InstructorRepo;

    public void addStudent(Student s)
    {
        if (StudentRepo.Add(s)) {
            Console.WriteLine("added Succuessfully");        
        }
        else
        {
            Console.WriteLine("Error");
        }
    }


    public void removeStudentById(int id)
    {
        if (StudentRepo.Delete(id))
        {
            Console.WriteLine("deleted Succuessfully");
        }
        else
        {
            Console.WriteLine("Error");
        }
    }

    public void updateStudent(Student s)
    {
        if (StudentRepo.Upadate(s))
        {
            Console.WriteLine("Update Succuessfully");
        }
        else
        {
            Console.WriteLine("Error");
        }
    }
    public void getStudent()
    {
        foreach (var studnet in StudentRepo.Get()) {

            Console.WriteLine(studnet);
        }
    }

    /// <summary>
    /// @param int id 
    /// @return
    /// </summary>
    public Student searchStudent(int id)
    {
        return StudentRepo.Find(X=> X.Id == id); 
    }

    public void addInstructor(Instructor i)
    {
        if (InstructorRepo.Add(i))
        {
            Console.WriteLine("added Succuessfully");
        }
        else
        {
            Console.WriteLine("Error");
        }
    }


    public void removeInstructorById(int id)
    {
        if (InstructorRepo.Delete(id))
        {
            Console.WriteLine("deleted Succuessfully");
        }
        else
        {
            Console.WriteLine("Error");
        }
    }

    public void updateInstructor(Instructor i)
    {
        if (InstructorRepo.Upadate(i))
        {
            Console.WriteLine("Update Succuessfully");
        }
        else
        {
            Console.WriteLine("Error");
        }
    }
    public void getInstructor()
    {
        foreach (var instructor in InstructorRepo.Get())
        {

            Console.WriteLine(instructor);
        }
    }

   
    public Instructor searchInstructor(int id)
    {
        return InstructorRepo.Find(X => X.Id == id);
    }
    /// <summary>
    /// @param Department 
    /// @return
    /// </summary>
    public void addDepartment(Department dep)
    {
        // TODO implement here
    }

    /// <summary>
    /// @param Department 
    /// @return
    /// </summary>
    public void removeDepartment(Department d)
    {
        // TODO implement here
    }

    /// <summary>
    /// @return
    /// </summary>
    public void updateDepartment()
    {
        // TODO implement here
    }

    /// <summary>
    /// @param int 
    /// @return
    /// </summary>
    public Department searchDepartment(int i)
    {
        // TODO implement here
        return null;
    }

   

}