def change_files(filename, cryptoFn, block_size=16):

    with open(filename, 'r+b') as _file:
        raw_Value = _file.read(block_size)
        while raw_Value:
            ciphervalue = cryptoFn(raw_Value)
            # compara o tamanho do bloco cifrado e plano(plain text)
            if len(raw_Value) != len(ciphervalue):
                raise ValueError('O valor cifrado {} tem um tamanho diferente do valor plano {}' 
            .format(len(cipher_value), len(raw_Value)))

            _file.seek(-len(raw_Value), 1)
            _file.write(cipher_value)
            raw_value = _file.read(block_size)