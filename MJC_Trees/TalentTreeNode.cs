using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJC_Trees
{
    class TalentTreeNode
    {
        //FIELDS
        private string abilName;
        private bool learned;
        private TalentTreeNode leftChild;
        private TalentTreeNode rightChild;

        //PROPERTIES
        public TalentTreeNode LeftChild
        {
            get { return leftChild; }
            set { leftChild = value; }
        }
        public TalentTreeNode RightChild
        {
            get { return rightChild; }
            set { rightChild = value; }
        }

        //CONSTRUCTORS
        public TalentTreeNode(string abilName, bool learned)
        {
            this.abilName = abilName;
            this.learned = learned;
        }

        //METHODS
        public void ListAllAbilities()
        {
            //Check for a child on the left branch
            if (leftChild != null)
            {
                leftChild.ListAllAbilities();
            }

            //Print this ability
            Console.WriteLine(abilName);

            //Check for a child on the right branch
            if (rightChild != null)
            {
                rightChild.ListAllAbilities();
            }
        }

        public void ListKnownAbilities()
        {
            if (learned == true)
            {
                //Print this ability
                Console.WriteLine($"Known ability: {abilName}");
            }

            //Check for a child on the left branch
            if (leftChild != null && learned == true)
            {
                leftChild.ListKnownAbilities();
            }

            //Check for a child on the right branch
            if (rightChild != null && learned == true)
            {
                rightChild.ListKnownAbilities();
            }
        }

        public void ListPossibleAbilities()
        {

            if (learned == true)
            {
                //Check for a child on the left branch
                if (leftChild != null)
                {
                    leftChild.ListPossibleAbilities();
                }
            }
            
            if (learned == false)
            {
                //Print this ability
                Console.WriteLine($"Possible ability: {abilName}");
            }

            if (learned == true)
            {
                //Check for a child on the right branch
                if (rightChild != null)
                {
                    rightChild.ListPossibleAbilities();
                }
            }
        }
    }
}
