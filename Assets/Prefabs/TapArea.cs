using UnityEngine;
using UnityEngine.EventSystems;

public class TapArea : MonoBehaviour, IPointerDownHandler
{
    public AudioSource playSound;

    public void OnPointerDown(PointerEventData eventData)
    {
        playSound.Play();
        GameManager.Instance.CollectByTap(eventData.position, transform);
    }
}
