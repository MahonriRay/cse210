using System;
Customer customer1 = new Customer("Joe Mama", new Address("10086 Sunset Boulevard", "Beverly Hills", "California", "America"));
Customer customer2 = new Customer("Joe Daddy", new Address("P. Sherman 42 Wallaby Way", "Sydney", "New South Wales", "Australia"));

Product shoes = new Product("Van's Skate Shoes", 1, 49.99f, 1);
Product computer = new Product("Laptop", 2, 899.99f, 1);
Product shirt = new Product("Thrasher T-Shirt", 3, 19.99f, 1);
Product blanket = new Product("Mink Blanket", 4, 49.99f, 1);

Order order1 = new Order(customer1, new List<Product>{shoes, shirt.AddQty(2)});
Order order2 = new Order(customer2, new List<Product>{computer, blanket.AddQty(3)});

Console.Clear();
order1.PrintAllDeets();
order2.PrintAllDeets();