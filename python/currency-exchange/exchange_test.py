from exchange import *

def test_exchange_money():
    input_data = [(100000, 0.84), (700000, 10.1)]
    output_data = [119047, 69306]

    for variant, (input_data, output_data) in enumerate(zip(input_data, output_data), start=1):
        assert int(exchange_money(input_data[0], input_data[1])) == output_data


def test_get_change():
    input_data = [(463000, 5000), (1250, 120), (15000, 1380)]
    output_data = [458000, 1130, 13620]

    for variant, (input_data, output_data) in enumerate(zip(input_data, output_data), start=1):
        assert get_change(input_data[0], input_data[1]) == output_data


def test_get_value_of_bills():
    input_data = [(10000, 128), (50, 360), (200, 200)]
    output_data = [1280000, 18000, 40000]

    for variant, (input_data, output_data) in enumerate(zip(input_data, output_data), start=1):
        assert get_value_of_bills(input_data[0], input_data[1]), output_data