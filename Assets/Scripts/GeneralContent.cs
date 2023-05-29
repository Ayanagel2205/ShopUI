using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GeneralContent : MonoBehaviour
{

    [SerializeField]
    private double currentAmount;
    public double CurrentAmount { get { return currentAmount; } }
    [SerializeField] TMP_Text currrencyText;
    // Start is called before the first frame update

    private double testD =200.00;
    private void Awake()
    {
        
        currrencyText.text = $"{currentAmount}$";



    }

    void Start()
    {
        currentAmount = 100.00;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public double getMoneyValue()
    {

        return currentAmount;

    }


    public void setCurrentAmount(double inCurrMount)
    {
        
        currentAmount = inCurrMount;
        currrencyText.text = $"{currentAmount}$";

    }



    public TMP_Text getMoneyText()
    {
        return currrencyText;
    }

   public int countPanels(GameObject paneChosen)
    {
        int numCreams = 0;

        foreach (Transform creams in paneChosen.transform)
        {
            if (creams.gameObject.activeSelf)
            {
                numCreams++;


            }


        }

        return numCreams;



    }

}
