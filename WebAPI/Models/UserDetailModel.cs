using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class UserDetailModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Address { get; set; }
        public string Notes { get; set; }
    }
}
