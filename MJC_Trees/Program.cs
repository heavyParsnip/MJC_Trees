using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJC_Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate nodes
            TalentTreeNode magic = new TalentTreeNode("Magic", true);
            TalentTreeNode fireball = new TalentTreeNode("Fireball", true);
            TalentTreeNode crazyBigFireball = new TalentTreeNode("Crazy Big Fireball", false);
            TalentTreeNode oneThousandTinyFireballs = new TalentTreeNode("1000 Tiny Fireballs", true);
            TalentTreeNode magicArrow = new TalentTreeNode("Magic Arrow", false);
            TalentTreeNode iceArrow = new TalentTreeNode("Ice Arrow", false);
            TalentTreeNode explodingArrow = new TalentTreeNode("Exploding Arrow", false);

            //Set relationships
            magic.LeftChild = fireball;
            magic.RightChild = magicArrow;
            fireball.LeftChild = crazyBigFireball;
            fireball.RightChild = oneThousandTinyFireballs;
            magicArrow.LeftChild = iceArrow;
            magicArrow.RightChild = explodingArrow;

            //Call methods on root node
            Console.WriteLine("--Listing all ablities in the game--");
            magic.ListAllAbilities();
            Console.WriteLine();

            Console.WriteLine("--Listing all learned ablities--");
            magic.ListKnownAbilities();
            Console.WriteLine();

            Console.WriteLine("--Listing all ablities that can currently be learned--");
            magic.ListPossibleAbilities();
            Console.ReadLine();
        }
    }
}
