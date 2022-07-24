//decimal, int, string, char

using MyApp;





//Console.WriteLine(changhuaStrawberry.GetFruitStatus());
//Watermelon changhuaFruit = new Watermelon();
//changhuaFruit.NotRipenWatermelon();
//Console.WriteLine(changhuaFruit.GetFruitStatus());

//Strawberry SB1 = new Strawberry();
//SB1.RipenStrawberry();
//Strawberry SB2 = new Strawberry();
//SB2.RipenStrawberry();
//Strawberry SB3 = new Strawberry();
//SB3.RipenStrawberry();
//Strawberry SB4 = new Strawberry();
//SB4.RipenStrawberry();
//Strawberry SB5 = new Strawberry();

//Console.WriteLine($"SB1:{SB1.GetFruitStatus()}\n SB2:{SB2.GetFruitStatus()}\nSB3:{SB3.GetFruitStatus()}\nSB4:{SB4.GetFruitStatus()}\nSB5:{SB5.GetFruitStatus()}");



//List<Fruit> myList = new List<Fruit>();


//for (int i = 1; i <= 5; i++)
//{
//    var strawberry = new Strawberry();
//    myList.Add(strawberry);
//    Console.WriteLine($"\n\nStrawberry{i} = \n{strawberry.GetFruitStatus()}");
//}

//for (int i =6; i >0 i--)
//{
//    var mango = new Mango();
//    myList.Add(mango);
//    Console.WriteLine($"\n\nMango{i} = \n{mango.GetFruitStatus()}");
//}


//Console.WriteLine($"I have {myList.Count} fruits");

//bool IsPuppyNotHappy = true;


//if (IsPuppyNotHappy == false)
//{
//    Console.WriteLine("Happy!!!!!");
//}
//else
//{
//    Console.WriteLine("Not happy:(");
//}


//int a = 5;
//int b = 1;

//bool isValidNumber = a > 2 || a > 8 || a > 4 || a == 5;

//if (isValidNumber == true)
//{
//    Console.WriteLine("test");
//}
//else
//{
//    Console.WriteLine("not true");
//}


Fruit changhuaFruit = new Strawberry();
changhuaFruit.Name = "Anything";

Strawberry danielStrawberry = (Strawberry)changhuaFruit;

Console.WriteLine(danielStrawberry.GetFruitStatus()); 