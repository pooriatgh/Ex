using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace Application.APIRequest
{
    public class GenerateFullUrl
    {
        public static string Get(string part1, string part2)
        {
            return part1 + part2;
        }
        
    }
}
