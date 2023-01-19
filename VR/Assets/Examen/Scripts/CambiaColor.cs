using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine;

[RequireComponent(typeof(XRGrabInteractable), typeof(Renderer))]
public class CambiaColor : MonoBehaviour
{
    XRBaseInteractable interactable;
    Renderer miRenderer;
    

    protected void OnEnable()
    {
        interactable = GetComponent<XRBaseInteractable>();
        miRenderer = GetComponent<Renderer>();
        interactable.selectEntered.AddListener(OnSelectEntered);
        interactable.activated.AddListener(OnButtonPressed);

    }
    protected virtual void OnSelectEntered(SelectEnterEventArgs args) { CambiaColorEv();}

    protected virtual void OnButtonPressed(ActivateEventArgs args) { CambiaColorActivated();}

    protected void CambiaColorEv()
    {
        Color color = Color.green;
        miRenderer.material.color = color;
    }

    protected void CambiaColorActivated(){
        Color color = Color.white;
        miRenderer.material.color = color;
    }
}
