﻿using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        } //this one above was done for us already

        public double Subtract(double minuend, double subtrahend)
        {
            //done
            return minuend - subtrahend;
        }

        public int Add(int number1, int number2)
        {
            //done
            return number1 + number2;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            //done
            if (number1 < number2)
            { 
                return number1;
            }
            else if (number1 > number2)
            {
                return number2;
            }
            else
            {
                return number1;
            }
        }

        public long Multiply(long factor1, long factor2)
        {
            return factor1 * factor2;
        }

        public string GetGreeting(string nameOfPerson)
        {
            if (nameOfPerson == "")
            {
                return "Hello!";
            }
            else  
            {
                return $"Hello, {nameOfPerson}!";
            }
        }


        public string GetHey()
        {
           return "HEY!";
        }
    }
}
