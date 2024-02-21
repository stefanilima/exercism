from collatz_conjecture import *


def test_zero_steps_for_one():
    assert steps(1) == 0


def test_divide_if_even():
    assert steps(16) == 4


def test_even_and_odd_steps():
    assert steps(12) == 9


def test_large_number_of_even_and_odd_steps():
    assert steps(1000000) == 152


def test_zero_is_an_error():
    try:
        steps(0)
    except ValueError as error:
        assert error.args[0] == "Only positive integers are allowed"


def test_negative_value_is_an_error():
    try:
        steps(-15)
    except ValueError as error:
        assert error.args[0] == "Only positive integers are allowed"
