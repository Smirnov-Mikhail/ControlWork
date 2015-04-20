type Polinom(coefficients: array<int>) =
    member v.Coefficients = coefficients

let arrayOfCoeff : int array = Array.zeroCreate 10
arrayOfCoeff.[0] <- 1;
arrayOfCoeff.[1] <- 1;
let polinom = Polinom(arrayOfCoeff)

let multiplication (polinom1: array<int>) (polinom2: array<int>) =
    let result: int array = Array.zeroCreate polinom1.Length
    // Проходим по первому полиному
    for i in (polinom1.Length - 1) .. - 1 .. 0 do
        // Проходим по второму полиному
        for j in (polinom2.Length - 1) .. -1 .. 0 do
            // Если оба коэффициента не нули, то перемножим их и прибавим к соответствующей позиции.
            if (polinom1.[i] <> 0 && polinom2.[j] <> 0) then
                result.[i + j] <- (polinom1.[i] * polinom2.[j]) + result.[i + j]
    result

let involution (polinom: Polinom) degree =
    let rec recInvolution result polinom degree =
        if (degree <> 1) then
            let result = multiplication result polinom
            recInvolution result polinom (degree - 1)
        else
            Polinom(result)
    recInvolution polinom.Coefficients polinom.Coefficients degree

// возведём х в степень 3
let newPolinom = involution polinom 3
printfn "%A" (newPolinom.Coefficients)
