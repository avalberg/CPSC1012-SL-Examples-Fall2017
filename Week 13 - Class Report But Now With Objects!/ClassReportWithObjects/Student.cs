using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassReportWithObjects
{
    public class Student
    {
        private string _firstName, _lastName, _letterGrade;
        double _grade;

        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        public double Grade { get { return _grade; } set { _grade = value; } }
        public string LetterGrade { get { return _letterGrade; } }

        public Student()
        {

        }

        public Student(string firstname,string lastname,double grade)
        {
            _firstName = firstname;
            _lastName = lastname;
            _grade = grade;
            FindLetterGrade();
        }

        public void FindLetterGrade()
        {
            // TODO: finish if statements :(
            if (_grade >= 90)
                _letterGrade = "A+";
            else if (_grade <= 89 && _grade >= 83)
                _letterGrade = "A";
            else if (_grade <= 82 && _grade >= 80)
                _letterGrade = "A-";
            else if (_grade <= 79 && _grade >= 77)
                _letterGrade = "B+";
            else if (_grade <= 76 && _grade >= 73)
                _letterGrade = "B";
            else if (_grade <= 72 && _grade >= 70)
                _letterGrade = "B-";
            else if (_grade <= 89 && _grade >= 83)
                _letterGrade = "C+";
            else if (_grade <= 89 && _grade >= 83)
                _letterGrade = "C";
            else if (_grade <= 89 && _grade >= 83)
                _letterGrade = "C-";
            else if (_grade <= 89 && _grade >= 83)
                _letterGrade = "D+";
            else if (_grade <= 89 && _grade >= 83)
                _letterGrade = "D";
            else
                _letterGrade = "F";
        }
    }
}
