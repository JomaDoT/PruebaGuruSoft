using ApiRest.Problema2.Controllers;
using ApiRest.Problema2.DTOS.Persistence;
using ApiRest.Problema2.DTOS.Primos;
using ApiRest.Problema2.PatronDiseño;
using Microsoft.AspNetCore.Mvc;

namespace ApiRest.Problema2.Test
{
    public class Tests
    {
        private readonly PrimosController _primosController;
        private readonly PersistenceController _PersistenceController;

        public Tests()
        {
            _primosController = new PrimosController();
            _PersistenceController = new PersistenceController();
        }
        [Test]
        public void PrimosGet_BadRequest_BadParams()
        {
            GetPrimosParamsDTO paramsDTO = new(1, 0, "jonathan");

            // Act
            var okResult = _primosController.FindPrimos(paramsDTO);
            // Assert
            Assert.IsInstanceOf<BadRequestObjectResult>(okResult as BadRequestObjectResult);
        }
        [Test]
        public void PersistenceGet_NotFound()
        {
            // Act
            var okResult = _PersistenceController.GetData();
            // Assert
            Assert.IsInstanceOf<NotFoundObjectResult>(okResult as NotFoundObjectResult);
        }
        [Test]
        public void PrimosGet_Ok()
        {
            GetPrimosParamsDTO paramsDTO = new(1, 5, "jonathan");
            // Act
            var okResult = _primosController.FindPrimos(paramsDTO);
            // Assert
            Assert.IsInstanceOf<OkObjectResult>(okResult as OkObjectResult);
        }

        [Test]
        public void PersistenceGet_Ok()
        {
           Singleton.Instance.Add(GetData());
            // Act
            var okResult = _PersistenceController.GetData();
            // Assert
            Assert.IsInstanceOf<OkObjectResult>(okResult as OkObjectResult);
        }

        private static GetPersistenceDTO GetData()
        {
            return new GetPersistenceDTO(1, "prueba", DateTime.Now, "prueba", DateTime.Now, "prueba");
        }
    }
}