using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopManager : MonoBehaviour
{

    private Button[] iceCreamButts;
    [SerializeField] GameObject shopCont;
    //[SerializeField] TMP_Text coinValue;
    [SerializeField] GeneralContent genContent;

    //private double currentCash;


    private double vanillaPrice = 5.00;
    private double caramelPrice= 10;
    private double bubblegumPrice= 20.50;
    private double mintPrice= 15.00;
    private double chocolatePrice= 5.50;
    private double strawberryPrice= 5.00;

    [SerializeField] GameObject vanillaObj;
    [SerializeField] GameObject caramelObj;
    [SerializeField] GameObject bubblegumObj;
    [SerializeField] GameObject mintObj;
    [SerializeField] GameObject chocolateObj;
    [SerializeField] GameObject strawberryObj;

    [SerializeField] GameObject vanillaObjBack;
    [SerializeField] GameObject caramelObjBack;
    [SerializeField] GameObject bubblegumObjBack;
    [SerializeField] GameObject mintObjBack;
    [SerializeField] GameObject chocolateObjBack;
    [SerializeField] GameObject strawberryObjBack;


    private void Awake()
    {
        iceCreamButts = new Button[shopCont.transform.childCount];
        populateShopArr();
        //currentCash = genContent.CurrentAmount;
        //coinValue.text = $"{currentCash}$";
    }

   void Update()
    {
        
    }








    public Button[] populateShopArr()
    {
        for (int loop = 0; loop < shopCont.transform.childCount; loop++)
        {

            iceCreamButts[loop] = shopCont.transform.GetChild(loop).GetComponent<Button>();


        }

        return iceCreamButts;


    }


    


    public void clickedVanilla()
    {
        if (genContent.CurrentAmount > vanillaPrice)
        {

            var deprecationAmount = vanillaPrice;
            TakeCash(deprecationAmount);

            vanillaObjBack.SetActive(true);
            vanillaObj.SetActive(false);
        }
    }

    private void TakeCash(double deprecationAmount)
    {
        var newCash = genContent.CurrentAmount - deprecationAmount;
        //genContent.CurrentAmount -= vanillaPrice;
        genContent.setCurrentAmount(newCash);
        genContent.getMoneyText().text = $"{newCash}$";
    }

    public void clickedCaramel()
    {
        if (genContent.CurrentAmount > caramelPrice)
        {
            caramelObjBack.SetActive(true);
            caramelObj.SetActive(false);
            TakeCash(caramelPrice);
            //genContent.CurrentAmount -= caramelPrice;
            //genContent.setCurrentAmount(genContent.CurrentAmount);

            //genContent.getMoneyText().text = $"{genContent.CurrentAmount}$";
        }



    }

    public void clickedBubbleGum()
    {
        if (genContent.CurrentAmount > bubblegumPrice)
        {
            //genContent.CurrentAmount -= bubblegumPrice;
            bubblegumObjBack.SetActive(true);
            bubblegumObj.SetActive(false);
            TakeCash(bubblegumPrice);
            //genContent.setCurrentAmount(genContent.CurrentAmount);

            //genContent.getMoneyText().text = $"{genContent.CurrentAmount}$";
        }
    }


    public void clickedMint()
    {
        if (genContent.CurrentAmount > mintPrice)
        {
            //genContent.CurrentAmount -= mintPrice;
            mintObjBack.SetActive(true);
            mintObj.SetActive(false);
            TakeCash(mintPrice);
            //genContent.setCurrentAmount(genContent.CurrentAmount);

            //genContent.getMoneyText().text = $"{genContent.CurrentAmount}$";


        }



    }


    public void clickedChocolate()
    {
        if (genContent.CurrentAmount > chocolatePrice)
        {
            //genContent.CurrentAmount -= chocolatePrice;
            chocolateObjBack.SetActive(true);
            chocolateObj.SetActive(false);
            TakeCash(chocolatePrice);
            //genContent.setCurrentAmount(genContent.CurrentAmount);

            //genContent.getMoneyText().text = $"{genContent.CurrentAmount}$";


        }



    }



    public void clickedStrawberry()
    {
        if (genContent.CurrentAmount > strawberryPrice)
        {
            //genContent.CurrentAmount -= strawberryPrice;
            strawberryObjBack.SetActive(true);
            strawberryObj.SetActive(false);
            TakeCash(strawberryPrice);
            //genContent.setCurrentAmount(genContent.CurrentAmount);

            genContent.getMoneyText().text = $"{genContent.CurrentAmount}$";


        }
    }
}
