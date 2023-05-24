using System.Collections.Generic;
using UnityEngine;

public class Land : MonoBehaviour
{
    [SerializeField] private BaseCard baseCard;
    [SerializeField] private manaAmount[] mana;

    public bool isBasic {get{ return _isBasic; } private set {}}
    [SerializeField] private bool _isBasic;

    public void TapForMana(Player player)
    {
        ColorType[] color = new ColorType[mana.Length];
        int[] amount = new int[mana.Length];

        for(int i = 0; i < mana.Length; i++)
        {
            color[i] = mana[i].type;
            amount[i] = mana[i].amount;
        }
    }
}
