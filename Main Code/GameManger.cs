using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManger : MonoBehaviour
{
    public int clicks = 0;
    public TMP_Text clickText;
    public int clickPower = 1;
    public TMP_Text multiplierText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        clickText.text = "Cheese: " + (clicks * clickPower);
        multiplierText.text = "Multiplyer: " + clickPower;
    }
    
    public void Click()
    {
        clicks++;
    }

    public void Sell()
    {
        clicks = 0;
        clickPower += 1;
        clickText.text = "Clicks: " + clicks;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
