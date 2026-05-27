using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InteractionController : MonoBehaviour
{
    private HashSet<IInteractable> interactablesInRange = new HashSet<IInteractable>();

    void OnTriggerEnter2D(Collider2D other)
    {
        IInteractable interactable = other.GetComponent<IInteractable>();
        if (interactable != null)
        {
            interactablesInRange.Add(interactable);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        IInteractable interactable = other.GetComponent<IInteractable>();
        if (interactable != null)
        {
            interactablesInRange.Remove(interactable);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            foreach (IInteractable interactable in interactablesInRange)
            {
                interactable.Interact();
                return;
            }

            Debug.Log("상호작용 가능한 오브젝트가 없습니다.");
        }
    }
}
