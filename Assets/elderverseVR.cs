using UnityEngine;

public class elderverseVR : MonoBehaviour
{
    void Start()
    {
        GameObject orb = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        orb.name = "ElderverseOrb";
        orb.transform.position = new Vector3(0f, 1f, 0f);
        orb.transform.localScale = Vector3.one * 0.5f;
        orb.GetComponent<Renderer>().material.color = new Color(0.35f, 0.2f, 0.9f);
    }
}
