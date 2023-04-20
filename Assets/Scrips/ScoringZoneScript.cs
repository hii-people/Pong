using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ScoringZoneScript : MonoBehaviour
{
    public EventTrigger.TriggerEvent scoreTrigger;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //BallScript ballScript = collision.gameObject.GetComponent<BallScript>();

        //if (ballScript != null)
        //{
        //}

        if (collision.gameObject.TryGetComponent(out BallScript ballScript))
        {
            BaseEventData eventData = new BaseEventData(EventSystem.current);
            scoreTrigger.Invoke(eventData);
        }
    }
}
