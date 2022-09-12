// Collections

// Arrays!
// Fixed size, and of a particular type
// indexed at 0, meaning numbered starting with 0
var students = new string[13]; // creates an empty array with 13 slots to fill
// variable = new type[length]; generic template
var instructors = new string[] { "Davis", "Gavin", "El", "Rickie", "Cliff"}; // because there are 5 things listed, the array's LENGTH is 5
// variable = new type[] {comma separated values};
// In C# - an array's length and type cannot change. period. .

// change the value at a slot in an array
// name = value;
// array[index] = value;
students[7] = "Ashley";
// student at index seven is updated to say "Ashley" 
// student at index seven is not the seventh student -> 8th student
// 0 1 2 3 4 5 6 7
// first thing in the list -> array[0]
// last thing in the list -> array[array.Length - 1]
Console.WriteLine(students.Length); // print the number of slots that the student array has

Console.WriteLine(  students[8]  );

// Lists
// Dynamic size, still must be of one type
// indexed at 0, similar to arrays
var groceries = new List<string>(); // sets up our new list, starting with no values within, its count is 0
groceries.Add("Pizza"); // our list contains 1 item, (pizza has an index = 0)
groceries.Add("Bananas"); // our list contains 2 items ( banana has an index = 1)
groceries.Add("Grapes"); // index = 2
groceries.Add("Potatoes"); // index = 3
Console.WriteLine(groceries[0]);

// Remove items from an array
// list.Remove(item to remove);
groceries.Remove("Bananas");
Console.WriteLine(groceries.Count);
Console.WriteLine(groceries[1]);
// RemoveAt -> give index to remove

//groceries.RemoveAt(1); // removes the second item in the list

groceries.Insert(1, "Bananas"); // shift items after this index up by 1, adds bananas to list
Console.WriteLine(groceries.Count);
Console.WriteLine(groceries[1]);

Console.WriteLine(groceries);

// How do we print out this list!?!?!?!?!?!?

// Foreach Loops! 
// Loops that run once for each item in a collection
// rather than specifically having an index (i) like previous loops, we have an object that we can look at and engage with
// foreach(type item in collection){
//  code to run on the item
// }
foreach(var instructor in instructors)
{
    Console.WriteLine(instructor);
}

// sometimes its nice to have access to the index of a particular item as well as the item itself. So, we can replicate the function
// of a foreach loop using a for loop. 
// same example as above, but with a for loop:
// collection.Length if array, collection.Count if list
for ( var i = 0; i < instructors.Length; i++)
{
    Console.WriteLine(instructors[i]);
}
// instructors[i] in a for loop is the same as the var instructor in a foreach loop

// Dictionaries
// collections of key value pairs
// keys - how we access elements
// values - the values we get in return 

var weather = new Dictionary<string, float>();
weather["Atlanta"] = 82.3f; // key is atlanta, and the value is 82.3f
weather["Cleveland"] = 71f;
Console.WriteLine(weather["Atlanta"]); // accessing the value at "atlanta"

Console.WriteLine(weather.Count);

// report is a keyvaluepair object, meaning we have access to both the keys and values as we go through each item in
// our weather dictionary
foreach(var report in weather)
{
    Console.WriteLine("Temperature: " + report.Key);
}