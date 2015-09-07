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

let l=[1;2;3;5;4;3;2;1;6]
let rec qs = function
    | [] -> []
    | x::xs ->
        let l, r = List.partition ((>=) x) xs
        (qs l) @ [x] @ (qs r)
let rec splt li =
    let l = List.length li
    let n = l/2
    let getseg li n i j =
        match i with
            | (n-j) List.nth li i
    let tml,tmr =
        li
        |> List.mapi (fun i e -> i,e )
        |> List.partition (fun (i,e) -> i < n)
    let ext nli = List.map (fun (x,y) -> y) nli
    let ml = ext tml
    let mr = ext tmr
    ml,mr
    
let rec ms li =
    let ml,mr = splt li
    printfn "%A     %A" ml mr
printfn "%A" (ms l)




let rec qs_old l =
    match l with
        | [] -> []
        | x::xs ->
            let sml = xs |> List.filter (fun e -> e < x) |> qs
            let lrl = xs |> List.filter (fun e -> e >= x) |> qs
            sml @ [x] @ lrl



(*
using System.IO;
using System.Collections.Generic;
using System;

class Program
{
    static void Main()
    {
        //Console.WriteLine(solution(new int[,]{{1,2,3,1,5},{2,1,4,2,3},{3,2,2,2,1},{4,2,3,1,3}}));
        Console.WriteLine(solution(new int[] {2,0,3,5,4,10}, 1));
    }
    static int solution1(int[,] A)
    {
        int cnt=0;
        for(int i=1;i<A.Rank-1;i++)
        {
            int rl = A.GetLength(i);
            for(int j=1;j<rl-1;j++)
            {
                if((A[i,j] < A[i,j+1] && A[i,j]<A[i,j-1])
                    || (A[i,j]>A[i,j+1] && A[i,j]>A[i,j-1])
                    || (A[i,j] < A[i+1,j] && A[i,j]<A[i-1,j])
                    || (A[i,j]>A[i+1,j] && A[i,j]>A[i-1,j]))
                    cnt++;
            }
        }
        return cnt;
    }
    static int solution(int[] A, int N)
    {
        List<int> S = new List<int>();
        while(N >= 0 && N < A.Length && !S.Contains(A[N]))
        {
            S.Add((N=A[N]));
            Console.WriteLine(N);
        }
        return S.Count;
    }
}

*)














