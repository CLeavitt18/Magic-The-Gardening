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
        ColorType color = baseCard.color[0];
    }
}
