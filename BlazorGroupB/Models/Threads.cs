using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BlazorGroupB.Models;

public class Threads
{
    public int ThreadID { get; set; }
    public string? ThreadName { get; set; }
    //public string? ThreadUrl { get; set; }
    public string? UserID { get; set; }
    public DateTime ThreadCreateDate { get; set; }
    public DateTime LastPostTime { get; set; }

    //  空のコンストラクタと値を得るコンストラクタ
    public Threads()
    {

    }
    public Threads(int id, string threadName,string userId,
        DateTime threadCreateDate, DateTime lastPostTime)
    {
        this.ThreadID = id;
        this.ThreadName = threadName;
        this.UserID = userId;
        this.ThreadCreateDate = threadCreateDate;
        this.LastPostTime = lastPostTime;
    }
}
