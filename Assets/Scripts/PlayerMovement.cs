using UnityEngine;
using System.Collections;
using UnityEngine.AI;

namespace CompleteProject
{

    public class ClickToMove : MonoBehaviour
    {

        private Animator anim;
        private NavMeshAgent navMeshAgent;
        private Transform targetedSymbol;
        private Ray shootRay;
        private RaycastHit shootHit;
        private bool walking;
        private bool enemyClicked;
        private float nextFire;
        
        void Awake()
        {
            anim = GetComponent<Animator>();
            navMeshAgent = GetComponent<NavMeshAgent>();
        }
        
        void Update()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Input.GetButtonDown("Fire2"))
            {
                if (Physics.Raycast(ray, out hit, 100))
                {
                    if (hit.collider.CompareTag("Symbol"))
                    {
                        targetedSymbol = hit.transform;
                        enemyClicked = true;
                    }

                    else
                    {
                        walking = true;
                        enemyClicked = false;
                        navMeshAgent.destination = hit.point;
                        navMeshAgent.Resume();
                    }
                }
            }

            if (navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance)
            {
                if (!navMeshAgent.hasPath || Mathf.Abs(navMeshAgent.velocity.sqrMagnitude) < float.Epsilon)
                    walking = false;
            }
            else
            {
                walking = true;
            }

            anim.SetBool("IsWalking", walking);
        }

        

    }

}