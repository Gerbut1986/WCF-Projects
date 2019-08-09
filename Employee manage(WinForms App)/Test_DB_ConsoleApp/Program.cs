using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Test_DB_ConsoleApp.ServiceReference1;
using System.Text;
using System.Threading.Tasks;

namespace Test_DB_ConsoleApp
{
    class Program
    {
        // ServiceReference1 wcf = new ServiceReference1();
        static readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='I:\Users\And\Documents\desktop\WCF-Projects\Employee manage(WinForms App)\App_Client\DATA\WCF_DB.mdf';Integrated Security=True";

        static void Main(string[] args)
        {
            int choice = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Show All Entities From Database");
                Console.WriteLine("2 - Add 1 Employer to Database");
                Console.WriteLine("3 - Edit / Update");
                Console.WriteLine("4 - Delete");
                Console.WriteLine("0 - Exit");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        try
                        {
                            ForShowing();
                        }
                        catch (Exception ex)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(ex.Message);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\n\n\t\tPress any key to continue..");
                            Console.ResetColor();
                            Console.ReadKey(true);
                        }
                        break;
                    case 2:
                        Console.Clear();
                        try
                        {
                            Employer e = new Employer();
                            Console.WriteLine("Input F.I.O. of the Employer: ");
                            string FIO = Console.ReadLine();
                            Console.WriteLine("Input Address of the Employer: ");
                            string Address = Console.ReadLine();
                            Console.WriteLine("Input Phone number of the Employer: ");
                            int phone = int.Parse(Console.ReadLine());
                            Console.WriteLine("Input Email of the Employer: ");
                            string Email = Console.ReadLine();
                            Console.WriteLine("Input Date of a Birth of the Employer: ");
                            string Datebirthday = Console.ReadLine();
                            Console.WriteLine("Input Salary of the Employer: ");
                            string Salary = Console.ReadLine();
                            e.FIO = FIO;
                            e.Addresss = Address;
                            e.Phone = phone;
                            e.Email = Email;
                            e.Datebirth = Datebirthday;
                            e.Salary = Salary;
                            string msg = Insert(e);
                            if (msg.Equals(FIO + " Inserted Successfully!"))
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"{msg} Congratulate!!!");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("\n\n\t\tPress any key to continue..");
                                Console.ResetColor();
                                Console.ReadKey(true);
                            }
                            else
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"{msg}...");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("\n\n\t\tPress any key to continue..");
                                Console.ResetColor();
                                Console.ReadKey(true);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Message Exeption is: {ex.Message}");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\n\n\t\tPress any key to continue..");
                            Console.ResetColor();
                            Console.ReadKey(true);
                        }
                        finally { }
                        break;
                }
            } while (choice != 0);
        }

        static DataSet ShowAllEntities()
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            DataSet dataSet = null;
            DataTableMapping custMap = null;
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                cmd = new SqlCommand("SELECT *FROM Employers", conn);
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(cmd);
                dataSet = new DataSet("Employers");
                custMap = sqlAdapter.TableMappings.Add("Employers", "Current Employers");
                custMap.ColumnMappings.Add("id", "ID");
                custMap.ColumnMappings.Add("FIO", "Name Surname");
                sqlAdapter.Fill(dataSet, "Employers");
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\n\t\tPress any key to continue..");
                Console.ResetColor();
                Console.ReadKey(true);
            }
            finally
            {
                conn.Close();
            }

            return dataSet;
        }

        static void ForShowing()
        {
            DataSet ds = ShowAllEntities();
            Console.WriteLine($"\n\nDataSetName is - {ds.DataSetName}\n");
            foreach (DataTable dt in ds.Tables)
            {
                Console.WriteLine($"{dt.TableName} Table.\n");
                Console.Write(new string('-', 120));
                for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
                {
                    Console.Write(dt.Columns[curCol].ColumnName.Trim() + "\t   |  ");
                }
                Console.WriteLine();
                Console.Write(new string('-', 120));
                Console.WriteLine("\n");
                for (int curRow = 0; curRow < dt.Rows.Count; curRow++)
                {
                    for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
                    {
                        Console.Write(dt.Rows[curRow][curCol].ToString().Trim() + "\t   ");
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
        }

        static string Insert(Employer e)
        {
            string MSG = string.Empty;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Employers(FIO, Addresss, Phone, Email, Datebirth, Salary) " +
                "VALUES(@FIO, @Addresss, @Phone, @Email, @Datebirth, @Salary)", conn);
            cmd.Parameters.AddWithValue("@FIO", e.FIO);
            cmd.Parameters.AddWithValue("@Addresss", e.Addresss);
            cmd.Parameters.AddWithValue("@Phone", e.Phone);
            cmd.Parameters.AddWithValue("@Email", e.Email);
            cmd.Parameters.AddWithValue("@Datebirth", e.Datebirth);
            cmd.Parameters.AddWithValue("@Salary", e.Salary);
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
                MSG = e.FIO + " Inserted Successfully!";
            else
                MSG = e.FIO + " NOT Inserted! Try to Find this Error";
            conn.Close();

            return MSG;
        }
    }
}
