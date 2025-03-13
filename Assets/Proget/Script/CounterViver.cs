using TMPro;
using UnityEngine;

public class CounterViver : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textCounter;
    [SerializeField] private Counter _counter;

    private void OnEnable() => _counter.Chenged += ChengeTrigger;

    private void OnDisable() => _counter.Chenged -= ChengeTrigger;

    private void ChengeTrigger(int count) => _textCounter.text = count.ToString("");
}
