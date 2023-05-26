const express = require('express')
const http = require('http')
const Server = require("socket.io").Server
const app = express()

// const server = http.createServer(app)
const io = new Server( {
    cors:{
        origin:"*"
    }
})




// this is where we test our connection when the front end is connected to our socket server we will see this message as sucess
io.on("connection" , (socket) =>{
    console.log('We are connected')

    socket.on("chat" , chat => {
        socket.broadcast.emit('chat', chat) // it will be connected to every server
    })

    socket.on('disconnect' , ()=> {
        console.log('disconnected')
    })
})



io.attach(app.listen(5000 , () => console.log('Listening to port 5000')))

//to do this differently and restructure this