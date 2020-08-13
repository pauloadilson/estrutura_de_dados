class Stack {
    constructor() {
        this.count = 0;
        this.storage = [];
    }
    push(value) {
        this.storage.push(value);
        this.count++;
    }
    pop() {
        if (this.count === 0) {
            return undefined;
        }
        this.count--;
        return this.storage.pop()
    }
    size() {
        return this.count;
    }
    empty() {
        return this.count == 0;
    }
}