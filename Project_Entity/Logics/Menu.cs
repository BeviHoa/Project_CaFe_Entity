﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Entity.Logics
{
    public class Menu
    {

        public Menu(string foodName, int count, float price, float totalPrice = 0)
        {
            this.FoodName = foodName;
            this.Count = count;
            this.Price = price;
            this.TotalPrice = totalPrice;
        }
        public Menu(DataRow row)
        {
            this.FoodName = row["tendouong"].ToString();
            this.Count = (int) row["SoLuong"];
            this.Price = (float)Convert.ToDouble(row["giatien"].ToString());
            this.TotalPrice = (float)Convert.ToDouble( row["totalPrice"].ToString());
        }
        private float totalPrice;
        private float price;
        private int count;
        private string foodName;

        public string FoodName { get => foodName; set => foodName = value; }
        public int Count { get => count; set => count = value; }
        public float Price { get => price; set => price = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}