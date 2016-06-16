using UnityEngine;
using System.Collections;

public class wall_ctr : MonoBehaviour {

	GameObject prefab_wall, wall;
	Vector3 position, rotation;

	// Use this for initialization
	void Start () {
	
	}

	public void create()
	{
		wall = (GameObject)Instantiate (prefab_wall.gameObject, position, Quaternion.identity);
		wall.transform.Rotate (rotation,Space.Self);
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
		prefab_wall = target;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
