// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


Source source = new Source("None were with Him", "http://www.churchofjesuschrist.org");
// Console.WriteLine(source.Stringify());
Quote holland = new Quote("Elder Holland", "Because Jesus walked such a long, lonely path utterly alone, we do not have to do so", source);

// Console.WriteLine(holland.GetQuote());

Board _board = new Board();
_board.AddQuote(
     new Quote(
        "Mario",
        "It's a me, Mario",
        new Source("Super Mario Bros."))
);
_board.AddQuote(
    new Quote("Fellow Traveler",
    "It's dangerous to go alone! Take this.",
    new Source("The Legend of Zelda"))
);
_board.AddQuote(
    new Quote("Navi",
    "HEY.... LISTEN!",
    new Source("The Legend of Zelda: Ocarina of Time"))
);
// quoteboard.AddQuote(holland);
// quoteboard.FindQuoteByAuthor("holland");

// quoteboard.GetRandomQuote();
Menu _menu = new Menu(_board);
_menu.Display();

