using UnityEngine;
using JU.CharacterSystem.AI;

public class tourelle : MonoBehaviour
{
    public JU_AI_PatrolCharacter patrol;
    
    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(1f, 0f, 0f, 1);
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(transform.position, patrol.FieldOfView.Distance);
    }
}
