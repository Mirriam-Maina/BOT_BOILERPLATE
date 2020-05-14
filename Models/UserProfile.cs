using System;
namespace EchoBot.Models
{
    public class UserProfile
    {
       public string Name { set; get; }
        public string Bug { set; get; }
        public string PhoneNumber { set; get; }
        public DateTime CallbackTime { set; get; }
        public string Description { get; internal set; }
    }
}
