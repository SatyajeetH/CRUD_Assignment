using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Employee_DB.Data;
using System.Xml.Serialization;

namespace Employee_DB
{
    public partial class Employee_Details : Form
    {
        public BindingList<Employee> _employees = new BindingList<Employee>();

        // ---------------- Custom Methods ---------------------------------------
        public void Initializer() {
            if (XmlReadFile() != null)
            {
                _employees = XmlReadFile();
            }
            else {
                MessageBox.Show("File read unsucessful");
            }
        }

        public BindingList<Employee> XmlReadFile() {
            try
            {
                var XmlSerializer = new XmlSerializer(typeof(BindingList<Employee>));
                BindingList<Employee> obj;

                using (var reader = new StreamReader(@"D:\Visual Studio Projects\Employee_DB\Data\Emp_DB.xml"))
                {
                    obj = (BindingList<Employee>)XmlSerializer.Deserialize(reader);
                }
                return obj;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Xml File is Empty.");
                return null;
            }
        }

        public void XmlWriteFile(BindingList<Employee> emp) {
            try
            {
                var XmlSerializer = new XmlSerializer(typeof(BindingList<Employee>));
                using (var writer = new StreamWriter(@"D:\Visual Studio Projects\Employee_DB\Data\Emp_DB.xml"))
                {
                    XmlSerializer.Serialize(writer, emp);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        public void AddEmployee(Employee employee)
        {
            Initializer();
            try
            {
                foreach (var emp in _employees)
                {
                    if (emp.Id == employee.Id)
                    {
                        throw new InvalidOperationException("ID Already exists.");
                    }
                }
                _employees.Add(employee);
                XmlWriteFile(_employees);
                MessageBox.Show("Record Entered successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        public Employee GetEmployee(int id)
        {
            Initializer();
            return _employees.FirstOrDefault(e => e.Id == id);
        }

        public void UpdateEmployee(Employee updatedEmployee)
        {
            try
            {
                    Employee employee = _employees.FirstOrDefault(e => e.Id == updatedEmployee.Id);
                if (employee != null) {
                    employee.Name = updatedEmployee.Name;
                    employee.Age = updatedEmployee.Age;
                    employee.Department = updatedEmployee.Department;
                    employee.Salary = updatedEmployee.Salary;
                }
                else
                {
                    throw new InvalidOperationException("ID does not Exists.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                XmlWriteFile(_employees);
                MessageBox.Show("Record updated successfully");
            }
        }

        public void DeleteEmployee(int id)
        {
            Employee employee = GetEmployee(id);
            try
            {
                if (employee!=null)
                {
                    int index = _employees.Select((emp, idx) => new { emp, idx })
                            .FirstOrDefault(x => x.emp.Id == employee.Id)?.idx ?? -1;

                    // Check if the employee was found
                    if (index != -1)
                    {
                        _employees.RemoveAt(index);
                        MessageBox.Show("Record deleted successfully");
                    }
                }
                else
                {
                    throw new InvalidOperationException("ID does not Exists.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return;
            }
            finally
            {
                XmlWriteFile(_employees);
            }
        }

        public void Clear() { 
            txt_Id.Text = string.Empty;
            txt_Name.Text = string.Empty;
            txt_Age.Value = default;
            txt_Department.Text = string.Empty;
            txt_Salary.Text = string.Empty;
        }

        // ---------------------------- Custom Methods End -----------------------------
        public Employee_Details()
        {
            InitializeComponent();

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Employee updEmployee = new Employee();
            try
            {
                updEmployee.Id = int.Parse(txt_Id.Text.ToString());
                updEmployee.Age = int.Parse(txt_Age.Text.ToString());
                updEmployee.Salary = decimal.Parse(txt_Salary.Text.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Clear();
                return;
            }

            updEmployee.Name = txt_Name.Text.ToString();
            updEmployee.Department = txt_Department.Text.ToString();

            if (!string.IsNullOrEmpty(updEmployee.Name) && !string.IsNullOrEmpty(updEmployee.Department))
            {
                UpdateEmployee(updEmployee);
                Clear();
            }
            else
            {
                MessageBox.Show("Enter all the details.");
                Clear();
            }
            data_Grid.DataSource = _employees;
        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            int _id = int.Parse(txt_Id.Text.ToString());
            Employee employee = GetEmployee(_id);
            if (employee != null)
            {
                txt_Id.Text = employee.Id.ToString();
                txt_Name.Text = employee.Name;
                txt_Age.Value = decimal.Parse(employee.Age.ToString());
                txt_Department.Text = employee.Department;
                txt_Salary.Text = employee.Salary.ToString();
            }
            else {
                MessageBox.Show("Id not found.");
                Clear() ;
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int _id = int.Parse(txt_Id.Text.ToString());
            DeleteEmployee(_id);
            Clear();
            data_Grid.DataSource = _employees;
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            try {
                employee.Id = int.Parse(txt_Id.Text.ToString());
                employee.Age = int.Parse(txt_Age.Text.ToString());
                employee.Salary = decimal.Parse(txt_Salary.Text.ToString());
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
                Clear();
                return;
            }

            employee.Name = txt_Name.Text.ToString();
            employee.Department = txt_Department.Text.ToString();

            if (!string.IsNullOrEmpty(employee.Name) && !string.IsNullOrEmpty(employee.Department))
            {
                AddEmployee(employee);
                Clear();
                data_Grid.DataSource= _employees;
            }
            else {
                MessageBox.Show("Enter all the details.");
                Clear();
            }
        }

        private void Employee_Details_Load(object sender, EventArgs e)
        {
            Initializer();
            data_Grid.DataSource = _employees;
        }

        private void btn_ViewAll_Click(object sender, EventArgs e)
        {
            Initializer();
            data_Grid.DataSource = _employees; 
        }

        private void data_Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedEmp = data_Grid.SelectedRows[0].DataBoundItem as Employee;

            if (selectedEmp != null) {
                txt_Id.Text = selectedEmp.Id.ToString();
                txt_Name.Text = selectedEmp.Name;
                txt_Age.Value = selectedEmp.Age;
                txt_Department.Text = selectedEmp.Department;
                txt_Salary.Text = selectedEmp.Salary.ToString();
            }
        }
    }
}
