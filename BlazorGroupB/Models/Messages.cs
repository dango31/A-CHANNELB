using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BlazorGroupB.Models;

public class Messages
{
    public int MessageID { get; set; }
    public int ThreadID { get; set; }
    public string? UserID { get; set; }
    public string WriteName { get; set; }
    public string? DetailMessage { get; set; }
    public int MessageNumber { get; set; }
    public DateTime PostTime { get; set; }

    //  空のコンストラクタと値を得るコンストラクタ
    public Messages()
    {

    }
    public Messages(int messageId, int threadId, string userId, string writeName, 
        string detailMessage, int messageNumber, DateTime postTime)
    {
        this.MessageID = messageId;
        this.ThreadId = threadId;
        this.UserID = userId;
        this.WriteName = writeName;
        this.DetailMessage = detailMessage;
        this.MessageNumber = messageNumber;
        this.PostTime = postTime;
    }

}
