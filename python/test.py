import unittest
from solve import count_well_formed_parenthesis

class Test(unittest.TestCase):

    def test_count_well_formed_parenthesis(self):
        test_cases = [
            (1, 1),
            (2, 2),
            (3, 5),
            (4, 14),
            (5, 42),
            (10, 16796),
            (15, 9694845),
        ]
        
        for n, expected in test_cases:
            with self.subTest(n=n):
                self.assertEqual(count_well_formed_parenthesis(n), expected)


if __name__ == "__main__":
    unittest.main()