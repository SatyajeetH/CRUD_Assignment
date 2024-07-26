using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Employee_DB.Data
{
    [Serializable]
    [XmlRoot("Employee")]
    public class Employee
    {

            [XmlElement("Emp_ID")]
            public int Id { get; set; }

            [XmlElement("Emp_Name")]
            public string Name { get; set; }

            [XmlElement("Emp_Age")]
            public int Age { get; set; }

            [XmlElement("Emp_Department")]
            public string Department { get; set; }

            [XmlElement("Emp_Salary")]
            public decimal Salary { get; set; }
    }
}
