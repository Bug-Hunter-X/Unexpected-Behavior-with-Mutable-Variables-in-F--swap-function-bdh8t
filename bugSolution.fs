let swap (x, y) = (y, x)

let x = 10
let y = 20

let (x', y') = swap (x, y)
printf "%d %d" x' y' //This will print 20 10