using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord
{
  class Message
  {
    public bool IsUser { get; set; }
    public string Name { get; set; }
    public string Content { get; set; }
    public string Avatar { get; set; }

    public Message(bool isUser, string content)
    {
      IsUser = isUser;
      Content = content;
    }

    public Message(bool isUser, string name, string content, string avatar)
    {
      IsUser = isUser;
      Name = name;
      Content = content;
      Avatar = avatar;
    }

  }
}
