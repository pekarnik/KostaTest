using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosta
{
	public class Employee:IEquatable<Employee>
	{
		public int ID { get; private set; }
		public string DepartmentID { get; private set; }
		public string Surname { get; private set; }
		public string FirstName { get; private set; }
		public string Patronymic { get; private set; }
		public DateTime DateOfBirth { get; private set; }
		public string DocSeries { get; private set; }
		public string DocNumber { get; private set; }
		public string Position { get; private set; }
		public int Age { get; private set; }
		public Employee(int id,string depID, string surname,string firstname,DateTime dateOfBirth,
			string position, int age, string patronymic=null,string docseries=null,string docnumber=null)
		{
			ID = id;
			DepartmentID = depID;
			Surname = surname;
			FirstName = firstname;
			Patronymic = patronymic;
			DateOfBirth = dateOfBirth;
			DocSeries = docseries;
			DocNumber = docnumber;
			Position = position;
			Age = age;
		}

		public bool Equals(Employee other)
		{
			return (this.ID.Equals(other.ID));
		}
	}
}
