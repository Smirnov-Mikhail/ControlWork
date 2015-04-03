exception EmptyQueueException of string

type QueueElement<'a> =
       struct        
          val Value: 'a
          val Priority: int
          new(value: 'a, priority: int) = { Value = value; Priority = priority }
       end

type Queue<'a>() =
    let mutable list : 'QueueElement list = []

    member this.isEmpty = list.Length = 0

    member this.push(value, priority) = 
        let element = new QueueElement<'a> (value, priority)
        list <- list @ [element]

    member this.pop =
        if (list.IsEmpty) then
            raise (EmptyQueueException "failed pop method. The Queue is empty!")

        let mutable indexMaxPriority = 0;
        for i = 0 to list.Length - 1 do
            if (list.Item(i).Priority > list.Item(indexMaxPriority).Priority) then
                indexMaxPriority <- i
        // не успел удалить элемент
        list.Item(indexMaxPriority).Value