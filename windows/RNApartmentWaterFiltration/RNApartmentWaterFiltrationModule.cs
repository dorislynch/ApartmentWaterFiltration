using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Apartment.Water.Filtration.RNApartmentWaterFiltration
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNApartmentWaterFiltrationModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNApartmentWaterFiltrationModule"/>.
        /// </summary>
        internal RNApartmentWaterFiltrationModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNApartmentWaterFiltration";
            }
        }
    }
}
