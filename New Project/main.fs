open System
(*
let isPof2 n = (n &&& (n-1) = 0)
printfn "%b" (isPof2 1)
*)
(*
let leftMost1 n = (n ^^^ (n-1) &&& n)
printfn "%A" (leftMost1 24)
*)
(*
let mutable mmm = "s"
while (mmm <> "a") do
    mmm <- Console.ReadLine()
    if mmm <> "a" then
        printfn "%A" (leftMost1 (Int32.Parse(mmm)))
*)
let al = [| 10;20;30 |]
let segsum a i j = (Array.sub a i j) |> Array.sum
let sumedseg a n i j =
    let thissum = segsum a i 1
    let mutable restsumset = [| |]
    if (i < n) then
        if (j < n) then restsumset <- sumedseg a n i j++
        else restsumset <- sumedseg a n i++ 0
    Array.append [| thissum |] restsumset
printfn "%A" (sumedseg al al.Length 0 0)

(*
let tp n = 1
    for i = 0 to n-1 do
        for j = i to n-1 do 
            i+j

as.n = [(i,j) | i <- [0...n-1], j<-[i...n-1]]
--take.3.l
--drop.n.l
-- a!!i - is like a[i]
segment.l.i.j = [l!!k | k <- [i...j]]
allsegments.l = [segment.l.i.j | (i,j) <- as.(length.l)]
sumas.l = [sum.s | s <- allsegments.l]
*)
