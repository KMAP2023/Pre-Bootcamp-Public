import React, { useState, useEffect } from 'react'
import { CommentOutlined } from '@ant-design/icons'
import _ from 'lodash'

const button = {
    width: '10%',
    height: 50,
    fontWeight: 'bold',
    borderRadius: 10,
    fontSize: 18,
    backGroundColor: '#075e54',
    borderWidth: 0,
    color: '#fff',
    margin: 10
}

export default function UserLogin(props) {

    const [user, setUser] = useState("")

    function handleSetUser() {
        if (!user) return
        localStorage.setItem("user", user)
        props.setUser(user)
        const avatar = `https://picsum.photos/id/${_.random(1, 1000)}/200/300`
        localStorage.setItem("avatar", avatar)
        props.setAvatar(avatar)
    }

    return (
        <div>
            <h2 style={{ margin: 10, textAlign: 'center' }}><CommentOutlined color={'green'} /> Chat </h2>

            <div style={{ display: 'flex', justifyContent: 'center' }}>
                <input
                    style={{ margin: 10, height: 30, width: '25%', borderRadius: 10, fontSize: 16 }}
                    value={user}
                    onChange={e => setUser(e.target.value)}
                    placeholder="Your name here.."
                ></input>
                <button
                    onClick={handleSetUser}
                    style={button}
                >
                    Login
                </button>
            </div>
        </div>
    )
}
