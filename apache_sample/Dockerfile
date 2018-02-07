FROM centos:latest

RUN yum install -y httpd
COPY httpd.conf /etc/httpd/conf
CMD /usr/sbin/httpd -DFOREGROUND

