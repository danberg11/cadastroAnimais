using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastroAnimal.Model
{
    internal class Conexao
    {
        public static string Conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\daniel.bnoliveira\source\repos\cadastroAnimais\cadastroAnimais\dados\Database1.mdf;Integrated Security=True";
        }
    }
}