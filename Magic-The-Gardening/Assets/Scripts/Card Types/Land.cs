using UnityEngine;

public class Land : MonoBehaviour
{
    [SerializeField] private BaseCard baseCard;

    public bool isBasic {get{ return _isBasic; } private set {}}
    [SerializeField] private bool _isBasic;
}
