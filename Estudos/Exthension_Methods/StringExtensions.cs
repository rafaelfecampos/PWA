using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exthension_Methods
{
    public static class StringExtensions
    {
        public static string Revert(this string valor)=>
            new string(valor.ToCharArray().Reverse().ToArray());
        
        public static int WordCount(this string str){
            return str.Split(new char[] {' ', '.', '?','!',',',';','(',')'}, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}