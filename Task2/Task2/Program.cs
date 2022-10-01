using System;


namespace Task2 
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            // Create structure
            Branch root = new Branch();
            (root.branches).Add(new Branch());
            (root.branches).Add(new Branch());
            (root.branches[0].branches).Add(new Branch());
            (root.branches[1].branches).Add(new Branch());
            (root.branches[1].branches).Add(new Branch());
            (root.branches[1].branches).Add(new Branch());
            (root.branches[1].branches[0].branches).Add(new Branch());
            (root.branches[1].branches[1].branches).Add(new Branch());
            (root.branches[1].branches[2].branches).Add(new Branch());
            (root.branches[1].branches[1].branches[0].branches).Add(new Branch());

            // Pass structure into DepthOfStructure method and print out depth
            Console.Write("Depth of provided structure is: " + Branch.DepthOfStructure(root));
        }
    }
}