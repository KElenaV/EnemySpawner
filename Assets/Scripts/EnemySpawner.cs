using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyTemplate;

    private List<Transform> _points;

    private void Start()
    {
        _points = new List<Transform>();

        foreach (var children in transform)
        {
            _points.Add(children as Transform);
        }

        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        Enemy enemy = Instantiate(_enemyTemplate, _points[Random.Range(0, _points.Count)]);
        yield return new WaitForSeconds(2);
        Destroy(enemy.gameObject);
        StartCoroutine(Spawn());
    }
}
