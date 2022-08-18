Heap.Heap heap = new(2);

heap.Insert("2", 2);
heap.Insert("5", 5);
heap.Insert("6", 6);
heap.Insert("9", 9);
heap.Insert("7", 7);
heap.RemoveMin();
heap.PrintArray();
