using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingButtons : MonoBehaviour
{
    public static int multipliersOwned;
    public int multiplierCost = 8;
    [SerializeField]
    Text multiCounterText;
    // Start is called before the first frame update
    void Start()
    {
        multipliersOwned = PlayerPrefs.GetInt("multipliersOwned", 0);
        PlayerPrefs.Save();
        UpdateText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Mine2xValue()
    {
        EggHandler.coinValue *= 2;
        multipliersOwned += 1;
        UpgradeCost();
        UpdateText();
        PlayerPrefs.SetFloat("multipliersOwned", multipliersOwned); //sets 
        PlayerPrefs.Save();
    }

    public void UpgradeCost()
    {
        EggHandler.coinCount -= multiplierCost;
        UpdateText();
        multiplierCost *= 2;
    }

    void UpdateText()
    {
        if (multipliersOwned != 1)
        {
            multiCounterText.text = "Owned: " + multipliersOwned + " mines";
        }
        else
        {
            multiCounterText.text = "Owned: " + multipliersOwned + " mine";
        }
    }
}
