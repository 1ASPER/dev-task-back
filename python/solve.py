import math

def count_well_formed_parenthesis(n_couples: int) -> int:
    if n_couples < 0:
        raise ValueError("")
    return math.comb(2 * n_couples, n_couples) // (n_couples + 1)