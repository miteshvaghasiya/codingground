let rec qs l =
    match l with
        | [] = []
        | x::xs ->
            let sml = xs |> List.filter (fun e -> e < x) |> qs
            let lrl = xs |> List.filter (fun e -> e >= x) |> qs
            sml @ [x] @ lrl

