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
        private User author;
        private string title;
        private string description;
        private Priority priorityType;
        private IList<string> tags;
        private IList<Comment> comments;

        public Issue(User author, string title, string description, Priority priorityType, IList<string> tags, IList<Comment> comments)
        {
            this.Id++;
            this.Author = author;
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

        public User Author
        {
            get
            {
                return this.author;
            }
            set
            {
                this.author = value;
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

        public IList<Comment> Comments
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
