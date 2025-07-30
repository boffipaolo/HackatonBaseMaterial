namespace Hackaton.Scripts.ControlPanel.Lever
{
    /// <summary>
    /// Lever interface that defines the methods for getting and setting the value of a lever.
    /// Any class that implements this interface must provide the logic for these methods.
    /// </summary>
    public interface ILever
    {
        public float GetValue();

        public void SetNewValue(float newValue);
    }
}