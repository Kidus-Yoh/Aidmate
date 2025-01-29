using AidMate.Models;

public interface IParamedicService
{
    Task<List<ParamedicModel>> Get();
    Task<ParamedicModel?> GetById(string id);
    Task<List<ParamedicModel>> Add(ParamedicModel newParamedic);
    Task<List<ParamedicModel>> Update(string id, ParamedicModel updatedParamedic);
    Task<List<ParamedicModel>> Delete(string id);
}