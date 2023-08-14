using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilkaDataRead : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip buyClip;
    [SerializeField] private StoreScriptableObject storeScriptObj;
    [SerializeField] private Image img;
    [SerializeField] private Text Name;
    [SerializeField] private Text Cost;
    [SerializeField] private Manager manager;
    private void Start()
    {
        img.sprite = storeScriptObj.Icon;
        Name.text = storeScriptObj.AbilName;
        Cost.text = storeScriptObj.cost.ToString() + " ֱ‏הזועא";
    }

    public void Buy()
    {
       if(manager.money > storeScriptObj.cost)
        {
            audioSource.PlayOneShot(buyClip);
            if(storeScriptObj.AutoClick == true && manager.money >= 60)
            {
                manager.AutoClickAbilka = true;
            }
            if (manager.TwoClickAbilka == false)
            {
                manager.money -= storeScriptObj.cost;
                manager.moneybaker.text = "ֱ‏הזוע:" + manager.money.ToString();
            }
            if (storeScriptObj.IsTwoClick == true)
            {
                manager.TwoClickAbilka = true;
            }
        }
    }

   
}
