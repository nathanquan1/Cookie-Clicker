using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class cookie_script : MonoBehaviour
{
    public int cookiesPerClick = 1;
    public int cookiesPerSecond = 0;
    public int cookies = 0;

    public int frames = 0;
    public int cookieMultiplier = 1;

    //Starting costs:
    public int perClickCost = 20;
    public int perSecondCost = 20;
    public int multiplierCost = 500;

    //Variables connecting to the text mesh pro UI
    public TextMeshProUGUI cookieText;
    public TextMeshProUGUI perSecondUpgrade; 
    public TextMeshProUGUI perClickUpgrade;
    public TextMeshProUGUI multiplyUpgrade;

    // Start is called before the first frame update
    void Start()
    {
        cookieText.text = "Cookies: " +cookies.ToString();
        perSecondUpgrade.text = "+1 Cookies/Second Cost: "+ perSecondCost.ToString();
        perClickUpgrade.text = "+1 Cookies/Click Cost: "+perClickCost.ToString();
        multiplyUpgrade.text = (cookieMultiplier+1)+"X Cookies/Click Cost: "+ multiplierCost.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //Fix to make it every second
        if (frames % 205 ==0)
        {
            cookies += cookiesPerSecond;
        }
        
        //text
        cookieText.text = "Cookies: " +cookies.ToString();
        perSecondUpgrade.text = "+1 Cookies/Second Cost: "+perSecondCost.ToString();
        perClickUpgrade.text = "+1 Cookies/Click Cost: "+perClickCost.ToString();
        multiplyUpgrade.text = (cookieMultiplier+1)+"X Cookies/Click Cost: "+ multiplierCost.ToString();

        frames += 1;
    }

    //Function for when cookie button is clicked
    public void clickCookie()
    {
        cookies += cookiesPerClick*cookieMultiplier;
    }

    //Function for when +1 Cursor Clicks button is clicked and +1 Cookies per second
    public void cookieUpgradeClick()
    {
        //Cost will be : Amount of upgrades +20
        if (cookies >= perClickCost)
        {
            cookies -= perClickCost;
            cookiesPerClick +=1;
            perClickCost = cookiesPerClick +19;
        }
        
        
    }
    public void cookieAutoUpgradeClick()
    {
        if (cookies >= perSecondCost)
        {
            cookies -= perSecondCost;
            cookiesPerSecond += 1;
            perSecondCost = cookiesPerSecond + 19;
        }
    }
//Adds 1x every time (1x,2x,3x)
    public void cookieMultiplyClick()
    {
        if (cookies >= multiplierCost)
        {
            cookies -= multiplierCost; 
            cookieMultiplier += 1;
            multiplierCost*= 4;
        }
        
    }

}
