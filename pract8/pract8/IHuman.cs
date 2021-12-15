using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract8
{
    interface IHuman
    {
        string GetName { get; set; }
        string GetSurname { get; set; }
        string GetPatronimy { get; set; }
        string GetGender { get; set; }
        string GetGroup { get; set; }
        int GetAge { get; set; }
    }
}
