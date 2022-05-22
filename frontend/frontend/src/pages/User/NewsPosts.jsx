import React, { useState, useEffect } from 'react'
import axios from 'axios';
import NewsCard from '../../components/NewsCard';

function NewsPosts() {

    const url = `https://6288990a7af826e39e62fc0a.mockapi.io/api/v1/news`
    const [newsPosts, setNewsPosts] = useState({
        data:null,
        error:false
    })

    let content = null;

    useEffect(() => {
        setNewsPosts({
            data:null,
            error:false
        })
        axios.get(url)
            .then(response => {
                setNewsPosts({
                    data:response.data,
                    error:false
                })
            })
            .catch(() => {
                setNewsPosts({
                    data:null,
                    error:true
                })
            })
    }, [url])

    if(newsPosts.error) {
        content = <p>There was an error.</p>
    }

    if (newsPosts.data) {
        content = newsPosts.data.map((newsPost, key) =>
            <div>
                <NewsCard
                    newsPost={newsPost}/>
            </div>
        )
    }
    
    return (
        <div>
            <h1 className='font-bold text-2xl'>
                News Page
            </h1>
            {content}
        </div>
    )
}

export default NewsPosts