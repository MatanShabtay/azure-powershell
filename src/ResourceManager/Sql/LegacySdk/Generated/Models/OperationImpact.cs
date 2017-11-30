// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.Sql.LegacySdk.Models
{
    /// <summary>
    /// Represents impact of an operation, both in absolute and relative terms.
    /// </summary>
    public partial class OperationImpact
    {
        private double? _changeValueAbsolute;
        
        /// <summary>
        /// Optional. Gets the absolute impact to dimension.
        /// </summary>
        public double? ChangeValueAbsolute
        {
            get { return this._changeValueAbsolute; }
            set { this._changeValueAbsolute = value; }
        }
        
        private double? _changeValueRelative;
        
        /// <summary>
        /// Optional. Gets the relative impact to dimension (null if not
        /// applicable)
        /// </summary>
        public double? ChangeValueRelative
        {
            get { return this._changeValueRelative; }
            set { this._changeValueRelative = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. Gets the name of the impact dimension.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private string _unit;
        
        /// <summary>
        /// Optional. Gets the unit in which estimated impact to dimension is
        /// measured.
        /// </summary>
        public string Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the OperationImpact class.
        /// </summary>
        public OperationImpact()
        {
        }
    }
}
