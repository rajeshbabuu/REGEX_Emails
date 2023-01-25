using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPattern
{
    public class Pattern
    {
        public void ValidateEMail(string eMail)
        {
            // Part2: ensure @ and validate mandatory part bridgelabz
            var regex = new Regex(@"^([a][b][c])\@([b][r][i][d][g][e][l][a][b][z])");
            bool matchRes = regex.IsMatch(eMail);
            if (matchRes == true)
            {
                Console.WriteLine($"\n{eMail} is valid email address");
            }
            else
            {
                Console.WriteLine($"\n{eMail} is invalid email address");
            }
        }
    }
}
