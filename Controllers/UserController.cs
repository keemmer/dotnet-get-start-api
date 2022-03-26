using Microsoft.AspNetCore.Mvc;
using demoapi.Models;

namespace demoapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    [Route("all")]
    [HttpGet()]
     public IEnumerable<UserModel> GetUserAll(){

        List<UserModel> userList = new List<UserModel>();
        userList.Add( new UserModel{
             id = 1,
            name = "keemmer1",
            age = 30
        });
         userList.Add( new UserModel{
             id = 2,
            name = "keemmer2",
        });
         userList.Add( new UserModel{
             id = 3,
            name = "keemmer3",
            age = 30
        });

        return userList;
     }
     
    [Route("profile/{id}")]
    [HttpGet]
    public UserModel GetUserById(int id){
        return new UserModel{
            id = id,
            name = "keemmer profile",
            age = 28
        };
    }

    [Route("show")]
    [HttpGet]
    public UserModel GetUserShow(int id,string name,int age){
        return new UserModel{
            id = id,
            name = name,
            age = age
        };
    }

    
    [HttpPost]
    public UserModel CreateUser(UserModel data){
        data.name  += " created";
        return data;
    }

    [HttpPut]
    public String EditUser(UserModel data){
        
        return "edit user " + data.name + " successfully";
    }

    [Route("{id}")]
    [HttpDelete]
    public String DestroyUser(int id){
        return "remove user " + id + " successfully";
    }

}

