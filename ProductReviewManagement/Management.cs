﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProductReviewManagement
{
    public class Management
    {
        public void Display(List<ProductReview> productList)
        {
            foreach (ProductReview list in productList)
            {
                Console.WriteLine("ProductID :-" + list.ProductID + " " + "User ID:-" + list.UserID + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "ISLike:-" + list.ISLike);
            }
        }
        public void TopThreeRecords(List<ProductReview> productList)
        {
            var records = (from Product in productList orderby Product.Rating descending select Product).Take(3).ToList();
            Display(records);
        }
        public void RetrieveRecordsByProductID(List<ProductReview> productList)
        {
            var records = (from Product in productList where (Product.ProductID == 1 || Product.ProductID == 4 || Product.ProductID == 9) && Product.Rating > 3 select Product).ToList();
            Display(records);
        }
        public void RetrieveRecordsCount(List<ProductReview> productList)
        {
            var records = productList.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });
            foreach (var data in records)
            {
                Console.WriteLine("The Number Of Records of Product ID : {0} are {1} ", data.ProductID, data.Count);
            }
        }
        public void RetrieveOnlyproductIDAndReview(List<ProductReview> productList)
        {
            var records = from Product in productList select new { Product.ProductID, Product.Review };
            foreach(var data in records)
            {
                Console.WriteLine("ProductID : " + data.ProductID + " " + "Review : " + data.Review);
            }
        }
    }
}