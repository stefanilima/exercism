from lasagna import EXPECTED_BAKE_TIME, bake_time_remaining, preparation_time_in_minutes, elapsed_time_in_minutes

def test_EXPECTED_BAKE_TIME():
    assert EXPECTED_BAKE_TIME == 40


def test_bake_time_remaining():
    input_data = [1, 2, 5, 10, 15, 23, 33, 39]
    result_data = [40 - item for item in input_data]

    for variant, (time, result) in enumerate(zip(input_data, result_data), start=1):
        assert bake_time_remaining(time) == result


def test_bake_time_remaining_with_time_1():
    assert bake_time_remaining(1) == 39


def test_preparation_time_in_minutes():
    input_data = [1, 2, 5, 8, 11, 15]
    result_data = [item * 2 for item in input_data]

    for variant, (layers, time) in enumerate(zip(input_data, result_data), start=1):
        assert preparation_time_in_minutes(layers) == time


def test_preparation_time_in_minutes_with_layers_15():
    assert preparation_time_in_minutes(15) == 30


def test_elapsed_time_in_minutes():
    layer_data = (1, 2, 5, 8, 11, 15)
    time_data = (3, 7, 8, 4, 15, 20)
    result_data = [prep * 2 + elapsed for prep, elapsed in zip(layer_data, time_data)]

    for variant, (layers, time, total_time) in enumerate(zip(layer_data, time_data, result_data), start=1):
        assert elapsed_time_in_minutes(layers, time) == total_time