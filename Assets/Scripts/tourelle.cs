using UnityEngine;

public class tourelle : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(1f, 0f, 0f, 1);
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(transform.position, 40);
    }
}
