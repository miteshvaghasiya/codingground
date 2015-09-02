(* This is a comment *)
(* Sample Hello World program using F# *)
printfn "Hello World!"

as.n = [(i,j) | i <- [0...n-1], j<-[i...n-1]]
--take.3.l
--drop.n.l
-- a!!i - is like a[i]
segment.l.i.j = [l!!k | k <- [i...j]]
allsegments.l = [segment.l.i.j | (i,j) <- as.(length.l)]
sumas.l = [sum.s | s <- allsegments.l]