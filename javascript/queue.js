class Queue {
    constructor() {
        this.inicio = 1;
        this.fim = 1;
        this.storage = {};
        this.max = 50;
    }

    isEmpty() {
        return this.inicio == this.fim;
    }

    isFull() {
        return this.fim == this.max - 1;
    }

    Enqueue(value) {
        this.storage[this.fim] = value;
        this.fim++;
    }

    Dequeue() {
        if (this.inicio === 0) {
            return undefined;
        }
        var value = this.storage[this.inicio]
        this.inicio++;
        return value;
    }

}

