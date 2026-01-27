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
                player.transform.position = new Vector3(outside.transform.position.x, 1, outside.transform.position.z);
                inRoom = !inRoom;
            }
            else
            {
                player.transform.position = new Vector3(room.transform.position.x, 1, room.transform.position.z);
                inRoom = !inRoom;
            }
        };
    }

}
