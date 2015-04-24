open System
open System.Collections.Generic

/// Exception of empty stack.
exception StackIsEmptyException of string

/// Class of stack.
type Stack<'a>() =
    let mutable stack : 'a list = []

    // Inserts an element at the top of the stack.
    member v.Push element =
        stack <- element::stack

    /// Removes and returns the element at the top of the stack.
    member v.Pop =
        match stack with
        | [] -> 
            raise (StackIsEmptyException "Stack is empty!")
        | _ ->
            let tempElement = List.head stack
            stack <- List.tail stack
            tempElement
    
    /// Returns the element at the top of the stack without removing it.
    member v.Peek =
        match stack with
        | [] -> 
            raise (StackIsEmptyException "Stack is empty!")
        | _ ->
            List.head stack
    
    /// Returns true if the stack is empty or else the true.
    member v.IsEmpty = 
        List.length stack = 0

let stack = Stack<int>()

stack.Push 1
stack.Push 2
stack.Push 3
printfn "%A" stack.IsEmpty
try
    printfn "Peek: %A" stack.Peek
with
    | StackIsEmptyException str -> printfn "%s" str
try
    printfn "%A" stack.Pop
with
    | StackIsEmptyException str -> printfn "%s" str
try
    printfn "%A" stack.Pop
with
    | StackIsEmptyException str -> printfn "%s" str
try
    printfn "%A" stack.Pop
with
    | StackIsEmptyException str -> printfn "%s" str
try
    printfn "%A" stack.Pop
with
    | StackIsEmptyException str -> printfn "%s" str
try
    printfn "%A" stack.Peek
with
    | StackIsEmptyException str -> printfn "Peek: %s" str

printfn "%A" stack.IsEmpty
