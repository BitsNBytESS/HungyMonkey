import React from "react";
import {Link} from "react-router-dom";

const Header = () => {
    return (
        <div className="ui secondary pointing menu">
            <Link to="/" className="item">Hungy Monkey</Link>

            <div className="right menu">
                    <button className="mini ui red google button">
                        <i className="google icon" />
                        Sign In/Out Button
                    </button>
            </div>
        </div>
    );
};

export default Header;