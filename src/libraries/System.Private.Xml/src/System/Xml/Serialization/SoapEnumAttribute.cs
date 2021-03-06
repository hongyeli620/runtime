// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Xml.Serialization
{
    using System;

    [AttributeUsage(AttributeTargets.Field)]
    public class SoapEnumAttribute : System.Attribute
    {
        private string _name;

        public SoapEnumAttribute()
        {
        }

        public SoapEnumAttribute(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name == null ? string.Empty : _name; }
            set { _name = value; }
        }
    }
}
