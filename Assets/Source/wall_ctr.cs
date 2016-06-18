using UnityEngine;
using System.Collections;

public class wall_ctr : MonoBehaviour {

	GameObject prefab_wall, wall,prefab_block;
	Vector3 position, rotation;
	int block_num;
	queue_block queue;

	// Use this for initialization
	void Start () {
		block_num = 0;
	}

	public void set_block(GameObject block)
	{
		prefab_block = block;
	}
		
	public Vector3 get_rot()
	{
		return rotation;
	}

	public Vector3 get_pos()
	{
		return position;
	}

	public int get_block_height()
	{
		return block_num;
	}

	public Vector3 get_wall_scale()
	{
		return wall.transform.localScale;
	}

	public void set_block_height(int height)
	{
		block_num = height;
		Vector3 vec = new Vector3 (get_wall_scale ().x, 2*(get_wall_scale ().x / 2 * Mathf.Sqrt (3))/3, get_wall_scale ().x);
		Debug.Log (vec);
		int i;
		for (i = 0; i < block_num; i += 1) {
			queue.add ();
			queue.get_rear ().set_obj (prefab_block);
			queue.get_rear ().create ();
			queue.get_rear ().set_scale (vec);

		}
	}

	public void create()
	{
		wall = (GameObject)Instantiate (prefab_wall.gameObject, position, Quaternion.identity);
		wall.transform.Rotate (rotation);

		queue = gameObject.AddComponent<queue_block> ();
	}

	public void set_pos_rot(Vector3 pos,Vector3 rot)
	{
		position = pos;
		wall.transform.position = pos;
		//wall.transform.Rotate(rot);
		rotation = rot;
		wall.transform.rotation = Quaternion.Euler(0.0f,0.0f,rot.z);
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
