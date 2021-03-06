﻿//-----------------------------------------------------------------------
// <copyright file="FacebookApiEventArgs.cs" company="Thuzi LLC (www.thuzi.com)">
//    Copyright 2011
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//      http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
// </copyright>
// <author>Nathan Totten (ntotten.com), Jim Zimmerman (jimzimmerman.com) and Prabir Shrestha (prabir.me)</author>
// <website>https://github.com/facebook-csharp-sdk/facbook-csharp-sdk</website>
//-----------------------------------------------------------------------

namespace Facebook
{
    using System;
    using System.ComponentModel;

    /// <summary>
    /// Represents the Facebook api event args.
    /// </summary>
    public class FacebookApiEventArgs : AsyncCompletedEventArgs
    {
        /// <summary>
        /// The result.
        /// </summary>
        private readonly object _result;

        /// <summary>
        /// Initializes a new instance of the <see cref="FacebookApiEventArgs"/> class.
        /// </summary>
        /// <param name="error">
        /// The error.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        /// <param name="result">
        /// The result.
        /// </param>
        public FacebookApiEventArgs(Exception error, bool cancelled, object userState, object result)
            : base(error, cancelled, userState)
        {
            _result = result;
        }

        /// <summary>
        /// Get the json result.
        /// </summary>
        /// <returns>
        /// The json result.
        /// </returns>
        public object GetResultData()
        {
            RaiseExceptionIfNecessary();
            return _result;
        }
    }
}
