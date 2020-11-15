using System;
using System.Collections.Generic;
using System.Text;
using Homework_Class08.Enums;

namespace Homework_Class08.Entities
{
    public class Car
    {
        public int ID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Doors { get; set; }
        public int TopSpeed { get; set; }
        public Consumption Consume;
        protected EngineType EngineType;

        //METHOD

        public void PrintInfo()
        {
            Console.WriteLine($"This {Brand} {Model}, with ID No.:{ID} has {Doors} doors, {EngineType} engine with {Consume} consumption and can reach a top speed of {TopSpeed} km/h. ");
        } 

    }   
}
