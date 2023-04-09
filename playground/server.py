from flask import Flask, render_template
app = Flask(__name__)  



@app.route('/')
def hello_world():
  return render_template("index.html")

@app.route('/play')
def play():
  return render_template("index.html")

@app.route('/play/<int:num>')
def playnum(num):
  return render_template("play.html", num = num)

@app.route('/play/<int:num>/<string:color>')
def play_num_color(num, color):
  return render_template("play.html", num = num, color = color)





if __name__=="__main__":   # Ensure this file is being run directly and not from a different module    
    app.run(debug=True)    # Run the app in debug mode.

