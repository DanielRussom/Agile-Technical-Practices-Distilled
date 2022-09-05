# Game of Life Brainstorming


## Requirements
### Setup
[ ] 2D orthoganol grid of square cells
[ ] Each cell has 8 neighbours bordering horizontally, vertically, or diagonally
[ ] Each cell can either be Alive or Dead
[ ] The grid is seeded at the start by setting which cells are alive before the first turn begins

### Gameplay
[ ] Any live cell with less than 2 live neighbours dies from isolation
[ ] Any live cell with 2 or 3 live neighbours survives
[ ] Any live cell with more than 3 live neighbours dies from overpopulation
[ ] Any dead cell with exactly 3 live neighbours becomes live
[ ] Births and Deaths all occur simultaneously when a turn (or tick) is made

### Broken down tasks
Set up 2d board
Decide on board size - configurable?
Set board values - Alive or Dead
Allow manually setting alive cells before first turn

Kill cell when 0-1 neighbours
Keep cell alive when 2-3 neighbours
Kill cell when 4+ neighbours
Bring cell to life when 3 neighbours
