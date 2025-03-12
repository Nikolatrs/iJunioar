using TMPro;
using UnityEngine;

public class CounterViver : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textCounter;
    [SerializeField] private Counter _counter;

    private void OnEnable()
    {
        _counter.TriggerChenged += CengeTrigger;
    }

    private void OnDisable()
    {
        _counter.TriggerChenged -= CengeTrigger;
    }

    private void CengeTrigger(int count)
    {
        _textCounter.text = count.ToString("");
    }
}
