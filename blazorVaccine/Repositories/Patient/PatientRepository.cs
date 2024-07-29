using blazorVaccine.Data;
using blazorVaccine.Models;
using Microsoft.EntityFrameworkCore;
namespace blazorVaccine.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private readonly BlazorVaccineContext _blazorVaccineContext;
        public PatientRepository()
        {

        }

        public async Task<List<Patient>>GetAll()
        {
           return await _blazorVaccineContext.Patient.ToListAsync();
        }

        public async Task<Patient> GetById(int id)
        {
            return await _blazorVaccineContext.Patient.FindAsync(id);
        }

        public async Task<List<Patient>> GetBySurname(string surname)
        {
            return await _blazorVaccineContext.Patient
            .Where(p => p.Surname == surname)
            .ToListAsync();
        }

        public  async Task<List<Patient>> GetByDOB(DateOnly date)
        {
            return await _blazorVaccineContext.Patient
            .Where(p => p.Dob == date)
            .ToListAsync();
        }

        public  async Task<List<Patient>> GetBySurnameFirstName(string Surname, string FirstName)
        {
            return await _blazorVaccineContext.Patient
            .Where(p => p.Surname == Surname && p.FirstName == FirstName)
            .ToListAsync();
        }


        public async Task Create(Patient patient)
        {
            _blazorVaccineContext.Patient.Add(patient);
            await _blazorVaccineContext.SaveChangesAsync();
        }
        public async Task Delete(Patient patient)
        {
            _blazorVaccineContext.Patient.Remove(patient);
            await _blazorVaccineContext.SaveChangesAsync();
        }
        public async Task Update(Patient patient)
        {
            _blazorVaccineContext.Patient.Update(patient);
            await _blazorVaccineContext.SaveChangesAsync();
        }
    }
}