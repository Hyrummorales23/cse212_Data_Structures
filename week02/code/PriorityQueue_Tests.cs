using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Dequeue returns highest priority item
    // Expected Result: "B" (priority 3)
    // Defect(s) Found: Dequeue didn't remove item or handle ties correctly.
    public void TestPriorityQueue_HighestPriorityFirst()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("A", 1);
        pq.Enqueue("B", 3);
        pq.Enqueue("C", 2);
        Assert.AreEqual("B", pq.Dequeue());
    }

    [TestMethod]
    // Scenario: FIFO order for same priority
    // Expected Result: "A" (added first)
    // Defect(s) Found: Dequeue didn't respect insertion order for ties.
    public void TestPriorityQueue_TieBreaker()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("A", 1);
        pq.Enqueue("B", 1); // Same priority as A
        Assert.AreEqual("A", pq.Dequeue()); // A was added first
    }

    [TestMethod]
    // Scenario: Dequeue from empty queue
    // Expected Result: Throws InvalidOperationException
    // Defect(s) Found: None (already implemented).
    public void TestPriorityQueue_EmptyQueue()
    {
        var pq = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(() => pq.Dequeue());
    }
}