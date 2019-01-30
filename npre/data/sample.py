from npre import bbs98

pre = bbs98.PRE()

sk_a = pre.gen_priv(dtype=bytes)
pk_a = pre.priv2pub(sk_a)
sk_b = pre.gen_priv(dtype=bytes)
pk_b = pre.priv2pub(sk_b)

msg = b'Hello world'
emsg = pre.encrypt(pk_a, msg)
print(emsg)
dmsg = pre.decrypt(sk_a, emsg)
print(dmsg)

re_ab = pre.rekey(sk_a, sk_b)
emsg_b = pre.reencrypt(re_ab, emsg)
print(emsg_b)
dmsg_b = pre.decrypt(sk_b, emsg_b)
print(dmsg_b)

print('----------')

sk_c = bytes.fromhex('00 0000000000000000 0000000000000000 0000000000000000 0000000000000001')
pk_c = pre.priv2pub(sk_c)
sk_d = bytes.fromhex('00 0000000000000000 0000000000000000 0000000000000000 0000000000000002')
pk_d = pre.priv2pub(sk_d)

msg = b'Hello world'
emsg = pre.encrypt(pk_c, msg)
print(emsg)
dmsg = pre.decrypt(sk_c, emsg)
print(dmsg)

re_cd = pre.rekey(sk_c, sk_d)
emsg_d = pre.reencrypt(re_cd, emsg)
print(emsg_d)
dmsg_d = pre.decrypt(sk_d, emsg_d)
print(dmsg_d)
