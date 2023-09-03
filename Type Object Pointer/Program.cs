using System;

//ref link:https://www.youtube.com/watch?v=OWnGnqIfIcI&list=PLRwVmtr-pp07XP8UBiUJ0cyORVCmCgkdA&index=32
//  see project -- what's in the box

// C# --CSC--> MSIL --JIT--> Machine Languange
//  MSIL(MS intermidiate langauge) - boxing/unboxing
//  Machine Languange - Stack/Heap

//  Heap -> 2 extra datamembers -- 1. sync block index - required threading knowledge , 2. type object pointer - requires reflection knowledge
//type object pointer -- allows us and CLR runtime(.NET runtime) to know about the actual type of object at runtime
// parenthetical cast - is/as -- null(as)

class Cow
{
    public int mooCount;
}

class MainClass
{
    static void Main()
    {
        Type t;         // reflection knowledge - for Type definition 
        Cow betsy = new Cow();
        betsy.GetType();    // type object pointer shares references

        betsy.mooCount = 9;
        Cow georgy = new Cow();
        georgy.mooCount = 3;

        MainClass m = new MainClass();
    }
}