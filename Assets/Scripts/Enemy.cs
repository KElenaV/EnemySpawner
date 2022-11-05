using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int _lifetime;

    private void Start()
    {
        _lifetime = GetComponentInParent<EnemySpawner>().SpawnInterval;
        Disappear();
    }

    private void Disappear()
    {
        Destroy(gameObject, _lifetime);
    }
}
