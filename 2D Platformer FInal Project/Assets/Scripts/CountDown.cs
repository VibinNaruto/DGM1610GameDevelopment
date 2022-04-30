using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    // These varibeles help the number/text update every frame
    public GameObject textDisplay;
    public int secondsLeft = 30;
    public bool takingAway = false;

    // Start is called before the first frame update
    void Start()
    {
        textDisplay.GetComponent<Text>().text = "00:" + secondsLeft;
    }

    // Update is called once per frame
    void Update()
    {
        if (takingAway == false && secondsLeft > 0)
        {
            // Reference of the Coroutine
            StartCoroutine(TimerTake());
        }
    }

    // So this is a coroutine something we didn't learn but let me explain.
    // What the coroutine does is that it takes the time away so activating it then waiting a second then reducing the time which diplays new time.
    // Then the if else is showing if it's one or two digits then if it is less then 10 put the extra zero if less then don't use zero. 
    IEnumerator TimerTake()
    {
        // Takes time away 
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        if (secondsLeft < 10)
        {
            textDisplay.GetComponent<Text>().text = "00:0" + secondsLeft;
        }
        else 
        {
            textDisplay.GetComponent<Text>().text = "00:" + secondsLeft;
        }
        takingAway = false;
    }
}
