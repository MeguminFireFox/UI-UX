using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTile : MonoBehaviour
{
    [SerializeField] private List<GameObject> _listTile;
    public void Onrandom()
    {
        _listTile[Random.Range(0, _listTile.Count)].SetActive(true);
    }
}
