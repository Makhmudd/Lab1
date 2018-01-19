 using System;
 
 namespace Homework
 {
     class Animal
     {
         public static int count = 0;
         public string name;
         public int age;
         public float mood;
 
         public void Print()
         {
             Console.WriteLine("Name " + name);
             Console.WriteLine("Age " + age);
             Console.WriteLine("Mood " + mood);
         }
 
         public Animal()
         {
             name = "Spotty";
             age = 10;
             mood = 6.7f;
         }
 
         public Animal(string _name, int _age, float _mood)
         {
             name = _name;
             age = _age;
             mood = _mood;
 
             Print();
         }
     }
 
     
   class MainClass
      {
        public static void Main(string[] args)
        {
            Animal cat = new Animal("Makha", 15, 0.8f);
            Console.WriteLine();
            Animal dog = new Animal("Danik", 10, 0.8f);
 
             Console.ReadKey();
         }
     }f
 }