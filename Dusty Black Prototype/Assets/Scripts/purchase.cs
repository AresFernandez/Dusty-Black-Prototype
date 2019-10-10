using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class purchase : MonoBehaviour, ISelectHandler
{
    public GameObject selector;
    public int option=1;

    public void OnSelect(BaseEventData eventData)
    {
        selector.GetComponent<StrategySelector>().Purchase(selector.GetComponent<StrategySelector>().slot.GetComponent<Base>().BaseType,option);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
