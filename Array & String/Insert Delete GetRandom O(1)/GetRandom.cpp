class RandomizedSet {
private:
    unordered_map<int, int> indices;
    vector<int> arr;

public:
    RandomizedSet() {
        srand(time(0));
    }

    bool insert(int val) {
        if (indices.find(val) != indices.end())
            return false;

        arr.push_back(val);
        indices[val] = arr.size() - 1;
        return true;
    }

    bool remove(int val) {
        if (indices.find(val) == indices.end())
            return false;

        int i = indices[val];
        indices[arr.back()] = i;
        arr[i] = arr.back();
        indices.erase(val);
        arr.pop_back();
        return true;
    }

    int getRandom() {
        int randIndex = rand() % arr.size();
        return arr[randIndex];
    }
};