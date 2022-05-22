import React from 'react'
import { Link } from 'react-router-dom'

function ShelterCard(props) {
    return (
        <div className="border mb-4 rounded overflow-hidden">
            <Link to={`/shelter/${props.shelter.id}`}>
                <div className='p-3'>
                    <h3 className='font-bold text-xl mb-3'>
                        {props.shelter.name}
                    </h3>
                </div>
            </Link>
            
            <Link to={`/shelter/${props.shelter.id}`}>
                <div style={{
                    'backgroundImage':`url("${props.shelter.imageUrl}")`,
                    backgroundRepeat: 'no-repeat',
                    width:'250px' 
                }}>
                    <img src={props.shelter.imageUrl} alt="Unavailable"/>
                </div>
            </Link>

            <Link 
                to={`/newspost/${props.shelter.id}`}
                className="bg-blue-700 text-white p-2 flex justify-center w-250"
            >
                View More
            </Link>

        </div>
    )
}

export default ShelterCard