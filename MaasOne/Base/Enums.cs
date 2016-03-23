﻿// ******************************************************************************
// ** 
// **  YahooManaged WebServices
// **  Originally written by Marius Häusler 2012
// **  Now it is maintained by the public community on GitHub
// **  Any contributions will be greatly appreciated.  Please go to be project home below and create a fork, make your change and merge back.
// **  Project Home: https://github.com/RickyGAkl/yahoo-finance-managed
// **  
// ******************************************************************************
// **  
// **  Copyright 2012 Marius Häusler
// **  
// **  Licensed under the Apache License, Version 2.0 (the "License");
// **  you may not use this file except in compliance with the License.
// **  You may obtain a copy of the License at
// **  
// **    http://www.apache.org/licenses/LICENSE-2.0
// **  
// **  Unless required by applicable law or agreed to in writing, software
// **  distributed under the License is distributed on an "AS IS" BASIS,
// **  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// **  See the License for the specific language governing permissions and
// **  limitations under the License.
// ** 
// ******************************************************************************
using System;
using System.Collections.Generic;
using System.Text;


namespace YahooManaged.Base
{
    /// <summary>
    /// Describes the end state of a connection.
    /// </summary>
    /// <remarks></remarks>
    public enum ConnectionState
    {
        /// <summary>
        /// Download process completed successfully without timeout, errors or cancelations
        /// </summary>
        /// <remarks></remarks>
        Success,
        /// <summary>
        /// Download process was canceled by user interaction
        /// </summary>
        /// <remarks></remarks>
        Canceled,
        /// <summary>
        /// Download process reached the setted timeout span
        /// </summary>
        /// <remarks></remarks>
        Timeout,
        /// <summary>
        /// An Error occured during download process
        /// </summary>
        /// <remarks></remarks>
        ErrorOccured
    }

    public enum RequestMethod
    {
        POST,
        GET
    }
}
