﻿using System;
using WPNinjas.Dsregcmd;

namespace WPNinjas.Dsregcmd.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var dsreg = Dsregcmd.GetInfo();
                Console.WriteLine("Successfully retrieved information.");
            } catch (Exception ex)
            {
                Console.WriteLine("Error occured.");
                Console.WriteLine(ex.Message);

            }

        }
    }
}
