using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Models
{
    public class Endpoint
    {
        private string actionName;
        private string[] parameters;

        public Endpoint(string actionName, string[] parameters)
        {
            this.ActionName = actionName;
            this.Parameters = parameters;
        }

        public string ActionName
        {
            get
            {
                return this.actionName;
            }
            set
            {
                this.actionName = value;
            }
        }

        public string[] Parameters
        {
            get
            {
                return this.parameters;
            }
            set
            {
                this.parameters = value;
            }
        }
    }
}
