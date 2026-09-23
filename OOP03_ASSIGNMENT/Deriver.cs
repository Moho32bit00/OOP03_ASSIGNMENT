using System;
using System.Collections.Generic;
using System.Text;

namespace OOP03_ASSIGNMENT
{
    public class Deriver
    {
        public Deriver() { }
        public Deriver(int driverId, string fullName, double phoneNumber)
        {
            DriverId = driverId;
            FullName = fullName;
            PhoneNumber = phoneNumber;
        }

        public int DriverId {  get; set; }
       public string FullName {  get; set; }
       public double PhoneNumber {  get; set; }

        
    }
}
