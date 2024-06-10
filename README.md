"Exercise 4 - Memory Management"
Exercise 1: ExamineList()
A list is an abstract data structure that can be implemented in several ways. Unlike arrays, lists do not have a predetermined size; instead, the size increases as the number of elements in the list increases. However, the List class has an underlying array that you will now investigate. To see the size of the list's underlying array, the Capacity method in the List class is used.

Complete the implementation of the ExamineList method so that the investigation can be conducted.
When does the capacity of the list increase? (i.e., the size of the underlying array)
By how much does the capacity increase?
Why doesn't the capacity of the list increase at the same rate as elements are added?
Does the capacity decrease when elements are removed from the list?
When is it advantageous to use a custom array instead of a list?


Exercise 2: ExamineQueue()
The queue data structure (implemented in the Queue class) operates according to the First In First Out (FIFO) principle. That is, the element that is added first will be the one removed first.

Simulate the following queue on paper:
a. The grocery store opens, and the queue at the cashier is empty.
b. Kalle joins the queue.
c. Greta joins the queue.
d. Kalle is served and leaves the queue.
e. Stina joins the queue.
f. Greta is served and leaves the queue.
g. Olle joins the queue.
h. ...
Implement the ExamineQueue method. The method should simulate how a queue works by allowing the user to enqueue and dequeue elements. Use the Queue class to help implement the method. Then simulate the grocery store queue using your program.


Exercise 3: ExamineStack()
Stacks are similar to queues, but a major difference is that stacks operate on the First In Last Out (FILO) principle. This means that the element pushed in first is the one popped out last.

Once again, simulate the grocery store queue on paper. This time using a stack. Why is it not a smart choice to use a stack in this scenario?
Implement a ReverseText method that reads a string from the user and, using a stack, reverses the order of characters, then outputs the reversed string to the user.


Exercise 4: CheckParenthesis()
You should now have sufficient knowledge of the aforementioned data structures to solve the following problem.
We say that a string is well-formed if all parentheses that are opened are also correctly closed. The correct opening and closing of parentheses are dictated by the following rules:
• ), }, ] can only occur after their respective (, {, [
• Every opened parenthesis must be closed, i.e., "(" is followed by ")"
For example, ({}) is well-formed, but not ({)}. Furthermore, a string may contain other characters; for example, "List<int> lista = new List<int>(){2, 3, 4};" is well-formed. Thus, we are only concerned with parentheses!

Create functionality to check a well-formed string on paper using your newfound knowledge. You should use one or more of the data structures we have just discussed. Which data structure do you use?
Implement the functionality in the CheckParentheses method. Let the program read a string from the user and return
