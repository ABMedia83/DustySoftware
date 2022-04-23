using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dusty
{
    /// <summary>
    /// Preset for Json to be created via a Record type class 
    /// </summary>
    public abstract record JsonRecord: IJsonFormat,IJsonString
    {

        /// <summary>
        /// Convert Record to Json string
        /// </summary>
        /// <returns></returns>
        public string ToJsonString() => Serialize(this);

        /// <summary>
        /// Get or set the Format Name 
        /// </summary>
        public string Format { get; init; }
        /// <summary>
        /// Get or set the Description of the format 
        /// </summary>
        public string Description { get; init; }

        /// <summary>
        /// Get or set the Author's name 
        /// </summary>
        public string Author { get; init; }
    }
}
