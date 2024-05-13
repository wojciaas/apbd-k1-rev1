using apbd_k1_rev1.Models;

namespace apbd_k1_rev1.Repositories;

public interface IPatientRepository
{
    public Task<Patient?> GetPatientAsync(string lastName);
}