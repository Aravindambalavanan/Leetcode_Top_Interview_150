class Solution {
public:
    ListNode* rotateRight(ListNode* head, int k) {
        if (head == nullptr || head->next == nullptr || k == 0) {
            return head;
        }
        int length = 1;
        ListNode* tail = head;
        while (tail->next != nullptr) {
            length++;
            tail = tail->next;
        }
        k = k % length;
        if(k == 0)
          return head;
        ListNode* newTail = head;
        for (int i = 0; i < length - k - 1; i++) {
            newTail = newTail->next;
        }
        ListNode* newHead = newTail->next;
        newTail->next = nullptr;
        tail->next = head;
        return newHead;
    }
};