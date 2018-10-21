using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;
    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;

    private Vector3 offset;	

	void Start () 
	{
		offset = transform.position - player.transform.position;
	}
	
	void LateUpdate () 
	{
        float x = Mathf.Clamp(player.transform.position.x, xMin, xMax);
        float y = Mathf.Clamp(player.transform.position.x, yMin, yMax);
        gameObject.transform.position = new Vector3(x, y, gameObject.transform.position.z);
	}
}
