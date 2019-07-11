FROM python:3.7-alpine3.10

COPY app/ /app
WORKDIR /app
RUN pip install -r requirements.txt
ENV FLASK_APP=app.py
ENV PORT=5000
CMD flask run --host 0.0.0.0 --port $PORT
