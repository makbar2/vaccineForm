using blazorVaccine.Data;
using blazorVaccine.Models;
namespace blazorVaccine.Repositories
{
    public interface IPatientRepository
    {
        
        public Task<List<Patient>> GetAll();
        public Task <Patient> GetById(int id);
        public Task<List<Patient>> GetBySurname(string Surname);
        public Task<List<Patient>> GetBySurnameFirstName(string Surname, string FirstName);
        public Task<List<Patient>> GetByDOB(DateOnly date);
        public Task Create(Patient patient);
        public Task Delete(Patient patient);
        public Task Update(Patient patient);

    }
}