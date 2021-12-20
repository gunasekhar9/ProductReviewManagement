using System;
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
    }
}
