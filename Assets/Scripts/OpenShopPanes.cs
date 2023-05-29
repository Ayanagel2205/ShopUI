using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OpenShopPanes : MonoBehaviour
{

    [SerializeField] GameObject shopPane;
    [SerializeField] GameObject backPane;
    [SerializeField] GameObject chestPane;

    [SerializeField] GameObject sendItemPane;
    [SerializeField] GameObject closeSendPane;


    private bool isOpen;


    private void Awake()
    {
        




    }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void openShopPanels()
    {

        if (shopPane != null) {

            shopPane.SetActive(true);
            isOpen = true;
        
        
        }
        /*else if(isOpen){


            shopPane.SetActive(false);
            isOpen = false;



        }*/





    }


    public void openBackPackPane()
    {

        if (backPane != null)
        {
            backPane.SetActive(true);


        }





    }

    public void openChestPane()
    {


        if (chestPane != null)
        {
            chestPane.SetActive(true);


        }



    }

    public void openSendItemsPane()
    {
        if (sendItemPane != null)
        {
            sendItemPane.SetActive(true);

        }


    }

    public void closeSendItemPane()
    {
        if (closeSendPane != null)
        {

            sendItemPane.SetActive(false);


        }


    }





}
