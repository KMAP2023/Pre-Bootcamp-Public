from flask import Flask, render_template  # Import Flask to allow us to create our app
from users import users
app = Flask(__name__)

@app.route('/')
def hello_world():
    return render_template("index.html", users_in_jinja = users)

@app.route('/success') #this is a test right here!
def success():
  return "success"














if __name__=="__main__":   # Ensure this file is being run directly and not from a different module    
    app.run(debug=True)    # Run the app in debug mode.

