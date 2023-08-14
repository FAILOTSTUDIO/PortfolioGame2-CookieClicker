using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;

public class Purchaser : MonoBehaviour
{
    [SerializeField]private Manager manager;
    public void OnPurchaseCompleted(Product product)
    {
        switch (product.definition.id)
        {
            case "test1":
                Rebith();
                break;

            case "test2":
                AddBucks1000();
                break;
            case "test3":
                AddBucks1500();
                break;
            case "test4":
                AddBucks2000();
                break;
            case "test5":
                AddBucks2500();
                break;
            case "test6":
                AddBucks3000();
                break;
        }
    }

    private void Rebith()
    {
        manager.BakedCookied = 0;
        manager.money = 0;
        manager.moneybaker.text = "Бюджет:" + manager.money.ToString();
        manager.bakedcookie.text = "Печений приготовлено:" + manager.BakedCookied.ToString();
        Debug.Log("Purchase: get Rebith");
    }

    private void AddBucks1000()
    {

        manager.money += 1000;
        manager.moneybaker.text = "Бюджет:" + manager.money.ToString();
        Debug.Log("Purchase: get 1000 bucsk");
    }
    private void AddBucks1500()
    {
        manager.money += 1500;
        manager.moneybaker.text = "Бюджет:" + manager.money.ToString();
        Debug.Log("Purchase: get 1500 bucsk");
    }
    private void AddBucks2000()
    {
        manager.money += 2000;
        manager.moneybaker.text = "Бюджет:" + manager.money.ToString();
        Debug.Log("Purchase: get 2000 bucsk");
    }
    private void AddBucks2500()
    {
        manager.money += 2500;
        manager.moneybaker.text = "Бюджет:" + manager.money.ToString();
        Debug.Log("Purchase: get 2500 bucsk");
    }
    private void AddBucks3000()
    {
        manager.money += 3000;
        manager.moneybaker.text = "Бюджет:" + manager.money.ToString();
        Debug.Log("Purchase: get 3000 bucsk");
    }
}
