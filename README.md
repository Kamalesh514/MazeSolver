# MazeSolver
About Project 
This is a .NET Core2 Web Api Project

About Endpoint 
Once you download and install the project, you should be able to hit the local endpoint at 
http://localhost:8785/api/maze

Body of this endpoint will look like 
{
	"input": "########## #A...#...# #.#.##.#.# #.#.##.#.# #.#....#B# #.#.##.#.# #....#...# ##########"
}

Response of this endpoint will look like 
{
	"steps": 19,
	"solution": "########## #A...#...# #.#.##.#.# #.#.##.#.# #.#....#B# #.#.##.#.# #....#...# ##########"
}


P.S.

I did not write any code to solve the maze. I bet it will be easy if we have some algorithm to follow, I don’t want to invent it now. So I just created bunch of model classes that we could use to solve it. The endpoint will return the same string you sent by adding a property called Steps to the Json.
