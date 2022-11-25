﻿using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Net.Http.Headers;


namespace Syncfusion.EJ2.FileManager.Base
{
    public class FileManagerDirectoryContent
    {
        public string Path { get; set; }

        public string Action { get; set; }

        public string NewName { get; set; }

        public string[] Names { get; set; }

        public string[] RenameFiles { get; set; }

        public string TargetPath { get; set; }

        public FileManagerDirectoryContent TargetData { get; set; }

        public string Name { get; set; }

        public long Size { get; set; }

        public byte[] Content { get; set; }

        public string PreviousName { get; set; }

        public string DateModified { get; set; }

        public string DateCreated { get; set; }

        public bool HasChild { get; set; }

        public bool IsFile { get; set; }

        public string Type { get; set; }

        public string Id { get; set; }

        public string FilterPath { get; set; }

        public string FilterId { get; set; }

        public IList<IFormFile> UploadFiles { get; set; }


        public bool CaseSensitive { get; set; }

        public bool isRoot { get; set; }

        public string SearchString { get; set; }

        public bool ShowHiddenItems { get; set; }

        public string IconClass { get; set; }

        public string NodeId { get; set; }

        public string ParentId { get; set; }

        public bool Selected { get; set; }

        public string Icon { get; set; }
     
        public FileManagerDirectoryContent[] Data { get; set; }


    }
}