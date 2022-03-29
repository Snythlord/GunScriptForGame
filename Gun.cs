using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    KillEnemy HP;
    public float Speed = 9f;
    [SerializeField] GameObject Player;
    private void Update()
    {
        transform.position += -transform.right * Time.deltaTime * Speed;

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            
            Destroy(gameObject);
        }
    }
    private void Awake()
    {
        HP = Player.GetComponent<KillEnemy>();
    }
}
