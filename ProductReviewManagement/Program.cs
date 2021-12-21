using System;
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
                Console.WriteLine("Specify the Number To Excute USE CASE Wise Problems:-- \n 1. Displaying ADD List \n 2. Top Three Records According to Rating \n 3. Retrieve Records using Product ID which is Rating > 3 \n 4. The Number of Recirds of ProductID \n 5. Retrieve Product ID and Review \n 6. Skip Top Five Records \n 7. Product Review of Datatable \n 8. Retrieve Records From DataTable \n 9. Average ProductID \n 10. Exit");
                int number = Convert.ToInt32(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        management.Display(productList);
                        break;
                    case 2:
                        management.TopThreeRecords(productList);
                        break;
                    case 3:
                        management.RetrieveRecordsByProductID(productList);
                        break;
                    case 4:
                        management.RetrieveRecordsCount(productList);
                        break;
                    case 5:
                        management.RetrieveOnlyproductIDAndReview(productList);
                        break;
                    case 6:
                        management.SkipTopFiveRecords(productList);
                        Console.WriteLine("Top Five records are Skipped, And Above records are Remaining Records");
                        break;
                    case 7:
                        management.ProductReviewDatatable(productList);
                        break;
                    case 8:
                        management.RetrieveRecordsFromDataTable(productList);
                        break;
                    case 9:
                        management.AverageProductID(productList);
                        break;
                    case 10:
                        flag = false;
                        break;
                }
            }
        }
    }
}