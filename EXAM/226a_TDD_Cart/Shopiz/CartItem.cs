using System;

namespace Shopiz
{
    /// <summary>
    /// This class is designed to be a shopping cart item
    /// </summary>
    public class CartItem
    {
        #region private attributes
        #endregion private attributes

        #region public methods
        /// <summary>
        /// This constructor provides a Cart Object
        /// </summary>
        /// <param name="id"></param>
        /// <param name="longDescription"></param>
        /// <param name="unitPrice"></param>
        public CartItem(string id, string longDescription, double unitPrice)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This property gets the cartitem's id
        /// </summary>
        public string Id
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// This property gets the cartitem's long description
        /// </summary>
        public string LongDescription
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// This property gets and set the CartItem's unit price
        /// </summary>
        /// <exception cref="TooSmallValueException">When unit price to set is smaller than 1.00</exception>
        public double UnitPrice
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// This property gets the cart's currency
        /// </summary>
        public string Currency
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        #endregion public methods

        #region private methods
        #endregion private methods
    }

    public class CartItemException : Exception { }
    public class TooSmallValueException : CartItemException { }
}
