using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EggHandler : MonoBehaviour
{
    public static float coinValue = 1f;
    public static float coinCount;
    [SerializeField]
    Text coinCounterText;
    // Start is called before the first frame update
    void Start()
    {
        coinCount = PlayerPrefs.GetInt("coinCount", 0);
        PlayerPrefs.Save();
        UpdateText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EggButton()
    {
        Debug.Log("You clicked the button");
        coinCount += coinValue;
        UpdateText();

        PlayerPrefs.SetFloat("coinCount", coinCount); //sets 
        PlayerPrefs.Save();
    }

    void UpdateText()
    {
        if (coinCount != 1)
        {   
            coinCounterText.text = coinCount + " coins";
        }
        else
        {
            coinCounterText.text = coinCount + " coin";
        }
    }
    
    public void ClearProgress()
    {
        PlayerPrefs.DeleteAll();
        coinCount = 0;
        UpdateText();
    }
}
