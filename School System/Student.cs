
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Student : Person {

    public Student() {
    }

    public double GPA { get; set; }

    public override string? ToString()
    {
        return base.ToString();
    }
}