FROM ubuntu:16.04

RUN apt-get update && apt-get install -y \
    build-essential \
    libgmp3-dev \
    software-properties-common \
    tree \
    cmake \
    libboost-dev \
    libboost-filesystem-dev \
    libboost-program-options-dev \
    libboost-regex-dev \
    libboost-system-dev \
    libboost-test-dev \
    git

RUN add-apt-repository ppa:jonathonf/golang-1.7 && apt-get update && apt-get install -y \
    golang-1.7

ENV PATH $PATH:/usr/lib/go-1.7/bin

RUN git clone https://github.com/ethereum/go-ethereum.git && cd go-ethereum && git checkout refs/tags/v1.7.2 && \
    make geth && cp build/bin/geth /usr/local/bin

RUN git clone  --recursive https://github.com/ethereum/solidity.git && cd solidity && git checkout refs/tags/v0.4.18 && \
    mkdir build && cd build && cmake .. && make && make install
