﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="BaseTestContext.cs">
//   Copyright (c) 2018 Aspose.Storage for Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Aspose.Storage.Cloud.Sdk.Tests.Base
{
    using System.IO;

    using Newtonsoft.Json;
    using Aspose.Storage.Cloud.Sdk.Api;


    /// <summary>
    /// Base class for all tests
    /// </summary>
    public abstract class BaseTestContext
    {
        // For some reason ConfigurationManager doesn't work on .Net Core
#if NETCOREAPP2_0

        //Get App key and App SID from https://cloud.aspose.com
        private readonly string _appSid = "";
        private readonly string _appKey = "";
        private readonly string _apiBaseUrl = "http://api-qa.aspose.cloud";

#else

        // It is "test" credentials for "dev" server. Please, don't use them in your application.
        private readonly string _appSid = System.Configuration.ConfigurationManager.AppSettings["AppSID"];
        private readonly string _appKey = System.Configuration.ConfigurationManager.AppSettings["AppKey"];
        private readonly string _apiBaseUrl = System.Configuration.ConfigurationManager.AppSettings["ApiBaseUrl"];

#endif

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseTestContext"/> class.
        /// </summary>
        protected BaseTestContext()
        {
            var configuration = new Configuration { AuthType = AuthType.OAuth2, ApiBaseUrl = _apiBaseUrl, AppSid = _appSid, AppKey = _appKey };
            this.StorageApi = new StorageApi(configuration);
        }

        /// <summary>
        /// Base path to test data        
        /// </summary>
        protected static string BaseTestDataPath
        {
            get
            {
                return "sdktests/dotnet";
            }
        }

        /// <summary>
        /// Base path to output data
        /// </summary>
        protected static string BaseTestOutPath
        {
            get
            {
                return "TestOut";
            }
        }

        /// <summary>
        /// Returns common folder with source test files
        /// </summary>
        protected static string CommonFolder
        {
            get
            {
                return "Common/";
            }
        }
        /// <summary>
        /// Storage API
        /// </summary>
        protected StorageApi StorageApi { get; set; }
        

        /// <summary>
        /// AppSid
        /// </summary>
        protected string AppSid
        {
            get
            {
                return _appSid;
            }
        }

        /// <summary>
        /// AppSid
        /// </summary>
        protected string AppKey
        {
            get
            {
                return _appKey;
            }
        }

        /// <summary>
        /// Returns test data path
        /// </summary>
        /// <param name="subfolder">subfolder for specific tests</param>
        /// <returns>test data path</returns>
        protected static string GetDataDir(string subfolder = null)
        {
            return Path.Combine("TestData", string.IsNullOrEmpty(subfolder) ? string.Empty : subfolder);
        }
        
        private class Keys
        {
            public string AppSid { get; set; }

            public string AppKey { get; set; }
        }
    }
}