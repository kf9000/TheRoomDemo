using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class MoonRotate : MonoBehaviour
{
    public float degreesPerSecond = 50.0f;
    public GameObject planet;

    void Update()
    {
        planet.transform.Rotate(0, degreesPerSecond * Time.deltaTime, 0);
    }
}
