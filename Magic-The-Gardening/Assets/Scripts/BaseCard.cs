using UnityEngine;

public class BaseCard : MonoBehaviour
{
    public CardType cardType {get{ return _cardType;} private set{}}
    [SerializeField] private CardType _cardType;
    public ColorType[] color {get{return _color;} private set{}}
    [SerializeField] private ColorType[] _color;

    public bool isLengend {get { return _isLegend; } private set{}}
    [SerializeField] private bool _isLegend;
    public bool isPermanent {get { return _isPermanent; } private set{}}
    [SerializeField] private bool _isPermanent;
}
