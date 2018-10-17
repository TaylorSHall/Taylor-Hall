using UnityEngine;
using UnityEngine.Events;

namespace Scenes.Move_Scripts
{
    [CreateAssetMenu]
    public class AddValue : ScriptableObject
    {
        public FloatData Data;
        public FloatData MaxValue;
        public FloatData MinValue;
    
    
        public UnityEvent EventMin;
        public UnityEvent EventMax;
    
    
        //ADD
        public void AddValueToObj(FloatData obj)
        {
            Data.Value += obj.Value;
        
            if (Data.Value >= MaxValue.Value)
            {
                EventMax.Invoke();
            }

            if (Data.Value <= MinValue.Value)
            {
                EventMin.Invoke();
            }
        }
        //SUBTRACT
        public void SubtractValueFromObj(FloatData obj)
        {
            Data.Value -= obj.Value;
            
            if (Data.Value >= MaxValue.Value)
            {
                EventMax.Invoke();
            }

            if (Data.Value <= MinValue.Value)
            {
                EventMin.Invoke();
            }
        }
        
        //MULTIPLY
        public void MultiplyValueWithObj(FloatData obj)
        {
            Data.Value *= obj.Value;
            
            if (Data.Value >= MaxValue.Value)
            {
                EventMax.Invoke();
            }

            if (Data.Value <= MinValue.Value)
            {
                EventMin.Invoke();
            }
        }
        
        //DIVIDE
        public void DivideValueByObj(FloatData obj)
        {
            Data.Value /= obj.Value;
            
            if (Data.Value >= MaxValue.Value)
            {
                EventMax.Invoke();
            }

            if (Data.Value <= MinValue.Value)
            {
                EventMin.Invoke();
            }
        }
    }
}
