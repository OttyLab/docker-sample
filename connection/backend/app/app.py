from flask import Flask, render_template, request
import uuid, requests

app = Flask(__name__)
id = str(uuid.uuid4())

@app.route('/')
def root():
    return render_template('index.html', id=id)

@app.route('/ping')
def ping():
    return f'callback("{id}");'

@app.route('/connect')
def connect():
    host = request.args.get('host')
    res = requests.get(f'http://{host}')
    return res.text

