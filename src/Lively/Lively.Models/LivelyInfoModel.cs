﻿using Lively.Common;
using System;

namespace Lively.Models
{
    /// <summary>
    /// livelyinfo.json wallpaper metadata file structure.
    /// </summary>
    [Serializable]
    public class LivelyInfoModel : ILivelyInfoModel
    {
        public string AppVersion { get; set; }
        public string Title { get; set; }
        public string Thumbnail { get; set; }
        public string Preview { get; set; } //preview clip
        public string Desc { get; set; }
        public string Author { get; set; }
        public string License { get; set; }
        public string Contact { get; set; }
        public WallpaperType Type { get; set; }
        public string FileName { get; set; }
        public string Arguments { get; set; } //start commandline args
        public bool IsAbsolutePath { get; set; } //for auto-generated tile: true, user opened wp's.. FileName will be full file path.

        public LivelyInfoModel()
        {
            AppVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            Title = null;
            Thumbnail = null;
            Preview = null;
            Type = WallpaperType.web;
            FileName = null;
            Desc = null;
            Author = null;
            License = null;
            Contact = null;
            Arguments = null;
            IsAbsolutePath = false;
        }

        public LivelyInfoModel(LivelyInfoModel info)
        {
            AppVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            Title = info.Title;
            Thumbnail = info.Thumbnail;
            Preview = info.Preview;
            Type = info.Type;
            FileName = info.FileName;
            Desc = info.Desc;
            Author = info.Author;
            Contact = info.Contact;
            License = info.License;
            Arguments = info.Arguments;
            IsAbsolutePath = info.IsAbsolutePath;
        }
    }
}
