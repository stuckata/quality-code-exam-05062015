using IssueTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Engine
{
    public class Dispatcher
    {
        private Endpoint action;

        public Dispatcher(Endpoint action)
        {
            this.Action = action;
        }

        public Endpoint Action
        {
            get
            {
                return this.action;
            }
            set
            {
                this.action = value;
            }
        }
    }
}
