def is_armstrong_number(number) -> bool:
    number_to_str = str(number)
    pow_number = len(number_to_str)
    total = 0
    for n in number_to_str:
        total+=pow(int(n), pow_number)
    return total == number