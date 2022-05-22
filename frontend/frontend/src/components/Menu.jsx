import React, {useState} from 'react';
import { Link } from "react-router-dom"

function Menu() {
    const [showMenu, setShowMenu] = useState(false);

    let menu;
    let menuMask;

    if(showMenu){
        menu = 
            <div className='fixed bg-white top-0 left-0 w-4/5 h-full z-50 shadow'>
                <div className='font-bold py-3'>
                    STOP WAR
                </div>
                <ul>
                    <li>
                        <Link 
                            to="/" 
                            className='text-black-500 py-3 border-t border-b block'
                            onClick={() => setShowMenu(false)}>
                                Home
                        </Link>
                    </li>
                    <li>
                        <Link 
                            to="/usernews" 
                            className='text-black-500 py-3 border-b block'
                            onClick={() => setShowMenu(false)}>
                            News
                        </Link>
                    </li>
                    <li>
                        <Link 
                            to="/shelters" 
                            className='text-black-500 py-3 border-b block'
                            onClick={() => setShowMenu(false)}>
                            Shelters
                        </Link>
                    </li>
                    <li>
                        <Link 
                            to="/profile"
                            className='text-black-500 py-3 border-b block'
                            onClick={() => setShowMenu(false)}>
                            Profile
                        </Link>
                    </li>
                </ul>
            </div>

        menuMask = 
            <div className='bg-black-t-50 fixed top-0 left-0 w-full h-full z-50'
            onClick={()=> setShowMenu(false)}>
            </div> 
    } 

    return (
        <nav>
            <h1 onClick={() => setShowMenu(!showMenu)}>Menu</h1>
            {menuMask}
            {menu}
        </nav>
    )
}

export default Menu