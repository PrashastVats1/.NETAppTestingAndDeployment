//using Microsoft.Data.SqlClient;

//try
//{
//    SqlConnection con = new SqlConnection();
//    string constr = "Server=tcp:webappserver0105.database.windows.net,1433;Initial Catalog=EmpsDb; User Id=PrashastVats; Password=Ankur23050105!;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
//    con.ConnectionString = constr;
//    SqlCommand cmd = new SqlCommand("Select * from Employee");
//    cmd.Connection = con;
//    con.Open();
//    SqlDataReader srdr = cmd.ExecuteReader();
//    while (srdr.Read())
//    {
//        Console.WriteLine("ID \t" + srdr["Id"]);
//        Console.WriteLine("First Name \t" + srdr["Fname"]);
//        Console.WriteLine("Last Name \t" + srdr["Lname"]);
//        Console.WriteLine("Salary \t" + srdr["Salary"]);
//        Console.WriteLine("Designation \t" + srdr["Designation"]);
//    }
//    con.Close();
//}
//catch(Exception ex)
//{
//    Console.WriteLine("Error: "+ex.Message);
//}
//finally
//{
//    Console.WriteLine("End of Program");
//    Console.ReadKey();
//}
using Microsoft.Data.SqlClient;

try
{
    SqlConnection con = new SqlConnection();
    string constr = "Server=tcp:webappserver0105.database.windows.net,1433;Initial Catalog=EmpsDb; User Id=PrashastVats; Password=Ankur23050105!;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
    con.ConnectionString = constr;
    SqlCommand cmd = new SqlCommand("usp_sEmployee")
    {
        Connection = con,
        CommandType = System.Data.CommandType.StoredProcedure
    };
    con.Open();
    SqlDataReader srdr = cmd.ExecuteReader();
    Console.WriteLine("Employee ID \t First Name \t Last Name \t Employee Salary \t Designation");
    while (srdr.Read())
    {
        Console.Write(srdr["Employee ID"] + "\t \t ");
        Console.Write(srdr["First Name"] + "\t \t ");
        Console.Write(srdr["Last Name"] + "\t \t ");
        Console.Write(srdr["Employee Salary"] + "\t\t ");
        Console.Write(srdr["Designation"] + "\t");
        Console.WriteLine();
    }
    con.Close();
}
catch (Exception ex)
{
    Console.WriteLine("Error: " + ex.Message);
}
finally
{
    Console.WriteLine("End of Program");
    Console.ReadKey();
}