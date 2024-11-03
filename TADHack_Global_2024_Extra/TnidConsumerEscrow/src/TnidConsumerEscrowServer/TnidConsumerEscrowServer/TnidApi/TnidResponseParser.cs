namespace TnidConsumerEscrowServer.TnidApi;

public static class TnidResponseParser
{
    public static string GetUserFullName(dynamic tnidPeopleSearchApiRequest)
    {
        var responseData = tnidPeopleSearchApiRequest.Data;

        var firstUser = responseData.users[0];

        var usersFirstName = (string)(firstUser.firstName);
        var usersLastName = (string)(firstUser.lastName);
        
        return usersFirstName + " " + usersLastName; 
    }
}