using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackPackItem : MonoBehaviour
{


    [SerializeField] GeneralContent genContBckPck;
    [SerializeField] ChosenShopFlavour choseFlave;
    [SerializeField] double resellPrice;

    //[SerializeField] GameObject sendItemPane;
    //[SerializeField] GameObject closeSendPane;


    [SerializeField] GameObject boughtFlave;
    [SerializeField] GameObject correspondingShopFlave;
    [SerializeField] GameObject correspondingChestFlave;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*public void openSendItemsPane()
    {
        if(sendItemPane != null)
        {
            sendItemPane.SetActive(true);

        }


    }

    public void closeSendItemPane()
    {
        if(closeSendPane != null)
        {
            
            sendItemPane.SetActive(false);


        }
        

    }*/
    
    
    
    
    public void returnFlavour()
    {
        double returnValue = genContBckPck.CurrentAmount + resellPrice;
        genContBckPck.setCurrentAmount(returnValue);

        boughtFlave.SetActive(false);
        correspondingShopFlave.SetActive(true);





    }

    public void saveToChest()
    {
        boughtFlave.SetActive(false);
        correspondingChestFlave.SetActive(true);

    }
}
