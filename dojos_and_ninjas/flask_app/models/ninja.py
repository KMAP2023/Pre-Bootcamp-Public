from flask_app.config.mysqlconnection import connectToMySQL

from pprint import pprint

DATABASE = "dojos_and_ninjas"

class Ninja:
    def __init__( self , data ):
        self.id = data['id']
        self.first_name = data['first_name']
        self.last_name = data['last_name']
        self.age = data['age']
        self.created_at = data['created_at']
        self.updated_at = data['updated_at']
    # Now we use class methods to query our database

#  C for create!!!
    @classmethod
    def save(cls, data):
        query = "INSERT INTO ninjas (first_name, last_name, age, dojo_id) VALUES (%(first_name)s, %(last_name)s, %(age)s, %(dojo_id)s);"
        return connectToMySQL(DATABASE).query_db(query, data)

    @classmethod
    def save_dojo(cls,data):
        query = "INSERT INTO dojos (name) VALUES %(name)s;"
        return connectToMySQL(DATABASE).query_db(query, data)


# R for read

    @classmethod
    def get_all(cls):
        query = "SELECT * FROM ninjas;"
        results = connectToMySQL(DATABASE).query_db(query)        # Create an empty list to append our instances of ninjas
        ninjas = []
        for ninja in results:
            ninjas.append(cls(ninja))
        return ninjas
            

    @classmethod
    def get_ninjas(cls, data):
        query= "SELECT * FROM ninjas WHERE dojo_id = %(id)s;"
        results = connectToMySQL(DATABASE).query_db(query,data)        # Create an empty list to append our instances of ninjas
        roster= []
        for students in results:
            roster.append(cls(students))
        return roster

#! read one


    @classmethod
    def get_ninja(cls, data):
        query = "SELECT * FROM ninjas WHERE id = %(id)s;"
        result = connectToMySQL(DATABASE).query_db(query, data)
        print(result[0])
        ninja = Ninja(result[0])
        return ninja





#! update

    @classmethod
    def update(cls, data):
        query = "UPDATE ninjas SET first_name=%(first_name)s, last_name=%(last_name)s WHERE id = %(id)s;"
        return connectToMySQL(DATABASE).query_db(query, data)


    #!delete
    @classmethod
    def delete(cls, id):
        query = "DELETE FROM ninjas WHERE id = %(id)s;"
        data = {
            'id':id
        }
        return connectToMySQL(DATABASE).query_db(query, data)