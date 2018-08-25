FROM ubuntu


# Install compilation tools

RUN echo "nameserver 8.8.8.8" >> /etc/resolv.conf

RUN apt-get update && apt-get install -y \
    automake \
    build-essential \
    git \
    wget \
    bash \
    curl \
    vim \
    zip

RUN git config --global user.email "you@example.com" && git config --global user.name "Your Name"
RUN curl -sL https://deb.nodesource.com/setup_8.x | bash - && apt-get install -y nodejs
RUN npm install -g @angular/cli
