#
# https://dev.classmethod.jp/articles/create-x-509-v3-cert-python/
#
from OpenSSL import crypto

key = crypto.PKey()
key.generate_key(crypto.TYPE_RSA, 2048)

cert = crypto.X509()
cert.get_subject().C = 'JP'
cert.get_subject().ST = 'Tokyo'
cert.get_subject().L = 'Shinagawa'
cert.get_subject().O = 'Capybara Corp'
cert.get_subject().OU = 'System development'
cert.get_subject().CN = 'openldap'
cert.set_serial_number(100)
cert.gmtime_adj_notBefore(0)
cert.gmtime_adj_notAfter(10 * 365 * 24 * 60 * 600)
cert.set_issuer(cert.get_subject())
cert.set_pubkey(key)
#cert.add_extensions([
#    crypto.X509Extension(
#        
#    )
#])
cert.set_version(2)
cert.sign(key, 'sha256')

with open('openldap-cert.pem', 'w') as f:
    f.write(crypto.dump_certificate(crypto.FILETYPE_PEM, cert).decode('utf-8'))

with open('openldap-key.pem', 'w') as f:
    f.write(crypto.dump_privatekey(crypto.FILETYPE_PEM, key).decode('utf-8'))
