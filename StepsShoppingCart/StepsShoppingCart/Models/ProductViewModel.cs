using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;



namespace StepsShoppingCart.Models
{
    public class ProductViewModel
    {
/// <summary>
        /// Gets or sets the product name.
        /// </summary>
        /// <value>
        /// The product name.
        /// </value>
        [Required(ErrorMessage = "Product Name is mandatory")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        public string ProductName { get; set; }

        /// <summary>
        /// Gets or sets the product quantity available.
        /// </summary>
        /// <value>
        /// The product quantity.
        /// </value>
        [Required(ErrorMessage = "Product Quantity must be a Number")]
        [RegularExpression(@"^\d$", ErrorMessage = "Use numbers only")]
        public int NumberOfProductsAvailable { get; set; }

            /// <summary>
        /// Gets or sets the product Price.
        /// </summary>
        /// <value>
        /// The product Price.
        /// </value>
        [Required(ErrorMessage = "Product Price must be a number with decimal")]
        [RegularExpression(@"^[0-9]*(?:\.[0-9]*)?$", ErrorMessage = "Use decimal numbers only")]
        public float ProductPrice { get; set; }

    }
}

