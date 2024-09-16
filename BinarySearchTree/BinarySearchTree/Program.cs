using BinarySearchTree;

public class Program
{
    public static void Main()
    {
        BinarySearchTree<Character> bst = new BinarySearchTree<Character>();

        bst.Insert(new Character("Anna Bortion", 90, 50));
        bst.Insert(new Character("Mike Oochie", 95, 100));
        bst.Insert(new Character("Mike Hunt", 85, 40));
        bst.Insert(new Character("Khansir", 90, 60));  
        bst.Insert(new Character("Zeek Ness en Deeseas", 85, 80));


        var result = bst.Search(new Character("Anna Bortion", 90, 50));

        Console.WriteLine(result != null ? $"Found: {result.Data}" : "Not Found");

        Console.WriteLine("Inorder Traversal:");
        bst.Inorder();

        Thread.Sleep(5000000);
    }

}
