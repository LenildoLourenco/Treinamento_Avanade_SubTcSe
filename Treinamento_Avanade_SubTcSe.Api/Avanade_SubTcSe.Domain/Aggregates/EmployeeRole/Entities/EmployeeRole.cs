namespace Avanade_SubTcSe.Domain.Aggregates.EmployeeRole.Entities
{
    public record EmployeeRole
    {
        public EmployeeRole(string id, string roleName)
        {
            Id = id;
            RoleName = roleName;
        }

        public EmployeeRole(string roleName)
        {
            
            RoleName = roleName;
        }



        public string Id { get; private set; }

        public string RoleName { get; init; }

    }
}
