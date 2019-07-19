namespace Service
{
    using Data;
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;

    public class CustomController : Controller
    {
        private readonly UsersContext db = new UsersContext();

        [HttpGet("Custom/GetTwoUsers")]
        public IQueryable<Users> GetTwoUsers()
        {
            return db.Users.Take(2);
        }
    }
}