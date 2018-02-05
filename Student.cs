using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Student : Person
    {
        private string program;
        private int year;
        private double fee;

        public string Program {get; set;}
        public int Year { get; set; }
        public double Fee { get; set; }

        public Student(string name, string address, string program, int year, double fee):base(name, address)
        {
            Program = program;
            Year = year;
            Fee = fee;
        }

        public Student()
        {
            Name = "not provided";
            Address = "not provided";
            Program = "not provided";
            Year = 0;
            Fee = 0;
        }

        public override string ToString()
        {
            return $"Student! Name: {Name} Address: {Address} Program: {Program} Year: {Year} Fee: {Fee}";
        }
    }
}
