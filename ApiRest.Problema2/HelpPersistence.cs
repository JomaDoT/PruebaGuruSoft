using ApiRest.Problema2.DTOS.Persistence;
using ApiRest.Problema2.PatronDiseño;

namespace ApiRest.Problema2
{
    public static class HelpPersistence
    {
        public static GetPersistenceDTO FillPersistence(string request,string response, string username,bool isFirst)
        {
            if (!isFirst)
            {
                return new(
                Id: Singleton.instance.Value.LastOrDefault().Id + 1,
                Request: request,
                RequestDate: DateTime.Now,
                Response: response,
                ResponseDate: DateTime.Now,
                UserName: username);
            }
            else
            {
                return new(
                                Id: 1,
                                Request: request,
                                RequestDate: DateTime.Now,
                                Response: response,
                                ResponseDate: DateTime.Now,
                                UserName: username);
            }
        }
    }
}
