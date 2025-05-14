function countWellFormedParenthesis(nCouples) {
    if (nCouples < 0) throw new Error("");

    let n = BigInt(nCouples);
    let res = 1n;

    for (let i = 0n; i < n; i++) {
        res = res * (2n * n - i) / (i + 1n);
    }

    res = res / (n + 1n);
    return Number(res);
}

module.exports = { countWellFormedParenthesis };
