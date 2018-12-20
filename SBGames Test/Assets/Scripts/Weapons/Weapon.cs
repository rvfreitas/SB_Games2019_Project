using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class Weapon : ScriptableObject {

    public float force, reloadTime, knockbackTick, damage;

    public Sprite wpnSprite;

    public GameObject Bullet;
	

    public void shoot(Transform playerPos)
    {

        GameObject bullet = Instantiate<GameObject>(Bullet, playerPos.position,playerPos.rotation);
        bullet.GetComponent<BulletBehaviour>().shoot(force);

    }

}
