List<int> numbers=Console.ReadLine().Split(' ').Select(int.Parse).ToList();

numbers.Sort();
numbers.RemoveAll(index => index %2!= 0);

