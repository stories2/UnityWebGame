using UnityEngine;
using System.Collections;

public class main_proc : MonoBehaviour {

	public GameObject obj_wall,miku,block;
	public Camera main_cam;

	wall_ctr[,] wall;
	player player_character;
	cam_ctr cam;
	io_ctr io;
	bool r_flag;

	int start_degree_point = 30, block_scale = 40, block_num = 6,distance = 2;

	// Use this for initialization
	void Start () {
	
		init ();
	}

	public void init()
	{
		int limit = block_num, i,t , degree = start_degree_point;
		float r = block_scale / 2 * Mathf.Sqrt(3),x,y;

		io = gameObject.AddComponent<io_ctr> ();
		io.set_degree (degree);
		io.set_movement (3);
		cam = gameObject.AddComponent<cam_ctr> ();
		wall = new wall_ctr[distance,limit];

		r_flag = true;

		for (i = 0; i < distance; i += 1) {
			for (t = 0; t < limit; t += 1) {
				wall[i,t] = gameObject.AddComponent<wall_ctr> ();
			}
		}
		player_character = gameObject.AddComponent<player> ();

		cam.set_cam (main_cam);
		cam.set_pos (new Vector3 (0, 0, -60));
		cam.set_rot (new Vector3 (0, 0, 0));

		for (i = 0; i < distance; i += 1) {
			for (t = 0; t < limit; t += 1) {
				wall [i, t].set_obj (obj_wall);
				x = Mathf.Cos ((t * 60 + degree) * (3.14f / 180)) * r + main_cam.transform.position.x;
				y = Mathf.Sin ((t * 60 + degree) * (3.14f / 180)) * r + main_cam.transform.position.y;
				wall [i,t].set_pos (new Vector3 (x, y,block_scale/2 - block_scale + i*block_scale));
				wall[i,t].set_rot (new Vector3 (0, 0, t*60 + 90 + degree));
				wall [i, t].set_block (block);
				wall[i,t].create ();

				if (t == 4 && i == 1) {
					player_character.set_obj (miku);
					player_character.set_pos (new Vector3 (0, y, 0));
					player_character.set_rot (new Vector3 (0, 180, 0));
					player_character.create ();
				}
			}
		}
		wall [1, 0].set_block_height(2);
	}
	
	// Update is called once per frame
	void Update () {
	
		wall_control ();
	}

	public void wall_control()
	{
		float x, y, r = block_scale / 2 * Mathf.Sqrt (3);
		int degree, i,t,q,limit = block_num,character_status;
		degree = io.get_degree ();
		character_status = io.get_status ();
		if (character_status == 0) 
		{
			player_character.update_rot (new Vector3 (0.0f, 180.0f, 0.0f));
		}
		else if (character_status == 1) 
		{
			player_character.update_rot (new Vector3 (0.0f, 190.0f, 0.0f));
			io.set_status (0);
		} 
		else if (character_status == 2) 
		{
			player_character.update_rot (new Vector3 (0.0f, 170.0f, 0.0f));
			io.set_status (0);
		}
		//Debug.Log ("degree : " + degree);
		for (i = 0; i < distance; i += 1) {
			for (t = 0; t < limit; t += 1) {
				x = Mathf.Cos ((t * 60 + degree) * (3.14f / 180)) * r + main_cam.transform.position.x;
				y = Mathf.Sin ((t * 60 + degree) * (3.14f / 180)) * r + main_cam.transform.position.y;
				wall [i,t].set_pos_rot (new Vector3 (x, y, block_scale/2 - block_scale + i * block_scale), new Vector3 (0, 0, t * 60 + 90 + degree));
			}
		}
	}
}
