using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class AnimationSettings : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] NavMeshAgent agent;
    [SerializeField] float BattleCrySpeed = 0.7f;
    [SerializeField] GameObject rollTarget;

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Speed", agent.velocity.magnitude);
        animator.SetFloat("ActionSpeed", BattleCrySpeed);
        BattleCry();
        Roll();
    }

    private void BattleCry()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            animator.SetTrigger("Battlecry");
            agent.ResetPath();
        }
    }

    private void Roll()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
        {
            animator.SetTrigger("Roll");
            agent.ResetPath();
            agent.Move(rollTarget.transform.position);
        }
    }
}
