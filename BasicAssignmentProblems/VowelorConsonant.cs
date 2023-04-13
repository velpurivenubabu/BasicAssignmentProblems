using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAssignmentProblems
{
    internal class VowelorConsonant
    {
        public static string FindVowelorConsonant(char alphabet)
        {
            switch(alphabet)
            {
                case 'A':
                     return "Vowel";
                case 'E':
                    return "Vowel";
                case 'I':
                    return "Vowel";
                case 'O':
                    return "Vowel";
                case 'U':
                    return "Vowel";
                case 'a':
                    return "Vowel";
                case 'e':
                    return "Vowel";
                case 'i':
                    return "Vowel";
                case 'o':
                    return "Vowel";
                case 'u':
                    return "Vowel";
                
                default:
                    return "Consonant";
            }
        }
    }
}
