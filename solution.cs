using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }

 list<int> arrayOne = new list<int> [1, 5, 2];

list<int> arrayTwo = new list<int> [3, 6, 4];

/* I am aware this doesn't work. Forgot how to initialize an empty list. */
list<int> result = new list<int>();

static list<int> Zip (list<int> a, list<int> b) {


foreach (int number in a) {

result.Add(number);

}

foreach (int number in b) {

result.Add(number);

}


return result;


  }

}