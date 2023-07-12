using CRUD_WebApi.Interfaces;

namespace CRUD_WebApi.DAL {
    public class Employees : IEntity {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
    }
}
