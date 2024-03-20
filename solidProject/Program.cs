using System.Diagnostics.Contracts;
using solidProject.User;

internal class Program
{
    private static void Main(string[] args)
    {
        ILog logger = new ConsoleLog();
        logger.writeLog("First log ... ");

        UserRepository userRepo = new UserRepository();
        userRepo.writeLog("Hi user repository");

        string line = Console.ReadLine();
    }
}

// ------------------------------
public class UserRepository : AbstractUserRepository, ILog
{
    public override int prop2 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public override void Add(User user)
    {
        if (user is null)
        {
            throw new ArgumentNullException(nameof(user));
        }

        throw new NotImplementedException();
    }

    public override void Edit(User user)
    {
        // new code for edit ...
        // or 
        // call base class:    base.Edit(user);
    }

    public void writeLog(string log)
    {
        // ...
    }
}


// ------------------------------
public class ConsoleLog : ILog
{
    public void writeLog(string log)
    {
        System.Console.WriteLine(log);
    }
}

public class DatabaseLog : ILog
{
    public void writeLog(string log)
    {
        throw new NotImplementedException();
    }
}

// ------------------------------

// ------------------------------