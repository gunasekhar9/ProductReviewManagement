﻿using System;
using System.Collections.Generic;

namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ProductReview> productList = new List<ProductReview>
            {
                new ProductReview(){ProductID=1, UserID=1,Rating=5,Review="Excellent",ISLike=true},
                new ProductReview(){ProductID=2, UserID=2,Rating=4,Review="VeryGood",ISLike=true},
                new ProductReview(){ProductID=3, UserID=3,Rating=3,Review="Good",ISLike=true},
                new ProductReview(){ProductID=4, UserID=4,Rating=2,Review="Bad",ISLike=false},
                new ProductReview(){ProductID=5, UserID=5,Rating=1,Review="VeryBad",ISLike=false},
                new ProductReview(){ProductID=6, UserID=6,Rating=1,Review="VeryBad",ISLike=false},
                new ProductReview(){ProductID=7, UserID=7,Rating=2,Review="Bad",ISLike=false},
                new ProductReview(){ProductID=8, UserID=8,Rating=3,Review="Good",ISLike=true},
                new ProductReview(){ProductID=9, UserID=9,Rating=4,Review="VeryGood",ISLike=true},
                new ProductReview(){ProductID=10, UserID=10,Rating=5,Review="Excellent",ISLike=true}
            };
            bool flag = true;
            Management management = new Management();
            while (flag)
            {
                Console.WriteLine("Specify the Number To Excute USE CASE Wise Problems:-- \n 1. Displaying ADD List \n 2. Exit");
                int number = Convert.ToInt32(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        management.Display(productList);
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }                         
        }
    }
}