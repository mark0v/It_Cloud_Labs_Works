using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharp_Net_module1_1_4_lab
{   
        public struct Computers
        {
            public ComputerTypeLkp typePC;
            public string Resolution;
            public float CPU_GHz;
            public int RAM;
            public int HDD;

            public Computers(ComputerTypeLkp typePc)
            {
                this.typePC = typePc;

                switch ((int)typePc)
                {
                    case 0:
                        { Resolution = "1920x1080"; CPU_GHz = 2.7f; RAM = 8; HDD = 240; break; }
                    case 1:
                        { Resolution = "2500x1080"; CPU_GHz = 3.5f; RAM = 16; HDD = 500; break; }
                    case 2:
                        { Resolution = "3820x2080"; CPU_GHz = 4.1f; RAM = 32; HDD = 2000; break; }
                    case 3:
                        { Resolution = "1620x860"; CPU_GHz = 3.1f; RAM = 8; HDD = 500; break; }
                    default:
                        { Resolution = "Null"; CPU_GHz = 0; RAM = 0; HDD = 0; break; }
                }

            }
            public void ShowPCSettings()
            {
                Console.WriteLine("PC Type: {0}, Resolution: {1}, CPU freq: {2}, RAM: {3}, HDD: {4}", typePC, Resolution, CPU_GHz, RAM, HDD);
            }
        }
    
}
