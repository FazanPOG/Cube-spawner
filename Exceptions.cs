using System;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public static class TryConvert
    {
        public static int TryConvertToInt(string checking)
        {
            if (checking != "")
            {
                try
                {
                    return Convert.ToInt32(checking);
                }
                catch (Exception e)
                {
                    Debug.Log(e);
                    return 0;
                };
            }
            return 0;
        }
    }
}
