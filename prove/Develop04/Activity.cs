public class Activity {
    protected string _activityName;
    protected string _startingMessage;
    protected string _activityDescription;
    protected string _endingMessage;
    protected int _duration;

    public Activity(string activityName, string startingMessage, string activityDescription, string endingMessage) {
        _activityName = activityName;
        _startingMessage = startingMessage;
        _activityDescription = activityDescription;
        _endingMessage = endingMessage;
    }

    public void StartActivity() {
        Console.Clear();
        Console.WriteLine(_startingMessage);
        Console.WriteLine();
        Console.WriteLine(_activityDescription);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get Ready...");
        Pause(3);
    }

    public void EndActivity() {
        Console.WriteLine(_endingMessage);
        Pause(2);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName}.");
        Pause(3);
    }
    protected void Pause(float pauseDuration) {
        string[] framesArray = {"|", "/", "-", "\\"};
        float pauseTime = 0;
        while (pauseTime < pauseDuration) {
            for (int i = 0; i < framesArray.Length; i ++) {
                Console.Write($"{framesArray[i % 4]}");
                Thread.Sleep(250);
                pauseTime += 0.25F;
                Console.Write("\b");
            }
        }
        Console.WriteLine(" ");
    }
    protected void CountdownTimer(int seconds) {
        for (int t = seconds; t > 0; t -- ) {
            int secondsCharacterLength = t.ToString().Length;
            Console.Write($"{t} ");
            Thread.Sleep(1000);
            for (int i = 0; i < secondsCharacterLength + 1; i ++) {
                Console.Write("\b");
            }
        }
        Console.WriteLine(" ");
    }
}