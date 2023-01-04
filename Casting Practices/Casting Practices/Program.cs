



using Casting_Practices.Models;

//Salmon salmon1 = new Salmon();

//Eagle eagle1 = new Eagle();

//Animal animal1 = eagle1;

//animal1.Sound();


//eagle1.Test();

//animal1.Test();



//Console.WriteLine(animal1.Speed);


//animal1.Sound();

//Animal animal2 = salmon1;

//Bird bird = new Bird();

//Animal animal3 = new Salmon();





//salmon1.Sound();

//eagle1.Sound();

//Animal animal = new Animal();

//animal.Sound();


//Bird bird1 = new Bird();

//bird1.Sound();

//Bird bird = new Bird();

//Fish fish = new Fish();



//Eagle eagle1 = new Eagle();

//Animal animal1 = new Animal();

//Eagle eagle2 = (Eagle)animal1;





//Eagle eagle1 = new Eagle();

//Animal animal1 = new Eagle();

//Fish fish1 = new Fish();

//Animal animal2 = fish1;

//Bird bird1 = new Bird();

//Eagle eagle3 = (Eagle)animal2;


//Bird bird2 = new Bird();

//Eagle eagle = (Eagle)bird2; 




//Animal[] animals = { eagle1, animal1, fish1, animal2, bird1, eagle3 };

//foreach (var item in animals)
//{
//    item.Name = "XXX";
//    Console.WriteLine(item.Name);
//}





//string str = "dddd";

//object obj1 = str;

//string name = obj1.ToString();

//int num1 = 55;

//object obj1 = num1;

//int num3 = (int)obj1;

//string str = "100";


//object obj = str;

//int num3 = (int)obj;

//var result = int.Parse(str);

//bool isMarried = false;

//object obj1 = isMarried;

//bool result = (bool)obj1;

//Console.WriteLine(result);


//byte num1 = 22;

//int num2 = num1;

//int num1 = 1200;

//byte num2 = (byte)num1;

//Console.WriteLine(num2);

//byte num3 = 55;

//int num4 = num3;

//Console.WriteLine(num4);





Bird bird = new Bird();

Fish fish = new Fish();


Animal animal1 = new Bird();

Animal animal2 = new Fish();


object[] objects = { 1, bird, fish, "Sagol", animal1};

//foreach (var item in objects)
//{
//    if (item is Animal)
//    {
//        ((Animal)item).Name = "test";
//        Console.WriteLine(((Animal)item).Name);
//    }
//    else
//    {
//        Console.WriteLine(item);
//    }  
//}

//foreach (var item in objects)
//{
//    if (item is Animal a)
//    {
//        a.Name = "test";
//        Console.WriteLine(a.Name);
//    }
//    else
//    {
//        Console.WriteLine(item);
//    }
//}


foreach (var item in objects)
{
    Animal animal = item as Animal;

	if (animal != null)
	{
		animal.Name = "sjjss";
		Console.WriteLine(animal.Name);
	}
	else
	{
		Console.WriteLine(item);
	}
}




