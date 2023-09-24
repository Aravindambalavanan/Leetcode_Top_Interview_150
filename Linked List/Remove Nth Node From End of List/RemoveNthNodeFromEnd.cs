public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        int counter = 0;
        ListNode current = head;
        while (current != null) {
            current = current.next;
            counter++;
        }
        current = head;
        if (counter == n) {
            head = head.next;
            return head;
        }
        for (int i = 0; i < counter - n - 1; i++) {
            current = current.next;
        }
        ListNode temp = current.next;
        current.next = current.next.next;
        return head;
    }
}