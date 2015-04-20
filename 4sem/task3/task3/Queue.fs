exception EmptyQueueException of string

let rec remove index list =
    match index, list with
    | 0, x::xs -> xs
    | index, x::xs -> x::remove (index - 1) xs
    | index, [] -> failwith "index out of range"
        
type 'a QueueElement =
       struct        
          val Value: 'a
          val Priority: int
          new(value: 'a, priority: int) = { Value = value; Priority = priority }
       end

type 'a Queue() =
    let mutable list : 'QueueElement list = []

    member this.isEmpty = list.Length = 0

    member this.enqueue(value, priority) = 
        let element = new QueueElement<'a> (value, priority)
        list <- list @ [element]

    member this.dequeue =
        if (list.IsEmpty) then
            raise (EmptyQueueException "failed dequeue method. The Queue is empty!")

        let mutable indexMaxPriority = 0;
        for i = 0 to list.Length - 1 do
            if (list.Item(i).Priority > list.Item(indexMaxPriority).Priority) then
                indexMaxPriority <- i       
        let result = list.Item(indexMaxPriority).Value
        list <- remove indexMaxPriority list
        result

let testQueue = Queue<int>()

testQueue.enqueue (2, 2)
testQueue.enqueue (0, 7)
testQueue.enqueue (8, 5)

printfn "%A" testQueue.dequeue
printfn "%A" testQueue.dequeue
printfn "%A" testQueue.dequeue

try
    printfn "%A" testQueue.dequeue
with
    | EmptyQueueException str -> printfn "%s" str

printfn "%A" testQueue.isEmpty