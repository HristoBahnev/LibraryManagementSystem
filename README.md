**Task:** **Implement** **a** **Library** **Management** **System**

**Objective:**

Develop a library management system in C# that adheres to
object-oriented programming principles. The system will manage books,
library members, and borrowing functionality while enforcing business
rules related to borrowing limits and book availability.

**Requirements:**

> 1\. **Book** **Management:**
>
> ○ Create a Book class to represent books in the library. Each book
> should have the following properties:
>
> ■ Title, Author, ISBN, and AvailableCopies.
>
> ○ Implement logic to prevent setting negative values for
> AvailableCopies. ○ Add methods to handle borrowing and returning a
> book, adjusting the
>
> AvailableCopies accordingly. 2. **Member** **Types:**
>
> ○ Implement a Member base class with the following attributes: ■ Name,
> MemberID, and MembershipType.
>
> ○ Create two derived classes: StudentMember and StaffMember. Each
> member type has a specific borrowing limit:
>
> ■ **Students** can borrow up to 5 books. ■ **Staff** can borrow up to
> 10 books.
>
> 3\. **Borrowing** **and** **Returning** **Books:**
>
> ○ Design a borrowing mechanism where:
>
> ■ A member cannot borrow more books than their allowed limit. ■ A
> member cannot borrow a book if no copies are available.
>
> ■ When a member borrows a book, the AvailableCopies for that book
> decreases.
>
> ■ When a book is returned, the AvailableCopies increases.
>
> ○ Borrowing behavior should differ based on the member type,
> reflecting the borrowing limits.
>
> 4\. **Library** **System** **Operations:**
>
> ○ Create an abstract class LibraryManagement with methods for the
> following operations:
>
> ■ Adding a book to the library.
>
> ■ Removing a book from the library. ■ Borrowing a book by a member. ■
> Returning a book by a member.
>
> ○ Implement this abstract class in a Library class, providing the
> concrete functionality for these operations.
>
> 5\. **Business** **Logic:**
>
> ○ When borrowing a book:
>
> ■ Display a message indicating whether the borrowing was successful or
> why it failed (e.g., limit reached, no available copies).
>
> ○ When returning a book:
>
> ■ Log the return and update the system to reflect the increased
> availability of the book.
>
> 6\. **Program** **Execution:**
>
> ○ Instantiate a Library object and add several books to the system. ○
> Create a mix of StudentMember and StaffMember objects.
>
> ○ Simulate a series of borrowing and returning operations, ensuring
> the system enforces all the rules and limits.
>
> ○ Display meaningful messages for each operation to demonstrate the
> functionality of the system.

**Expected** **Output:**

> ● The program should simulate realistic scenarios: ○ Adding and
> removing books.
>
> ○ Borrowing books with success and failure messages based on business
> rules. ○ Returning books and updating the system state.
>
> ● Example:
>
> Unset
>
> Added book: "C# in Depth" by Jon Skeet.
>
> Added book: "Clean Code" by Robert C. Martin.
>
> Alice (Student) borrowed "C# in Depth". Books borrowed: 1/5. Alice
> (Student) cannot borrow "Clean Code". No copies available. Bob (Staff)
> borrowed "Clean Code". Books borrowed: 1/10.
>
> Bob returned "Clean Code". Copies available: 2.

**Implementation:**

> ● Write the complete system in C# to implement this functionality.
>
> ● Ensure modularity and readability of code, using OOP principles
> throughout the implementation.
