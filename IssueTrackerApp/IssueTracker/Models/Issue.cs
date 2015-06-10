using IssueTracker.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Models
{
    public class Issue
    {
        private int id = 0;
        private string title;
        private string description;
        private Priority priorityType;
        private IList<string> tags;
        private IList<string> comments;

        public Issue(string title, string description, Priority priorityType, IList<string> tags, IList<string> comments)
        {
            this.Id++;
            this.Title = title;
            this.Description = description;
            this.PriorityType = priorityType;
            this.Tags = tags;
            this.Comments = comments;
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                this.title = value;
            }
        }

        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                this.description = value;
            }
        }

        public Priority PriorityType
        {
            get
            {
                return this.priorityType;
            }
            set
            {
                this.priorityType = value;
            }
        }

        public IList<string> Tags
        {
            get
            {
                return this.tags;
            }
            set
            {
                this.tags = value;
            }
        }

        public IList<string> Comments
        {
            get
            {
                return this.comments;
            }
            set
            {
                this.comments = value;
            }
        }
    }
}
