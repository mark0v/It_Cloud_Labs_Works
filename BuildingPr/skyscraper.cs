using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingPr
{
    public class Skyscraper : Hous
    {
        private bool isElevatorExist;



        public Skyscraper()
        {
            isElevatorExist = false;
            

        }
        public override bool GetBasement()
        {
            throw new NotImplementedException();
        }

        public override int GetElevator(bool isElevatorExist = false)
        {
            throw new NotImplementedException();
        }

        public override int GetEntrance()
        {
            throw new NotImplementedException();
        }

        public override int GetFloors()
        {
            throw new NotImplementedException();
        }
    }
}
