using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingPr
{
    public abstract class Hous
    {
        
        public bool isElevatorExist { get; set; }

        public abstract int GetFloors();
        public abstract bool GetBasement();
        public abstract int GetEntrance();
        public abstract int GetElevator(bool isElevatorExist = false);
        

        


    }
}
