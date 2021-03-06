﻿using System;

namespace Vsite.CSharp
{
    public static class IspišiParnost
    {
        public static void UvjetnimPridruživanjem(int broj)
        {
            
            string odgovor = broj % 2 == 0 ? "paran" : "neparan";

            Console.WriteLine("Broj {0} je {1}", broj, odgovor);
        }

        public static void GrananjemIf(int broj)
        {
            
            string odgovor = "neparan";
            if (broj % 2 == 0)
                odgovor = "paran";
            
            Console.WriteLine("Broj {0} je {1}", broj, odgovor);
        }
    }
}
