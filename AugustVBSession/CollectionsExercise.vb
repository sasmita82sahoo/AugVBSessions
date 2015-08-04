Module CollectionsExercise
    'Create 2 collections
    '1 collection has 10 names
    'second collection is empty
    'code such that : transfer of all the names from one collection to another 
    'except the one which has your name
    
    'Updated By Sasmita Sahoo (688991) on 4th August 2015
    
    
    Sub DoCollectionCopy()
    Dim sourceCollection As New Collection
    Dim destCollection As New Collection
        

        sourceCollection.Add("Archana")
        sourceCollection.Add("Ruchita")
        sourceCollection.Add("Sasmita")
        sourceCollection.Add("Jhansi")
        sourceCollection.Add("Arjun")
        sourceCollection.Add("Rasmita")
        sourceCollection.Add("jeevitha")
        sourceCollection.Add("sumit")
        sourceCollection.Add("john")
        sourceCollection.Add("vivek")


        For Each item In sourceCollection
            If item.ToString().ToLower() <> "sasmita" Then
                destCollection.Add(item)
            End If
        Next
        'Printing the names in First Collection
        Console.WriteLine("Items in the Source Collection")
        
        For Each item In sourceCollection
            Console.WriteLine(item)
        Next
        
        Console.WriteLine()
        'Printing the names in Second Collection excluding my name="sasmita"
        
        Console.WriteLine("Items in the Destination Collection")
        
        For Each item In destCollection
            Console.WriteLine(item)
        Next
        
        Console.Read()
        End Sub


End Module
