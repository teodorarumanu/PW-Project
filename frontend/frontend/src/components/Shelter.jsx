import React from 'react'
import axios from "axios"
import {useState, useEffect} from 'react'
import { useParams } from 'react-router-dom'

function Shelter() {

    const { id } = useParams()
    const url = `https://6288990a7af826e39e62fc0a.mockapi.io/api/v1/shelters/${id}`
    const [shelter, setShelter] = useState({
        data:null,
        error:false
    })
    let content = null

    useEffect(() => {
        setShelter({
            data:null,
            error:false
        })
        axios.get(url)
            .then(response => {
                setShelter({
                    data:response.data,
                    error:false
                })
            })
            .catch(() => {
                setShelter({
                    data:null,
                    error:true
                })
            })
    }, [url])
    
    if(shelter.error) {
        content = <p>There was an error.</p>
    }

    if (shelter.data) {
        content =
            <div>
                <h1 className='font-bold text-2xl mb-3'>
                    {shelter.data.name}
                </h1>
                <div className='mb-3'>
                    <img src={shelter.data.imageUrl} alt="Unavailable"/>
                </div>
                <div className='flex items-center space-x-13'>
                    Location: {shelter.data.location}
                </div>
                <div className='flex items-center space-x-13'> 
                    Capacity: {shelter.data.capacity}
                </div>
                <div className='font-bold text-xl mb-3'> 
                    Status: {shelter.data.status}
                </div>
            </div>
    }

    return (
        <div className='font-bold'>
            {content}
        </div>
    )
}

export default Shelter