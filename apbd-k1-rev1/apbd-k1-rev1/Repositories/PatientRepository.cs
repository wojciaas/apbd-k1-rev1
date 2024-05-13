using System.Data.SqlClient;
using apbd_k1_rev1.Models;
using Microsoft.VisualBasic;

namespace apbd_k1_rev1.Repositories;

public class PatientRepository : IPatientRepository
{
    public async Task<Patient?> GetPatientAsync(string lastName)
    {
        await using SqlConnection connection = new SqlConnection();
        await using SqlCommand com = new SqlCommand();

        com.Connection = connection;
        com.CommandText = "SELECT * FROM Patient WHERE NAZWISKO = @LastName";
        com.Parameters.AddWithValue("@LastName", lastName);

        await connection.OpenAsync();

        SqlDataReader dr = await com.ExecuteReaderAsync();
        
        await dr.ReadAsync();

        return new Patient()
        {
            IdPatient = (int)dr["IdPatient"],
            FirstName = dr["FirstName"].ToString(),
            LastName = dr["LastName"].ToString(),
            BirthDate = (DateFormat)dr["BirthDate"]
        };
    }
}