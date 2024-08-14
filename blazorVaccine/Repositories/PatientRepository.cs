using blazorVaccine.Data;
using blazorVaccine.Models;
using Microsoft.EntityFrameworkCore;
namespace blazorVaccine.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private readonly BlazorVaccineContext _blazorVaccineContext;
        public PatientRepository(BlazorVaccineContext blazorVaccineContext)
        {
            _blazorVaccineContext =  blazorVaccineContext;
        }

        public async Task<List<Patient>>GetAll()
        {
            try{

            }catch(Exception e)
            {
                Console.WriteLine($"Error fetching data : {e.Message}");
            }
           return await _blazorVaccineContext.Patient.ToListAsync();
        }

        public async Task<Patient> GetById(int id)
        {
            try{

                return await _blazorVaccineContext.Patient.FindAsync(id);
            }catch(Exception e)
            {
                Console.WriteLine($"Error fetching patient with ID {id}: {e.Message}");
                return null;
            }
        }

        public async Task<List<Patient>> GetBySurname(string surname)
        {
            try{
                string lowerSurname = surname.ToLower();
                return await _blazorVaccineContext.Patient
                .Where(p => p.Surname.Contains(surname))
            .ToListAsync();
            }catch(Exception e)
            {
                Console.WriteLine($"Error fetching data : {e.Message}");
                return null;
            }

        }


        public  async Task<List<Patient>> GetByDOB(DateOnly date)
        {
            try{
                return await _blazorVaccineContext.Patient
                .Where(p => p.Dob == date)
                .ToListAsync();
            }catch(Exception e)
            {
                Console.WriteLine($"Error fetching data : {e.Message}");
                return null;
            }

        }

        public  async Task<List<Patient>> GetBySurnameFirstName(string Surname, string FirstName)
        {
            try{
                return await _blazorVaccineContext.Patient
                .Where(p => p.Surname == Surname && p.FirstName == FirstName)
                .ToListAsync();
            }catch(Exception e)
            {
                Console.WriteLine($"Error fetching data : {e.Message}");
                return null;
            }

        }


        public async Task Create(Patient patient)
        {
            try{
                _blazorVaccineContext.Patient.Add(patient);
                await _blazorVaccineContext.SaveChangesAsync();
            }catch(Exception e)
            {
                Console.WriteLine($"An error has occured when creating a new patient : {e.Message}");
            }

        }
        public async Task Delete(Patient patient)
        {
            try{
                _blazorVaccineContext.Patient.Remove(patient);
                await _blazorVaccineContext.SaveChangesAsync();
            }catch(Exception e)
            {
                Console.WriteLine($"An error has occured when delete the patient with the id of {patient.Id} : {e.Message}");
            }

        }
        public async Task Update(Patient patient)
        {
            try
            {
                _blazorVaccineContext.Patient.Update(patient);
                await _blazorVaccineContext.SaveChangesAsync();
            }catch(Exception e)
            {
                Console.WriteLine($"An error has occured when updating the patient with the id of {patient.Id} : {e.Message}");
            }
        }
    }
}