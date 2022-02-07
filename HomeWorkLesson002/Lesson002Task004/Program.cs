using System;

namespace Lesson002Task004
{
    internal class Program
    {
       
        static void Main(string[] args)
        {

            string shopName = "Магазин у Палыча";
            DateTime date = DateTime.Now;
            
            string row_product = "ТОВАР";
            string row_price = "ЦЕНА";
            string row_discount = "СКИДКА";
            string row_quantity = "КОЛ/ВО";
            string row_result = "ИТОГ";


            string product1 = "Мука";
            string product2 = "Хлеб";
            string product3 = "Вода";


            decimal product1_quantity = 0.765M;
            decimal product2_quantity = 1.000M;
            decimal product3_quantity = 3.000M;
            
            decimal product1_price = 50.55m; 
            decimal product2_price = 29.30m;
            decimal product3_price = 99.99m;
            
            decimal product1_discount = 0.55m; 
            decimal product2_discount = 9.30m;
            decimal product3_discount = 9.99m;

            decimal res1 = Math.Round((product1_price - product1_discount) * product1_quantity, 2, MidpointRounding.AwayFromZero);
            decimal res2 = Math.Round((product2_price - product2_discount) * product2_quantity, 2, MidpointRounding.AwayFromZero);
            decimal res3 = Math.Round((product3_price - product3_discount) * product3_quantity, 2, MidpointRounding.AwayFromZero);


            string total_price = "ИТОГО";
            string total_discount_title = "ИТОГОВАЯ СКИДКА";
            decimal totalDiscount = product1_discount + product2_discount + product3_discount;
            
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"-------------  {shopName} ------------------");
            Console.WriteLine($"{row_product}  |  {row_price}  |  {row_discount}  |  {row_quantity}  |   {row_result}");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"{product1}      {product1_price}     {product1_discount}    {product1_quantity}      {res1}");
            Console.WriteLine($"{product2}      {product2_price}     {product2_discount}    {product2_quantity}      {res2}");
            Console.WriteLine($"{product3}      {product3_price}     {product3_discount}    {product3_quantity}      {res3}");
            Console.WriteLine("\n");
            Console.WriteLine("------------");
            Console.WriteLine($"{total_price}:  {res1+res2+res3}");
            Console.WriteLine($"{total_discount_title}:  {totalDiscount}");
            
            Console.WriteLine($"Дата и время покупки: {date}");
            Console.WriteLine("--------------------------------------------------");
        }
    }
}