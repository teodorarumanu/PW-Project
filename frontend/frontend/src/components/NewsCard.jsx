import React from 'react'
import { Link } from 'react-router-dom'

function NewsCard(props) {
    return (
        <div className="border mb-4 rounded overflow-hidden">
            <Link to={`/newspost/${props.newsPost.id}`}>
                <div className='p-3'>
                    <h3 className='font-bold text-xl mb-3'>
                        {props.newsPost.title}
                    </h3>
                </div>
            </Link>
            
            <Link to={`/newspost/${props.newsPost.id}`}>
                <div style={{
                    'backgroundImage':`url("${props.newsPost.imageUrl}")`,
                    backgroundRepeat: 'no-repeat',
                    width:'250px' 
                }}>
                    <img src={props.newsPost.imageUrl} alt="Unavailable"/>
                </div>
            </Link>

            <Link 
                to={`/newspost/${props.newsPost.id}`}
                className="bg-blue-500 text-white p-2 flex justify-center w-250"
            >
                View More
            </Link>
        
        </div>
    )
}

export default NewsCard