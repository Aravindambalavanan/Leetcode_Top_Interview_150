class Solution {
public:
    ListNode* removeNthFromEnd(ListNode* head, int n) {
        int counter = 0;
        ListNode* current = head;
        while (current != nullptr) {
            current = current->next;
            counter++;
        }
        current = head;
        if (counter == n) {
            head = head->next;
            delete current;
            return head;
        }
        for (int i = 0; i < counter - n - 1; i++) {
            current = current->next;
        }
        ListNode* temp = current->next;
        current->next = current->next->next;
        delete temp;
        return head;
    }
};