open System
(*
let isPof2 n = (n &&& (n-1) = 0)
printfn "%b" (isPof2 1)

let leftMost1 n = (n ^^^ (n-1) &&& n)
printfn "%A" (leftMost1 24)

let pm x =
    match x with
        | 'a' -> x * -x
        | _ -> x*x
pm 20.0f
pm 10.0f
pm -2.0f

let sq x = x * x
let l = [10.1;20.2;30.3]
printfn "%f" (l |> List.map (fun x->x*x*x) |> List.sum)
printfn "%d" ([1..100] |> List.filter (fun x->x%5=0) |> List.sum)
*)


let rec qs = function
    | [] -> []
    | x::xs ->
        let l, r = List.partition ((>=) x) xs
        (qs l) @ [x] @ (qs r)


printfn "%A" (qs [1;2;3;5;4;3;2;1])




let rec qs_old l =
    match l with
        | [] -> []
        | x::xs ->
            let sml = xs |> List.filter (fun e -> e < x) |> qs
            let lrl = xs |> List.filter (fun e -> e >= x) |> qs
            sml @ [x] @ lrl

















