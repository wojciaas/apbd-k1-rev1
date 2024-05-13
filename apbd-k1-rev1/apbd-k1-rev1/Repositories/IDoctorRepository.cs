using apbd_k1_rev1.Models;

namespace apbd_k1_rev1.Repositories;

public interface IDoctorRepository
{
    public Task<Doctor?> GetDoctorAsync(string lastName);
}