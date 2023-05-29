using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OpenChest : MonoBehaviour
{
    [SerializeField] GameObject panelChestSend;






    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void openChestSendPanel()
    {
        if (panelChestSend != null)
        {
            panelChestSend.SetActive(true);


        }



    }


    public void closeSendChestPanels()
    {
        panelChestSend.SetActive(false);



    }

    










}
