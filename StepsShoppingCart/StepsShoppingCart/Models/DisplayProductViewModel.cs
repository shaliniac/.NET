using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StepsShoppingCart.Models
{
    public class DisplayProductViewModel
    {
        
            /// <summary>
            /// Gets or sets the employee view model list.
            /// </summary>
            /// <value>
            /// The employee view model list.
            /// </value>
            public IList<ProductViewModel> ProductViewModelList { get; set; }

            
    }
}