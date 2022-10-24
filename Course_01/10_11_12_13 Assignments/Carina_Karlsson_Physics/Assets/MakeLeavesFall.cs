using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeLeavesFall : MonoBehaviour
{

    public GameObject leavesParticles;
    ParticleSystem makeLeavesFall;

    private void Start()
    {
        makeLeavesFall = FindObjectOfType<ParticleSystem>();
    }

    private void OnMouseOver()
    {
        makeLeavesFall.Play(leavesParticles);
    }

    private void OnMouseExit()
    {
        makeLeavesFall.Stop(leavesParticles);
    }


}
