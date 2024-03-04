using Employee;
using System;
using System.Net.Sockets;
using System.Text;

namespace client
{
    public class Program
    {
        static void Main(string[] args)
        {
            TcpClient tcpClient;
            try
            {
                tcpClient = new TcpClient("127.0.0.1", 2308);
            }
            catch (SocketException ex)
            {
                Console.WriteLine("Không thể kết nối đến server");
                Console.WriteLine("Lỗi: " + ex.Message);
                return;
            }

            NetworkStream stream = tcpClient.GetStream();
            Employee.Employee employee = new Employee.Employee(1, "Nguyen Phan Thanh", "Sang", 10, 15000000); // Khởi tạo thông tin ban đầu
            byte[] data = employee.GetBytes();
            int size = employee.Size;
            byte[] packageSize = BitConverter.GetBytes(size);

            while (true)
            {
                Console.WriteLine("Thong tin Employee :");
                Console.WriteLine("EmployeeID: " + employee.EmployeeID);
                Console.WriteLine("FullName: " + employee.LastName + " " + employee.FirstName);
                Console.WriteLine("YearService: " + employee.YearService);
                Console.WriteLine("Salary: " + employee.Salary);

                Console.Write("Ban co muon tiep tuc ko (co/khong)? ");
                string continueInput = Console.ReadLine();
                if (continueInput.ToLower() != "co")
                    break;

                Console.Write("Nhap EmployeeID: ");
                int employeeID = int.Parse(Console.ReadLine());

                Console.Write("Nhap LastName: ");
                string lastName = Console.ReadLine();

                Console.Write("Nhap FirstName: ");
                string firstName = Console.ReadLine();

                Console.Write("YearService: ");
                int yearService = int.Parse(Console.ReadLine());

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());

                employee = new Employee.Employee(employeeID, lastName, firstName, yearService, salary);
                data = employee.GetBytes();
                size = employee.Size;

                Console.WriteLine("Kich thuoc goi tin moi = {0}", size);

                stream.Write(packageSize, 0, 2);
                stream.Write(data, 0, size);
                stream.Flush();

                // Đọc phản hồi từ server
                byte[] buffer = new byte[1024];
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                string response = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                Console.WriteLine("Phan hoi tu server: " + response);
            }

            stream.Close();
            tcpClient.Close();
        }
    }
}
