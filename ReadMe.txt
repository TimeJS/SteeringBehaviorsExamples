For this assignment, I started by experimenting with all of the different behaviors to see what 
each one did. A lot of them didn't see to be of too much consequence, or had behaviors which we 
wouldn't  want. 

One of the core things I landed on was keeping the wander script, but increasing the values of 
Wander Radius, Wander Distance, and Wander Jitter significantly. Getting stuck on walls is one of
the worst things that can happen in the Tag scenario, and making all of these values higher made it
so that the ball wouldn't remain stuck in anyone place for too long. 

Then, I added o n the Flee script which appeared to make the ball run more. 

Finally, me and some classmates noticed that the Evade script, which would hypothetically be the
most useful, never actually set a target to evade. So I created a new script which sets this value based
on the closest target, allowing it to function. This new script "Evade Target Selector" never actually
effects the Player ball's movement, it just allows the Evade script itself to function. I hope this
fits into the "planning" category which we were allowed to right code for. 

The ball can pretty consistently score over 10,000, and usually gets either 12,000 or 11800 which 
are the two highest scores (when the timer is set to 60 seconds)