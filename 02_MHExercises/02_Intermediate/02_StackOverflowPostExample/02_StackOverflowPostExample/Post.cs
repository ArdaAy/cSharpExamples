using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_StackOverflowPostExample
{
    class Post
    {
        private int _id;
        private string _title;
        private string _description;
        private string _author;
        private DateTime _creationTime;
        private int _vote;

        public Post(int Id, string Title, string Description, string Author)
        {
            _id = Id;
            _title = Title;
            _description = Description;
            _author = Author;
            _creationTime = DateTime.Now;
        }

        public void UpVote()
        {
            _vote += 1;
        }
        public void DownVote()
        {
            _vote -= 1;
        }

        public override string ToString()
        {
            return "Id:"+_id+
                "\nTitle: " + _title + 
                "\nAuthor: " + _author + 
                "\nCreation Date: " + _creationTime +
                "\nDescription: " + _description + 
                "\nVote: " + _vote;
        }
    }
}
