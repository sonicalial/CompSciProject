# Karl Frogley A level Computer Science Project 

# Goals

My goal is to create a simple topdown shooter with AI that can learn/ adapt to the users playstyle.

# Planning:

I chose Unity due to its in built rendering and collision detection systems as well as it being simpler than Unreal Engine but just as powerful. I chose Unity over Visual Studio as Visual Studio is not as suited for game development as unity and even though I am more familier and would reqire less outside information to be able to complete each step

# Report

Due to my inexperence with unity each step takes longer than expected. I struggled to make obstacles that are able to stop the player so my solution was to cause a trigger on contact with an obstacle to temporarily inverse the controls, causing the player to be weakly "bounce" off of obstacles. This solution came with the issue that with precise enough inputs the player charater can ignore the obstacles completely. I could not find a work around or solution to this problem so and time encoraged me forward. The "barrel" of the players gun came along relatively nicely, first I teleport it onto the player, next I rotate the rectange so that the long end points toward the mouse and move it slightly toward the mouse so that it only pokes out of one end of the player character. The next thing I worked on was the the bullets that the gun would shoot. I experenced much difficulty with these. Firstly there where issues with spawning them but after fixing those they didnt go anywhere, counted as obstacles would stay forever. I fixed the counting as obstacles issue relatively easily, but the other 2 issues came with more difficulty. At first the despawing code would run once, despawning one single bullet accross the entire runtime, then it would despawn faster the more bullets that existed, this may sound like a positive untill you find out that for some unknown reason the script would always target the most recently spawned bullet, causing the player after a certan point the be unable to fire their gun until they let the other bullets despawn. I managed to divorce the rate of deletion from the amount of bullets in existance but could never figure out how to add momentum to the bullets 

# Testing

I have conducted a series of manuel test that I have sent my teacher that test the following features: movement, collision, aiming, firing the gun and despawning the bullets.