using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_App.DTO
{
    public class User
    {
        public int user_id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string image { get; set; }


        public User()
        {
            this.user_id = 0;
            this.username = string.Empty;
            this.password = string.Empty;
            this.email = string.Empty;
            this.name = string.Empty;
            this.age = 0;
            this.image = string.Empty;
        }
        public User(int id, string userName, string passWord, string Email, string Name, int Age, string Image)
        {
            this.user_id = id;
            this.username = userName;
            this.password = passWord;
            this.email = Email;
            this.name = Name;
            this.age = Age;
            this.image = Image;
        }

        public override string ToString()
        {
            return "[user_id = " + user_id.ToString() + ", username = " + username + ", password = " + password
                + ", email = " + email + ", name = " + name + ", age = " + age.ToString() + ", image = "
                + image + "]";
        }
    }
}
