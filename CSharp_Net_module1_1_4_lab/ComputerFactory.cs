using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_1_4_lab
{
    public class ComputerFactory 
    {
        //public ComputerTypeLkp type;
        //public Computers pc = new Computers(ComputerTypeLkp.Monoblock);



        public ComputerFactory()
        {
            // this.type = type;
            // 3) declare jagged array of computers size 4 (4 departments)
            Computers[][] department = new Computers[4][];            


        }


        public Computers[][] GetArray(Computers[][] department)
        {            
            // 4) set the size of every array in jagged array (number of computers)
            department[0] = new Computers[5]; // desktop
            department[1] = new Computers[6]; // laptop
            department[2] = new Computers[5]; // workstation
            department[3] = new Computers[6]; // monoblock
            // 5) initialize array
            // Note: use loops and if-else statements
            
            int length = department.Length;
            
            for (int i = 0; i < length; i++)
            {
                int compNum = 0;

                for (int j = 0; j < department[i].Length; j++)
                {
                    
                    if (j==0)
                    {
                        department[i][compNum] = new Computers(ComputerTypeLkp.Desktop);
                        compNum++;
                    }
                    else if (j == 1)
                    {
                        department[i][compNum] = new Computers(ComputerTypeLkp.Laptop);
                        compNum++;
                    }
                    else if (j == 2)
                    {
                        department[i][compNum] = new Computers(ComputerTypeLkp.Monoblok);
                        compNum++;
                    }
                    else 
                    {
                        department[i][compNum] = new Computers(ComputerTypeLkp.Workstation);
                        compNum++;
                    }

                }               
            }
            for (int i = 0; i < department.Length; i++)
                for (int j = 0; j < department[i].Length; j++)
                {
                    Console.Write("Department {0},Computer{1}:", i + 1, j + 1);
                    department[i][j].ShowPCSettings();
                }
            return department;


        }

        
    }
}
