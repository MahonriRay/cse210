﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Book fablehaven = new Book("Fablehaven","Brandon Mull");
fablehaven.Display();

Book bom = new Book("Book of Mormon","Mormon");
bom.Display();

// Console.WriteLine(bom.IsAvailable());
// bom.Checkout();
// bom.Display();
// bom.Checkin();
// bom.IsAvailable();
// Console.WriteLine(bom.IsAvailable());
// bom.Display();

Console.WriteLine(bom.HasAuthor("Mormon"));

Console.WriteLine(bom.HasAuthor("Smith"));