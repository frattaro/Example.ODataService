namespace Service
{
    using Data;
    using Microsoft.AspNet.OData;
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;

    public class UsersController : ODataController
    {
        private readonly UsersContext db = new UsersContext();

        [EnableQuery]
        public IQueryable<Users> Get()
        {
            return db.Users;
        }
    }
}