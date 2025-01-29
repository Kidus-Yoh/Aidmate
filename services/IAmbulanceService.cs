using AidMate.Models;

public interface IAmbulanceService
{
    Task<List<AmbulanceModel>> Get();
    Task<AmbulanceModel?> GetById(string id);
    Task<List<AmbulanceModel>> Add(AmbulanceModel newAmbulance);
    Task<List<AmbulanceModel>> Update(string id, AmbulanceModel updatedAmbulance);
    Task<List<AmbulanceModel>> Delete(string id);
}