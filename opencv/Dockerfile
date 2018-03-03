#
# Reference:
# https://www.learnopencv.com/install-opencv3-on-ubuntu/
#
FROM ubuntu:16.04

# Mandatory
RUN apt-get update && apt-get install -y \
    build-essential \
    checkinstall \
    cmake \
    gfortran \
    git \
    libatlas-base-dev \
    libavcodec-dev \
    libavformat-dev \
    libdc1394-22-dev \
    libfaac-dev \
    libgstreamer0.10-dev \
    libgstreamer-plugins-base0.10-dev \
    libgtk2.0-dev \
    libjasper-dev \
    libjpeg8-dev \
    libmp3lame-dev \
    libopencore-amrnb-dev \
    libopencore-amrwb-dev \
    libpng12-dev \
    libswscale-dev \
    libtbb-dev \
    libtheora-dev \
    libtiff5-dev \
    libv4l-dev \
    libvorbis-dev \
    libxine2-dev \
    libxvidcore-dev \
    pkg-config \
    qt5-default \
    v4l-utils \
    x264 \
    yasm

# Optional
RUN apt-get install -y \
    doxygen \
    libeigen3-dev \
    libgflags-dev \
    libgoogle-glog-dev \
    libgphoto2-dev \
    libhdf5-dev \
    libprotobuf-dev \
    protobuf-compiler \
    vim

# Python
RUN apt-get install -y \
    python3-dev \
    python3-pip \
    python-dev \
    python-pip

# OpenCV
RUN git clone https://github.com/opencv/opencv_contrib.git && cd opencv_contrib && \
    git checkout 3.4.1 && cd ..

RUN git clone https://github.com/opencv/opencv.git && cd opencv && \
    git checkout 3.4.1 && mkdir build && cd build && \
    cmake \
        -D CMAKE_BUILD_TYPE=RELEASE \
        -D CMAKE_INSTALL_PREFIX=/usr/local \
        -D INSTALL_C_EXAMPLES=ON \
        -D INSTALL_PYTHON_EXAMPLES=ON \
        -D WITH_TBB=ON \
        -D WITH_V4L=ON \
        -D WITH_QT=ON \
        -D WITH_OPENGL=ON \
        -D OPENCV_EXTRA_MODULES_PATH=../../opencv_contrib/modules \
        -D BUILD_EXAMPLES=ON .. && \
    make && make install

