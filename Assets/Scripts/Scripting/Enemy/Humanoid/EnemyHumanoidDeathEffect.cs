using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHumanoidDeathEffect : MonoBehaviour
{
    public GameObject deathRH;
    public GameObject deathLH;
    public GameObject deathTorso;
    public GameObject deathRL;
    public GameObject deathLL;

    public Transform referensePointRH;
    public Transform referensePointLH;
    public Transform referensePointTorso;
    public Transform referensePointRL;
    public Transform referensePointLL;
    public int health = 100;

    public LayerMask toTakeDamageFrom;
    private async void OnTriggerEnter(Collider other) {
        Debug.Log("hit-----------------------------------------------------------------------------------------------------------------");
        Weapon w = other.gameObject.GetComponent<Weapon>();
        if(w != null && w.playerName != "Enemy")
            health -= w.damage;
        if (health <= 0) {
            Destroy(Instantiate(deathRH, referensePointRH.position, referensePointRH.rotation), 2f);
            Destroy(Instantiate(deathLH, referensePointLH.position, referensePointLH.rotation), 2f);
            Destroy(Instantiate(deathTorso, referensePointTorso.position, referensePointTorso.rotation), 2f);
            Destroy(Instantiate(deathRL, referensePointRL.position, referensePointRL.rotation), 2f);
            Destroy(Instantiate(deathLL, referensePointLL.position, referensePointLL.rotation), 2f);
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision) {
        Debug.Log("hit Oncollition-----------------------------------------------------------------------------------------------------------------");
        Weapon w = collision.gameObject.GetComponent<Weapon>();
        if(w != null && w.playerName != "Enemy")
            health -= w.damage;
        if (health <= 0) {
            Destroy(Instantiate(deathRH, referensePointRH.position, referensePointRH.rotation), 2f);
            Destroy(Instantiate(deathLH, referensePointLH.position, referensePointLH.rotation), 2f);
            Destroy(Instantiate(deathTorso, referensePointTorso.position, referensePointTorso.rotation), 2f);
            Destroy(Instantiate(deathRL, referensePointRL.position, referensePointRL.rotation), 2f);
            Destroy(Instantiate(deathLL, referensePointLL.position, referensePointLL.rotation), 2f);
            Destroy(gameObject);
        }
    }
}
