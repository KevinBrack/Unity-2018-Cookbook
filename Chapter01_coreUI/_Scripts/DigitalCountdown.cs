using UnityEngine;
using UnityEngine.UI;

public class DigitalCountdown : MonoBehaviour {
	private Text textClock;
	private CountdownTimer countdownTimer;
	
	void Awake () {
		textClock = GetComponent<Text>();
		countdownTimer = GetComponent<CountdownTimer>();
	}

	void Start () {
		countdownTimer.ResetTimer(30);
	}

	void Update () {
		int timeRemaining = countdownTimer.GetSecondsRemaining();
		string message = TimerMessage(timeRemaining);
		textClock.text = message;
	}

	private string TimerMessage(int secondsLeft) {
		if(secondsLeft <= 0) {
			return "Countdown has finished";
		} else {
			return "Countdown seconds remaining = " + secondsLeft;
		}
	}

}