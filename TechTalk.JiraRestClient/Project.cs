using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TechTalk.JiraRestClient
{
    public class ProjectCategory
    {
        public string self {get; set;}
        public string id {get; set;}
        public string name {get; set;}
        public string description {get; set;}
    }

    public class Project
    {
        public string self {get; set;}
        public string id {get; set;}
        public string key {get; set;}
        public string name {get; set;}
        public ProjectCategory projectCategory { get; set; }
    }
}
