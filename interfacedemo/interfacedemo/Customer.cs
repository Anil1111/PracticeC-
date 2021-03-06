﻿using System;
using System.Collections.Generic;
using System.Text;

namespace interfacedemo
{
    // Implementing an Interface
    public class Customer : ILoyaltyCardHolder
    {
        private int totalPoints;
        public int TotalPoints
        {
            get { return totalPoints; }
        }
        public int AddPoints(decimal transactionValue)
        {
            int points = Decimal.ToInt32(transactionValue);
            totalPoints += points;
            return totalPoints;
        }
        public void ResetPoints()
        {
            totalPoints = 0;
        }
        // Other members of the Customer class.   
    }
}