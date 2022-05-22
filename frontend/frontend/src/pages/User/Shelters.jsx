import React, { useState, useEffect } from 'react'
import axios from 'axios';
import ShelterCard from '../../components/ShelterCard';

function Shelters() {

    const url = `https://6288990a7af826e39e62fc0a.mockapi.io/api/v1/shelters`
    const [shelters, setShelters] = useState({
        data:null,
        error:false
    })

    let content = null;

    useEffect(() => {
        setShelters({
            data:null,
            error:false
        })
        axios.get(url)
            .then(response => {
                setShelters({
                    data:response.data,
                    error:false
                })
            })
            .catch(() => {
                setShelters({
                    data:null,
                    error:true
                })
            })
    }, [url])

    if(shelters.error) {
        content = <p>There was an error.</p>
    }

    if (shelters.data) {
        content = shelters.data.map((shelter, key) =>
            <div>
                <ShelterCard
                    shelter={shelter}/>
            </div>
        )
    }
    
    return (
        <div>
            <h1 className='font-bold text-2xl'>
                Shelter list
            </h1>
            {content}
        </div>
    )
}

export default Shelters