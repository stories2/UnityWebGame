using UnityEngine;
using System.Collections;

public class block_ctr : MonoBehaviour {

	GameObject block_prefab,block_obj;
	Vector3 position,rotation;
	block_ctr next_block_link;

	// Use this for initialization
	void Start () {
	
		next_block_link = null;
	}

	public block_ctr get_next_block()
	{
		return next_block_link;
	}

	public void set_next_block(block_ctr next)
	{
		next_block_link = next;
	}

	public void set_scale(Vector3 scale)
	{
		block_obj.transform.localScale = scale;
	}

	public void set_pos_rot(Vector3 pos,Vector3 rot)
	{
		block_obj.transform.position = pos;
		//wall.transform.Rotate(rot);
		block_obj.transform.rotation = Quaternion.Euler(0.0f,0.0f,rot.z);
	}

	public void create()
	{
		block_obj = (GameObject)Instantiate (block_prefab.gameObject, position, Quaternion.identity);
		block_obj.transform.Rotate (rotation,Space.Self);


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
		block_prefab = target;
	}
	// Update is called once per frame
	void Update () {
	
	}
}
