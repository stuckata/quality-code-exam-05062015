using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Interfaces
{
    public interface IUser
    {
        void CreateIssue();
        void DeleteIssue();
        void SearchForIssue();
        void AddIssueComment();
    }
}
