using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ResetScene : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Transform spawnPoint;
    public GameObject centralTableLimits;
    //Reset current scene
    public void ResetMainScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    public void SpawnRandomObject()
    {
        var size = GameObject.Find("GrassTableField7").GetComponent<Collider>().bounds.size;

        Vector3 center = new Vector3(centralTableLimits.transform.position.x, 1, centralTableLimits.transform.position.z);

        var px = Random.Range(-size.x / 2, size.x / 2);
        var pz = Random.Range(-size.z / 2, size.z / 2);

        Vector3 pos = center + new Vector3(px, spawnPoint.position.y, pz);
        Instantiate(objectToSpawn.transform, pos, Quaternion.identity, spawnPoint);
    }
}
