FROM ubuntu:20.04

RUN apt-get update && apt-get install -y \
    build-essential \
    groff-base \
    libdb-dev \
    libssl-dev \
    libsasl2-dev \
    curl \
    net-tools \
    git

RUN git clone https://github.com/openldap/openldap.git && cd openldap && \
    git checkout refs/tags/OPENLDAP_REL_ENG_2_4_50

RUN cd openldap && \
    ./configure --prefix=/app --with-tls -enable-crypt --with-cyrus-sasl --enable-rwm --enable-null --enable-shell && \
    make && \
    make install

COPY configs/* /configs/

RUN mkdir /app/etc/openldap/slapd.d 
RUN /app/sbin/slaptest -f /configs/slapd.conf.mdb -F /app/etc/openldap/slapd.d; exit 0
