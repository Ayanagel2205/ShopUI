using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChosenShopFlavour : MonoBehaviour
{

    [SerializeField] GeneralContent grandGenCOnt;
    [SerializeField] ShopManager grandShopMan;
    [SerializeField] double flavourPrice; 
    [SerializeField] GameObject flavourButton;
    [SerializeField] GameObject backPackCorrespond;

    private int currentPaneCount;
    private int spendingLimit = 3;
    private int increaseSpace;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        


        
    }


    public void purchaseIceCream()
    {

        


        if(grandGenCOnt.CurrentAmount> flavourPrice)
        {
            
            
        double currentSpendature = grandGenCOnt.CurrentAmount - flavourPrice;
        grandGenCOnt.setCurrentAmount(currentSpendature);

        flavourButton.SetActive(false);
        backPackCorrespond.SetActive(true);


        }


    }











}
