using PasswordGenerator;

// Console.WriteLine("my name is chales");
// var name = Console.ReadLine();
// var currentDate = DateTime.Now;
// Console.WriteLine($"{Environment.NewLine}Hello,{name},on {currentDate:d}");
// Console.Write($"{Environment.NewLine}press any key to exit");
// Console.ReadKey(true);


var pwd = new Password();
var password = pwd.Next();


Console.WriteLine(password);