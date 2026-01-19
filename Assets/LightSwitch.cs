using UnityEngine;
using UnityEngine.InputSystem;


[RequireComponent(typeof(Light))]
public class LightSwitch : MonoBehaviour {
    public new Light light;
    public InputActionReference action;

    void Start() 
    {
        light = GetComponent<Light>();
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            light.color = new Color(1f, 0.4f, 0.7f);
        };

    }

}
