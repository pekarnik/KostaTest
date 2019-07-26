using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosta
{
	public class Department
	{
		public string ID { get; private set; }
		public string ParentDepartmentID { get; private set; }
		public string Code { get; private set; }
		public string Name { get; private set; }
		public Department(string id, string name, string parentDepartmentID=null, string code=null)
		{
			ID = id;
			ParentDepartmentID = parentDepartmentID;
			Code = code;
			Name = name;
		}
	}
	
}
