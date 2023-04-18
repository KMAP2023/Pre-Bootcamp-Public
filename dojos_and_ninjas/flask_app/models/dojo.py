from flask_app.config.mysqlconnection import connectToMySQL

from pprint import pprint

DATABASE = "dojos_and_ninjas"

class Dojo:
    def __init__( self , data ):
        self.id = data['id']
        self.name = data['name']
        self.created_at = data['created_at']
        self.updated_at = data['updated_at']
    # Now we use class methods to query our database

#  C for create!!!
    @classmethod
    def save(cls, data):
        query = "INSERT INTO dojos (name) VALUES (%(name)s);"
        return connectToMySQL(DATABASE).query_db(query, data)

    @classmethod
    def save_dojo(cls,data):
        query = "INSERT INTO dojos (name) VALUES %(name)s;"
        results = connectToMySQL(DATABASE).query_db(query, data)
        save =[]
        for location in results:
            save.append(cls(location))
        return save


    @classmethod
    def get_ninjas(cls, data):
        query= "SELECT * FROM ninjas WHERE dojo_id = %(id)s;"
        results = connectToMySQL(DATABASE).query_db(query,data)        # Create an empty list to append our instances of ninjas
        roster= []
        for students in results:
            roster.append(cls(students))
        return roster

# R for read

    @classmethod
    def get_all(cls):
        query = "SELECT * FROM dojos;"
        results = connectToMySQL(DATABASE).query_db(query)        # Create an empty list to append our instances of dojos
        dojos = []
        for dojo in results:
            dojos.append(cls(dojo))
        return dojos
            

#! read one


    @classmethod
    def get_dojo(cls, data):
        query = "SELECT * FROM dojos WHERE id = %(id)s;"
        result = connectToMySQL(DATABASE).query_db(query, data)
        # print(result[0])
        dojo = cls(result[0])
        return dojo

