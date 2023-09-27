using System;

public class Initialize
{
    private char[] array;      //  Private array to store elements
    private int occupancy;    //  Number of elements in the stack
    private const int DefaultCapacity = 10;

    public Initialize()
    {
        array = new char[DefaultCapacity]; //  Initialize the array with the default capacity
        occupancy = 0;                   //  Initialize occupancy to 0
    }

    public int Occupancy()
    {
        return occupancy; //  Returns the current number of elements in the stack
    }

    public void Add(char item)
    {
        if (occupancy == array.Length)
        {
            //  If the stack is full, double the capacity
            Array.Resize(ref array, array.Length * 2);
        }
        array[occupancy++] = item; //  Add the item to the stack and increment occupancy
    }

    public char Remove()
    {
        if (occupancy == 0)
        {
            throw new InvalidOperationException("Stack is empty"); //  Throw an exception if the stack is empty
        }
        char item = array[--occupancy]; //  Get the top element and decrement occupancy
        array[occupancy] = '\0';        //  Clear the previous top element
        return item;
    }

    public char Peek()
    {
        if (occupancy == 0)
        {
            throw new InvalidOperationException("Stack is empty"); //  Throw an exception if the stack is empty
        }
        return array[occupancy - 1]; //  Return the top element without removing it
    }

    public bool IsEmpty()
    {
        return occupancy == 0; //  Check if the stack is empty
    }
}
