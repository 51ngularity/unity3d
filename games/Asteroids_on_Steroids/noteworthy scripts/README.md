
when using Turn_to_mouse_cursor_2d on an object with rigidbody2d it is recommended to enable freze_rotation_z in rigidbody2d/constraints

Add_force_towards_object has a constant component force_const and force_linear, a component, which scales linearly with the distance to the target. 

Hide_behind_cover teleports the object to the position behind cover. for best results it should be used on a empty object. the object intended to take cover should then use the force_linear of Add_force_towards_object to be pushed towards the epty object.

the asteroids use Add_force_orthogonal_to_target and the force_linear from Add_force_towards_object with a little bit of linear friction to create chaotic movement, which is still bound. notably using force_const generates unbound orbits. 

the alien fighter ship uses Hide_behind_cover, then when the base is destroyed - Keep_distance_to_target and Add_force_orthogonal_to_target
