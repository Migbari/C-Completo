﻿using System;

namespace CustomExeption.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public Reservation()
        {

        }
        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }
        public int Duration() 
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays; 
        }
        public string UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                 return "Data Inferior a Data ATUAL";
            }
            if (checkOut <= checkIn)
            {
                 return "Data de Saída menor que Entrada";
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
            return null;
        }
        public override string ToString()
        {
            return "Quarto "
            + RoomNumber
            + ", Entrada: "
            + CheckIn.ToString("dd/MM/yyyy")
            + ", Saída: "
            + CheckOut.ToString("dd/MM/yyyy")
            + ", "
            + Duration()
            + " Noites";
        }
    }
}
