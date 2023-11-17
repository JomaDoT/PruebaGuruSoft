using ApiRest.Problema2.DTOS.Persistence;

namespace ApiRest.Problema2.PatronDiseño
{

    //Patron de diseño Singleton
    public sealed class Singleton
    {
        public static readonly Lazy<List<GetPersistenceDTO>> instance = new();

        private Singleton() { }

        public static List<GetPersistenceDTO> Instance
        {
            get
            {
                return instance.Value;
            }
        }
    }
}
