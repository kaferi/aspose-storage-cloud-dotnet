// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="StorageApiTests.cs">
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

using Aspose.Storage.Cloud.Sdk.Api;
using Aspose.Storage.Cloud.Sdk.Model;
using Aspose.Storage.Cloud.Sdk.Model.Requests;
using Aspose.Storage.Cloud.Sdk.Tests.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Aspose.Storage.Cloud.Sdk.Tests
{
    /// <summary>
    ///  Class for testing StorageApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestClass]
    public class StorageApiTests : BaseTestContext
    {
        private readonly string dataFolder = BaseTestDataPath;
        private readonly string storageName = "StorageName";
        private readonly string destStorageName = "DestStorageName";

        /// <summary>
        /// Test StorageGetDiscUsage
        /// </summary>
        [TestMethod]
        public void StorageGetDiscUsageTest()
        {
            GetDiscUsageRequest request = new GetDiscUsageRequest();
            request.Storage = storageName;
            var response = StorageApi.GetDiscUsage(request);
            Assert.AreEqual(200, response.Code);
        }

        /// <summary>
        /// Test StorageGetIsExist
        /// </summary>
        [TestMethod]
        public void StorageGetIsExistTest()
        {
            GetIsExistRequest request = new GetIsExistRequest();
            request.Path = Path.Combine(dataFolder, "folder1");
            request.Storage = storageName;
            request.VersionId = null;
            var response = StorageApi.GetIsExist(request);
            Assert.AreEqual(200, response.Code);
            Assert.IsTrue(Convert.ToBoolean(response.FileExist.IsExist));
        }

        /// <summary>
        /// Test StorageGetIsStorageExist
        /// </summary>
        [TestMethod]
        public void StorageGetIsStorageExistTest()
        {
            GetIsStorageExistRequest request = new GetIsStorageExistRequest();
            request.Name = storageName;
            var response = StorageApi.GetIsStorageExist(request);
            Assert.AreEqual(200, response.Code);
            Assert.IsTrue(Convert.ToBoolean(response.IsExist));
        }

        /// <summary>
        /// Test StorageGetListFileVersions
        /// </summary>
        [TestMethod]
        public void StorageGetListFileVersionsTest()
        {
            GetListFileVersionsRequest request = new GetListFileVersionsRequest();
            request.Path = "folder2/TestFile1.pdf";
            request.Storage = storageName;
            var response = StorageApi.GetListFileVersions(request);
            Assert.AreEqual(200, response.Code);
            Assert.IsNotNull(response.FileVersions);
        }

        /// <summary>
        /// Test FileDeleteFile
        /// </summary>
        [TestMethod]
        public void FileDeleteFileTest()
        {
            DeleteFileRequest request = new DeleteFileRequest();
            request.Path = Path.Combine(dataFolder, "TestFile.pdf");
            request.Storage = storageName;
            request.VersionId = null;
            var response = StorageApi.DeleteFile(request);
            Assert.AreEqual(200, response.Code);
        }

        /// <summary>
        /// Test FileGetDownload
        /// </summary>
        [TestMethod]
        public void FileGetDownloadTest()
        {
            GetDownloadRequest request = new GetDownloadRequest();
            request.Path = Path.Combine(dataFolder, "TestFile.pdf");
            request.Storage = storageName;
            request.VersionId = null;
            var response = StorageApi.GetDownload(request);
            Assert.IsNotNull(response);
        }

        /// <summary>
        /// Test FilePostMoveFile
        /// </summary>
        [TestMethod]
        public void FilePostMoveFileTest()
        {
            PostMoveFileRequest request = new PostMoveFileRequest();
            request.Src = Path.Combine(dataFolder, "TestFile1.pdf");
            request.Storage = storageName;
            request.Dest = Path.Combine(dataFolder, "TestFile2.pdf");
            request.DestStorage = destStorageName;
            request.VersionId = null;
            var response = StorageApi.PostMoveFile(request);
            Assert.AreEqual(200, response.Code);

        }

        /// <summary>
        /// Test FilePutCreate
        /// </summary>
        [TestMethod]
        public void FilePutCreateTest()
        {
            string path = Path.Combine(dataFolder, "folder2/TestFile1.pdf");
            PutCreateRequest request = new PutCreateRequest();
            request.Path = Path.Combine(dataFolder, "folder4/TestFile1.pdf");
            request.File = StorageApi.GetDownload(new GetDownloadRequest(path, null, storageName));
            request.Storage = destStorageName;
            request.VersionId = null;
            var response = StorageApi.PutCreate(request);
            Assert.AreEqual(200, response.Code);

        }

        /// <summary>
        /// Test FilePutCopy
        /// </summary>
        [TestMethod]
        public void FilePutCopyTest()
        {
            PutCopyRequest request = new PutCopyRequest();
            request.Path = Path.Combine(dataFolder, "/folder2/TestFile1.pdf");
            request.Storage = storageName;
            request.VersionId = null;
            request.Newdest = Path.Combine(dataFolder, "folder3/TestFile1.pdf");
            request.DestStorage = destStorageName;
            var response = StorageApi.PutCopy(request);
            Assert.AreEqual(200, response.Code);

        }

        /// <summary>
        /// Test FolderDeleteFolder
        /// </summary>
        [TestMethod]
        public void FolderDeleteFolderTest()
        {
            DeleteFolderRequest request = new DeleteFolderRequest();
            request.Path = Path.Combine(dataFolder, "folder1");
            request.Recursive = true;
            request.Storage = storageName;
            var response = StorageApi.DeleteFolder(request);
            Assert.AreEqual(200, response.Code);
        }

        /// <summary>
        /// Test FolderGetListFiles
        /// </summary>
        [TestMethod]
        public void FolderGetListFilesTest()
        {
            GetListFilesRequest request = new GetListFilesRequest();
            request.Path = Path.Combine(dataFolder, "folder2");
            request.Storage = storageName;
            var response = StorageApi.GetListFiles(request);
            Assert.AreEqual(200, response.Code);
        }

        /// <summary>
        /// Test FolderPostMoveFolder
        /// </summary>
        [TestMethod]
        public void FolderPostMoveFolderTest()
        {
            PostMoveFolderRequest request = new PostMoveFolderRequest();
            request.Src = Path.Combine(dataFolder, "folder1");
            request.Storage = storageName;
            request.Dest = Path.Combine(dataFolder, "folder2");
            request.DestStorage = destStorageName;
            var response = StorageApi.PostMoveFolder(request);
            Assert.AreEqual(200, response.Code.Value);
        }

        /// <summary>
        /// Test FolderPutCreateFolder
        /// </summary>
        [TestMethod]
        public void FolderPutCreateFolderTest()
        {
            PutCreateFolderRequest request = new PutCreateFolderRequest();
            request.Path = Path.Combine(dataFolder, "folder1");
            request.Storage = storageName;
            request.DestStorage = destStorageName;
            var response = StorageApi.PutCreateFolder(request);
            Assert.AreEqual(200, response.Code);
        }

        /// <summary>
        /// Test FolderPutCopyFolder
        /// </summary>
        [TestMethod]
        public void FolderPutCopyFolderTest()
        {
            PutCopyFolderRequest request = new PutCopyFolderRequest();
            request.Path = Path.Combine(dataFolder, "folder1");
            request.Storage = storageName;
            request.Newdest = "folder4/folder3/folder1";
            request.DestStorage = destStorageName;
            var response = StorageApi.PutCopyFolder(request);
            Assert.AreEqual(200, response.Code);
        }

    }

}
