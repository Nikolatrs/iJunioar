using System.Collections;
using System;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private float _delay = 0.5f;
    
    private bool _isCountTrigger = true;
    private int _count = 0;

    public event Action<int> TriggerChenged;

    private void Start()
    {
        StartCoroutine(ControlCounter(_delay));
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _isCountTrigger = !_isCountTrigger;
        }
    }

    private IEnumerator ControlCounter(float delay)
    {

        while (_count < 99999)
        {
            if (_isCountTrigger)
            {
                _count += 1;
                TriggerChenged?.Invoke(_count);
                yield return new WaitForSecondsRealtime(delay);
            }
            else
            {
                yield return null;
            }
        }
    }
}
