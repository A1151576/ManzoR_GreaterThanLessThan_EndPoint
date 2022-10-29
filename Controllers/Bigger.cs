/*
Rafael Manzo
Greater Than Less than
10/25/2022
Peer Review:Manuel L., I like the how he layed out the code and how it preforms, very unique on how he did, great job :)
*/
using Microsoft.AspNetCore.Mvc;

namespace ManzoR_GreaterThanLessThan_EndPoint.Controllers;

[ApiController]
[Route("[controller]")]
public class BiggerController : ControllerBase
{
   [HttpGet]
    [Route("Maths/{name}/{num1}/{num2}")]
    public string BigOrSmall(string name, string num1, string num2)
    {
        int num1a = int.Parse(num1);
        int num2a = int.Parse(num2);
        if (num1a < num2a)
        {
            return $"Hello, {name} your first number is less than the second";
        }
        else if (num1a > num2a)
        {
            return $"Hello, {name} your first number is greater than the second";
        }
         else 
        {
         return $"Hello {name} your two numbers are equal.";
        }
    }



}
