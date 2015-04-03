let fib = Seq.unfold
            (fun (u, v) -> Some(u, (u + v, u)))
            (1, 1)

let sum = List.sum (Seq.take 10 (Seq.filter (fun x -> (x % 2  = 0 && x < 1000000)) fib) |> Seq.toList)

printfn "%A" sum