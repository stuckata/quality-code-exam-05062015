using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Models
{
    public class User
    {
        private string username;
        private string password;
        private bool isLogged;

        public User(bool isLogged, string username = "guest", string password = "")
        {
            this.Username = username;
            this.Password = password;
            this.IsLogged = isLogged;
        }

        public string Username
        {
            get
            {
                return this.username;
            }
            set
            {
                this.username = value;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
            }
        }

        public bool IsLogged
        {
            get
            {
                return this.isLogged;
            }
            set
            {
                this.isLogged = value;
            }
        }

        public void RegisterUser()
        {

        }

        public void Login()
        {

        }

        public void Logout()
        {

        }

        public void CreateIssue()
        {

        }

        public void DeleteIssue()
        {

        }

        public void SearchForIssue()
        {

        }

        public void AddCommentForIssue()
        {

        }
    }
}
