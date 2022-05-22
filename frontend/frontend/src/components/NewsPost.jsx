import React from 'react'
import axios from "axios"
import {useState, useEffect} from 'react'
import { useParams } from 'react-router-dom'

function NewsPost() {

    const { id } = useParams()
    // const { id } = StockNewsPosts.id
    const url = `https://6288990a7af826e39e62fc0a.mockapi.io/api/v1/news/${id}`
    const [newsPost, setNewsPost] = useState({
        data:null,
        error:false
    })
    let content = null

    useEffect(() => {
        setNewsPost({
            data:null,
            error:false
        })
        axios.get(url)
            .then(response => {
                setNewsPost({
                    data:response.data,
                    error:false
                })
            })
            .catch(() => {
                setNewsPost({
                    data:null,
                    error:true
                })
            })
    }, [url])
    
    if(newsPost.error) {
        content = <p>There was an error.</p>
    }

    if (newsPost.data) {
        content =
            <div>
                <h1 className='font-bold text-2xl mb-3'>
                    {newsPost.data.title}
                </h1>
                <div className='mb-3'>
                    <img src={newsPost.data.imageUrl} alt="Unavailable"/>
                </div>
                {/* <div className='flex items-center space-x-13'>
                    <div>
                        {newsPost.data.nrThumbsUp}
                    </div>
                    <div> 
                        {newsPost.data.nrThumbsDown}
                    </div>
                </div> */}
                <div className='font-bold text-xl mb-3'>
                    {newsPost.data.description}
                </div>
            </div>
    }

    return (
        <div className='font-bold'>
            {content}
        </div>
    )
}

export default NewsPost