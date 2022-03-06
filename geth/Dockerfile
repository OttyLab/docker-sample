FROM ubuntu:20.04

RUN sed -i'' 's/archive.ubuntu.com/jp.archive.ubuntu.com/' /etc/apt/sources.list
RUN apt-get update
RUN apt-get install -y \
    tzdata
RUN apt-get install -y \
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

RUN add-apt-repository ppa:longsleep/golang-backports && apt-get update && apt-get install -y \
    golang-go

ENV PATH $PATH:/usr/lib/go/bin

RUN git clone https://github.com/ethereum/go-ethereum.git && cd go-ethereum && git checkout refs/tags/v1.10.16 && \
    make geth && cp build/bin/geth /usr/local/bin

RUN git clone  --recursive https://github.com/ethereum/solidity.git && cd solidity && git checkout refs/tags/v0.8.12 && \
    mkdir build && cd build && cmake .. && make && make install
