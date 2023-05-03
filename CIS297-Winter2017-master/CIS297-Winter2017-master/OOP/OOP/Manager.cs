using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	public class Manager : Employee
	{
		private List<Employee> employees;
		public Manager( string name, double salary ) : base(name, salary)
		{
			employees = new List<Employee>();
		}

		public void AddEmployeeToManage(Employee employee )
		{
			employees.Add( employee );
		}

		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine( base.ToString() );
			foreach ( Employee employee in employees )
			{
				stringBuilder.AppendLine( $"\tManages: {employee}" );
			}
			return stringBuilder.ToString();
		}
	}
}
