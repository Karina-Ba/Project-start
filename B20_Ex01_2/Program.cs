﻿using System;
using System.Text;

namespace B20_Ex01_2
{
    public class Program 
    {
        //-----------------------------------------------------------------------------------------------------------------------//
        public static void Main()
        {
            InitProgram();
        }
        //-----------------------------------------------------------------------------------------------------------------------//
        public static void InitProgram()
        {
            PrintSandClock(5);
        }
        //-----------------------------------------------------------------------------------------------------------------------//
        public static void PrintSandClock(int i_RowLength)
        {
            StringBuilder sandClockBuilder = new StringBuilder();
            
            if (i_RowLength % 2 == 1) //Uneven numbers are sent to function as is
            {
                RecursivePrintSandClock(ref sandClockBuilder, i_RowLength, i_RowLength);
            }

            else //Fixed even numbers by adding one befre sending to function
            {
                RecursivePrintSandClock(ref sandClockBuilder, i_RowLength + 1, i_RowLength + 1);
            }
            Console.Write(sandClockBuilder.ToString());
        }
        //-----------------------------------------------------------------------------------------------------------------------//
        public static void RecursivePrintSandClock(ref StringBuilder io_stringBuilder, int i_CurrentRowLength, int i_MaximumRowLength)
        {
            int amountOfSpaces = (i_MaximumRowLength - i_CurrentRowLength) / 2;
            io_stringBuilder.Append(' ', amountOfSpaces);
            io_stringBuilder.Append('*', i_CurrentRowLength);
            io_stringBuilder.AppendLine();

            if (i_CurrentRowLength <= 1)
            {
                return;
            }

            RecursivePrintSandClock(ref io_stringBuilder, i_CurrentRowLength - 2, i_MaximumRowLength);
            io_stringBuilder.Append(' ', amountOfSpaces);
            io_stringBuilder.Append('*', i_CurrentRowLength);
            io_stringBuilder.AppendLine();
        }
        //-----------------------------------------------------------------------------------------------------------------------//
    }
}