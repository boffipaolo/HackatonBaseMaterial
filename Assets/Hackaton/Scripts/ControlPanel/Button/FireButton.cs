using Hackaton.Scripts.Utilities;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

namespace Hackaton.Scripts.ControlPanel.Button
{
    public class FireButton : MonoBehaviour
    {
        [SerializeField] private XRBaseInteractable interactable;

        private void OnEnable()
        {
            if (interactable == null)
                interactable = GetComponent<XRBaseInteractable>();

            if (interactable != null)
                interactable.selectEntered.AddListener(OnPokeClick);
        }
        
        private void OnDisable()
        {
            if (interactable != null)
                interactable.selectEntered.RemoveListener(OnPokeClick);
        }

        private void OnPokeClick(SelectEnterEventArgs args)
        {
            // implement here the logic for what happens when the button is clicked
            
            ConsoleLogger.LogMessage(name, "Button clicked!");
        }
    }
}
