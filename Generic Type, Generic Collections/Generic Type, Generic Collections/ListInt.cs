public class ListInt<T>
{
	private T[] _arr;
	private int _count;
	private int _capacity;

	public ListInt()
	{
		_capacity = 4;
		_arr = new T[_capacity];
		_count = 0;
	}

	public int Count
	{
		get { return _count; }
	}

	public int Capacity
	{
		get { return _capacity; }
	}

	public T this[int index]
	{
		get
		{
			if (index >= 0 && index < _count)
			{
				return _arr[index];
			}
			throw new IndexOutOfRangeException("Index düzgün deyil!");
		}
		set
		{
			if (index >= 0 && index < _count)
			{
				_arr[index] = value;
			}
			else
			{
				throw new IndexOutOfRangeException("Index düzgün deyil!");
			}
		}
	}

	public void Add(T item)
	{
		if (_count == _capacity)
		{
			_capacity *= 2;
			Array.Resize(ref _arr, _capacity);
		}
		_arr[_count] = item;
		_count++;
	}

	public void AddRange(params T[] items)
	{
		if (_count + items.Length > _capacity)
		{
			while (_capacity < _count + items.Length)
			{
				_capacity *= 2;
			}
			Array.Resize(ref _arr, _capacity);
		}
		for (int i = 0; i < items.Length; i++)
		{
			_arr[_count] = items[i];
			_count++;
		}
	}

	
	public bool Contains(T item)
	{
		for (int i = 0; i < _count; i++)
		{
			if (_arr[i].Equals(item))
			{
                
				return true;
			}
		}
		return false;
	}

	public void Remove(T item)
	{
		int index = Array.IndexOf(_arr, item, 0, _count);
		if (index >= 0)
		{
			for (int i = index; i < _count - 1; i++)
			{
				_arr[i] = _arr[i + 1];
			}
			_count--;
		}
	}

	public void RemoveRange(params T[] items)
	{
		foreach (var item in items)
		{
			Remove(item);
		}
	}

	public override string ToString()
	{
        
		return string.Join(", ", _arr.Take(_count));
	}
}
