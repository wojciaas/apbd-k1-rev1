using System.Data.SqlClient;
using apbd_k1_rev1.Models;

namespace apbd_k1_rev1.Repositories;

public class DoctorRepository : IDoctorRepository
{
    public async Task<Doctor?> GetDoctorAsync(string lastName)
    {
        await using SqlConnection connection = new SqlConnection();
        await using SqlCommand com = new SqlCommand();

        com.Connection = connection;
        com.CommandText = "SELECT * FROM DOCTOR WHERE NAZWISKO = @LastName";
        com.Parameters.AddWithValue("@LastName", lastName);

        await connection.OpenAsync();

        SqlDataReader dr = await com.ExecuteReaderAsync();
        
        await dr.ReadAsync();

        return new Doctor()
        {
            IdDoctor = (int)dr["IdDoctor"],
            FirstName = dr["FirstName"].ToString(),
            LastName = dr["LastName"].ToString(),
            Email = dr["Email"].ToString()
        };
    }
}