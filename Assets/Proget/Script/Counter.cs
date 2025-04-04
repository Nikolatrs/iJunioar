using System.Collections;
using System;
using UnityEngine;
using UnityEngine.Serialization;

public class Counter : MonoBehaviour
{
    [SerializeField] private float _delay;

    private bool _isCountTrigger = true;
    private int _count = 0;
    private Coroutine _magnifier;

    public event Action<int> Chenged;

    private void Start() => Restart();

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _isCountTrigger = !_isCountTrigger;

            if (_isCountTrigger)
            {
                Restart();
            }
            else
            {
                StopCoroutine(_magnifier);
            }
        }
    }

    private void Restart() => _magnifier = StartCoroutine(MagnifyCount(_delay));

    private IEnumerator MagnifyCount(float delay)
    {
        var wait = new WaitForSecondsRealtime(delay);

        while (true)
        {
            _count += 1;
            Chenged?.Invoke(_count);
            yield return wait;

        }
    }
}
