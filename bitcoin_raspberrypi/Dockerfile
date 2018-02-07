FROM resin/rpi-raspbian

RUN apt-get update && apt-get install -y \
    build-essential \
    libtool \
    autotools-dev \
    automake \
    pkg-config \
    libssl-dev \
    libevent-dev \
    bsdmainutils \
    libboost-system-dev \
    libboost-filesystem-dev \
    libboost-chrono-dev \
    libboost-program-options-dev \
    libboost-test-dev \
    libboost-thread-dev \
    software-properties-common \
    libminiupnpc-dev \
    libzmq3-dev \
    git

#RUN add-apt-repository ppa:bitcoin/bitcoin -y && apt-get update && apt-get install -y \
#    libdb4.8-dev \
#    libdb4.8++-dev

RUN git clone https://github.com/bitcoin/bitcoin.git && cd bitcoin && git checkout refs/tags/v0.15.0rc2 && \
    ./autogen.sh && ./configure --disable-wallet --with-incompatible-bdb CXXFLAGS=" --param ggc-min-expand=1 --param ggc-min-heapsize=32768" && make && make install
