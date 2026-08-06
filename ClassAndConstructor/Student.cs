using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAndConstructor;

internal class Student
{
    private  string _firstName;
    private  string _lastName;

    public Student()
    {
        _firstName = "Abdullah Al";
        _lastName = "Noman";
    }
    public Student(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
    }

    public string FirstName { get => _firstName; }
    public string LastName { get => _lastName; }

    public void GetFullName()
    {
        Console.WriteLine($"{_firstName} {_lastName}");
    }
}
