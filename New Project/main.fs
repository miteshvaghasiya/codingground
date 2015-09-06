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
using System.Linq;

class Program
{
    static void Main()
    {
        string s;
        while((s=Console.ReadLine()).Trim() != "")
        {
            int d;
            if(int.TryParse(s, out d))
            {
                sol(s);
                Console.WriteLine("Calculated:: " + solution(d));
            }
        }
    }
    static int sol(string s)
    {
        List<string> r = new List<string>();
        r.Add(s[0].ToString());
        for(int i=1;i<s.Length;i++)
        {
            for(int j=r.Count-1;j>=0;j--)
            {
                string si = r[j];
                r.RemoveAt(j);
                r.Add(s[i] + si);
                for(int k=1;k<si.Length;k++)
                {
                    r.Add(si.Substring(0,k) + s[i] + si.Substring(k,si.Length-k));
                }
                r.Add(si + s[i]);
            }
        }
        Dictionary<string,string> d = new Dictionary<string,string>();
        for(int i=0;i<r.Count;i++)
        {
            d[r[i]]=null;
        }
        r=d.Keys.ToList();
        
        for(int i=0,j=1;i<r.Count;i++,j++)
        {
            Console.Write(r[i] + "  ");
            if((s.Length + 1) * j > 140) {Console.WriteLine();j=0;}
        }
        Console.WriteLine();
        Console.WriteLine("Count:: " + r.Count);
        return 0;
    }
    static int solution(int N)
    {
        if(N==0) return 1;
        int c=0;
        int[] d=new int[10];
        while(N>0)
        {
            d[N%10]++;
            c++;
            N/=10;
        }
        int nF = fact(c);
        int r1Fr2FN=1;
        for(int i=0;i<d.Length;i++)
        {
            r1Fr2FN *= fact(d[i]);
        }
        return nF/r1Fr2FN;
    }
    static int fact(int n){int f=1; for(int i=1;i<=n;i++)f*=i;return f;}
}
*)














