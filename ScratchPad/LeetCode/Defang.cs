using System;
using System.Collections.Generic;
using System.Text;

namespace ScratchPad.LeetCode
{
    // Link: https://leetcode.com/problems/defanging-an-ip-address/
    public class Defang
    {

        public string DefangIPaddress(string address)
        {
           
            return address.Replace(".", "[.]");
            
        }
    }
}
