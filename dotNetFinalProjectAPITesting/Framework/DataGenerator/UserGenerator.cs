namespace dotNetFinalProjectAPITesting.Framework.DataGenerator;

public class UserGenerator
{
    public UserRequest GenerateValidUser()
    {
        return new UserRequest("2pac", $"2pac{Guid.NewGuid()}@testovi.com", "male", "active");
    }

    public UserRequest GenerateUserWithInvalidEmail()
    {
        return new UserRequest("2pac", $"2pac{Guid.NewGuid()}@", "male", "active");
    }

    public UserRequest GenerateUserWithEmptyEmail()
    {
        return new UserRequest("2pac", "", "male", "active");
    }

    public UserRequest GenerateUserWithInvalidGender()
    {
        return new UserRequest("2pac", $"2pac{Guid.NewGuid()}@", "test", "active");
    }

    public UserRequest GenerateUserWithEmptyName()
    {
        return new UserRequest("", $"2pac{Guid.NewGuid()}@", "male", "active");
    }

    public UserRequest GenerateUpdatedValidUser()
    {
        return new UserRequest("2pac Shakur", $"2pac{Guid.NewGuid()}@testovi.com", "male", "active");
    }
}