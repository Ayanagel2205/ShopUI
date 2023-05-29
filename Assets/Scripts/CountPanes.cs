using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountPanes : MonoBehaviour
{

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


    public int countBoughtIceCreams(GameObject chosenPane)
    {
        int numCreams = 0;

        foreach (Transform creams in chosenPane.transform)
        {
            if (creams.gameObject.activeSelf)
            {
                numCreams++;


            }


        }

        return numCreams;

    }




}
