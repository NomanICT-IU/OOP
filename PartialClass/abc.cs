using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClass;

partial class Student
{
    private  string _firstName;
    private  string _lastName;

    public Student(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
    }

    public string LastName { get => _lastName; }
    public string LastName1 { get => _lastName; }
}

partial class Student
{
    public void GetFullName()
    {
        Console.WriteLine($"{_firstName} {_lastName}");
    }
}
