class Solution:
    def hasCycle(self, head: Optional[ListNode]) -> bool:
        if not head:
            return False

        slow, fast = head, head.next

        while fast and fast.next:
            if fast == slow:
                return True

            slow = slow.next
            fast = fast.next.next

        return False
