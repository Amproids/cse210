public class BreathingActivity : Activity {
    public BreathingActivity(string _activityName, string _startingMessage, string _activityDescription, string _endingMessage) : base(_activityName, _startingMessage, _activityDescription, _endingMessage) {
    }
    public void DoActivity() {
        StartActivity();
        int remainder = _duration % 8;
        int cycles = (_duration - remainder) / 8;
        if (remainder != 0) {
            int initialBreathIn = remainder / 2;
            int initialBreathOut = remainder - initialBreathIn;
            BreathIn(initialBreathIn);
            BreathOut(initialBreathOut);
            Console.WriteLine();
        }
        for (int i = 0; i < cycles; i ++) {
            BreathIn(4);
            BreathOut(4);
            Console.WriteLine();
        }
        EndActivity();
    }

    private void BreathIn(int breathTime) {
        Console.Write("Breath in... ");
        CountdownTimer(breathTime);
    }    
    private void BreathOut(int breathTime) {
        Console.Write("Breath Out... ");
        CountdownTimer(breathTime);
    }
}