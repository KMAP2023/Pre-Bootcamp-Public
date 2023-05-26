import { useState, useEffect } from 'react'
import socketIOClient from "socket.io-client";
import ChatBoxReciever, { ChatBoxSender } from './ChatBox';
import InputText from './InputText';
import UserLogin from './UserLogin';

export default function ChatContainer() {

    const [socketio] = useState(() => socketIOClient("http://localhost:5000"))

    const [chats, setChats] = useState(JSON.parse(localStorage.getItem("chats")) || [])
    const [user, setUser] = useState(localStorage.getItem("user"))
    const [avatar, setAvatar] = useState(localStorage.getItem("avatar"))




    // whenever we recieve the event as chat, that event will give us a list of chat inside the socket channel
    useEffect(() => {
        socketio.on('chat', senderChat => {
            setChats(currentChats => [...currentChats, senderChat])
            localStorage.setItem("chats", JSON.stringify([...chats, senderChat]))
        })
        return () => {
            socketio.removeAllListeners()
        }
    }, [])

    //always have clean up function to clean up the memories ***important for sockets

    function sendChatToSocket(chat) {
        socketio.emit("chat", chat)
    }


    // this is the function that is called everytime a messsage is being entered or messaged into the conversation
    function addMessage(chat) {
        const updatedChats = [...chats, { ...chat, user, avatar }]
        setChats(updatedChats)
        sendChatToSocket({ ...chat, user, avatar })
        localStorage.setItem("chats", JSON.stringify(updatedChats))
    }


    // the logout function removes both the user and the user's avatar thus deleting/ending the session from the local storage
    function logout() {
        localStorage.removeItem("user")
        localStorage.removeItem("avatar")
        localStorage.removeItem("chats")
        setUser("")
        setAvatar("")
        setChats([])
    }

    function ChatsList() {
        return chats.map((chat, index) => {
            if (chat.user === user) return <ChatBoxSender key={index} message={chat.message} avatar={chat.avatar} />
            return <ChatBoxReciever key={index} message={chat.message} avatar={chat.avatar} />
        })
    }


    return (
        <div>
            {
                user ?
                    <div>
                        <div style={{ display: 'flex', flexDirection: "row", justifyContent: 'space-between' }}>
                            <h4>Username: {user}</h4>
                            <p onClick={() => logout()} style={{ color: "blue", cursor: 'pointer' }} >Log Out</p>
                        </div>
                        <ChatsList />
                        <InputText addMessage={addMessage} />
                    </div>
                    :
                    <UserLogin setUser={setUser} setAvatar={setAvatar} />
            }
        </div>
    )
}


