using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_1_4_lab
{
    class Program
    {
        
        // 2) declare struct Computer     
        
 

        public static void Main(string[] args)
        {
            Computers[][] department = new Computers[4][];
            var computers = new ComputerFactory();
            var arr = computers.GetArray(department);



            //Console.ReadLine();

            // 6) count total number of every type of computers
            int Desktop = 0;
            int Laptop = 0;
            int Workstation = 0;
            int Monoblok = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if ((int)arr[i][j].typePC == 0)
                    {
                        Laptop++;
                    }
                    else if ((int)arr[i][j].typePC == 1)
                    {
                        Desktop++;
                    }
                    else if ((int)arr[i][j].typePC == 2)
                    {
                        Workstation++;
                    }
                    else if ((int)arr[i][j].typePC == 3)
                    {
                        Monoblok++;
                    }
                }
            }
            Console.WriteLine("Total numbers of Desktop: {0}", Desktop);
            Console.WriteLine("Total numbers of Laptop: {0}", Laptop);
            Console.WriteLine("Total numbers of Workstation: {0}", Workstation);
            Console.WriteLine("Total numbers of Monoblok: {0}", Monoblok);



            // 7) count total number of all computers
            int totalCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    totalCount++;
                }
            }
            Console.WriteLine("Total numbers of computers: {0}", totalCount);
           
            // Note: use loops and if-else statements
            // Note: use the same loop for 6) and 7)

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    totalCount++;
                }
            }


            // 8) find computer with the largest storage (HDD) - 
            // compare HHD of every computer between each other; 
            
            // Note: use loops and if-else statements

            int Index1 = 0;
            int Index2 = 0;
            int maxHdd = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[Index1][Index2].HDD < arr[i][j].HDD)
                    {
                        Index1 = i;
                        Index2 = j;
                        maxHdd = arr[i][j].HDD;
                    }                    
                }
            }
            Console.WriteLine("Max HDD: {0}", maxHdd);
            

            // find position of this computer in array (indexes)
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[Index1][Index2].HDD == arr[i][j].HDD)
                    {
                        Console.WriteLine("PC with max Hdd: Department: {0}, Computer: {1}, Type PC: {2}", i+1, j+1, arr[i][j].typePC);
                    }
                }
            }

           
            // 9) find computer with the lowest productivity (CPU and memory) - 
            // compare CPU and memory of every computer between each other; 
           

            int lowProdIndex1 = 0;
            int lowProdIndex2 = 0;
            float lowCPU = 0;
            float lowRAM = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[lowProdIndex1][lowProdIndex2].HDD > arr[i][j].HDD && arr[lowProdIndex1][lowProdIndex2].CPU_GHz > arr[i][j].CPU_GHz)
                    {
                        lowProdIndex1++;
                        lowProdIndex2++;
                        lowCPU = arr[i][j].CPU_GHz;
                        lowRAM = arr[i][j].RAM;
                    }
                }
            }
            Console.WriteLine("Cmputer with the lowest productivity: CPU: {0}, RAM: {1}", lowCPU, lowRAM);
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements
            // Note: use logical oerators in statement conditions
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[lowProdIndex1][lowProdIndex2].CPU_GHz == arr[i][j].CPU_GHz 
                        && arr[lowProdIndex1][lowProdIndex2].RAM == arr[i][j].RAM)
                    {
                        Console.WriteLine("Position of this computer in array: Department: {0}, Computer: {1}, Type PC: {2}", i + 1, j + 1, arr[i][j].typePC);
                    }
                }
            }

            
            // 10) make desktop upgrade: change memory up to 8
            // change value of memory to 8 for every desktop. Don't do it for other computers
            // Note: use loops and if-else statements
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if ((int)arr[i][j].typePC == 1)
                    {
                        arr[i][j].RAM = 8;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("Department {0},Computer{1}:", i + 1, j + 1);
                    department[i][j].ShowPCSettings();
                }
            }
            Console.ReadLine();
        }

    }
}
