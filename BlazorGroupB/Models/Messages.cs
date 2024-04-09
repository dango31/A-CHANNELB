using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BlazorGroupB.Models;

public class Messages
{
    public int MessageID { get; set; }
    public int ThreadId { get; set; }
    public string? UserID { get; set; }
    public string WriteName { get; set; }
    public string? DetailMessage { get; set; }
    public int MessageNumber { get; set; }
    public DateTime PostTime { get; set; }

    

}
