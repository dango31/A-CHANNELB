using Microsoft.AspNetCore.Identity;
namespace BlazorGroupB.Models;

public class Users
{
    //  ユーザーID
    public string UserID { get; set; }

    //  ユーザーエージェント
    public string UserAgent { get; set; }

    //  作成日
    public DateTime UserCreateDate { get; set; }
    

}
