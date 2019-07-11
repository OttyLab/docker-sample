from flask import Flask, render_template
import uuid

app = Flask(__name__)
id = str(uuid.uuid4())

@app.route('/')
def root():
    return render_template('index.html', id=id)

@app.route('/ping')
def ping():
    return f'callback("{id}");'

