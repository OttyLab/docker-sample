FROM ubuntu:18.04

RUN apt-get update && apt-get install -y \
    build-essential \
    python3 \
    python3-dev \
    python3-pip \
    libssl-dev \
    libgmp-dev \
    git

RUN git clone https://github.com/nucypher/nucypher-pre-python.git && cd nucypher-pre-python && \
    pip3 install -e .
