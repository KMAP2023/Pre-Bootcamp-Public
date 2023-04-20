# import the function that will return an instance of a connection
from flask_app import flash
from flask_app.config.mysqlconnection import connectToMySQL
from pprint import pprint


DATABASE = "recipes"

class Recipe:
    
    
    def __init__(self, data:dict):
        self.id = data['id']
        self.name = data['name']
        self.description = data['description']
        self.instructions = data['instructions']
        self.under = data['under']
        self.date_made = data['date_made']
        self.user_id = data['user_id']
        self.user = data['first_name']

    def show_name(self):
        return self.name
    
    #! CREATE and make sure to change the queries!!!!
    @classmethod
    def save(cls, data): 
        query = "INSERT INTO recipes (name, description, instructions, under, date_made, user_id) VALUES (%(name)s, %(description)s, %(instructions)s, %(under)s, %(date_made)s, %(user_id)s);"
        return connectToMySQL(DATABASE).query_db(query, data)
       
    #! READ ALL 
    @classmethod
    def get_all(cls):
        query = "SELECT * FROM recipes JOIN users ON users.id = recipes.user_id;"
        results = connectToMySQL(DATABASE).query_db(query)
        pprint(results)
        recipes = []
        for recipe_dict in results:
            recipes.append(cls(recipe_dict))
        return recipes
    
    #! READ ONE
    @classmethod
    def get_recipe(cls, id):
        query = "SELECT * FROM recipes JOIN users ON users.id= recipes.user_id WHERE recipes.id = %(id)s;"
        data = {'id': id}
        result = connectToMySQL(DATABASE).query_db(query, data)
        print(result[0])
        recipe = Recipe(result[0])
        return recipe
    
    #! UPDATE
    @classmethod
    def update(cls, data):
        query = "UPDATE recipes SET name=%(name)s, description=%(description)s, instructions=%(instructions)s WHERE id = %(id)s;"
        return connectToMySQL(DATABASE).query_db(query, data)
    
    #! DELETE
    @classmethod
    def delete(cls, id):
        query = "DELETE FROM recipes WHERE id = %(id)s;"
        data = {
            'id':id
        }
        return connectToMySQL(DATABASE).query_db(query, data)
        

            # make sure to keep static methods in their own models
    @staticmethod 
    def validate_recipe(recipe:dict):
        is_valid = True
        if len(recipe['name']) < 3:
            flash("name must have a valid name or have 3 or more characters")
            is_valid = False
        if len(recipe['description']) < 1:
            flash("must have more than 5 characters")
            is_valid = False
        if len(recipe['instructions'])<1:
            flash("you must tell us how to make it!!!!")
            is_valid = False

        return is_valid
