using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Internal.System.Collections.Sequences;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Dojo
{
    public class HashMap
    {
        public int bucketSize = 16;

        //public LinkedList<>;


        public static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                if ( i * 2 > 0)
                {
                    Console.WriteLine(i);
                }
            }
        }


    }
}
