//

// Why FSharp?
// Teaches you a new way of thinking about programming
// Makes you a better programmer no matter what language you use
// 

//From the blog F# for fun and profit
// Scott Wlaschin

// let's try a toy problem
// define the square function
let square x = x * x

// define the sumOfSquares function
let sumOfSquares n = 
   [1..n] |> List.map square |> List.sum

// How would we do this using old-style C#?
//public static class SumOfSquaresHelper
//{
//   public static int Square(int i)
//   {
//      return i * i;
//   }
//
//   public static int SumOfSquares(int n)
//   {
//      int sum = 0;
//      for (int i = 1; i <= n; i++)
//      {
//         sum += Square(i);
//      }
//      return sum;
//   }
//}

//Note
//The F# code is more compact
//The F# code didn’t have any type declarations
//F# can be developed interactively



// using new C
//public static class FunctionalSumOfSquaresHelper
//{
//   public static int SumOfSquares(int n)
//   {
//      return Enumerable.Range(1, n)
//         .Select(i => i * i)
//         .Sum();
//   }
//}

//The first three things are still true
//In F# you never see loops like this
//F# in general has 1/3 the LOC as C# (less code=less errors, more code visible on screen, etc)


// My own stuff
//How F# code evolves
//Let's say we have a list of dogs, breeds, and ages
type Dog=
    {
        Name:string
        Breed:string
        Age:int 
    }
let myDogs=[
    {Name="Spot";Breed="Beagle";Age=12}
    ;{Name="Rover";Breed="Black Labrador";Age=1}
    ;{Name="Roxie";Breed="Irish Setter";Age=7}
    ;{Name="Plato";Breed="Golden Retriever";Age=3}
    ;{Name="Ginger";Breed="Mutt";Age=9}
    ;{Name="Fido";Breed="Cockerspaniel";Age=5}
    ;{Name="Rufus";Breed="German Shepherd";Age=2}
    ]
// Note it already knows the type without my having to specify it
// Immutable by default
// Non-null by default
// Structural equality by default
// Can't have uninitialized variables
// Eliminates a ton of defensive programming
// there are a lot of new code smells, (like one of the above)

// Predictable Code: Can you understand the code using only what you can see right now (no diving into the codebase, using tools, etc)


[<EntryPoint>]
let main argv = 
    let sumOfSquaresTo10=sumOfSquares 10
    printfn "The sum of squares up to 10 is: %d" sumOfSquaresTo10
    0