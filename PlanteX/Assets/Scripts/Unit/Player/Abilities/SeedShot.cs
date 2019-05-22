using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedShot : Ability
{
    [Header("Ability variables")]
    public float ShotForce;
    public float CooldownTime;
    public GameObject source;
    public GameObject effectToSpawn;

    private float NextFireTime;

    private void Start()
    {
        NextFireTime = 0;
    }

    public override void Initialize(Rigidbody rb, GameObject player)
    {
        //Debug.Log("nextfiretime: " + NextFireTime);
        //Debug.Log("time.time: " + Time.time);
        //Debug.Log("cooldown: " + CooldownTime);
        //Debug.Log("player.transform.localEulerAngles.y : " + player.transform.localEulerAngles.y);

        if (NextFireTime < Time.time)
        {
            GameObject effect;

            effect = Instantiate(effectToSpawn, source.transform.position, Quaternion.identity);
            effect.GetComponent<SeedShotLogic>().ShotForce = ShotForce;
            effect.GetComponent<SeedShotLogic>().YRotation = player.transform.localEulerAngles.y;
            //ranged attacks deal half off attackDamage
            effect.GetComponent<SeedShotLogic>().Damage = player.GetComponent<Player>().AttackDamage/2;
            NextFireTime = Time.time + CooldownTime;

        }



        //effect.AddComponent<Rigidbody>();
    }
}
