#checklist


[]create new directory
[]inside the directory

----bash
[pipenv install flask]
[pipenv shell]
[]activate the virtual env
create [server.py]
Run[python server.py]

[go to localhost:5000]
create[html]
from flask import Flask, render_template, request, redirect, session





# Import Flask to allow us to create our app
app = Flask(__name__)    # Create a new instance of the Flask class called "app"


@app.route('/play')          # The "@" decorator associates this route with the function immediately following
def play():
    return 'where are we?'  # Return the string 'Hello World!' as a response


@app.route('/')          # The "@" decorator associates this route with the function immediately following
def hello_world():
    return render_template('index.html')  # Return the string 'Hello World!' as a response



if __name__=="__main__":   # Ensure this file is being run directly and not from a different module
    app.run(debug=True)    # Run the app in debug mode.