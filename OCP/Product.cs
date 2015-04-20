namespace BreakingOpenClosedPrinciple
{
    public class Product
    {
        private readonly ProductType _type;

        public Product(ProductType type)
        {
            _type = type;
        }

        /// <summary>
        /// Render has one behaviour for Standard Products Types, and a different behaviour for Featured Products types. 
        /// </summary>
        public void Render()
        {
            if (Type == ProductType.Standard)
            {
                // Do something
            }

            if (Type == ProductType.Featured)
            {
                //Do something a bit more jazzy
            }
        }

        public ProductType Type
        {
            get { return _type; } 
        }
    }

    #region What's wrong with the above?
// if we add a new ProductType, then we need to modify how this existing code works in order 
// to include the new ProductType.
// What if we add lots more ProductTypes? – We need more and more If statements.
// What if this is not the only thing that varies by ProductType? - We start to duplicate this If block all over our code base.
//
// NB: Don’t fool yourself into thinking that a switch statement is any better – it’s just as bad!
    #endregion 
}
