from strings import *


def test_add_prefix_un():
    input_data = "happy"
    result_data = add_prefix_un(input_data)

    assert result_data == "unhappy"


def test_make_word_groups_auto():
    input_data = [
        'auto', 'didactic', 'graph', 'mate', 'chrome', 'centric', 'complete', 'echolalia', 'encoder', 'biography'
    ]
    expected = (
        'auto :: autodidactic :: autograph :: automate :: autochrome :: autocentric :: autocomplete :: '
        'autoecholalia :: autoencoder :: autobiography'
    )

    result_data = make_word_groups(input_data)

    assert result_data == expected


def test_make_word_groups_en():
    input_data = ['en', 'circle', 'fold', 'close', 'joy', 'lighten', 'tangle', 'able', 'code', 'culture']
    expected = (
        'en :: encircle :: enfold :: enclose :: enjoy :: enlighten :: entangle :: enable :: encode :: enculture'
    )

    result_data = make_word_groups(input_data)

    assert result_data == expected


def test_make_word_groups_pre():
    input_data = [
        'pre', 'serve', 'dispose', 'position', 'requisite', 'digest',
        'natal', 'addressed', 'adolescent', 'assumption', 'mature', 'compute'
    ]
    expected = (
        'pre :: preserve :: predispose :: preposition :: prerequisite :: predigest :: prenatal :: preaddressed :: '
        'preadolescent :: preassumption :: premature :: precompute'
    )

    result_data = make_word_groups(input_data)

    assert result_data == expected


def test_make_word_groups_inter():
    input_data = [
        'inter', 'twine', 'connected', 'dependent', 'galactic', 'action', 'stellar', 'cellular', 'continental',
        'axial', 'operative', 'disciplinary'
    ]
    expected = (
        'inter :: intertwine :: interconnected :: interdependent :: intergalactic :: interaction :: interstellar :: '
        'intercellular :: intercontinental :: interaxial :: interoperative :: interdisciplinary'
    )

    result_data = make_word_groups(input_data)

    assert result_data == expected


def test_remove_suffix_ness():
    input_data = "sadness"
    result_data = remove_suffix_ness(input_data)

    assert result_data == "sad"


def test_remove_suffix_ness_with_i():
    input_data = "heaviness"
    result_data = remove_suffix_ness(input_data)

    assert result_data == "heavy"


def test_adjective_to_verb():
    input_data = "Look at the bright sky."
    result_data = adjective_to_verb(input_data, -2)

    assert result_data == "brighten"
