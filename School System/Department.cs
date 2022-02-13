
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Department {

    public Department() {
    }

    public string Name { get; set; }

    public int DepartMentNum { get; set; }

    public List<Instructor> Instructors { get; set; } = new List<Instructor>();

}