import React from "react";
import Menu from "./Menu";

function Header() {
    return (
        <header className="border-b-3 font-bold p-3 flex align:left"> 
            <Menu/>
        </header>
    )
}

export default Header