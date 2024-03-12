
public class Solution {
    public ListNode RemoveZeroSumSublists(ListNode head) {
        // Create a dummy node to handle edge cases
        ListNode dummy = new ListNode(0);
        dummy.next = head;

        // Create a dictionary to store prefix sums and their corresponding node
        Dictionary<int, ListNode> prefixSums = new Dictionary<int, ListNode>();
        int prefixSum = 0;
        ListNode current = dummy;

        while (current != null) {
            prefixSum += current.val;

            if (prefixSums.ContainsKey(prefixSum)) {
                ListNode prev = prefixSums[prefixSum];
                ListNode start = prev.next;

                // Remove nodes between prev and current
                int sum = prefixSum;
                while (start != current) {
                    sum += start.val;
                    prefixSums.Remove(sum);
                    start = start.next;
                }

                // Update prev's next pointer
                prev.next = current.next;
            }
            else {
                // Store prefix sum and its corresponding node
                prefixSums[prefixSum] = current;
            }

            current = current.next;
        }

        return dummy.next;
    }
}