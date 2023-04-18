from flask_app import app, render_template, request, redirect 
from flask_app.models.ninja import Ninja
from flask_app.models.dojo import Dojo

@app.route("/ninjas")
def ninjas():
    dojos = Dojo.get_all()
    return render_template('ninjas.html', dojos = dojos)

@app.route("/create", methods=['post'])
def create_ninja():
    data = { "first_name":request.form["first_name"], "last_name":request.form["last_name"],"age":request.form["age"], "dojo_id":request.form["dojo_id"]}
    Ninja.save(data)
    id = request.form["dojo_id"]
    return redirect(f"/show/{id}")
    

@app.route("/create_dojo", methods=['post'])
def create_dojo():
    data = {"name":request.form["name"]}
    dojo = Dojo.save(data)
    return redirect("/dojos")

@app.route('/show/<int:id>')
def students(id):
    data = {'id':id}
    dojo = Dojo.get_dojo(data)
    ninja = Ninja.get_ninjas(data)
    return render_template("show.html", dojo = dojo, ninja = ninja)


@app.route("/dojos")
def index():
    dojos = Dojo.get_all()
    # print(ninjas)
    return render_template("dojos.html", dojos = dojos)



#! READ ONE
@app.route('/ninja/<int:id>')
def show(id):
    data= {'id':id}
    ninja = Ninja.get_ninja(data)
    print(ninja)
    return render_template('show.html', ninja = ninja)


#! UPDATE


#! DELETE 

