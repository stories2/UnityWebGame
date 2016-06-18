using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

	GameObject miku,playground_miku;
	Vector3 position, rotation;
	// Use this for initialization
	void Start () {
	
	}

	public void update_rot(Vector3 target)
	{
		playground_miku.transform.rotation = Quaternion.Euler(0.0f,target.y,0.0f);
	}

	public void create()
	{
		playground_miku = (GameObject)Instantiate (miku.gameObject, position, Quaternion.identity);
		playground_miku.transform.Rotate (rotation,Space.Self);
	}

	public void set_rot(Vector3 target)
	{
		rotation = target;
	}

	public void set_pos(Vector3 target)
	{
		position = target;
	}

	public void set_obj(GameObject target)
	{
		miku = target;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
