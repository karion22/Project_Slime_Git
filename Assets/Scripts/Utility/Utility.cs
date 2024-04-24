using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Project.Slime
{
    public static class Utility
    {
        public static string StringBuilder(params string[] str)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0, end = str.Length; i < end; i++)
            {
                sb.Append(str[i]);
            }
            return sb.ToString();
        }
    }
}
