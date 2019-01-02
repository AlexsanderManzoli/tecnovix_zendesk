using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Zendesk.Tecnovix.RNZendeskTecnovix
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNZendeskTecnovixModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNZendeskTecnovixModule"/>.
        /// </summary>
        internal RNZendeskTecnovixModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNZendeskTecnovix";
            }
        }
    }
}
