
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FolderDeleteFolderRequest.cs">
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
namespace Aspose.Storage.Cloud.Sdk.Model.Requests 
{
  using Aspose.Storage.Cloud.Sdk.Model; 

  /// <summary>
  /// Request model for <see cref="Aspose.Storage.Cloud.Sdk.FolderDeleteFolder" /> operation.
  /// </summary>  
  public class FolderDeleteFolderRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="FolderDeleteFolderRequest"/> class.
        /// </summary>        
        public FolderDeleteFolderRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FolderDeleteFolderRequest"/> class.
        /// </summary>
        /// <param name="path">Folder path e.g. /Folder1</param>
        /// <param name="storage">User&#39;s storage name</param>
        /// <param name="recursive">Remove recursivelly inner folder/files. If false and folder contains data than exception is raised.</param>
        public FolderDeleteFolderRequest(string path, string storage = null, bool? recursive = null)             
        {
            this.path = path;
            this.storage = storage;
            this.recursive = recursive;
        }

        /// <summary>
        /// Folder path e.g. /Folder1
        /// </summary>  
        public string path { get; set; }

        /// <summary>
        /// User's storage name
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Remove recursivelly inner folder/files. If false and folder contains data than exception is raised.
        /// </summary>  
        public bool? recursive { get; set; }
  }
}