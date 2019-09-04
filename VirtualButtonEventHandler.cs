using UnityEngine;
using UnityEngine.Events;
using Vuforia;

[RequireComponent(typeof(VirtualButtonBehaviour))]
public class VirtualButtonEventHandler : MonoBehaviour, IVirtualButtonEventHandler
{
    private VirtualButtonBehaviour buttonBehaviour;

    public UnityEvent buttonPressedEvent;
    public UnityEvent buttonReleasedEvent;
    void Start()
    {
        buttonBehaviour = GetComponent<VirtualButtonBehaviour>();
        buttonBehaviour.RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        buttonPressedEvent?.Invoke();
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        buttonReleasedEvent?.Invoke();
    }
}
