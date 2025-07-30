using Hackaton.Scripts.Utilities.XR;
using UnityEngine;

namespace Hackaton.Scripts.ControlPanel.Lever
{
    public class Lever : MonoBehaviour, ILever
    {
        [SerializeField] public GameObject controlPanel;
        [SerializeField] public bool hasDisplay = true;
        [SerializeField] public GameObject display;
        
        //private IDisplay _display;
        //private ControlPanel _controlPanel;
        private float _value = 0f;
        private XRSlider _xrSlider;
        
        public float Value => _value;

        public void Awake()
        {
            _xrSlider = GetComponent<XRSlider>();
            //_display = Display.GetComponent<IDisplay>();
            //_controlPanel = ControlPanel.GetComponent<ControlPanel>();
        }

        public void Update()
        {
            UpdateDisplay();
            
            /*
            if (_controlPanel.active)
            {
                _xrSlider.enabled = true;
            }
            else
            {
                _xrSlider.enabled = false;
            }
            */
        }

        private void UpdateDisplay()
        {
            //if (HasDisplay) _display.UpdateDisplay(_value);
        }

        public void UpdateByXR()
        {
            _value = _xrSlider.value;
        }
        
        // ILever methods
        public float GetValue()
        {
            return _value;
        }

        public void SetNewValue(float result)
        {
            _value = result;
            _xrSlider.value = _value;
        }
    }
}