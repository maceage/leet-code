namespace LeetCode.Problems;

public class AWSProblem
{
    /**
    badging_records_hour.txt
    -----
    username, minute_past_hour, action
    bob, 0, in
    bob, 10, out
    alice, 8, in
    alice, 30, in
    nathan, 40, out
    alice, 42, in
    alice, 43, out

    Process file. Identify two scenarios:

        1. Users who entered the room without badging in
            nathan
        
        2. Users who exited the room without badging out
            alice
*/

    public class BadgingProblem
    {
        BadgingRecords records = File.ReadAllText("badging_records_hour.txt");

        sortedRecords = records.Sort(r => r.username).ThenBy(r => minute_past_hour);

        //UserAction userAction = new UserAction { Minute, Action };

        Dictionary<string, Stack<int, string>> usersAndActions = new Dictionary<string, Queue<UserAction>>();
    
    foreach(var record in records) {
        string username = record.username;
        string previousUsername;
        
        if(username != previousUsername) {
            Queue<UserAction> actionsStack = new Queue<UserAction>();

        UserAction userAction = new UserAction { Minute = record.minute_past_hour, Action = record.action };

        actionsQueue.Enqueue(userAction);
            
            usersAndActions.Add(record.username, actionsStack);
            
            previousUsername = username;
        }
    }
    
    List<string> usersWithoutBadgingIn = new List<string>();
    List<string> usersWithoutBadgingOut = new List<string>();
    
    foreach(var key in userActions.Keys) {
        var actionsQueue = userAction[key].Actions;

var previousAction = null
        do
        {
            var currentAction = actionsQueue.Dequeue();
            
            if(previousAction == null)
            {
                if(action.action == "out") {
                    usersWithoutBadgingIn.Add(key);
                }
            }
            else
{
    if (previousAction == "in")
    {
        if (action.action == "in")
        {
            usersWithoutBadgingOut.Add(key)
        }
    }
    else if (previousAction == "out")
    {
        if (action.action == "out")
        {
            usersWithoutBadgingIn.Add(key)
        }
    }
}

previousAction = currentAction;
        }
    }
}
}