FROM ubuntu:18.04

RUN apt-get update && apt-get install -y \
    build-essential \
    libtool \
    automake \
    git

RUN git clone https://github.com/bitcoin-core/secp256k1.git && cd secp256k1 && \
    ./autogen.sh && ./configure && make && make install

COPY secp256k1.conf /etc/ld.so.conf.d
RUN ldconfig
