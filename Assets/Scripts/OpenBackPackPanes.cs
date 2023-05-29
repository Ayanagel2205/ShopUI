using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBackPackPanes : MonoBehaviour
{

    [SerializeField] GameObject sendItemPane;
    [SerializeField] GameObject closeSendPane;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
        /*if (closeSendPane != null)
        {

            


        }*/
        
        sendItemPane.SetActive(false);


    }
}
