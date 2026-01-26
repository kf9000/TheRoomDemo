using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.InputSystem;

public class Teleport : MonoBehaviour
{
    public InputActionReference action;
    public GameObject room;
    public GameObject outside;
    public GameObject player;
    public bool inRoom = true;

    void Start()
    {
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            if (inRoom)
            {
                player.transform.position = outside.transform.position;
                inRoom = !inRoom;
            }
            else
            {
                player.transform.position = room.transform.position;
                inRoom = !inRoom;
            }
        };
    }

}
