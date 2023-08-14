using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Abilka", menuName = "Abilka Data", order = 51)]
public class StoreScriptableObject : ScriptableObject
{
    [SerializeField]
    private string AbilkaName;
    [SerializeField]
    private string description;
    [SerializeField]
    private Sprite icon;
    [SerializeField]
    private int Cost;
    [SerializeField]
    private bool TwoClick;
    [SerializeField]
    private bool IsAutoClick;

    public bool AutoClick
    {
        get
        {
            return IsAutoClick;
        }
    }


    public bool IsTwoClick
    {
        get
        {
            return TwoClick;
        }
    }

    public string AbilName
    {
        get
        {
            return AbilkaName;
        }
    }

    public string Description
    {
        get
        {
            return description;
        }
    }

    public Sprite Icon
    {
        get
        {
            return icon;
        }
    }

    public int cost
    {
        get
        {
            return Cost;
        }
    }
}
