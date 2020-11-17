using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Toys
{
    class ToyBox
    {

        public List<Toy> Toys { get; set; }

        public ToyBox()
        {
            Toys = new List<Toy>();
        }

        public Toy GetRandomToy ( )
        {
            // generate a random number between 0 and the # of the toys in the Toys property

            //get the toy object at the index of the random # you generated
            
            //return the toy from the second step
        }
    }
}
