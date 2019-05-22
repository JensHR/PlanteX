using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootStrike : Ability
{

    public float Damage;
    public float Range;
    public float CooldownTime;
    public GameObject Source;

    private float NextFireTime;

    public override void Initialize(Rigidbody rb, GameObject player)
    {
        Debug.Log("cooldown: " + CooldownTime);
        if (Time.time > NextFireTime)
        {
            Damage = player.GetComponent<Player>().AttackDamage;

            //hmmm
            StartCoroutine("SpinToWinBaby", player);
            
            NextFireTime = Time.time + CooldownTime;
        }
    }

    private IEnumerator SpinToWinBaby(GameObject player)
    {
        float degree = Time.time;
        while (degree + 1 < 360)
        {
            Source.transform.RotateAround(player.transform.position, Vector3.up, 360 * Time.deltaTime);
            degree += Time.deltaTime;
        }
        return null;
    }
}
