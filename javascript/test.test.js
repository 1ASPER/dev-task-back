const assert = require('assert');
const { countWellFormedParenthesis } = require('./solve.js');

describe('Parentheses Count', () => {
    it('n=1 returns 1', () => {
        assert.strictEqual(countWellFormedParenthesis(1), 1);
    });

    it('n=2 returns 2', () => {
        assert.strictEqual(countWellFormedParenthesis(2), 2);
    });

    it('n=3 returns 5', () => {
        assert.strictEqual(countWellFormedParenthesis(3), 5);
    });

    it('n=4 returns 14', () => {
        assert.strictEqual(countWellFormedParenthesis(4), 14);
    });

    it('n=15 returns 9694845', () => {
        assert.strictEqual(countWellFormedParenthesis(15), 9694845);
    });
});