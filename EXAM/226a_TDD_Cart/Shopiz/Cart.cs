using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopiz
{
    /// <summary>
    /// This class is designed to be a shopping cart
    /// </summary>
    public class Cart
    {
        #region private attributes
        private string _id;
        private string _name;
        private string _currency;
        private List<CartItem> _items;
        #endregion private attributes

        #region public methods
        /// <summary>
        /// This constructor provides a Cart Object
        /// </summary>
        /// <param name="id">cart's unique identifier</param>
        /// <param name="name">cart's name</param>
        /// <param name="cartItems">collection of cart's items. If null, balance will be set to zero.</param>
        public Cart(string id, string name, List<CartItem> cartItems = null)
        {
            _id = id;
            _name = name;
            _items = cartItems is null ? new List<CartItem>() : cartItems;
            _currency = "CHF";
        }

        /// <summary>
        /// This property gets the cart'id.
        /// </summary>
        public string Id
        {
            get => _id;
        }

        /// <summary>
        /// This property gets the cart's name.
        /// </summary>
        public string Name
        {
            get => _name;
        }

        /// <summary>
        /// This property gets the cart's items.
        /// </summary>
        public List<CartItem> CartItems
        {
            get => _items;
        }

        /// <summary>
        /// This property gets the cart's balance (sum of item's unit price).
        /// </summary>
        public double Balance
        {
            get => _items.Sum(item => item.UnitPrice);
        }

        /// <summary>
        /// This property gets the cart's currency.
        /// </summary>
        public string Currency
        {
            get => _currency;
        }

        /// <summary>
        /// This method adds a list of cart item in the current cart.
        /// </summary>
        /// <param name="cartItemsToAdd">List of cart items to add</param>
        public void AddItems(List<CartItem> cartItemsToAdd)
        {
            _items.AddRange(cartItemsToAdd);
        }

        /// <summary>
        /// This method empty the cart. It removes all items from the cart.
        /// </summary>
        public void Empty()
        {
            if (_items.Count <= 0) throw new EmptyCartException();
            _items.Clear();
        }
        #endregion public methods

        #region private methods
        #endregion private methods
    }

    public class CartException : Exception { }
    public class EmptyCartException : CartException { }
}
