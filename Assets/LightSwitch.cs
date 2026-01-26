using UnityEngine;
using UnityEngine.InputSystem;


[RequireComponent(typeof(Light))]
public class LightSwitch : MonoBehaviour {
    public new Light light;
    public InputActionReference action;
    private bool isLightChanged = false;

    void Start() 
    {
        light = GetComponent<Light>();
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            if(isLightChanged == false)
            {
                light.color = new Color(0.0f, 1.0f, 1.0f);
                isLightChanged = true;
            }
            else
            {
                light.color = new Color(1.0f, 1.0f, 1.0f);
                isLightChanged = false;
            }
        };

    }

}
