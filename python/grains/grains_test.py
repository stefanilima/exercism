from grains import *


def test_grains_on_square_1():
    assert square(1) == 1


def test_grains_on_square_2(self):
    assert square(2) == 2


def test_grains_on_square_3(self):
    assert square(3) == 4


def test_grains_on_square_4(self):
    assert square(4) == 8


def test_grains_on_square_16(self):
    assert square(16) ==  32768


def test_grains_on_square_32(self):
    assert square(32) ==  2147483648


def test_grains_on_square_64(self):
    assert square(64) ==  9223372036854775808


def test_returns_the_total_number_of_grains_on_the_board():
    assert total() == 18446744073709551615