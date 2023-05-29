using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BackPackManager : MonoBehaviour
{
    [SerializeField] GeneralContent genContentBackPack;
    [SerializeField] ChosenShopFlavour choseFlave;
    [SerializeField] double resellPrice;


    [SerializeField] GameObject boughtFlave;
    [SerializeField] GameObject correspondingShopFlave;
    [SerializeField] GameObject correspondingChestFlave;
    
    /*[SerializeField] GameObject chocPane;
    [SerializeField] GameObject bubblePane;
    [SerializeField] GameObject caramelPane;
    [SerializeField] GameObject vanillaPane;
    [SerializeField] GameObject mintPane;
    [SerializeField] GameObject strawPane;

    [SerializeField] GameObject chocObj;
    [SerializeField] GameObject bubbleObj;
    [SerializeField] GameObject caramelObj;
    [SerializeField] GameObject vanillaObj;
    [SerializeField] GameObject mintObj;
    [SerializeField] GameObject strawObj;

    [SerializeField] GameObject chocObjBack;
    [SerializeField] GameObject bubbleObjBack;
    [SerializeField] GameObject caramelObjBack;
    [SerializeField] GameObject vanillaObjBack;
    [SerializeField] GameObject mintObjBack;
    [SerializeField] GameObject strawObjBack;*/






    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void returnFlavour()
    {
        double returnValue = genContentBackPack.CurrentAmount + resellPrice;
        genContentBackPack.setCurrentAmount(returnValue);





    }







}
