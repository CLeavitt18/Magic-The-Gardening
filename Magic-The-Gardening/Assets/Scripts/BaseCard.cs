using UnityEngine;

public class BaseCard : MonoBehaviour
{
    public bool isLengend {get { return _isLegend; } private set{}}
    [SerializeField] private bool _isLegend;
    public bool isPermanent {get { return _isPermanent; } private set{}}
    [SerializeField] private bool _isPermanent;
}
